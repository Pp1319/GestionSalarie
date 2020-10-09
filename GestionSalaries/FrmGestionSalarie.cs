using GestionSalaraies.Properties;
using SalariesDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitaires;

namespace GestionSalaraies
{

    public partial class GestionSalarie : Form
    {
        private static GestionSalarie _instance;
        public static GestionSalarie GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GestionSalarie();
            }
            return _instance;
        }
        public static GestionSalarie KillInstance()
        {
            if (_instance != null)
            {
                _instance = null;
            }
            return _instance;
        }
        

        Salarie salarie;
        Salaries salaries;
        Roles roles;
        Commercial commercial;


        enum Contextes
        {
            Initial = 0,
            Consultation = 1,
            ModificationInitiale = 2,
            ModificationAnnuler = 3,
            ModificationValider = 4,
            AjoutInitial = 5,
            AjoutValider = 6

        }

        public GestionSalarie()
        {
            InitializeComponent();

        }
        private void GestionSalarie_FormClose(object sender, FormClosingEventArgs e)
        {
            KillInstance();
        }

        // GestionnaireContextes
        void GestionnaireContextes(Contextes contexte)

        {

            switch (contexte)
            {
                case Contextes.Initial:
                    cbSal.Enabled = (cbSal.Items.Count > 0);
                    BtnNouveau.Enabled = true;
                    gbSal.Visible = false;
                    gbCom.Visible = false;
                    
                    break;
                case Contextes.Consultation:
                    BtnNouveau.Enabled = true;
                    gbSal.Visible = true;
                    PnlBtn.Enabled = true;
                    btnModif.Enabled = true;
                    btnAnnuler.Enabled = false;
                    btnValider.Enabled = false;
                    tbID.ReadOnly = true;
                    tbMDP.ReadOnly = true;
                    tbNom.ReadOnly = true;
                    tbSalBrut.ReadOnly = true;
                    tbCommission.ReadOnly = true;
                    tbCA.ReadOnly = true;
                    cbCompteBloque.Enabled = false;
                    cbRole.Enabled = false;
                    break;
                case Contextes.ModificationInitiale:
                    BtnNouveau.Enabled = false;
                    gbSal.Visible = true;
                    cbSal.Enabled = true;
                    PnlBtn.Enabled = true;
                    btnModif.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    tbID.ReadOnly = true;
                    tbMDP.ReadOnly = false;
                    tbSalBrut.ReadOnly = false;
                    cbCompteBloque.Enabled = true;
                    tbNom.ReadOnly = false;
                    cbRole.Enabled = true;
                    break;
                case Contextes.ModificationAnnuler:
                    BtnNouveau.Enabled = false;
                    gbSal.Visible = true;
                    cbSal.Enabled = false;
                    PnlBtn.Enabled = true;
                    btnModif.Enabled = false;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    tbID.ReadOnly = false;
                    tbMDP.ReadOnly = false;
                    tbSalBrut.ReadOnly = false;
                    cbCompteBloque.Enabled = true;
                    tbNom.ReadOnly = false;
                    cbRole.Enabled = true;



                    GestionnaireContextes(Contextes.Consultation);

                    break;
                case Contextes.ModificationValider:
                    break;
                case Contextes.AjoutInitial:
                    BtnNouveau.Enabled = true;
                    gbSal.Visible = true;
                    PnlBtn.Enabled = true;
                    btnModif.Enabled = true;
                    btnAnnuler.Enabled = true;
                    btnValider.Enabled = true;
                    tbID.ReadOnly = false;
                    tbMDP.ReadOnly = false;
                    tbNom.ReadOnly = false;
                    tbSalBrut.ReadOnly = false;
                    cbCompteBloque.Enabled = false;
                    cbRole.Enabled = true;
                   cbSal.ResetText();
                    break;
                case Contextes.AjoutValider:
                    cbSal.Enabled = true;

                    break;
                default:
                    break;
            }

        }
        //Chargement des salariés
        private void GestionSalarie_Load(object sender, EventArgs e)
        {
            ChargerSal();
            ChargerRoles();
            GestionnaireContextes(Contextes.Initial);

        }



        private void cbSal_SelectedIndexChanged(object sender, EventArgs e)
        {
            salarie = salaries.ExtraireSalarie(cbSal.Items[cbSal.SelectedIndex].ToString());

            ChargerValeursSal();
            GestionnaireContextes(Contextes.Consultation);
        }
        private void ChargerSal()
        {
            salaries = new Salaries();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            salaries.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Salarie item in salaries)
            {
                cbSal.Items.Add(item.Matricule);
            }

        }
        private void ChargerValeursSal()
        {
            tbID.Text = salarie.Matricule;
            tbMDP.Text = salarie.Prenom;
            tbNom.Text = salarie.Nom;
            dtDate.Value = salarie.DateNaissance;
            tbSalBrut.Text = salarie.SalaireBrut.ToString();
            cbCompteBloque.Checked = salarie.CompteBloque;

            if (salarie is Commercial)
            {
                Commercial commercial = (Commercial)salarie;
                tbCommission.Text = commercial.Commission.ToString();
                tbCA.Text = commercial.ChiffreAffaire.ToString();
                
               
            }

        }
        private void ChargerRoles()
        {
            roles = new Roles();
            ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
            roles.Load(serialiseur, Properties.Settings.Default.AppData);

            foreach (Role item in roles)
            {
                cbRole.Items.Add(item.Identifiant);
            }
        }
        //Ajout des salariés
        private void AjouterSal()
        {
            try
            {
                salarie = new Salarie();

            salarie.Matricule = tbID.Text;
            salarie.Prenom = tbMDP.Text;
            salarie.Nom = tbNom.Text;

         
            salarie.DateNaissance = dtDate.Value;
            decimal.TryParse(tbSalBrut.Text, out decimal salBrut);
            salarie.SalaireBrut = salBrut;

            salarie.CompteBloque = cbCompteBloque.Checked;
            salaries.Add(salarie);
           
            }
            catch( ApplicationException aE )
            {
                epSal.SetError(btnValider, aE.Message);
            }
            



        }
        private void AjouterCom()
        {
            try
            {
                commercial = new Commercial();
                commercial.Matricule = tbID.Text;
                commercial.Prenom = tbMDP.Text;
                commercial.Nom = tbNom.Text;


                commercial.DateNaissance = dtDate.Value;
                decimal.TryParse(tbSalBrut.Text, out decimal salBrut);
                commercial.SalaireBrut = salBrut;
                decimal.TryParse(tbCommission.Text, out decimal commission);
                commercial.Commission = commission;
                decimal.TryParse(tbCA.Text, out decimal chiffrea);
                commercial.ChiffreAffaire = chiffrea;

                commercial.CompteBloque = cbCompteBloque.Checked;
                salaries.Add(commercial);
            }
            catch (ApplicationException aE)
            {
                epSal.SetError(btnValider, aE.Message);
               
            }
        }
        private void SaveSal()
        {

            salaries.Save(new SauvegardeXML(), Settings.Default.AppData);
          
        }
        
        private void Clear()
        {

            tbMDP.Clear();
            tbNom.Clear();
            dtDate.ResetText();
            tbSalBrut.Clear();

        }

        private bool IsValidChamps()
        {
            bool valid = true;

            if (!Salarie.IsMatriculeValide(tbID.Text))
            {
                valid = false;
                epSal.SetError(tbID, "L'identifiant n'est pas valide");
            }
            else
            {
                epSal.SetError(tbID, string.Empty);
            }
            if (!Salarie.IsNomPrenomValide(tbMDP.Text))
            {
                valid = false;
                epSal.SetError(tbMDP, "Le prénom n'est pas valide");

            }
            else
            {
                epSal.SetError(tbMDP, string.Empty);
            }

            if (!Salarie.IsNomPrenomValide(tbNom.Text))
            {
                valid = false;
                epSal.SetError(tbNom, "Le nom n'est pas valide");

            }
            
            else
            {
                epSal.SetError(tbNom, string.Empty);
            }
            
            return valid;
        }
        private void ModifierSal()
        {
            try
            {
               
                if (IsValidChamps())
                { 
                    salaries.Remove(salarie);
                    AjouterSal();
                }
            }
            catch (ApplicationException ex1)
            {
                epSal.SetError(btnValider, ex1.Message);

            }
            catch (Exception ex)
            {
                epSal.SetError(btnValider, ex.Message);
            }
            




        }


        //Evènements

        private void btnModif_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationInitiale);



        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.ModificationInitiale);
            Clear();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {


                GestionnaireContextes(Contextes.AjoutValider);
                
                if (!salaries.Contains(salarie))
                {
                    if (cbCom.Checked)
                    {
                        AjouterCom();
                        cbSal.Items.Add(commercial.Matricule);
                    }
                    else
                    {
                        AjouterSal(); 
                        cbSal.Items.Add(salarie.Matricule);
                    }
                    
                   
                    
                }
                else 
                {
                    ModifierSal();


                }
                
                SaveSal();

            }
            catch (Exception ex)
            {
                epSal.SetError(btnValider, ex.Message);
            }


        }

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
             GestionnaireContextes(Contextes.AjoutInitial);
            
            

        }

        private void cbCom_Click(object sender, EventArgs e)
        {
            CheckBox s = sender as CheckBox;
            gbCom.Visible = s.Checked;
        }

        private void GestionSalarie_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
