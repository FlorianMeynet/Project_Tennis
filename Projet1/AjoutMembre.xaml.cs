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
    /// Logique d'interaction pour AjoutMembre.xaml
    /// </summary>
    public partial class AjoutMembre : Window
    {
        public AjoutMembre()
        {
            InitializeComponent();
        }
        private void Precedent(object sender, RoutedEventArgs e)
        {
            Membres a = new Membres();
            a.Show();
            this.Close();
            
        }

        private void Inscription(object sender, RoutedEventArgs e)
        {
            string fichierMembre = "membres.txt";
            StreamWriter lire = null;
            lire = new StreamWriter(fichierMembre);

            string p = prenom.Text;
            string n = nom.Text;
            string d_j = jour.Text;
            string d_m = mois.Text;
            string d_a = annee.Text;
            string t = tel.Text;
            string em = email.Text;
            string v = ville.Text;

            string seexe = "";
            if ((bool)male.IsChecked)
            {
                seexe = "M";
            }
            else { seexe = "F"; }
            lire.WriteLine(n + "," + p + "," + d_j + "/" + d_m + "/" + d_a + "," + em + "," + t + "," + seexe + "," + v+"\n");
            lire.Close();
        }

   
    }
}

