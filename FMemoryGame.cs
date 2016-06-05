﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllLoto;
using System.Diagnostics;

/*
 *
 * Memory Game
 * Par Mélanie DUBREUIL et Ophélie EOUZAN, 3APP
 * Module ISI2
 * 
 */

namespace Memory
{
    public partial class FMemoryGame : Form
    {
        private GameEngine g;

        /* Déclaration des variables globales du jeu */

        static int NB_CARTES_SABOT;
        static int NB_CARTES_TAPIS;
        int[] tImagesCartes; // Tableau comprenant les indices des cartes sur le tapis
        int[] tSuiteRecherche; // Tableau comprenant l'ordre des cartes à trouver

        static int TIMER = 40; // Durée du timer
        int nbPoints;
        bool partieDémarrée = false;
        int carteCourante;
        int indiceCarteATrouver = 1;

        static System.Windows.Forms.Timer monTimer = new System.Windows.Forms.Timer();
        static Stopwatch chronomètre = new Stopwatch();
        static bool arrêtTimer = false;


        /* Méthode affichant le temps restant toutes les secondes */
        private void afficherTemps(object sender, System.EventArgs e)
        {
            // On calcule le temps écoulé depuis l'instanciation du Timer et on convertit en secondes
            long secondes_restantes = TIMER - (chronomètre.ElapsedMilliseconds / 1000);
            // Puis on met à jour le label
            String temps = secondes_restantes.ToString();
            temps += " seconde(s) restante(s)";
            label_timer.Text = temps;
            label_timer.Update();
        }


        private void boutonRetourner(object sender, EventArgs e)
        {
            retournerCartes();
        }


        /* Méthode déclenchée lors du clic sur le boutton Distribuer */
        private void btn_Distribuer_Click(object sender, EventArgs e)
        {
            // On récupère le nombre d'images dans le réservoir :
            NB_CARTES_SABOT = ilSabotDeCartes.Images.Count - 1;
            // On récupère également le nombre de cartes à distribuées sur la tapis
            // autrement dit le nombre de contrôles présents sur le conteneur
            NB_CARTES_TAPIS = tlpTapisDeCartes.Controls.Count;
            // On effectue la distribution (aléatoire) proprement dite
            Distribution_Aleatoire();
            // On va masquer le boutton distribuer et afficher le bouton retourner
            btn_distribuer.Enabled = false;
            btn_retourner.Enabled = true;
        }


        /* Méthode démarrant le timer */
        private void démarrerTimer()
        {
            // Le timer doit afficher le temsp restant toutes les secondes
            monTimer.Tick += new EventHandler(afficherTemps);
            // On doit également pouvoir vérifier si le temps est écoulé ou non
            monTimer.Tick += new EventHandler(finPartie);
            // L'intervalle du timer sera de 40 secondes
            monTimer.Interval = 40000;
            monTimer.Start();
            // On utilise l'objet stopwtach pour comptabiliser le temps écoulé
            chronomètre.Start();
            // On laisse tourner le timer
            while (arrêtTimer == false)
            {
                afficherTemps(this, null);
                Application.DoEvents();
            }
        }

        /* Méthode distribuant 8 cartes aléatoires parmi les cartes disponibles */
        private void Distribution_Aleatoire()
        {
            // On utilise la LotoMachine pour générer une série aléatoire            
            LotoMachine hasard = new LotoMachine(NB_CARTES_SABOT);
            // On veut une série de nbCartesSurTapis cartes parmi celles du réservoir
            tImagesCartes = hasard.TirageAleatoire(NB_CARTES_TAPIS, false);
            // Affectation des images aux picturebox
            PictureBox carte;
            int i_image;
            for (int i_carte = 0; i_carte < NB_CARTES_TAPIS; i_carte++)
            {
                carte = (PictureBox)tlpTapisDeCartes.Controls[i_carte];
                i_image = tImagesCartes[i_carte + 1]; // i_carte + 1 à cause des pbs d'indices
                carte.Image = ilSabotDeCartes.Images[i_image];
                carte.Tag = i_carte + 1;
            }
        }


        /* Méthode déclenchée lorsque le timer atteint zéro */
        private void finPartie(Object myObject, EventArgs myEventArgs)
        {
            // On met à jour le label indiquant le nombre de secondes restantes
            label_timer.Text = "0 seconde(s) restante(s)";
            label_timer.Update();
            // On arrête le timer et la stopwatch
            chronomètre.Stop();
            monTimer.Stop();
            // On affiche un message au joueur : le jeu est terminé
            MessageBox.Show("Temps écoulé... GAME OVER !");
            // On quitte le jeu !
            arrêtTimer = true;
            Application.Exit();
        }


