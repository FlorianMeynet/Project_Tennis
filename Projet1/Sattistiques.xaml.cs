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
    /// Logique d'interaction pour Sattistiques.xaml
    /// </summary>
    public partial class Sattistiques : Window
    {
        public Sattistiques()
        {
            InitializeComponent();
        }
        private void ResultatClub(object sender, RoutedEventArgs e)
        {
            ResultatClub a = new ResultatClub();
            a.Show();
            this.Close();
        }
        private void ResultatJoueur(object sender, RoutedEventArgs e)
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
    }
}
