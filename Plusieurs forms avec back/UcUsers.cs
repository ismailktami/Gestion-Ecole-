using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plusieurs_forms_avec_back.Dao;
using MySql.Data.MySqlClient;

namespace Plusieurs_forms_avec_back
{
    public partial class UcUsers : MetroFramework.Controls.MetroUserControl
    {
        public UcUsers()
        {
            InitializeComponent();
        }

        public void add_clickuser(object sender, EventArgs e)
        {

        }

        private void canceladduser(object sender, EventArgs e)
        {
            resetchamp();
            erroconfirmation.Visible = false;
            errorpass.Visible = false;

        }

        public void resetchamp() {
            nomuser.ResetText();
            prenomuser.ResetText();
            cinuser.ResetText();
            username.ResetText();
            password.ResetText();
            passwordconfirmation.ResetText();
            erroconfirmation.Visible = false;
            errorpass.Visible = false;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string nom = nomuser.Text.ToString();
            string prenom = prenomuser.Text.ToString();
            string cin = cinuser.Text.ToString();
            string userna = username.Text.ToString();
            string password2 = password.Text.ToString();
            string password2confirm = passwordconfirmation.Text.ToString();

            if (String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(prenom) || String.IsNullOrEmpty(cin) || String.IsNullOrEmpty(userna) || String.IsNullOrEmpty(password2))
            {
                return ;

            }              
            else
            { 
                    if (!password2confirm.Equals(password2))
                {
                    erroconfirmation.Visible = true;
                    return;
                }
                    UtilisateurDao u = new UtilisateurDao(nom, prenom, cin, userna, password2);
                    u.insertUtilisateur(u);
                    resetchamp();
                    
            }

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }
        public void remplirlisteetudiant(String a)
        {
           
            String query;
            bdd b = new bdd();
            b.openConnection();
            if (String.IsNullOrEmpty(a))
                query = "select *from utilisateur";
            else
                query = "select * from utilisateur  where nom='"+a+"'";

            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            listeuser.DataSource = dataTable;
            b.closeConnection();


        }
    }
}
