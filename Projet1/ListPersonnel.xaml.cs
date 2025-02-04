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
using System.IO;

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


            String[] mots;
            string fichierPersonnel = "personnel.txt";

            List<Personnel> liste_personnel = new List<Personnel>();
            string affichage = "";
            string[] lignes = File.ReadAllLines(fichierPersonnel);
            for (int i = 0; i < lignes.Length; i++)
            {
                string ligne_num = lignes[i];
                mots = ligne_num.Split(',');
                Personnel perso = new Personnel();
                perso.Nom = mots[0];
                perso.Prenom = mots[1];
                String[] date = mots[2].Split('/');
                int d_j = int.Parse(date[0]);
                int d_m = int.Parse(date[1]);
                int d_a = int.Parse(date[2]);
                DateTime date_n = new DateTime(d_a, d_m, d_j);
                perso.Naissance = date_n;
                perso.Adresse = mots[3];
                perso.Telephone = long.Parse(mots[4]);
                if (mots[5]=="F")
                    {
                    perso.Sexe = true;
                        }
                else
                {
                    perso.Sexe = false;
                }
                perso.Ville = mots[6];
                perso.Info_bancaire = mots[7];
                perso.Salaire = int.Parse(mots[8]);
                
                String[] date_e = mots[9].Split('/');
                int d_ej = int.Parse(date_e[0]);
                int d_em = int.Parse(date_e[1]);
                int d_ea = int.Parse(date_e[2]);
                DateTime date_entre = new DateTime(d_ea, d_em, d_ej);
                perso.Date_entree = date_entre;
                liste_personnel.Add(perso);
            }
            foreach (Personnel pers in liste_personnel)
            {
                affichage += pers.ToString() + "\n";

            }
            lise.Text = (affichage);
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
