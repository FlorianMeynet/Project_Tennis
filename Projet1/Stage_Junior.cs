using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Stage_Junior : Evenement , Cours_Stage
    {
        private bool paiement;
        private int age_necessaire;



        public Stage_Junior(bool p ,int a_n , string t ,int a, int n, List<string> l) : base(t,a,n,l)
        {
            this.paiement = p;
            this.age_necessaire=a_n;

        }
        public int Paiement
        {
            get { return (this.paiement); }
            set { this.paiement = value; }
        }
        public int Age_necessaire
        {
            get { return (this.age_necessaire); }
            set { this.age_necessaire = value; }
        }

        public string Affichage_liste(List<> liste)
        {
            int t =Liste_eleve.Count();
            string s="";
            for(int i=0;i<t;i++)
            {
                s+=" "+liste[i];
            }
            return(s);
        }
        public bool Test_age()
        {
            int t =Liste_eleve.Count();
            List<string> Liste_pas_age = new List<string>();
            for(int i=0;i<t;i++)
            {
                if(this.Liste_eleve[i].Age < age_necessaire)
                {
                    Liste_pas_age.Add(this.Liste_eleve[i]);
                    Liste_eleve.Remove(this.Liste_eleve[i]);

                }
            }
            if(Liste_pas_age==null){retrun("Tous le monde a le bon age");}
            else{return(Affichage_liste(Liste_pas_age));}
        }


    }
}
