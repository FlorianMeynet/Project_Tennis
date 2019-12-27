using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Event : Evenement
    {
        private string type;

        public Event (string t , DateTime date) : base(date)
        {
            this.type=t;
        }

        public string Type
        {
             get { return (this.type ); }
            set { this.type = value; }
        }

    }
}
