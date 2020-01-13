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
using System.IO;

namespace Projet1
{
    /// <summary>
    /// Logique d'interaction pour Modifier_Membre.xaml
    /// </summary>
    public partial class Modifier_Membre : Window
    {
        public Modifier_Membre()
        {
            InitializeComponent();
        }
        private void Precedent(object sender, RoutedEventArgs e)
        {
            Membres a = new Membres();
            a.Show();
            this.Close();
        }

        private void Modifier(object sender, RoutedEventArgs e)
        {
            if ((bool)compet.IsChecked)
            {
                string ligne = "";
                String[] mots;
                string fichierMembre_compet = "joueur_compet.txt";
                StreamReader lire_r = null;
                StreamWriter lire_w = null;
                lire_r = new StreamReader(fichierMembre_compet);
                List<Joueur_competition> liste_j_c = new List<Joueur_competition>();

               

                string[] lignes = File.ReadAllLines(fichierMembre_compet);
                for (int i = 0; i< lignes.Length-1; i++)
                {
                    string ligne_num = lignes[i];
                    mots=ligne_num.Split(',');
                    Joueur_competition j_compet = new Joueur_competition();
                    j_compet.Nom =mots[0] ;
                    j_compet.Prenom = mots[1];
                    String[] date = mots[2].Split('/');
                    int d_j = int.Parse(date[0]);
                    int d_m = int.Parse(date[1]);
                    int d_a = int.Parse(date[2]);

                    DateTime date_n = new DateTime(d_a, d_m, d_j);
                    j_compet.Naissance = (date_n);
                    j_compet.Adresse = mots[3];
                    j_compet.Telephone = long.Parse(mots[4]);
                    if (mots[5] == "F")
                    {
                        j_compet.Sexe = true;
                    }
                    else
                    {
                        j_compet.Sexe = false;
                    }

                    j_compet.Ville = mots[6];
                    j_compet.Classement = double.Parse(mots[7]);

                    liste_j_c.Add(j_compet);
                }
                    

            
                lire_r.Close();
                lire_w = new StreamWriter(fichierMembre_compet);  //On a bien la liste des joueurs compet

                foreach (Joueur_competition j_c in liste_j_c)
                {
                    if (j_c.Nom == nom.Text)
                    {
                        if (j_c.Prenom == prenom.Text)
                        {
                            if ((jour.Text != "") && (mois.Text != "") && (annee.Text != ""))
                            {
                                int d_j = int.Parse(jour.Text);
                                int d_m = int.Parse(mois.Text);
                                int d_a = int.Parse(annee.Text);
                                DateTime naissance = new DateTime(d_a, d_m, d_j);
                                j_c.Naissance = naissance;
                            }
                            else if (email.Text != "")
                            {
                                string mail = email.Text;
                                j_c.Adresse = mail;
                            }
                            else if (tel.Text != "")
                            {
                                long tell = long.Parse(tel.Text);
                                j_c.Telephone = tell;
                            }
                            else if (ville.Text != "")
                            {
                                string vil = ville.Text;
                                j_c.Ville = vil;
                            }
                            else if (classement.Text != "")
                            {
                                double clas = double.Parse(classement.Text);
                                j_c.Classement = clas;
                            }
                        }
                    }
                    lire_w.WriteLine(j_c.Nom + "," + j_c.Prenom + "," + j_c.Naissance.Day + "/" + j_c.Naissance.Month + "/" + j_c.Naissance.Year + "," + j_c.Adresse + "," + j_c.Telephone + "," + j_c.Sexe + "," + j_c.Ville + "," + j_c.Classement);
                }
                lire_w.Close();
            }

            else if ((bool)loisir.IsChecked)
            {
                
                String[] mots;
                string fichierMembre_loisir = "joueur_loisir.txt";
                StreamReader lire_r = null;
                StreamWriter lire_w = null;
                lire_r = new StreamReader(fichierMembre_loisir);
                List<Joueur_loisir> liste_j_l = new List<Joueur_loisir>();

                string[] lignes = File.ReadAllLines(fichierMembre_loisir);
                for (int i = 0; i < lignes.Length-1; i++)
                {
                    string ligne_num = lignes[i];
                    mots = ligne_num.Split(',');
                    Joueur_loisir j_loisir = new Joueur_loisir();
                    j_loisir.Nom = mots[0];
                    j_loisir.Prenom = mots[1];
                    String[] date = mots[2].Split('/');
                    int d_j = int.Parse(date[0]);
                    int d_m = int.Parse(date[1]);
                    int d_a = int.Parse(date[2]);

                    DateTime date_n = new DateTime(d_a, d_m, d_j);
                    j_loisir.Naissance = (date_n);
                    j_loisir.Adresse = mots[3];
                    j_loisir.Telephone = long.Parse(mots[4]);
                    if (mots[5] == "F")
                    {
                        j_loisir.Sexe = true;
                    }
                    else
                    {
                        j_loisir.Sexe = false;
                    }

                    j_loisir.Ville = mots[6];


                    liste_j_l.Add(j_loisir);
                }
                lire_r.Close();
                lire_w = new StreamWriter(fichierMembre_loisir);

                foreach (Joueur_loisir j_c in liste_j_l)
                {
                    if (j_c.Nom == nom.Text)
                    {
                        if (j_c.Prenom == prenom.Text)
                        {
                            if ((jour.Text != "") && (mois.Text != "") && (annee.Text != ""))
                            {
                                int d_j = int.Parse(jour.Text);
                                int d_m = int.Parse(mois.Text);
                                int d_a = int.Parse(annee.Text);
                                DateTime naissance = new DateTime(d_a, d_m, d_j);
                                j_c.Naissance = naissance;
                            }
                            else if (email.Text != "")
                            {
                                string mail = email.Text;
                                j_c.Adresse = mail;
                            }
                            else if (tel.Text != "")
                            {
                                long tell = long.Parse(tel.Text);
                                j_c.Telephone = tell;
                            }
                            else if (ville.Text != "")
                            {
                                string vil = ville.Text;
                                j_c.Ville = vil;
                            }
                        }
                    }
                    lire_w.WriteLine(j_c.Nom + "," + j_c.Prenom + "," + j_c.Naissance.Day + "/" + j_c.Naissance.Month + "/" + j_c.Naissance.Year + "," + j_c.Adresse + "," + j_c.Telephone + "," + j_c.Sexe + "," + j_c.Ville);
                }
                lire_w.Close();

            }
        }
    }
}
