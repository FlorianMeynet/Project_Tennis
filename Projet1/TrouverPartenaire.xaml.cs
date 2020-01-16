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
    /// Logique d'interaction pour TrouverPartenaire.xaml
    /// </summary>
    public partial class TrouverPartenaire : Window
    {
        public TrouverPartenaire()
        {
            InitializeComponent();
        }

        private void Precedent(object sender, RoutedEventArgs e)
        {
            Autres a = new Autres();
            a.Show();
            this.Close();
        }

        private void Chercher(object sender, RoutedEventArgs e)
    { }
    }
}
