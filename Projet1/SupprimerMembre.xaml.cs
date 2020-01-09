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
    /// Logique d'interaction pour SupprimerMembre.xaml
    /// </summary>
    public partial class SupprimerMembre : Window
    {
        public SupprimerMembre()
        {
            InitializeComponent();
        }
        private void Precedent(object sender, RoutedEventArgs e)
        {
            Membres a = new Membres();
            a.Show();
            this.Close();
        }

        private void supprimer(object sender, RoutedEventArgs e)
        {
            if ((bool)supr_compet.IsChecked)
            {
                string ligne = "";
                String[] mots;
                string nom;
                string prenom;
                string fichierMembre_compet = "joueur_compet.txt";
                StreamReader lire = null;
                lire = new StreamReader(fichierMembre_compet);

                while (lire.Peek() > 0)
                {
                    ligne = lire.ReadLine();
                    mots = ligne.Split(',');
                    nom = mots[0];
                    prenom = mots[1];
                    if (nom == supr_nom1.Text)
                    {
                        if (prenom == supr_prenom1.Text)
                        {

                        }
                    }
                  
                }

            }

        }

        
    }
}
