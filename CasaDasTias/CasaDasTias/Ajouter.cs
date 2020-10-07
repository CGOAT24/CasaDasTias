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
    public partial class Ajouter : Form {
        public Ajouter() {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e) {
            String nomProduit, date;
            int numLot, quantite;

            if (tbNumLot.Text.Trim().Equals("")) {
                MessageBox.Show("Le numéro ne peut pas être vide. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!int.TryParse(tbNumLot.Text, out int _)) {
                MessageBox.Show("Le numéro de lot ne doit contenir que des chiffres. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                numLot = Convert.ToInt32(tbNumLot.Text);
            }

            dataGridView1.DataSource = ConnexionDB.GetInstance().Check_PK(Convert.ToInt32(tbNumLot.Text), "numLot");

            if (tbNom.Text.Trim().Equals("")) {
                MessageBox.Show("Le nom du produit ne peut pas être vide. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbNom.Text.Length >= 255) {
                MessageBox.Show("Le nom du produit est trop long. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                nomProduit = tbNom.Text;
            }

            if (!int.TryParse(tbQuantite.Text, out int _)) {
                MessageBox.Show("La quantité ne doit contenir que des chiffres. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(tbQuantite.Text.Trim().Equals("")) {
                MessageBox.Show("La quantité de peut pas être vide. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                quantite = Convert.ToInt32(tbQuantite.Text);
            }

            if(dtpDate.Value == null) {
                MessageBox.Show("La date ne peut pas être vide. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                date = dtpDate.Value.ToString("yyyy-MM-dd");
            }
            /*
            if (ConnexionDB.GetInstance().Query($"INSERT INTO inventaire VALUES('{numLot}', '{nomProduit}', '{quantite}', '{date}')")) {
                MessageBox.Show("L'ajout a été effectué avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Une erreur s'est produite. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
    }
}
