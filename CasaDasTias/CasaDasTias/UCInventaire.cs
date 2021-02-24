using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.CompilerServices;

namespace CasaDasTias {
    public partial class UCInventaire : UserControl {
        public UCInventaire() {
            InitializeComponent();
            refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            refresh();
        }

        private void btnAjouter_Click(object sender, EventArgs e) {
            Ajouter formAjouter = new Ajouter();
            formAjouter.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e) {
            ModifierInventaire formModifier = new ModifierInventaire();
            formModifier.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e) {
            SupprimerInventaire formSupprimer = new SupprimerInventaire();
            formSupprimer.ShowDialog();
        }

        private void UCInventaire_Load(object sender, EventArgs e) {
            refresh();
        }

        public void refresh() {
            string query = "SELECT numLot as 'Numéro de lot', nom as 'Produit', qte as 'Quantité', dateAjout as 'Date dajout' FROM inventaire";

            dataGridView1.DataSource = ConnexionDB.GetInstance().Select(query, "inventaire");
    
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
