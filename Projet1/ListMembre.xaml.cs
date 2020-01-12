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
    /// Logique d'interaction pour ListMembre.xaml
    /// </summary>
    public partial class ListMembre : Window
    {
        public ListMembre()
        {
            InitializeComponent();
            lise.Text="coucou\n\n\n Heyyyyy";
        }
        private void Precedent(object sender, RoutedEventArgs e)
        {
            Membres a = new Membres();
            a.Show();
            this.Close();
        }

        private void Nom(object sender, RoutedEventArgs e)
        {

        }

        private void Prenom(object sender, RoutedEventArgs e)
        {

        }

        private void Email(object sender, RoutedEventArgs e)
        {

        }

        private void Tel(object sender, RoutedEventArgs e)
        {

        }

        private void Salaire(object sender, RoutedEventArgs e)
        {

        }

        private void Sexe(object sender, RoutedEventArgs e)
        {

        }

        private void Type(object sender, RoutedEventArgs e)
        {

        }

        private void Naissance(object sender, RoutedEventArgs e)
        {

        }

        private void Competition(object sender, RoutedEventArgs e)
        {
            string ligne = "";
            String[] mots;
            string fichierMembre_compet = "joueur_compet.txt";
            StreamReader lire_r = null;
            lire_r = new StreamReader(fichierMembre_compet);

            while (lire_r.Peek() > 0)    //Creation d'un Liste de tous les joueurs en competition
            {
                List<Joueur_competition> liste_j_c = new List<Joueur_competition>();
                ligne = lire_r.ReadLine();
                mots = ligne.Split(',');
                for (int i = 0; i < mots.Length; i++)
                {
                    Joueur_competition j_compet = new Joueur_competition();
                    j_compet.Nom = mots[0];
                    j_compet.Prenom = mots[1];
                    String[] date = mots[3].Split('/');
                    int d_j = int.Parse(date[0]);
                    int d_m = int.Parse(date[1]);
                    int d_a = int.Parse(date[2]);

                    DateTime date_n = new DateTime(d_a, d_m, d_j);
                    j_compet.Naissance = (date_n);
                    j_compet.Adresse = mots[4];
                    j_compet.Telephone = long.Parse(mots[5]);
                    if (mots[6] == "F")
                    {
                        j_compet.Sexe = true;
                    }
                    else
                    {
                        j_compet.Sexe = false;
                    }

                    j_compet.Ville = mots[7];
                    j_compet.Classement = double.Parse(mots[8]);

                    liste_j_c.Add(j_compet);
                }

                lire_r.Close();
                foreach (Joueur_competition j_c in liste_j_c)
                {
                    lise.Text = j_c.ToString()+"\n";
                }
            }
        }
        private void Loisir(object sender, RoutedEventArgs e)
        {
            string ligne = "";
            String[] mots;
            string fichierMembre_loisir = "joueur_loisir.txt";
            StreamReader lire_r = null;
            lire_r = new StreamReader(fichierMembre_loisir);

            while (lire_r.Peek() > 0)    //Creation d'un Liste de tous les joueurs en Loisir
            {
                List<Joueur_loisir> liste_j_l = new List<Joueur_loisir>();
                ligne = lire_r.ReadLine();
                mots = ligne.Split(',');
                for (int i = 0; i < mots.Length; i++)
                {
                    Joueur_loisir j_loisir = new Joueur_loisir();
                    j_loisir.Nom = mots[0];
                    j_loisir.Prenom = mots[1];
                    String[] date = mots[3].Split('/');
                    int d_j = int.Parse(date[0]);
                    int d_m = int.Parse(date[1]);
                    int d_a = int.Parse(date[2]);

                    DateTime date_n = new DateTime(d_a, d_m, d_j);
                    j_loisir.Naissance = (date_n);
                    j_loisir.Adresse = mots[4];
                    j_loisir.Telephone = long.Parse(mots[5]);
                    if (mots[6] == "F")
                    {
                        j_loisir.Sexe = true;
                    }
                    else
                    {
                        j_loisir.Sexe = false;
                    }

                    j_loisir.Ville = mots[7];


                    liste_j_l.Add(j_loisir);
                }

                lire_r.Close();
                foreach(Joueur_loisir j_l in liste_j_l)
                {
                    lise.Text = j_l.ToString() + "\n";

                    //Ajouter pour trier par Nom/Prenom / date_naissance 

                }

            }
        }


    }

}
