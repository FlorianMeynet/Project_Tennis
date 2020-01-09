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
            string fichierMembre_compet = "joueur_compet.txt";
            string fichierMembre_loisir = "joueur_loisir.txt";
            StreamWriter lire = null;

            string p = prenom.Text;
            string n = nom.Text;
            string d_j = jour.Text;
            string d_m = mois.Text;
            string d_a = annee.Text;
            string t = tel.Text;
            string em = email.Text;
            string v = ville.Text;
            string c = classement.Text;
            string seexe = "";

            if ((bool)male.IsChecked)
            {
                seexe = "M";
            }

            if((bool)femme.IsChecked)
            {
                seexe = "F"; 
            }
<<<<<<< HEAD

=======
>>>>>>> d614193750fcea2b2691e35a8516263278122317
           
            if ((bool)compet.IsChecked)
            {
                lire = new StreamWriter(fichierMembre_compet);
                lire.WriteLine(n + "," + p + "," + d_j + "/" + d_m + "/" + d_a + "," + em + "," + t + "," + seexe + "," + v + "," + c + "\n");
                lire.Close();

            }
            if ((bool)loisir.IsChecked)
            {
                lire = new StreamWriter(fichierMembre_loisir);
                lire.WriteLine(n + "," + p + "," + d_j + "/" + d_m + "/" + d_a + "," + em + "," + t + "," + seexe + "," + v + "\n");
                lire.Close();
            }

            Ca_marche a = new Ca_marche();
            a.Show();
            this.Close();



        }

   
    }
}

