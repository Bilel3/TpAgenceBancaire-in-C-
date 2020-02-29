using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_AgenceBancaire
{
    class ListCompte
    {
        private List<Compte> _LCompte;
        private List<Compte> List_Compte { get;set; }
        public ListCompte()
        {
            _LCompte = new List<Compte>();
        }
        public void Ajouter(Compte c)
        {
            _LCompte.Add(c);
        }
        public Compte Rechercher(string numcompte)
        {
            Compte c=null;
            if (_LCompte.Count == 0)
            {
                return null;
            }
            else
            {
                for(int i = 0; i < _LCompte.Count; i++ ) {
                    c = (Compte)_LCompte[i];
                    if (numcompte == c.numcompte)
                        break;
                }
                return c;
            }
        }
        public void Supprimer (Compte c)
        {
            _LCompte.Remove(c);
        }
    }
}
