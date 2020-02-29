using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2_AgenceBancaire
{
    public partial class FCompte : Form
    {
        public Compte c;

        public FCompte()
        {
            InitializeComponent();
        }

        private void FCompte_Load(object sender, EventArgs e)
        {
       

        }
        
        private void btnValider_Click(object sender, EventArgs e)
        {

            c = new Compte
            {
                numcompte = txtNumCompte.Text,
                solde = Convert.ToDouble(txtSolde.Text),
                titulaire = txtTitulaire.Text
            };
            this.Close();
            


            
            
            
        }
    }
}
