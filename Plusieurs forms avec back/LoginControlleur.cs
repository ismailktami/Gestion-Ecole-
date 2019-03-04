using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Plusieurs_forms_avec_back.Dao;

namespace Plusieurs_forms_avec_back
{
    public partial class LoginControlleur : MetroFramework.Controls.MetroUserControl
    {
        public LoginControlleur()
        {
            InitializeComponent();
        }

        private void LoginControlleur_Load(object sender, EventArgs e)
        {

        }

     

       
        private void Login_Click(object sender, EventArgs e)
        {
          
            try
            {
                 UtilisateurDao utilisateur = new UtilisateurDao(username.Text.ToString(),password.Text.ToString());
                Boolean c= utilisateur.Auhthenfier(utilisateur);
                if (c == false)
                    MessageBox.Show("Login Failed");
             
             else{
             
                    if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("UcDashboard"))
                    {
                        UcDashboard ucDashboard = new UcDashboard();
                        ucDashboard.Dock = DockStyle.Fill;
                        frmMain.Instance.MetroContainer.Controls.Add(ucDashboard);

                      

                    }
                    frmMain.Instance.MetroContainer.Controls["UcDashboard"].BringToFront();
                }
            }
            catch(Exception )
            {
                Application.Exit();


            }
            

            }

     

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("Registration"))
            {
                Registration ucReg = new Registration();
                ucReg.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(ucReg);
            }
            frmMain.Instance.MetroContainer.Controls["Registration"].BringToFront();
           
        }
    }
}
