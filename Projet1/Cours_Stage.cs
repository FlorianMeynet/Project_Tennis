using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    abstract class  Cours_Stage 

    {
        private int age;
        private int niveau;
        private List<Joueur_competition> liste_eleve;

        public Cours_Stage()
        {
            this.age = 0;
            this.niveau = 0;
            this.liste_eleve = null;
        }
        public Cours_Stage(int a, int n, List<Joueur_competition> l)
        {
            this.age = a;
            this.niveau = n;
            this.liste_eleve = l;
        }
        public int  Age
        {
            get { return (this.age); }
            set { this.age = value; }
        }
        public int Niveau
        {
            get { return (this.niveau); }
            set { this.niveau = value; }
        }
        public List<Joueur_competition> Liste_eleve
        {
            get { return (this.liste_eleve); }
            set { this.liste_eleve = value; }
        }
    }
}
