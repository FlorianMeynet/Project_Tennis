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
    /// Logique d'interaction pour Competitions.xaml
    /// </summary>
    public partial class Competitions : Window
    {
        public Competitions()
        {
            InitializeComponent();
        }

        private void AjoutCompet(object sender, RoutedEventArgs e)
        {
            AjoutCompet a = new AjoutCompet();
            a.Show();
            this.Close();
        }
        private void VoirCompet(object sender, RoutedEventArgs e)
        {
            VoirCompet a = new VoirCompet();
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
