using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Capitaine
    {
        public List<Joueur_competition> ChoixEquipe()
        {
            List<Joueur_competition> list = new List<Joueur_competition>();
            Console.WriteLine("Nombre de Joueur dans l'équipe ?");
            int nbre = int.Parse(Console.ReadLine());
            for (int i = 0; i < nbre; i++)
            {
                Console.WriteLine("Nom ,prenom du joueur a ajouter");
                //list.add(Ajout(nom,prenom)) methode d instance a creer
            }
            return list;
        }
    }
}
