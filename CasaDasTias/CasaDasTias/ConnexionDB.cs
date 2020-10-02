using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CasaDasTias {
    class ConnexionDB {
        MySqlConnection con = new MySqlConnection();
        static ConnexionDB instance = null;
        const String TABLE = "";

        public ConnexionDB() {
            con = new MySqlConnection("Server=69.90.160.150;Database=;Uid=Louka782;Pwd=9nv0pftz15;Port=3306");
        }

        public static ConnexionDB GetInstance() {
            if (instance == null) {
                instance = new ConnexionDB();
            }

            return instance;
        }

        public DataTable Afficher() {

            DataTable tableClients = null;
            try {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = $"SELECT * FROM '{TABLE}'";
                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                tableClients = new DataTable(TABLE);
                tableClients.Load(r);

                r.Close();
                con.Close();
            }
            catch (Exception) {

            }
            return tableClients;
        }

        public bool Ajouter(/**/) { //passer les valeurs en paramètre
            try {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = $"INSERT INTO '{TABLE}' VALUES()"; //insérer les valeurs ici

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

        public bool Modifier(String pk, String column, String newValue) {
            try {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = $"UPDATE '{TABLE}' SET '{column}' = '{newValue}' WHERE email = '{pk}'";

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

        public bool Supprimer(String pk, String column) {
            try {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = $"DELETE FROM '{TABLE}' WHERE '{column}' = '{pk}'";

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
    }
}
