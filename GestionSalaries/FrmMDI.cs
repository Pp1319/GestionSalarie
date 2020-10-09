using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSalaraies
{
    public partial class MDIWindow : Form
    {
        public MDIWindow()
        {
            InitializeComponent();
        }

       

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUtilisateurs frmUtilisateurs = FrmUtilisateurs.GetInstance();
                frmUtilisateurs.MdiParent = this;
                

                //FrmUtilisateurs frm = new FrmUtilisateurs();
                /// Form lancer le formulaire
                frmUtilisateurs.Show();
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Veuillez relancer l'application");
                
            }
            

        }

        private void ouvrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                GestionSalarie gestionSalarie = GestionSalarie.GetInstance();
                gestionSalarie.MdiParent = this;
                //GestionSalarie frm = new GestionSalarie();
                gestionSalarie.Show();
                
            }
            catch (ObjectDisposedException)
            {

                MessageBox.Show("Veuillez relancer l'application");
            }
            
            

        }       
    }
}
