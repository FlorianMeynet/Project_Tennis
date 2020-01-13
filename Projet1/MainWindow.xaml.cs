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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;

namespace Projet1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SoundPlayer music;
        public MainWindow()
        {
            InitializeComponent();
            music = new SoundPlayer("music.wav");
            music.Play();
        }



        private void Membres(object sender,RoutedEventArgs e)
        {
            Membres a = new Membres();
            a.Show();
            this.Close();
        }

        private void Statistiques(object sender, RoutedEventArgs e)
        {
            Sattistiques a = new Sattistiques();
            a.Show();
            this.Close();
        }
        private void Competitions(object sender,RoutedEventArgs e)
        {
            Competitions a = new Competitions();
            a.Show();
            this.Close();
        }
        private void Autres(object sender, RoutedEventArgs e)
        {
            Autres a = new Autres();
            a.Show();
            this.Close();
        }
    }
}
