
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
            this.grpMot.SuspendLayout();
            this.grpTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMot
            // 
            this.grpMot.Controls.Add(this.txtMot);
            this.grpMot.Location = new System.Drawing.Point(99, 92);
            this.grpMot.Name = "grpMot";
            this.grpMot.Size = new System.Drawing.Size(324, 52);
            this.grpMot.TabIndex = 0;
            this.grpMot.TabStop = false;
            this.grpMot.Text = "Mot a chercher";
            // 
            // txtMot
            // 
            this.txtMot.Location = new System.Drawing.Point(56, 19);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(203, 20);
            this.txtMot.TabIndex = 0;
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.lblLettres);
            this.grpTest.Controls.Add(this.btnTest);
            this.grpTest.Controls.Add(this.cmbLettres);
            this.grpTest.Location = new System.Drawing.Point(99, 150);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(329, 100);
            this.grpTest.TabIndex = 1;
            this.grpTest.TabStop = false;
            this.grpTest.Text = "Test";
            // 
            // lblLettres
            // 
            this.lblLettres.AutoSize = true;
            this.lblLettres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettres.Location = new System.Drawing.Point(7, 60);
            this.lblLettres.Name = "lblLettres";
            this.lblLettres.Size = new System.Drawing.Size(317, 16);
            this.lblLettres.TabIndex = 2;
            this.lblLettres.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(184, 19);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Tester";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // cmbLettres
            // 
            this.cmbLettres.FormattingEnabled = true;
            this.cmbLettres.Location = new System.Drawing.Point(56, 19);
            this.cmbLettres.Name = "cmbLettres";
            this.cmbLettres.Size = new System.Drawing.Size(121, 21);
            this.cmbLettres.TabIndex = 0;
            // 
            // pctPendu
            // 
            this.pctPendu.Location = new System.Drawing.Point(434, 92);
            this.pctPendu.Name = "pctPendu";
            this.pctPendu.Size = new System.Drawing.Size(250, 250);
            this.pctPendu.TabIndex = 2;
            this.pctPendu.TabStop = false;
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = global::JeuDuPendu.Properties.Resources.refresh_6711474;
            this.btnRejouer.Location = new System.Drawing.Point(353, 284);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(75, 58);
            this.btnRejouer.TabIndex = 3;
            this.btnRejouer.UseVisualStyleBackColor = true;
            // 
            // FrmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.pctPendu);
            this.Controls.Add(this.grpTest);
            this.Controls.Add(this.grpMot);
            this.Name = "FrmPendu";
            this.Text = "Jeu du pendu";
            this.Load += new System.EventHandler(this.Pendu_Load);
            this.grpMot.ResumeLayout(false);
            this.grpMot.PerformLayout();
            this.grpTest.ResumeLayout(false);
            this.grpTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).EndInit();
            this.ResumeLayout(false);

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
    }
}