        public FMemoryGame()
        {
            InitializeComponent();
            // On initialise le nombre de points
            nbPoints = 0;
            // Ainsi que le label de points
            label_points.Text = "Nombre de points : 0";
            // On masque les bouttons retourner et jouer car les cartes ne sont pas distribuées
            btn_jouer.Enabled = false;
            btn_retourner.Enabled = false;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            g = new GameEngine();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label_timer_Click(object sender, EventArgs e)
        {

        }

        /* Méthode démarrant la partie */
        private void lancerPartie(object sender, EventArgs e)
        {
            partieDémarrée = true;
            suiteRecherche();
            // On va montrer la carte à rechercher
            montrerCarte(tSuiteRecherche[indiceCarteATrouver]);
            démarrerTimer();
            // On va masquer le bouton retourner et le bouton jouer
            btn_retourner.Enabled = false;
            btn_jouer.Enabled = false;
        }


        /* Méthode qui va récupérer les cartes à trouver au fur et à mesure du jeu */
        private void montrerCarte(int carteaTrouver)
        {
            // On va chercher le le numéro de la carte correspondante            
            carteCourante = tImagesCartes[carteaTrouver];
            // Et on affiche la carte à trouver dans le sabot
            pb_recherche.Image = ilSabotDeCartes.Images[carteCourante];
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        /* Méthode retournant toutes les cartes du tapis */
        private void retournerCartes()
        {
            PictureBox carte;
            for (int i_carte = 0; i_carte < NB_CARTES_TAPIS; i_carte++)
            {
                carte = (PictureBox)tlpTapisDeCartes.Controls[i_carte];
                if(!carte.Image.Equals(ilSabotDeCartes.Images[0])){
                    carte.Image = ilSabotDeCartes.Images[0]; 
                }               
            }
            btn_retourner.Enabled = false;
            btn_jouer.Enabled = true;
        }

        /* Méthode qui va créer une suite de cartes à rechercher parmi les cartes sur le tapis */
        private void suiteRecherche()
        {
            // On va générer un indice aléatoire pour récupérer une des 8 cartes au hasard
            LotoMachine hasard = new LotoMachine(8);
            tSuiteRecherche = hasard.TirageAleatoire(8, false);
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        /* Méthode vérifiant si la carte sélectionnée est celle qu'il faut trouver */
        private void verifierCarte(object sender, EventArgs e)
        {
            // On récupère la carte
            PictureBox carte;
            int i_carte, i_image;

            if (partieDémarrée)
            {
                // On va chercher le le numéro de la carte correspondante
                carte = (PictureBox)sender;
                i_carte = Convert.ToInt32(carte.Tag);
                // Puis l'image de la carte cliquée par le joueur
                i_image = tImagesCartes[i_carte];
                carte.Image = ilSabotDeCartes.Images[i_image];

                if (i_image == carteCourante)
                {
                    // Le joueur a trouvé la bonne carte : on va mettre à jour son score
                    nbPoints += 10;
                    label_points.Text = "Nombre de points : " + nbPoints;
                    label_points.Update();
                    indiceCarteATrouver++;
                    // Si on a pas trouvé toutes les cartes, on continue la partie
                    if (indiceCarteATrouver < 9)
                    {
                        montrerCarte(tSuiteRecherche[indiceCarteATrouver]);
                        démarrerTimer();
                    }
                    else
                    {
                        MessageBox.Show("Vous avez gagné la partie ! Bravo !");
                        arrêtTimer = true;
                        chronomètre.Stop();
                        monTimer.Stop();
                        Application.Exit();
                    }
                }
                else
                {
                    // Le joueur s'est trompé de carte : on va diminuer son nb de points
                    nbPoints -= 2;
                    label_points.Text = "Nombre de points : " + nbPoints;
                    label_points.Update();
                    MessageBox.Show("Dommage ! Essayez encore (et encore, et encore) !");
                    retournerCartes();
                    // Il faut regénérer une nouvelle suite pour les cartes à trouver
                    suiteRecherche();
                    indiceCarteATrouver = 1;
                    montrerCarte(tSuiteRecherche[indiceCarteATrouver]);
                    démarrerTimer();
                }
            }
            else
            {
                MessageBox.Show("Vous devez démarrer une partie avant de cliquer n'importe où !");
            }
            
        }
    }
}
