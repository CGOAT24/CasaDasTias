using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDasTias {
    public partial class Commande : Form {
        public Commande() {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e) {
            int numLot, quantite;
            String nom, dateAjout;

            if (tbNumLot.Text.Trim().Equals("")) {
                MessageBox.Show("Le numéro de lot ne peut pas être vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!int.TryParse(tbNumLot.Text, out int _)) {
                MessageBox.Show("Le numéro de lot doit être des chiffres seulement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                numLot = Convert.ToInt32(tbNumLot.Text);
            }

            if (tbNom.Text.Trim().Equals("")) {
                MessageBox.Show("Le nom ne peut pas être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                nom = tbNom.Text;
            }

            if (tbQuantite.Text.Trim().Equals("")) {
                MessageBox.Show("La quantité ne peut pas être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(tbQuantite.Text, out int _)) {
                MessageBox.Show("La quantité doit être des chiffres seulement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToInt32(tbQuantite.Text) < 0) {
                MessageBox.Show("La quantité doit être plus grand ou égale à zéro", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                quantite = Convert.ToInt32(tbQuantite.Text);
            }

            if(dtpDateAjout.Value == null) {
                MessageBox.Show("Vous devez ajouter une date d'ajout", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                dateAjout = dtpDateAjout.Value.ToString("yyyy-MM-dd");
            }

            if(ConnexionDB.GetInstance().Check_PK(numLot, "numLot")) {

            }
            else {
                if(ConnexionDB.GetInstance().Query($"INSERT INTO inventaire VALUES('{numLot}', '{nom}', '{quantite}', '{dateAjout}')")) {

                }
                else {

                }
            }
        }
    }
}
