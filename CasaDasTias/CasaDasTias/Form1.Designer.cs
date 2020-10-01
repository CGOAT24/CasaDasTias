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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEmployes = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCommandes = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegistres = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInventaire = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMenu.Controls.Add(this.btnEmployes);
            this.panelMenu.Controls.Add(this.btnCommandes);
            this.panelMenu.Controls.Add(this.btnRegistres);
            this.panelMenu.Controls.Add(this.btnInventaire);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 453);
            this.panelMenu.TabIndex = 0;
            // 
            // btnEmployes
            // 
            this.btnEmployes.AutoSize = true;
            this.btnEmployes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmployes.Depth = 0;
            this.btnEmployes.Location = new System.Drawing.Point(13, 182);
            this.btnEmployes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEmployes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmployes.Name = "btnEmployes";
            this.btnEmployes.Primary = false;
            this.btnEmployes.Size = new System.Drawing.Size(82, 36);
            this.btnEmployes.TabIndex = 3;
            this.btnEmployes.Text = "Employés";
            this.btnEmployes.UseVisualStyleBackColor = true;
            // 
            // btnCommandes
            // 
            this.btnCommandes.AutoSize = true;
            this.btnCommandes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCommandes.Depth = 0;
            this.btnCommandes.Location = new System.Drawing.Point(13, 134);
            this.btnCommandes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCommandes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCommandes.Name = "btnCommandes";
            this.btnCommandes.Primary = false;
            this.btnCommandes.Size = new System.Drawing.Size(98, 36);
            this.btnCommandes.TabIndex = 2;
            this.btnCommandes.Text = "Commandes";
            this.btnCommandes.UseVisualStyleBackColor = true;
            // 
            // btnRegistres
            // 
            this.btnRegistres.AutoSize = true;
            this.btnRegistres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistres.Depth = 0;
            this.btnRegistres.Location = new System.Drawing.Point(13, 86);
            this.btnRegistres.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistres.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistres.Name = "btnRegistres";
            this.btnRegistres.Primary = false;
            this.btnRegistres.Size = new System.Drawing.Size(83, 36);
            this.btnRegistres.TabIndex = 1;
            this.btnRegistres.Text = "Registres";
            this.btnRegistres.UseVisualStyleBackColor = true;
            this.btnRegistres.Click += new System.EventHandler(this.btnRegistres_Click);
            // 
            // btnInventaire
            // 
            this.btnInventaire.AutoSize = true;
            this.btnInventaire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInventaire.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInventaire.Depth = 0;
            this.btnInventaire.Location = new System.Drawing.Point(13, 38);
            this.btnInventaire.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInventaire.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInventaire.Name = "btnInventaire";
            this.btnInventaire.Primary = false;
            this.btnInventaire.Size = new System.Drawing.Size(90, 36);
            this.btnInventaire.TabIndex = 0;
            this.btnInventaire.Text = "Inventaire";
            this.btnInventaire.UseVisualStyleBackColor = false;
            this.btnInventaire.Click += new System.EventHandler(this.btnInventaire_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(206, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(595, 453);
            this.pnlMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Casa Das Tias";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private MaterialSkin.Controls.MaterialFlatButton btnEmployes;
        private MaterialSkin.Controls.MaterialFlatButton btnCommandes;
        private MaterialSkin.Controls.MaterialFlatButton btnRegistres;
        private MaterialSkin.Controls.MaterialFlatButton btnInventaire;
        private System.Windows.Forms.Panel pnlMain;
    }
}

