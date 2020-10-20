using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace CasaDasTias {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e) {
            String username, password;
            username = tbNomUtilisateur.Text;
            password = tbMDP.Text;
            DataTable result = ConnexionDB.GetInstance().Select($"SELECT password FROM employe WHERE username = '{username}'", "employe");
            
            if(result.Rows.Count > 0) {
                string db_password = result.Rows[0][0].ToString();
                if(SecurePasswordHasher.Verify(password, db_password)) {
                    Form1.connected = true;
                    this.Close();
                }
                else {
                    MessageBox.Show("Le mot de passe est incorrect. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Le nom d'utilisateur est incorrect. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e) {

        }
    }
}
