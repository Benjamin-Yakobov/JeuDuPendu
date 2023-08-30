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

        private void CreeBoutons()
        {
            char[] tableauAlpha = new char[26]; // Création du tableau contenant les lettres de l'alphabet

            // Remplissage du tableau 
            for (int k = 0; k < 26; k++)
            {
                tableauAlpha[k] = (char)('A' + k);
            }

            // Propriétés
            int sizeButton = 30; // Taille bouton
            int nbLettresParLigne = 10; // Nombre de lettre par ligne
            int posXButton = 6; // Position du 1er bouton a partir de la gauche
            int posYButton = 18; // Position du 1er bouton a partir du haut

            int col = 0;
            int line = -1;

            // Création des boutons 
            for(int i = 0; i < 26; i++)
            {
                Button btn = new Button(); // Déclaration et création du bouton 
                grpTest.Controls.Add(btn); // Ajout du bouton dans le conteneur grpTest
                btn.Text = tableauAlpha[i].ToString(); // Affectation d'une lettre au bouton
                btn.Size = new Size(sizeButton, sizeButton); // Dimensionne la taille du bouton

                // Ecoute sur le clique du bouton 
                btn.Click += new System.EventHandler(btnAlpha_Click);

                col++; 

                // chengement de ligne 
                if(i % nbLettresParLigne == 0)
                {
                    line++;
                    col = 0;
                }

                // Position des boutons dans le conteneur
                btn.Location = new Point(posXButton + sizeButton * col, posYButton + sizeButton * line);
            }
        }
        // Evenement clique sur un des boutons du conteneur
        private void btnAlpha_Click(object sender, EventArgs e)
        {
            
            Button btnLettre = ((Button)sender); // Recupère le bouton concerné
            btnLettre.Enabled = false; // Désactive le bouton
            GestionFocusBoutonLettre(); // Focus au premier bouton non désactivé
          
            // Recherche la lettre
            char lettre = char.Parse(btnLettre.Text);
            if (!RechercheLettreDansMot(lettre))
            {
                // Si la lettre n'a pas été trouvée
                if (AffichagePendu())
                {
                    // Verification si c'est la fin du jeu
                    FinJeu("PERDU");
                }
            }
            else
            {
                // Si il n'y a plus de lettre à trouver
                if (txtMot.Text.IndexOf('-') == -1)
                {
                    // s'il n'y a plus de tirets
                    FinJeu("GAGNE");
                }
            }
        }
        
        // Géstion des focus
        private void GestionFocusBoutonLettre()
        {
            int k = 0;
            while (!grpTest.Controls[k].Enabled)
            {
                k++;
            }
            grpTest.Controls[k].Focus();
        }


        private int etapePendu;
        private int maxPendu = 10;
        private string mot;

        /// <summary>
        /// Initialisation des objets graphiques
        /// </summary>
        public FrmPendu()
        {
            InitializeComponent();
        }

        // S'execute au chargement
        private void Pendu_Load(object sender, EventArgs e)
        {
            PreparationPhase1();
            CreeBoutons();
        }

        // Préparation de la phase 1 (phase 1 = saisie du mot a chercher)
        private void PreparationPhase1()

        {
            etapePendu = 0;
            AffichageImage(etapePendu);
            grpTest.Enabled = false; // Désactivation de la zone de teste
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

                    mot = txtMot.Text.ToUpper();  // Met le mot en majuscule et le mémorise
                   
                    // Rempli le zone de saisie de tirets a la place des lettres
                    txtMot.Text = "";
                    for (int k = 0; k < mot.Length; k++)
                    {
                        txtMot.Text += "-";
                    }

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

        }

        //  Fonction qui permet d'afficher une image du pendu dans le PictureBox
        private void AffichageImage(int num)
        {
            string chemin = @"C:\Users\Benjamin Yakobov\Desktop\Activités professionnelles\Jeu du pendu\Jeu du pendu - Application\JeuDuPendu\JeuDuPendu\JeuDuPendu\Resources\pendu"+num+".png";
            pctPendu.Image = Image.FromFile(chemin);

        }

        // Affichage d'une image en fonction de l'etape 
        private bool AffichagePendu()
        {
            etapePendu++;
            AffichageImage(etapePendu); 
            return (etapePendu == maxPendu); // Verification si le joueur a atteint le maximum
        }

        // Recherche la lettre dans le mot et remplace le tiret par la lettre si vrai
        // Retourn vrai si la lettre est toruvée au moin une fois
       
        
        private bool RechercheLettreDansMot(char lettre)
        {
          
            int position = -1; // Position de la lettre dans le mot
            bool trouve = false; // La lettre a elle été trouvée
          
            // Boucle sur la recherche de la lettre
            do
            {
                // Récupère la position de la lettre ou -1 si pas trouvé
                position = mot.IndexOf(lettre, position + 1);

                // Si trouvé 
                if (position != -1) 
                {
                    trouve = true; 

                    // remplace les tiret par les lettres
                    txtMot.Text = txtMot.Text.Remove(position, 1);
                    txtMot.Text = txtMot.Text.Insert(position, lettre.ToString());
                }

            } while (position != -1);
            return trouve;

        }

        // Traitement de la lettre récupéré
        private void TraitementLettre(char lettre)
        {
            // Si la lettre a été trouvée
            if(RechercheLettreDansMot(lettre))
            {
                // Si il n'y a plus de lettre a trouvé
                if(txtMot.Text.IndexOf('-') == -1)
                {
                    FinJeu("Gangé");
                }
            }
            else // Si la lettre n'a pas été trouvée
            {
                if(AffichagePendu())
                {
                    FinJeu("Perdu");
                }
            }
        }

        // Gère la quand le jeu est fini
        private void FinJeu(string message)
        {
            lblResultat.Text = message;
            txtMot.Text = mot;
            btnRejouer.Focus();
        }
        
    }
}
