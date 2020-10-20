namespace CasaDasTias {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            MaterialSkin.Controls.MaterialFlatButton btnConnecter;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.tbNomUtilisateur = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            btnConnecter = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnecter
            // 
            btnConnecter.AutoSize = true;
            btnConnecter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnConnecter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnConnecter.Depth = 0;
            btnConnecter.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnConnecter.Location = new System.Drawing.Point(307, 325);
            btnConnecter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnConnecter.MouseState = MaterialSkin.MouseState.HOVER;
            btnConnecter.Name = "btnConnecter";
            btnConnecter.Primary = true;
            btnConnecter.Size = new System.Drawing.Size(111, 36);
            btnConnecter.TabIndex = 0;
            btnConnecter.Text = "Se Connecter";
            btnConnecter.UseVisualStyleBackColor = false;
            btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // tbMDP
            // 
            this.tbMDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMDP.Location = new System.Drawing.Point(307, 278);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(111, 20);
            this.tbMDP.TabIndex = 1;
            this.tbMDP.UseSystemPasswordChar = true;
            // 
            // tbNomUtilisateur
            // 
            this.tbNomUtilisateur.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomUtilisateur.Location = new System.Drawing.Point(307, 227);
            this.tbNomUtilisateur.Name = "tbNomUtilisateur";
            this.tbNomUtilisateur.Size = new System.Drawing.Size(111, 20);
            this.tbNomUtilisateur.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CasaDasTias.Properties.Resources.locked_padlock;
            this.pictureBox2.InitialImage = global::CasaDasTias.Properties.Resources.locked_padlock;
            this.pictureBox2.Location = new System.Drawing.Point(253, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::CasaDasTias.Properties.Resources._Logo_CasaDasTias_CND;
            this.pictureBox3.InitialImage = global::CasaDasTias.Properties.Resources._Logo_CasaDasTias_CND;
            this.pictureBox3.Location = new System.Drawing.Point(240, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(233, 199);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasaDasTias.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(720, 441);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbNomUtilisateur);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(btnConnecter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Connection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.TextBox tbNomUtilisateur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}