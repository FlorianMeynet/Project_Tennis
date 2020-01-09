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
    /// Logique d'interaction pour ListPersonnel.xaml
    /// </summary>
    public partial class ListPersonnel : Window
    {
        public ListPersonnel()
        {
            InitializeComponent();
            lise.Text = "coucou\n\n\n Heyyyyy";
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

        private void Salaire(object sender, RoutedEventArgs e)
        {

        }

        private void InfoBanque(object sender, RoutedEventArgs e)
        {

        }

        private void DatEntree(object sender, RoutedEventArgs e)
        {

        }

        private void Tel(object sender, RoutedEventArgs e)
        {

        }
    }
}
