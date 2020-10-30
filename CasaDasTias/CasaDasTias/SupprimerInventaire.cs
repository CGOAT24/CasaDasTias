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
    public partial class SupprimerInventaire : Form {
        public SupprimerInventaire() {
            InitializeComponent();
            
        }

        private void SupprimerInventaire_Load(object sender, EventArgs e) {
            refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
           
        }

        private void btnSupprimer_Click(object sender, EventArgs e) {
            DialogResult resultat = MessageBox.Show("Êtes-vous sur de vouloir supprimer " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultat == DialogResult.No)
                return;

            if(dataGridView1.CurrentCell.RowIndex == null)
                MessageBox.Show("Vous devez choisir un produit à supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else {
                int numLot = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if(ConnexionDB.GetInstance().Query($"DELETE FROM inventaire WHERE numLot = '{numLot}'"))
                    MessageBox.Show("Le produit a été supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                else
                    MessageBox.Show("Une erreur s'est produit. Veuillez réessayer à nouveau", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                refresh();
            }
        }

        public void refresh() {
            dataGridView1.DataSource = ConnexionDB.GetInstance().Select("SELECT * FROM inventaire", "inventaire");
        }
    }
}
