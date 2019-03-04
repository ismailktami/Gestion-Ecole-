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
using MySql.Data.MySqlClient;
using Plusieurs_forms_avec_back.Dao;

namespace Plusieurs_forms_avec_back
{


    public partial class Teachers : MetroFramework.Controls.MetroUserControl
    {
        byte[] img;
        int id_teacher;

        public Teachers()
        {
            InitializeComponent();
        }

        private void addenseignat_Click(object sender, EventArgs e)
        {
            String nom, prenom, cin, cnen,email,phone;
            int age = int.Parse(ageteacher.Value.ToString());
            byte[] image = img;
            nom = NomTeacher.Text.ToString();
            prenom = PrenomTeacher.Text.ToString();
            cin = CinTEACHER.Text.ToString();
            cnen = CNETeacher.Text.ToString();
            email = emailteacher.Text.ToString();
            phone = phoneteacher.Text.ToString();

            bdd b = new bdd();
            b.openConnection();
            
               
                String query = "INSERT INTO enseigant(nom,prenom,cnen,cin,image,age,email,phone)" +
                       "" +
                       "    values('" + nom + "','" + prenom + "','" + cnen + "','" + cin + "',@image,'" + age + "','"+email+"','"+phone+"')";

                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.Parameters.Add("@image", MySqlDbType.Blob);
                cmd.Parameters["@image"].Value = image;
                cmd.ExecuteNonQuery();

          
           

                b.closeConnection();
                img = null;

            

            resetChamps();
            



        }

        private void updateenseignat_Click(object sender, EventArgs e)
        {
            String nom, prenom, cin, cnen,email,phone;
            int age = int.Parse(ageteacher.Value.ToString());
         //   byte[] image = img;
            nom = NomTeacher.Text.ToString();
            prenom = PrenomTeacher.Text.ToString();
            cin = CinTEACHER.Text.ToString();
            cnen = CNETeacher.Text.ToString();
            email = emailteacher.Text.ToString();
            phone = phoneteacher.Text.ToString();
            
            bdd b = new bdd();
            b.openConnection();
            try
            {

                String query = "UPDATE  enseigant SET  " +
                       "" +
                       "  nom='" + nom + "' , prenom='" + prenom + "' ,cnen='" + cnen + "', cin='" + cin + "',age='"+age+"',email='"+email+"',phone='"+phone+"'  where id='" + id_teacher + "'  ";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.ExecuteNonQuery();

            }
            catch (Exception exx)
            {

            }
            finally
            {

                b.closeConnection();
                img = null;

            }

            resetChamps();
            remplirlisteteacher(null);
            

        }

        private void cancelenseigant_Click(object sender, EventArgs e)
        {
            resetChamps();
        }

        private void resetenseignat_Click(object sender, EventArgs e)
        {
            resetChamps();
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
                    pictureteacher.Image = System.Drawing.Image.FromFile(ofd.FileName);
                    image = System.Drawing.Image.FromFile(ofd.FileName); ;
                    var ms = new MemoryStream();
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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



        public void resetChamps()
        {
            NomTeacher.ResetText();
            PrenomTeacher.ResetText();
            CinTEACHER.ResetText();
            CNETeacher.ResetText();
            ageteacher.ResetText();
            emailteacher.ResetText();
            phoneteacher.ResetText();
            pictureteacher.Image = null;
            remplirlisteteacher(null);
        }

        private void listeteachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            else
            {

                DataGridViewRow selectedRow = listeteachers.Rows[index];
                cnedetails.Text = selectedRow.Cells["Cne"].Value.ToString();
                cindetails.Text = selectedRow.Cells["Cin"].Value.ToString();
                
                {
                    NomTeacher.Text = selectedRow.Cells["NomTe"].Value.ToString();
                    PrenomTeacher.Text = selectedRow.Cells[1].Value.ToString();
                    CNETeacher.Text = selectedRow.Cells["Cne"].Value.ToString();
                    CinTEACHER.Text = selectedRow.Cells["Cin"].Value.ToString();
                    ageteacher.Value = Decimal.Parse(selectedRow.Cells["age"].Value.ToString());
                    emaildetails.Text= selectedRow.Cells["emailte"].Value.ToString(); 
                    phonedetails.Text= selectedRow.Cells["phonete"].Value.ToString(); 
                    updateenseignat.Enabled = true;
                    id_teacher = EnseignatDao.EnseignatId(CinTEACHER.Text.ToString());
                    bdd b = new bdd();
                    byte[] c = null;
                    b.openConnection();
                    String query = "select image from enseigant where cin='" + cindetails.Text.ToString() + "'";
                    MySqlCommand cmd = new MySqlCommand(query, b.connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    
                    try
                    {
                        byte[] imgg = (byte[])table.Rows[0][0];
                        MemoryStream ms = new MemoryStream(imgg);

                        imageTeacher.Image = System.Drawing.Image.FromStream(ms);
                        pictureteacher.Image = System.Drawing.Image.FromStream(ms);
                    }
                    catch (Exception exs) { }

                    }
            }
        }

        public  void remplirlisteteacher(String a)
        {
            //String fili = "nomfiliere";
            String query;
            bdd b = new bdd();
            b.openConnection();
            if (String.IsNullOrEmpty(a))
                query = "select nom,prenom,cnen,cin,age,email,phone,image from enseigant ";
            else
                query = "select nom,prenom,cnen,cin,age,email,phone,image from enseigant where nom='"+a+"'";

            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            cmd.ExecuteNonQuery();
            DataTable  dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            listeteachers.DataSource = dataTable;
            b.closeConnection();


        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            remplirlisteteacher(null);
        }

        private void phoneteacher_Click(object sender, EventArgs e)
        {

        }

        private void delette_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Delete?" + NomTeacher.Text.ToString() + " " + PrenomTeacher.Text.ToString(), "You want", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bdd b = new bdd();
                    b.openConnection();
                    String query = "delete from enseigant where id='" + id_teacher + "'";
                    MySqlCommand cmd = new MySqlCommand(query, b.connection);
                    cmd.ExecuteNonQuery();
                    b.closeConnection();

                }

                catch (Exception)
                {

                }
                remplirlisteteacher(null);
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            resetChamps();
        }

        private void SearchTeacher_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            resetChamps();
        }
    }
}
