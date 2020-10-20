namespace CasaDasTias {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInventaire = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCommandes = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnCommandes);
            this.pnlMenu.Controls.Add(this.materialFlatButton2);
            this.pnlMenu.Controls.Add(this.btnInventaire);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(158, 426);
            this.pnlMenu.TabIndex = 0;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(11, 54);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(83, 36);
            this.materialFlatButton2.TabIndex = 0;
            this.materialFlatButton2.Text = "Registres";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // btnInventaire
            // 
            this.btnInventaire.AutoSize = true;
            this.btnInventaire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInventaire.Depth = 0;
            this.btnInventaire.Location = new System.Drawing.Point(11, 6);
            this.btnInventaire.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInventaire.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInventaire.Name = "btnInventaire";
            this.btnInventaire.Primary = false;
            this.btnInventaire.Size = new System.Drawing.Size(90, 36);
            this.btnInventaire.TabIndex = 0;
            this.btnInventaire.Text = "Inventaire";
            this.btnInventaire.UseVisualStyleBackColor = true;
            this.btnInventaire.Click += new System.EventHandler(this.btnInventaire_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(176, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(612, 426);
            this.pnlMain.TabIndex = 1;
            // 
            // btnCommandes
            // 
            this.btnCommandes.AutoSize = true;
            this.btnCommandes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCommandes.Depth = 0;
            this.btnCommandes.Location = new System.Drawing.Point(11, 102);
            this.btnCommandes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCommandes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCommandes.Name = "btnCommandes";
            this.btnCommandes.Primary = false;
            this.btnCommandes.Size = new System.Drawing.Size(98, 36);
            this.btnCommandes.TabIndex = 0;
            this.btnCommandes.Text = "Commandes";
            this.btnCommandes.UseVisualStyleBackColor = true;
            this.btnCommandes.Click += new System.EventHandler(this.btnCommandes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Casa Das Tias";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMain;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton btnInventaire;
        private MaterialSkin.Controls.MaterialFlatButton btnCommandes;
    }
}

