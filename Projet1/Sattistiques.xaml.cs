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
using System.IO;

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
            string fichierCompet = "compet_individuel.txt";
            List<Competition_simple> liste_j_c = new List<Competition_simple>();
            string[] lignes = File.ReadAllLines(fichierCompet);
            String[] mots;
            double nb_j = 0;
            for (int i = 0; i < lignes.Length; i++)
            {
                string ligne_num = lignes[i];
                mots = ligne_num.Split(',');
                String[] joueur = mots[4].Split('/');
                nb_j += joueur.Length;
            }
            double res=nb_j / (double)lignes.Length;
            joueurclub.Text = Convert.ToString(res);
            clubcompet.Text = Convert.ToString(lignes.Length);

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

        private double NbreMoyenJoueur()
        {
            string fichierCompet = "compet_individuel.txt";
            List<Competition_simple> liste_j_c = new List<Competition_simple>();
            string[] lignes = File.ReadAllLines(fichierCompet);
            String[] mots;
            double nb_j = 0;
            for (int i = 0; i < lignes.Length; i++)
            {
                string ligne_num = lignes[i];
                mots = ligne_num.Split(',');
                String[] joueur = mots[4].Split('/');
                nb_j += joueur.Length;
            }
            return (nb_j/(double)lignes.Length);  
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
