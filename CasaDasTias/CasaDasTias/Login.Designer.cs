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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            btnConnecter = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnecter
            // 
            btnConnecter.AutoSize = true;
            btnConnecter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnConnecter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnConnecter.Depth = 0;
            btnConnecter.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnConnecter.Location = new System.Drawing.Point(314, 256);
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
            this.tbMDP.Location = new System.Drawing.Point(314, 209);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(111, 20);
            this.tbMDP.TabIndex = 1;
            this.tbMDP.UseSystemPasswordChar = true;
            // 
            // tbNomUtilisateur
            // 
            this.tbNomUtilisateur.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomUtilisateur.Location = new System.Drawing.Point(314, 158);
            this.tbNomUtilisateur.Name = "tbNomUtilisateur";
            this.tbNomUtilisateur.Size = new System.Drawing.Size(111, 20);
            this.tbNomUtilisateur.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(130)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(264, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Casa Das Tias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 158);
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
            this.pictureBox2.Location = new System.Drawing.Point(260, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasaDasTias.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(720, 441);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.TextBox tbNomUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}