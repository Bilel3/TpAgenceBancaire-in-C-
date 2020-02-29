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
    public partial class Form1 : Form
    {
        int ind;
        ListCompte lc = new ListCompte();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            var form2 = new FCompte();
            form2.ShowDialog();
            lc.Ajouter(form2.c);
            Dg_Client.Rows.Add(form2.c.numcompte, form2.c.titulaire, form2.c.solde);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Dg_Client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Supp_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Compte c = lc.Rechercher(Txt_Rech.Text);
            if (c == null)
            {
                MessageBox.Show("Compte inexistant");
            }
        }
    }
   
}
