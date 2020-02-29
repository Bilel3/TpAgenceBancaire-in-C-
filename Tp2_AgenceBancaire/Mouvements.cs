using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_AgenceBancaire
{
    class Mouvements
    {
        public DateTime dateop{ get; set; }
        
        public double montant { get; set; }
        public string typop { get; set; }

        public Mouvements(DateTime dateop, double montant, string typop)
        {
            this.dateop = dateop;
            this.montant = montant;
            this.typop = typop;

        }
    }
}
