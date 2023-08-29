
namespace JeuDuPendu
{
    partial class FrmPendu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMot = new System.Windows.Forms.GroupBox();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.grpTest = new System.Windows.Forms.GroupBox();
            this.lblLettres = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.cmbLettres = new System.Windows.Forms.ComboBox();
            this.pctPendu = new System.Windows.Forms.PictureBox();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.grpMot.SuspendLayout();
            this.grpTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMot
            // 
            this.grpMot.Controls.Add(this.txtMot);
            this.grpMot.Location = new System.Drawing.Point(115, 106);
            this.grpMot.Name = "grpMot";
            this.grpMot.Size = new System.Drawing.Size(378, 60);
            this.grpMot.TabIndex = 0;
            this.grpMot.TabStop = false;
            this.grpMot.Text = "Mot a chercher";
            // 
            // txtMot
            // 
            this.txtMot.Location = new System.Drawing.Point(65, 22);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(236, 21);
            this.txtMot.TabIndex = 0;
            this.txtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMot_KeyPress);
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.lblLettres);
            this.grpTest.Controls.Add(this.btnTest);
            this.grpTest.Controls.Add(this.cmbLettres);
            this.grpTest.Location = new System.Drawing.Point(115, 173);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(384, 115);
            this.grpTest.TabIndex = 1;
            this.grpTest.TabStop = false;
            this.grpTest.Text = "Test";
            // 
            // lblLettres
            // 
            this.lblLettres.AutoSize = true;
            this.lblLettres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettres.Location = new System.Drawing.Point(8, 69);
            this.lblLettres.Name = "lblLettres";
            this.lblLettres.Size = new System.Drawing.Size(317, 16);
            this.lblLettres.TabIndex = 2;
            this.lblLettres.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(215, 22);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(87, 27);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Tester";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cmbLettres
            // 
            this.cmbLettres.FormattingEnabled = true;
            this.cmbLettres.Location = new System.Drawing.Point(65, 22);
            this.cmbLettres.Name = "cmbLettres";
            this.cmbLettres.Size = new System.Drawing.Size(141, 23);
            this.cmbLettres.TabIndex = 0;
            this.cmbLettres.SelectedIndexChanged += new System.EventHandler(this.cmbLettres_SelectedIndexChanged);
            // 
            // pctPendu
            // 
            this.pctPendu.Location = new System.Drawing.Point(506, 106);
            this.pctPendu.Name = "pctPendu";
            this.pctPendu.Size = new System.Drawing.Size(292, 288);
            this.pctPendu.TabIndex = 2;
            this.pctPendu.TabStop = false;
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = global::JeuDuPendu.Properties.Resources.refresh_6711474;
            this.btnRejouer.Location = new System.Drawing.Point(412, 327);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(87, 67);
            this.btnRejouer.TabIndex = 3;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(122, 374);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(69, 20);
            this.lblResultat.TabIndex = 4;
            this.lblResultat.Text = "Résultat";
            // 
            // FrmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.pctPendu);
            this.Controls.Add(this.grpTest);
            this.Controls.Add(this.grpMot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPendu";
            this.Text = "Jeu du pendu";
            this.Load += new System.EventHandler(this.Pendu_Load);
            this.grpMot.ResumeLayout(false);
            this.grpMot.PerformLayout();
            this.grpTest.ResumeLayout(false);
            this.grpTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMot;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.GroupBox grpTest;
        private System.Windows.Forms.Label lblLettres;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cmbLettres;
        private System.Windows.Forms.PictureBox pctPendu;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Label lblResultat;
    }
}

