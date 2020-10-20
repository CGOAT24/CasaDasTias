using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CasaDasTias {
    class ConnexionDB {
        MySqlConnection con;
        static ConnexionDB instance = null;

        public ConnexionDB() {
            con = new MySqlConnection("Server=69.90.160.150;Database=louka782_CasadasTias;Uid=louka782;Pwd=9nv0pftz15;Port=3306"); //à modifier
        }

        public static ConnexionDB GetInstance() {
            if (instance == null) {
                instance = new ConnexionDB();
            }

            return instance;
        }

        public DataTable Select(String query, string table) {

            DataTable table_query = null;
            try {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = query;
                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                table_query = new DataTable(table);
                table_query.Load(r);

                r.Close();
                con.Close();
            }
            catch (Exception) {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return table_query;
        }

        public bool Query(String query) {
            try {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = query;
                con.Open();
                commande.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception) {

                if (con.State == ConnectionState.Open) {
                    con.Close();
                }

                return false;
            }
        }

        public bool Check_PK(int pk, string column) {
            DataTable output = ConnexionDB.GetInstance().Select($"SELECT COUNT(*) FROM inventaire WHERE '{column}' = '{pk}'", "inventaire");
            string num = output.Rows[0][0].ToString();
            int iNum = Convert.ToInt32(num);
            if(iNum > 0) {
                return true;
            }
            else {
                return false;
            }
           
        }
    }
}
