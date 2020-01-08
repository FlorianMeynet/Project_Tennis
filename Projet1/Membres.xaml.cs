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
    /// Logique d'interaction pour Membres.xaml
    /// </summary>
    public partial class Membres : Window
    {
        public Membres()
        {
            InitializeComponent();
        }

        private void AjoutMembre(object sender, RoutedEventArgs e)
        {
            AjoutMembre a = new AjoutMembre();
            a.Show();
            this.Close();
        }

        private void SupprimerMembre(object sender, RoutedEventArgs e)
        {
            SupprimerMembre a = new SupprimerMembre();
            a.Show();
            this.Close();
        }
        private void ModifierMembre(object sender, RoutedEventArgs e)
        {
            Modifier_Membre a = new Modifier_Membre();
            a.Show();
            this.Close();
        }
        private void ListeMembre(object sender, RoutedEventArgs e)
        {
            ListMembre a = new ListMembre();
            a.Show();
            this.Close();
        }
        private void ListePersonnel(object sender, RoutedEventArgs e)
        {
            ListPersonnel a = new ListPersonnel();
            a.Show();
            this.Close();
        }
    }
}
