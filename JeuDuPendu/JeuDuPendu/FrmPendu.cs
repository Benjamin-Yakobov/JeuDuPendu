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
            PreparationPhase1();
        }

        // Préparation de la phase 1 (phase 1 = saisie du mot a chercher)
        private void PreparationPhase1()
        {
            grpTest.Enabled = false; // Désactivation de la zone de teste
            lblLettres.Text = ""; // Vide le label des lettres téstées
            lblResultat.Text = ""; // Vide le label qui affiche le résultat
            grpMot.Enabled = true; // Activation de la zone de saisie
            txtMot.Text = ""; // Vide la zone de saisie
            txtMot.Focus(); // Se positionne sur la zone de saisie
            txtMot.MaxLength = 15; // Limite la longeur du mot a trouvé
        }

        // Préparation de la phase 2 (phase 2 = test)
        private void PreparationPhase2()
        {
            grpMot.Enabled = false; // Désactivation de la zone de saisie
            grpTest.Enabled = true; // Activation de la zone de test
            RemplirCmbLettres(); // Remplissage du combo avec les lettres de l'alphabet
            btnTest.Focus(); // Focus sur le bouton de test
            cmbLettres.SelectedIndex = 0;
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            PreparationPhase1();
        }

        // Vérification que le mot saisi est constitué uniquement de caractère
        private bool MotCorrect(string unMot)
        {
            unMot = unMot.ToUpper(); // Transforme chaque lettre du mot en majuscule
            bool correct = true; // Déclaration et initialisatin de la variable correct

            // Boucle sur chaque lettre afin de verifier
            for(int k = 0; k < unMot.Length; k++)
            {
                // Verification que le mot est constitué de l'alphabet (entre A et Z)
                if(char.Parse(unMot.Substring(k,1)) < 'A' || char.Parse(unMot.Substring(k,1)) > 'Z')
                {
                    correct = false;
                }
            }
            return correct;
        }

        // Evenement : choix d'une lettre dans le menu déroulant
        private void cmbLettres_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTest.Focus(); // Focus sur le bouton de test
        }

        // Evenement :  validation du mot saisie
        private void txtMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifie que la touche Enter a été préssée
            if (e.KeyChar == (char)Keys.Enter) 
            {
                // Verification qu'un mot a été saisie et qu'il soit correct
                if(!txtMot.Text.Equals("") && MotCorrect(txtMot.Text))
                {
                    PreparationPhase2(); // Préparation des objets graphiques pour la phase 2
                }
                else
                {
                    // Si la zone de saisi est vide
                    if(txtMot.Text == "")
                    {
                        MessageBox.Show("Vous devez saisir un mot !!");
                        txtMot.Focus();
                    }
                    else // Si le mot entré contien un caractère autre que l'alphabet
                    {
                        MessageBox.Show("Le moit doit contenir uniquement des lettres alphabétiques");
                        txtMot.Text = "";
                        txtMot.Focus();
                    }
                }
            }
        }

        // Evenement : clique sur le bouton de test
        private void btnTest_Click(object sender, EventArgs e)
        {
            
            try
            {
                char lettre = char.Parse(cmbLettres.SelectedItem.ToString()); // Recupère dans la variable "lettre" la lettre séléctionnée
                lblLettres.Text = lblLettres.Text + lettre; // Ajout de la lettre téstée dans le label de lettres dèja téstées
                cmbLettres.Items.Remove(lettre); // Suppression de la lettre séléctionnée du combo
                cmbLettres.SelectedIndex = 0; // se positonne automatiquement sur la premier lettre présente
            }
            catch // Dans le cas ou il y'a tantative de supprimer une lettre alors que le combo est vide
            {
                grpTest.Enabled = false;
            }
            
        }
    }
}
