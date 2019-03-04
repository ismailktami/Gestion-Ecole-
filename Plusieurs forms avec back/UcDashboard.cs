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
namespace Plusieurs_forms_avec_back
{
    public partial class UcDashboard : MetroFramework.Controls.MetroUserControl
    {
        static UtilisateurDao user = new UtilisateurDao();

        public UcDashboard()
        {
            InitializeComponent();
        }

        private void MbCatgeory_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("UcCategory")) {
                UcCategory ucCategory = new UcCategory();
                ucCategory.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(ucCategory);

            }
            frmMain.Instance.MetroContainer.Controls["UcCategory"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void MbProduct_Click(object sender, EventArgs e)
        {

            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("Students"))
            {
                Students students = new Students();
                students.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(students);

            }
            frmMain.Instance.MetroContainer.Controls["Students"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;

        }
       


        //View to manage users
        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("UcUsers"))
            {
                UcUsers ucUsers = new UcUsers();
                ucUsers.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(ucUsers);

            }
            frmMain.Instance.MetroContainer.Controls["UcUsers"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;

        }

        private void decconexion_Click(object sender, EventArgs e)
        {

            if (MetroFramework.MetroMessageBox.Show(this, "Stop?", "You want", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
              
                Application.Exit();
            }
  
        }

        private void formation_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("Formations"))
            {
                Formations formations = new Formations();
                formations.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(formations);

            }
            frmMain.Instance.MetroContainer.Controls["Formations"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;

        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("Teachers"))
            {
                Teachers teachers = new Teachers();
                teachers.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(teachers);

            }
            frmMain.Instance.MetroContainer.Controls["Teachers"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;

        }

        private void Examens_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("Examens"))
            {
                Examens teachers = new Examens();
                teachers.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(teachers);

            }
            frmMain.Instance.MetroContainer.Controls["Examens"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void UcDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

