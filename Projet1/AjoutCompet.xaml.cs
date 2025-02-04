﻿using System;
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
    /// Logique d'interaction pour AjoutCompet.xaml
    /// </summary>
    public partial class AjoutCompet : Window
    {
        public AjoutCompet()
        {
            InitializeComponent();
        }

        private void Precedent(object sender, RoutedEventArgs e)
        {
            Competitions a = new Competitions();
            a.Show();
            this.Close();
        }

        private void Equipe(object sender, RoutedEventArgs e)
        {
            CompetEquipe a= new CompetEquipe();
            a.Show();
            this.Close();
        }
        private void Individuel(object sender, RoutedEventArgs e)
        {
            CompetSimple a = new CompetSimple();
            a.Show();
            this.Close();
        }
    }
}
