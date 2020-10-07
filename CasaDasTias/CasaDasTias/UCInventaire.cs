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
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
           dataGridView1.DataSource = ConnexionDB.GetInstance().Select($"SELECT * FROM inventaire", "inventaire");
        }

        private void btnAjouter_Click(object sender, EventArgs e) {
            Ajouter formAjouter = new Ajouter();
            formAjouter.ShowDialog();
        }
    }
}
