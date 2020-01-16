using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    abstract class Evenement
    {
        private DateTime date;

        public DateTime Date
        {
             get { return (this.date ); }
            set { this.date = value; }
        }

        public Evenement(DateTime d)
        {
            this.date=d;
        }
        public Evenement()
        {
            this.date = new DateTime();
        }

    }
}
