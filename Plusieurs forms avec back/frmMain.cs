using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using MetroFramework.Components;
using System.Threading;

namespace Plusieurs_forms_avec_back
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {

      
    
        static frmMain _instance;
        public static frmMain Instance
        {

            get {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
                        }
         
        }
         public MetroFramework.Controls.MetroPanel MetroContainer {
            get { return metroPanel1;
            }
            set
            {
                metroPanel1= value;

            }
            

        }


        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return MbBack; }
            set { MbBack = value; }


        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

          
                       Thread thread = new Thread(new  ThreadStart(loadingSplach));
                        thread.Start();

                        for (int i = 0; i < 1000; i++)
                            Thread.Sleep(10);
                        thread.Abort();
                        
                           
            MbBack.Visible = false;
            _instance = this;

       
           
            LoginControlleur uc = new LoginControlleur();
            uc.Dock = DockStyle.Fill;
            metroPanel1.Controls.Add(uc);
            
 
            /*
            UcDashboard uc = new UcDashboard();
            uc.Dock = DockStyle.Fill;
            metroPanel1.Controls.Add(uc);
           
    */

        }

        private void MbBack_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls["UcDashboard"].BringToFront();
            MbBack.Visible = false;
        }


        void loadingSplach() {

            frmSplashScreen splach = new frmSplashScreen();
            Application.Run(splach);

        }


        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
