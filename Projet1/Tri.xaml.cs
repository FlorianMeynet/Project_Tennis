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
    /// Logique d'interaction pour Tri.xaml
    /// </summary>
    public partial class Tri : Window
    {
        public Tri()
        {
            InitializeComponent();
            triballe.Text = "• Vos balles de tennis : à déposer dans les conteneurs en carton « Opérations Balles jaunes » Participation du club à l’opération Balles Jaunes: C’est plus de 58000 balles que les clubs de la LYT ont recyclé cette année pour les transformer en sols sportifs, destinés à des structures à vocation sociale ou solidaire(instituts pur personnes handicapées, hôpitaux pour enfants, centre de rééducation…).";
            triselectif.Text = "• Collecte des autres déchets : suivre la signalétique fixée sur les différentes sortes de poubelles.";
        }

        private void Precedent(object sender, RoutedEventArgs e)
        {
            Autres a = new Autres();
            a.Show();
            this.Close();
        }
    }
}

