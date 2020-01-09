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
    /// Logique d'interaction pour Resultatjoueur.xaml
    /// </summary>
    public partial class Resultatjoueur : Window
    {
        public Resultatjoueur()
        {
            InitializeComponent();
            lise.Text = "HeyHey";//Mettre le tostring des resultats ?
        }

        private void Precedent(object sender, RoutedEventArgs e)
        {
            Sattistiques a = new Sattistiques();
            a.Show();
            this.Close();
        }

        private void Nom(object sender, RoutedEventArgs e)
        {

        }

        private void Email(object sender, RoutedEventArgs e)
        {

        }

        private void Prenom(object sender, RoutedEventArgs e)
        {

        }
    }
}
