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
    public partial class ModifierInventaire : Form {
        public ModifierInventaire() {
            InitializeComponent();
            dataGridView1.DataSource = ConnexionDB.GetInstance().Select("SELECT * FROM inventaire", "inventaire");
        }

        private void button1_Click(object sender, EventArgs e) {
            String nomProduit, date;
            int numLot, quantite;

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
            else if (tbQuantite.Text.Trim().Equals("")) {
                MessageBox.Show("La quantité de peut pas être vide. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                quantite = Convert.ToInt32(tbQuantite.Text);
            }

            if (dtpDateAjout.Value == null) {
                MessageBox.Show("La date ne peut pas être vide. Veuillez réessayer!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                date = dtpDateAjout.Value.ToString("yyyy-MM-dd");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            string selectedNom = dataGridView1.CurrentRow.Cells[1].ToString();
            int selectedQuantite = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2]);
            string selectedDate = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            tbNom.Text = selectedNom;
            tbQuantite.Text = selectedQuantite.ToString();
            dtpDateAjout.Value = selectedDate;

          
        }
    }
}
