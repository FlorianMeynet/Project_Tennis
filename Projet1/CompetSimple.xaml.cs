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
    /// Logique d'interaction pour CompetSimple.xaml
    /// </summary>
    public partial class CompetSimple : Window
    {
        public CompetSimple()
        {
            InitializeComponent();
        }

        private void Precedent(object sender, RoutedEventArgs e)
        {
            AjoutCompet a = new AjoutCompet();
            a.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fichier_compet_simple = "compet_individuel.txt";
            StreamWriter lire = null;

            string l = lieu.Text;
            string n = nom_compet.Text;
            string min = nbre_min_joueur.Text;
            string max = classement_max.Text;
            string participant = liste_participant.Text;
            string jour = nbre_jour.Text;
            string match = nbre_match.Text;
            string anne_min = annee_min.Text;
            string anne_max = annee_max.Text;

            lire = new StreamWriter(fichier_compet_simple, true);
            lire.Write("\n"+l + "," + n + "," + min + "," + max + "," + participant + "," + jour + "," + match + "," + anne_min+"/"+anne_max );
            lire.Close();
            Ca_marche a = new Ca_marche();
            a.Show();
            this.Close();
        }
    }
}