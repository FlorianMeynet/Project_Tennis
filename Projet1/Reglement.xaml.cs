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
    /// Logique d'interaction pour Reglement.xaml
    /// </summary>
    public partial class Reglement : Window
    {
        public Reglement()
        {
            InitializeComponent();
            reglement.Text = "Le règlement intérieur d’une association sert à préciser les modalités pratiques de son fonctionnement, dans le cadre prévu par les statuts.\n\nEn voici quelques éléments essentiels:\n– le club étant situé dans l’enceinte du stade municipal, l’accès aux terrains n’est donc possible que pendant les heures d’ouverture du stade, soit entre 7h et 23h.\n– l’adhésion au club(et aux différentes formules d’enseignement) est valable pour une saison sportive(du 1er septembre de l’année N au 30 août de la saison N + 1) et ne saurait faire l’objet d’aucun remboursement. Tout adhérent du TCCS doit être titulaire d’une licence FFT.\n– les parents doivent s’assurer, avant de laisser leur(s) enfant(s) à leurs cours, qu’un enseignant responsable est bien présent pour les accueillir.Les enfants restent sous l’entière responsabilité de leurs parents, sauf pendant le temps des cours, durant lesquels ils sont sous la responsabilité de l’éducateur.\n– toutes les réservations et planifications d’occupation des courts s’effectuent par internet, soit à distance, soit au club - house.Il n’y a pas de réservation par téléphone.\n– un adhérent du club a la possibilité d’inviter un non adhérent uniquement sur les terrains extérieurs et aux heures d’ouverture du club - house\n– l’adhésion au club entraîne l’acceptation du règlement intérieur.";
        }

        private void Precedent(object sender, RoutedEventArgs e)
        {
            Autres a = new Autres();
            a.Show();
            this.Close();
        }
    }
}
