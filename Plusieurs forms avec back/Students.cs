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
using System.Text.RegularExpressions;

namespace Plusieurs_forms_avec_back
{
    public partial class Students : MetroFramework.Controls.MetroUserControl
    {
        byte[] img;
        DataTable dataTable;
        int id_student;
        String nomfiliereselectionne;
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            remplirFilieresModule();
            remplirlisteetudiant(null);
         

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Image image;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All Files |*.*|JPG|*.jpg|PNG|*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureStudent.Image = System.Drawing.Image.FromFile(ofd.FileName);
                     image= System.Drawing.Image.FromFile(ofd.FileName); ;
                      var ms = new MemoryStream();
                      image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                      byte[] i = ms.ToArray();
                      img = i;
                }
                else
                {
                 
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            String email = emailetudiant.Text.ToString();
            if (email == "" || !(email.Contains("@")))
            {

                erroremail.Visible = true;
                return;
            }

         String nom =nameetudiant.Text.ToString();
         String prenom=prenometudiant.Text.ToString();
         int age=int.Parse(ageetudiant.Value.ToString());

            string pattern = "^[0-9]{10}$";
            Regex reg = new Regex(pattern);

            String telephone = teleetudiant.Text.ToString();
            if (telephone == "" || !reg.IsMatch(telephone))
            {
                errorphone.Visible = true;
                return;

            }
              
         String nationalite = nationaliteetudiant.Text.ToString();
         String address=addressetudiant.Text.ToString();
            String sexe="default";
            if (men.Checked == true)         
            sexe="men";
            if (women.Checked == true)
            sexe = "women";
         String CNE=cneetudiant.Text.ToString();
         String CIN=cinetudiant.Text.ToString();
         String date_naissance = metroDateTime1.ToString();
         String Lieu_naissance=localetudiant.Text.ToString();
         byte[] image=img;
         int level = int.Parse(leveletudiant.Value.ToString());

            String c;
            if (FiliereEtudiants.SelectedIndex < 0)
            {
                errorfiliere.Visible = true;
                return;

            }
            else
                c = FiliereEtudiants.SelectedItem.ToString();
           
            int id_filiere = FiliereDao.getIdByNom(c);
            bdd b = new bdd();
            try
            {
                b.openConnection();
                String query = "INSERT INTO etudiant(nom,prenom,cne,cin,sexe,nationalite,lieu_naissance,date_naissance,email,telephone,adresse,niveau,id_filiere,image,age) " +
                    " values('" + nom + "','" + prenom + "','" + CNE + "','" + CIN + "','" + sexe + "','" + nationalite + "','" + Lieu_naissance + "','" + date_naissance + "','" + email + "','" + telephone + "','" + address + "','" + level + "','" + id_filiere + "',@image,'" + age + "')";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.Parameters.Add("@image", MySqlDbType.Blob);
                cmd.Parameters["@image"].Value = image;
                cmd.ExecuteNonQuery();
                        }
            catch(Exception excp) {

            }
            b.closeConnection();
                resetChampInsert();
                 

        }





