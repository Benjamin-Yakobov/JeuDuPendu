using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class FrmPendu : Form
    {
        /// <summary>
        /// Initialisation des objets graphiques
        /// </summary>
        public FrmPendu()
        {
            InitializeComponent();
        }
         
        // Rempli le Combo avec les lettres de l'alphabet
        private void RemplirCmbLettres()
        {
            cmbLettres.Items.Clear();
            for(int k = 0; k < 26; k++)
            {
                cmbLettres.Items.Add((char)('A' + k));
            }
        }
        // S'execute au chargement
        private void Pendu_Load(object sender, EventArgs e)
        {
            RemplirCmbLettres();
        }
    }
}
