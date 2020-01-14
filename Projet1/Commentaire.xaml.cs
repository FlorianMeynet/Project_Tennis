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
    /// Logique d'interaction pour Commentaire.xaml
    /// </summary>
    public partial class Commentaire : Window
    {
        public Commentaire()
        {
            InitializeComponent();
        }

        private void Precedent(object sender, RoutedEventArgs e)
        {
            Autres a = new Autres();
            a.Show();
            this.Close();
        }

        private void Soumettre(object sender, RoutedEventArgs e)
        {
            string comment = commentaire.Text;
            string fichier_commentaire = "commentaire.txt";

            StreamWriter lire = new StreamWriter(fichier_commentaire, true);
            lire.Write("\n" +"Commentaire :"+ comment);
            lire.Close();
            Ca_commentaire a = new Ca_commentaire();
            a.Show();
            this.Close();

        }
    }
}