        public void remplirFilieresModule()
        {
            FiliereEtudiants.Items.Clear();
            String query;
            bdd b = new bdd();
            b.openConnection();
            query = "select nom from filiere";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FiliereEtudiants.Items.Add(reader[0]);

            }
            b.closeConnection();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            resetChampInsert();
        }


        public void resetChampInsert()
        {

            remplirFilieresModule();
            nameetudiant.ResetText();
            prenometudiant.ResetText();
            ageetudiant.ResetText();
            emailetudiant.ResetText();
            teleetudiant.ResetText();
            addressetudiant.ResetText();
            cneetudiant.ResetText();
            cinetudiant.ResetText();
            metroDateTime1.ResetText();
            localetudiant.ResetText();
            nationaliteetudiant.ResetText();
            cnedetails.ResetText();
            cindetails.ResetText();
            emaildetails.ResetText();
            phonedetails.ResetText();
            MotCleStudentSearche.ResetText();
            errorphone.Visible = false;
            erroremail.Visible = false;
            errorfiliere.Visible = false;
        
            remplirlisteetudiant(null);
        }
        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            String nom = nameetudiant.Text.ToString();
            String prenom = prenometudiant.Text.ToString();
            int age = int.Parse(ageetudiant.Value.ToString());
            String email = emailetudiant.Text.ToString();
            String telephone = teleetudiant.Text.ToString();
            String nationalite = nationaliteetudiant.Text.ToString();
            String address = addressetudiant.Text.ToString();
            String sexe = "default";
            if (men.Checked == true)
                sexe = "men";
            if (women.Checked == true)
                sexe = "women";
            String CNE = cneetudiant.Text.ToString();
            String CIN = cinetudiant.Text.ToString();
            String date_naissance = metroDateTime1.Text.ToString();
            String Lieu_naissance = localetudiant.Text.ToString();
            int level = int.Parse(leveletudiant.Value.ToString());
            String c;
            if (FiliereEtudiants.SelectedIndex>0)
                c = FiliereEtudiants.SelectedItem.ToString();
            else
                c = nomfiliereselectionne;

            int id_filiere = FiliereDao.getIdByNom(c);
   
            bdd b = new bdd();
           
                b.openConnection();
                String query = "UPDATE  etudiant SET  "+
                       "" +
                       "  nom='"+nom+"' , prenom='"+prenom+"' ,CNE='"+CNE+"', CIN='"+CIN+"' , sexe='"+sexe+"' , nationalite='"+nationalite+"' ,lieu_naissance='"+Lieu_naissance+"' ,date_naissance='"+ date_naissance + "' ,email='"+ email + "' ,telephone='"+ telephone + "' ,adresse ='"+ address + "', niveau='"+ level + "' , age='"+ age + "' ,id_filiere='"+id_filiere+"' " +
                    " where id='"+id_student+"'  ";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.ExecuteNonQuery();
          
                b.closeConnection();

            resetChampInsert();
            remplirlisteetudiant(null);
            

        }

        public void remplirlisteetudiant(String a )
        {
            String fili = "nomfiliere";
            String query;
            bdd b = new bdd();
            b.openConnection();
            if (String.IsNullOrEmpty(a))
                query = "select  e.nom,e.prenom,e.cin,e.cne,e.email,e.telephone,e.adresse,e.age,e.niveau,e.lieu_naissance,e.date_naissance,e.sexe,e.nationalite,f.nom as '"+fili+"' from etudiant e,filiere  f where id_filiere=f.id ";
            else
                query = "select  Nom,prenom,cin,cne,email,telephone,adresse,age,niveau,image  from etudiant where Nom='" + a + "'";

            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            cmd.ExecuteNonQuery();
             this.dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            listetudiant.DataSource = dataTable;
                    b.closeConnection();

 
        }

        private void listetudiant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void listetudiant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            else
            {

                DataGridViewRow selectedRow = listetudiant.Rows[index];
                cnedetails.Text = selectedRow.Cells["Cne"].Value.ToString();
                cindetails.Text = selectedRow.Cells["Cin"].Value.ToString();
                emaildetails.Text = selectedRow.Cells["Emailet"].Value.ToString();
                phonedetails.Text = selectedRow.Cells["telephone"].Value.ToString();
                {
                    nameetudiant.Text = selectedRow.Cells["Nomet"].Value.ToString();
                    prenometudiant.Text = selectedRow.Cells[1].Value.ToString();
                    cneetudiant.Text = selectedRow.Cells["Cne"].Value.ToString();
                    cinetudiant.Text = selectedRow.Cells["Cin"].Value.ToString();
                    String sexe = selectedRow.Cells["sexe"].Value.ToString();
                    if (sexe.Equals("men"))
                        men.Checked = true;
                    else
                        women.Checked = true;

                    emailetudiant.Text = selectedRow.Cells["Emailet"].Value.ToString();
                    addressetudiant.Text = selectedRow.Cells["Adresse"].Value.ToString();
                    localetudiant.Text = selectedRow.Cells["lieu_naiss"].Value.ToString();
            
                    ageetudiant.Value = Decimal.Parse(selectedRow.Cells["age"].Value.ToString());
                    leveletudiant.Value = Decimal.Parse(selectedRow.Cells["niveau"].Value.ToString());    
                    teleetudiant.Text = selectedRow.Cells["telephone"].Value.ToString();
                   
                    UpdateStudent.Enabled = true;
                    nomfiliereselectionne = selectedRow.Cells["nomfiliere"].Value.ToString(); 
                    EtudiantDao et = new EtudiantDao();
                    id_student = et.getIdEt(cinetudiant.Text.ToString());
                    nationaliteetudiant.Text = selectedRow.Cells["Nationaliteet"].Value.ToString();
                    bdd b = new bdd();
                    byte[] c=null;
                    b.openConnection();
                    String query = "select image from etudiant where cin='"+cindetails.Text.ToString()+"'";
                    MySqlCommand cmd = new MySqlCommand(query, b.connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    byte[] imgg = (byte[])table.Rows[0][0];
                    MemoryStream ms = new MemoryStream(imgg);
                    imagestudent.Image = System.Drawing.Image.FromStream(ms);
                    pictureStudent.Image= System.Drawing.Image.FromStream(ms); 

                    b.closeConnection();
                }

            }
        }

        public void selectimage(String a )
        {

        }

        private void delette_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Delete?"+nameetudiant.Text.ToString()+" "+prenometudiant.Text.ToString(), "You want", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bdd b = new bdd();
                    b.openConnection();
                    String query = "delete from etudiant where id='" + id_student + "'";
                    MySqlCommand cmd = new MySqlCommand(query, b.connection);
                    cmd.ExecuteNonQuery();
                    b.closeConnection();

                }

                catch (Exception)
                {

                }
                remplirlisteetudiant(null);
                resetChampInsert();
            }



        }

        private void Reset_Click(object sender, EventArgs e)
        {
            remplirlisteetudiant(null);
            resetChampInsert();

        }

        private void metroButton4_Click(object sender, EventArgs e)

        {
            String NomStudent;
            if (String.IsNullOrEmpty(MotCleStudentSearche.Text.ToString()) || comboboxSearchStudent.SelectedIndex < 0)
            {

                return;

            }
            else

            {
                String query = "select *from etudiant";
                String mot = MotCleStudentSearche.Text.ToString();
                String fili = "nomfiliere";
                switch (comboboxSearchStudent.SelectedItem.ToString())

                {
                    case "Nom": { query = "select  e.nom,e.prenom,e.cin,e.cne,e.email,e.telephone,e.adresse,e.age,e.niveau,e.lieu_naissance,e.date_naissance,e.sexe,e.nationalite,f.nom as '" + fili + "' from etudiant e,filiere  f where id_filiere=f.id and e.nom='"+mot+"'" ; break; }
                    case "Prenom": { query = "select  e.nom,e.prenom,e.cin,e.cne,e.email,e.telephone,e.adresse,e.age,e.niveau,e.lieu_naissance,e.date_naissance,e.sexe,e.nationalite,f.nom as '" + fili + "' from etudiant e,filiere  f where id_filiere=f.id and e.prenom='" + mot + "'"; break; }
                    case "Email": { query = "select  e.nom,e.prenom,e.cin,e.cne,e.email,e.telephone,e.adresse,e.age,e.niveau,e.lieu_naissance,e.date_naissance,e.sexe,e.nationalite,f.nom as '" + fili + "' from etudiant e,filiere  f where id_filiere=f.id and e.email='" + mot + "'"; break; }
                    case "CNE": { query = "select  e.nom,e.prenom,e.cin,e.cne,e.email,e.telephone,e.adresse,e.age,e.niveau,e.lieu_naissance,e.date_naissance,e.sexe,e.nationalite,f.nom as '" + fili + "' from etudiant e,filiere  f where id_filiere=f.id and e.cne='" + mot + "'"; break; }
                    case "CIN": { query = "select  e.nom,e.prenom,e.cin,e.cne,e.email,e.telephone,e.adresse,e.age,e.niveau,e.lieu_naissance,e.date_naissance,e.sexe,e.nationalite,f.nom as '" + fili + "' from etudiant e,filiere  f where id_filiere=f.id and e.cin='" + mot + "'"; break; }
                    case "Phone": { query = "select  e.nom,e.prenom,e.cin,e.cne,e.email,e.telephone,e.adresse,e.age,e.niveau,e.lieu_naissance,e.date_naissance,e.sexe,e.nationalite,f.nom as '" + fili + "' from etudiant e,filiere  f where id_filiere=f.id and e.telephone='" + mot + "'"; break; }
                    case "Age": { query = "select  e.nom,e.prenom,e.cin,e.cne,e.email,e.telephone,e.adresse,e.age,e.niveau,e.lieu_naissance,e.date_naissance,e.sexe,e.nationalite,f.nom as '" + fili + "' from etudiant e,filiere  f where id_filiere=f.id and e.age='" + mot + "'"; break; }
            }

                bdd b = new bdd();
                b.openConnection();
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.ExecuteNonQuery();
                DataTable datatable = new DataTable();
                MySqlDataAdapter oleDbData = new MySqlDataAdapter(cmd);
                oleDbData.Fill(datatable);
                b.closeConnection();
                listetudiant.DataSource = datatable;
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateStudent_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cancel(object sender, EventArgs e)
        {
            resetChampInsert();
        }

        private void addstudent_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            resetChampInsert();
            remplirFilieresModule();
            remplirlisteetudiant(null);

        }
    }
}
