using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CasaDasTias {
    public partial class Form1 : Form {
        UCInventaire inventaire;
        UCRegistres registres;
        UCCommandes commandes;
        UCEmployes employes;
        public Form1() {
            InitializeComponent();
            inventaire = new UCInventaire();
            registres = new UCRegistres();
        }

        private void btnInventaire_Click(object sender, EventArgs e) {
            pnlMain.Controls.Add(inventaire);
            inventaire.Dock = DockStyle.Fill;
            inventaire.BringToFront();
        }


        private void btnRegistres_Click(object sender, EventArgs e) {
            pnlMain.Controls.Add(registres);
            registres.Dock = DockStyle.Fill;
            registres.BringToFront();
        }
    }
}
