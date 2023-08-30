
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
            this.pctPendu = new System.Windows.Forms.PictureBox();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.grpTest = new System.Windows.Forms.GroupBox();
            this.grpMot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMot
            // 
            this.grpMot.Controls.Add(this.txtMot);
            this.grpMot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.lblResultat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultat.Location = new System.Drawing.Point(111, 374);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(69, 20);
            this.lblResultat.TabIndex = 4;
            this.lblResultat.Text = "Résultat";
            // 
            // grpTest
            // 
            this.grpTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpTest.Location = new System.Drawing.Point(115, 172);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(384, 149);
            this.grpTest.TabIndex = 1;
            this.grpTest.TabStop = false;
            this.grpTest.Text = "Test";
            // 
            // FrmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMot;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.PictureBox pctPendu;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.GroupBox grpTest;
    }
}

