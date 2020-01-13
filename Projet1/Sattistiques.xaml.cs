using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projet1
{
    /// <summary>
    /// Logique d'interaction pour Sattistiques.xaml
    /// </summary>
    public partial class Sattistiques : Window
    {
        public Sattistiques()
        {
            InitializeComponent();
            joueurclub.Text = "A ecrire";//Afficher le résultat de la méthode
            clubcompet.Text = "A écrire";//Afficher le résultat de la méthode
        }
        private void ResultatJoueur(object sender, RoutedEventArgs e)
        {
            ResultatClub a = new ResultatClub();
            a.Show();
            this.Close();
        }
        private void ResultatClub(object sender, RoutedEventArgs e)
        {
            Resultatjoueur a = new Resultatjoueur();
            a.Show();
            this.Close();
        }
        private void Precedent(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }

        private int NbreMoyenJoueur(List<Competition_simple> list)
        {
            int compteur_compet = 0;
            int compteur_joueur = 0;
            foreach(Competition_simple elt in list)
            {
                foreach(Joueur_competition  a in elt.Liste_equipe)
                {
                    compteur_joueur++;
                }
                compteur_compet++;
            }
            return (compteur_joueur / compteur_compet);
        }
        private int NbreMoyenJoueur(List<Competition> list)
        {
            int compteur_compet = 0;
            foreach (Competition elt in list)
            {
                compteur_compet++;
            }
            return compteur_compet;
        }
    }
}
