using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_AgenceBancaire
{
    public class Compte
    {
        List<Mouvements> lmouv { get; set; }
        public string numcompte  { get; set; }
        public double solde { get; set; }
        public string titulaire { get; set; }

       
        
        public int NBMouv()
        {
            return this.lmouv.Count;
        }
         void NouveauMouv(Mouvements m)
        {
            this.lmouv.Add(m);
        }
        void retirer(double val)
        {
            if (val > 0)
            {
                if (val <= this.solde)
                    solde -= val;
            }
        }
        public void verser(double val)
        {
            if (val > 0)
            {
                this.solde += val;
            }
        }
    }
}
