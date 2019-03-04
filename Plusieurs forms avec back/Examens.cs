using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Plusieurs_forms_avec_back.Dao;
using MySql.Data.MySqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Plusieurs_forms_avec_back
{
    public partial class Examens : MetroFramework.Controls.MetroUserControl
    {
        public Examens()
        {
            InitializeComponent();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "CSV files (*.csv)|*.csv";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path.Text = ofd.FileName.ToString();



                }
            }
            catch (Exception ex)
            {

            }
        }

        public void remplirFilieresModule()
        {
            filieres.Items.Clear();
            String query;
            bdd b = new bdd();
            b.openConnection();
            query = "select nom from filiere";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                filieres.Items.Add(reader[0]);

            }
            b.closeConnection();
        }


        public void remplirFilieresModule2()
        {
            filieres2.Items.Clear();
            String query;
            bdd b = new bdd();
            b.openConnection();
            query = "select nom from filiere";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                filieres2.Items.Add(reader[0]);

            }
            b.closeConnection();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (filieres.SelectedIndex >= 0 && modules.SelectedIndex >= 0 ) {
                string fil = filieres.SelectedItem.ToString();
                int id_filiere = FiliereDao.getIdByNom(fil);
                int id_module = ModuleDao.getIdModuleByFiliere(modules.SelectedItem.ToString(), id_filiere);
                
                using (StreamReader sr = new StreamReader(path.Text.ToString()))
                {
                    String line;
                    String[] data = new String[50];
                    String[] dataspliter = new String[4];
                    String[] error = new String[50];
                    int compteur = 0;
                    int j = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        data[j] = line;
                        j++;
                    }

                    for (int i = 1; i < j; i++)
                    {
                        dataspliter = data[i].Split(';');
                        int id_etudiant = EtudiantDao.getIdEtByCne(dataspliter[0]);
                        string note = dataspliter[1];
                        DateTime dateTime = DateTime.UtcNow;
                        int year = dateTime.Year;
                        ExamenDao examen = new ExamenDao(id_etudiant, id_module, note, year);
                        examen.insertexamen(examen);
                       
                    }

                }


                path.ResetText();


            }

            else
            {
                if (filieres.SelectedIndex < 0)
                    errorfiliere.Visible = true;
                if (modules.SelectedIndex < 0)
                    errormodule.Visible = true;
            }
        }

      
        public void remplirModules()
        {
            modules.Items.Clear();
            String query;
            bdd b = new bdd();
            b.openConnection();
            int id_filiere = FiliereDao.getIdByNom(filieres.SelectedItem.ToString());
            query = "select nom from module where id_filiere='"+id_filiere+"'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                modules.Items.Add(reader[0]);

            }
            b.closeConnection();
        }

        public void remplirModules2()
        {
            modules2.Items.Clear();
            String query;
            bdd b = new bdd();
            b.openConnection();
            int id_filiere = FiliereDao.getIdByNom(filieres2.SelectedItem.ToString());
            query = "select nom from module where id_filiere='" + id_filiere + "'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                modules2.Items.Add(reader[0]);

            }
            b.closeConnection();
        }
        private void Examens_Load(object sender, EventArgs e)
        {
            remplirFilieresModule();
           //remplirModules2();
            remplirFilieresModule2();
            RemplirListExamen(null, null);
        }

        private void filieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirModules();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            path.ResetText();
            errormodule.Visible = false;
            errorfiliere.Visible = false;
            filieres.SelectedIndex = 0;
            modules.SelectedIndex = 0;
        }


        public void RemplirListExamen(String Filiere=null,String Module=null)
        {
            int moduleid = ModuleDao.getIdModule(Module);
            bdd b = new bdd();
            b.openConnection();
            String query = "select e.nom,e.prenom,e.cne,m.nom as 'nommodule',ex.note,ex.annee from etudiant e ,evaluation ex,module m " +
                "where ex.id_etudiant=e.id and   ex.id_module=m.id and ex.id_module='"+moduleid+"'  ";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            ListeExamen.DataSource = dataTable;
            b.closeConnection();

        }

        private void filieres2_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirModules2();
        }

        private void modules2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirListExamen(null,modules2.SelectedItem.ToString());
             
                downoald.Visible = true;
            if (modules.SelectedIndex < 0)
                downoald.Visible = false;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            remplirFilieresModule();
            //remplirModules2();
            remplirFilieresModule2();
            RemplirListExamen(null, null);
        }

        private void downoald_Click(object sender, EventArgs e)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(ListeExamen.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
           
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf,10,iTextSharp.text.Font.NORMAL);


            foreach (DataGridViewColumn column in ListeExamen.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText,text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240,240,240);
                pdftable.AddCell(cell);
            }


            foreach (DataGridViewRow row in ListeExamen.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells ) {
                   
                    pdftable.AddCell(new Phrase(cell.Value.ToString(),text));

                }
            }

            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = "test";
            savefiledialog.DefaultExt = ".pdf";

            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfodc = new Document(PageSize.A4, 10f, 10f, 10f,0f); ;
                    PdfWriter.GetInstance(pdfodc,stream);
                    pdfodc.Open();
                    pdfodc.Add(pdftable);
                    pdfodc.Close();
                    stream.Close();
                }

            }
        }

    }
}
