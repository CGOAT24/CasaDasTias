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

namespace CasaDasTias {
    public partial class UCInventaire : UserControl {
        public UCInventaire() {
            InitializeComponent();
            dataGridView1.DataSource = ConnexionDB.GetInstance().Select($"SELECT DISTINCT nom, SUM(qte) as Quantité FROM inventaire GROUP BY nom", "inventaire");
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
           dataGridView1.DataSource = ConnexionDB.GetInstance().Select($"SELECT DISTINCT nom, SUM(qte) as Quantité FROM inventaire GROUP BY nom", "inventaire");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
