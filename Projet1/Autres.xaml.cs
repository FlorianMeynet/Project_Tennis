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
    /// Logique d'interaction pour Autres.xaml
    /// </summary>
    public partial class Autres : Window
    {
        public Autres()
        {
            InitializeComponent();
        }

        private void Commentaire(object sender, RoutedEventArgs e)
        {
            Commentaire a = new Commentaire();
            a.Show();
            this.Close();
        }
        private void Trouver(object sender, RoutedEventArgs e)
        {
            TrouverPartenaire a = new TrouverPartenaire();
            a.Show();
            this.Close();
        }
    }
}
