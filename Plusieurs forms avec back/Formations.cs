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
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace Plusieurs_forms_avec_back
{
    public partial class Formations : MetroFramework.Controls.MetroUserControl
    {

       static  String nomprecedentModule;
       private string deptextclicked;

        public Formations()
        {
            InitializeComponent();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void departement_Click(object sender, EventArgs e)
        {

        }

        private void Formations_Load(object sender, EventArgs e)
        {
            disp_departement();
            disp_filiere();
            disp_module();
            remplirdep();
            remplirEnseg();
            remplirFilieresModule();
            remplirDepartementsModule();
            remplirTeachersModule();
        }
        public void disp_departement(String a = null)
        {
            String query;
            bdd b = new bdd();
            b.openConnection();
            if (String.IsNullOrEmpty(a))
                query = "select nom from departement ";
            else
                query = "select nom from departement where nom='"+a+"' ";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            cmd.ExecuteNonQuery();
            DataTable datatable = new DataTable();
            MySqlDataAdapter oleDbData = new MySqlDataAdapter(cmd);
            oleDbData.Fill(datatable);
            griddepartement.DataSource = datatable;
            b.closeConnection();
        }

        public void disp_filiere(string a = null)
        {

            remplirdep();
            remplirEnseg();
            String query;
            bdd b = new bdd();
            b.openConnection();
            if (String.IsNullOrEmpty(a))
                query = "select * from filiererespdep";
            else
                query = "select * from filiererespdep where Nom='" + a + "'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            cmd.ExecuteNonQuery();
            DataTable datatable = new DataTable();
            MySqlDataAdapter oleDbData = new MySqlDataAdapter(cmd);
            oleDbData.Fill(datatable);
            listefiliere.DataSource = datatable;
            b.closeConnection();

        }


        public void disp_module(String a = null) {

            String query;
            bdd b = new bdd();
            b.openConnection();
            if (String.IsNullOrEmpty(a))
                query = "select * from module_filiere_enseignat";
            else
                query = "select * from module_filiere_enseignat where Nom='" + a + "'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            cmd.ExecuteNonQuery();
            DataTable datatable = new DataTable();
            MySqlDataAdapter oleDbData = new MySqlDataAdapter(cmd);
            oleDbData.Fill(datatable);
            listmodule.DataSource = datatable;
            b.closeConnection();

        }

        private void adddep_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(depText.Text.ToString())) {
                erreurDepText.Text = "Erreur";


            }
            else {
                DepartementDao d = new DepartementDao(depText.Text.ToString());
                d.insertDepartement(d);
                depText.Text = "";
                erreurDepText.Text = "";
                disp_departement();
                disp_filiere();
                remplirFilieresModule();
                remplirDepartementsModule();
                remplirTeachersModule();


            }
        }

        private void search_click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(depText.Text.ToString()))
            {
                disp_departement(depText.Text.ToString());

            }
        }

        private void refresh(object sender, EventArgs e)
        {
            disp_departement();
            depText.ResetText();
            depText.Enabled = true;
            details.Visible = false;
           
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filiere_Click(object sender, EventArgs e)
        {

            remplirEnseg();
            remplirdep();
        }

       public void remplirDepartementsModule() {
        DepartementModules.Items.Clear();
            String query;
        bdd b = new bdd();
        b.openConnection();
            query = "select nom from departement";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
        MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DepartementModules.Items.Add(reader[0]);

            }
    b.closeConnection();
        }

        public void remplirTeachersModule()
        {
            TeachersModule.Items.Clear();
            String query;
            bdd b = new bdd();
            b.openConnection();
            query = "select nom from enseigant";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TeachersModule.Items.Add(reader[0]);

            }
            b.closeConnection();
        }


        public void remplirFilieresModule()
        {
            FiliereModules.Items.Clear();
            String query;
            bdd b = new bdd();
            b.openConnection();
            query = "select nom from filiere";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FiliereModules.Items.Add(reader[0]);

            }
            b.closeConnection();
        }




        public void remplirEnseg()
        {

            nomEnseingant.Items.Clear();
            String query, query2;
            bdd b = new bdd();
            b.openConnection();
            query = "select nom from enseigant";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nomEnseingant.Items.Add(reader[0]);

            }
            b.closeConnection();

        }

        public void remplirdep()
        {
            nomdepartements.Items.Clear();
            String query, query2;
            bdd b = new bdd();
            b.openConnection();
            query = "select Nom from departement";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nomdepartements.Items.Add(reader[0]);

            }
            b.closeConnection();

        }

        private void AjouterFiliere(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(namefil.Text.ToString()) || String.IsNullOrEmpty(typefil.Text.ToString())
                || String.IsNullOrEmpty(nmbrfil.Text.ToString()) || nomEnseingant.SelectedIndex<0 ||
               nomdepartements.SelectedIndex<0
                )
                
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Verifie data", "Please", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    return ; 


            }
            else
            {
                String nom=namefil.Text.ToString();
                String type=typefil.Text.ToString();


                string pattern = "^[1-5]{1}$";
                Regex reg = new Regex(pattern);
                if (nmbrfil.Text.ToString() == "" || !reg.IsMatch(nmbrfil.Text.ToString()))
                {
                    errornombreyears.Visible = true;
                    return;
                }
                int nombre= int.Parse(nmbrfil.Text.ToString());
                string a = nomdepartements.SelectedItem.ToString();
                int id_departement = DepartementDao.DepatementId(a);
                String b = nomEnseingant.SelectedItem.ToString();
                int id_respon = EnseignatDao.EnseignatIdByNom(b);
                FiliereDao d = new FiliereDao(nom,type,nombre, id_respon, id_departement);
                bdd ba = new bdd();
                ba.openConnection();
                try
                {
                    
                    string query = "INSERT INTO `filiere`( `nom`, `type`, `id_departement`, `id_responsable`, `nombre_annee`)  VALUES('" + d.nom + "','" + d.type + "','"+id_departement+"','"+id_respon+"','" + d.nombre_annee + "')";
                    MySqlCommand cmd = new MySqlCommand(query, ba.connection);
                    cmd.ExecuteNonQuery();
                  
                   
                }

                catch (Exception  jbj)
                {
                  
                }
                ba.closeConnection();
                namefil.ResetText();
                typefil.ResetText();
                nmbrfil.ResetText();
                errornombreyears.Visible = false;
                disp_filiere();
                remplirFilieresModule();
            }
        }

        private void listefiliere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void DeletteFiliere(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(namefil.Text.ToString()) || String.IsNullOrEmpty(typefil.Text.ToString()) || String.IsNullOrEmpty(nmbrfil.Text.ToString())  ) {
                if (MetroFramework.MetroMessageBox.Show(this, "Verifie data", "Please", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    return;
            }
            else {
                FiliereDao f = new FiliereDao();
                f.deleteFilere(nameprecedentfiliere.Text.ToString());
                namefil.ResetText();
                typefil.ResetText();
                nmbrfil.ResetText();
                add.Enabled = true;
                disp_filiere();
            }
            remplirFilieresModule();
        }

        

        private void UpdateFiliere(object sender, EventArgs e)
        {


          

            if (String.IsNullOrEmpty(namefil.Text.ToString()) || String.IsNullOrEmpty(typefil.Text.ToString())
                || String.IsNullOrEmpty(nmbrfil.Text.ToString()) 
                )

            {
                if (MetroFramework.MetroMessageBox.Show(this, "Verifie data", "Please", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    return;


            }
            else
            {
                  String namep = nameprecedentfiliere.Text.ToString();
            String type = typefil.Text.ToString();
                string pattern = "^[0-9]{10}$";
                Regex reg = new Regex(pattern);
                if (nmbrfil.Text.ToString() == "" || !reg.IsMatch(nmbrfil.Text.ToString()))
                {
                    errornombreyears.Visible = false;
                    return;
                }
                int nombre = int.Parse(nmbrfil.Text.ToString());
            string a = nomdepartements.SelectedItem.ToString();
            int id_departement = DepartementDao.DepatementId(a);
            String b = nomEnseingant.SelectedItem.ToString();
            int id_respon = EnseignatDao.EnseignatIdByNom(b);
            String nom = namefil.Text.ToString();


                FiliereDao d = new FiliereDao(nom, type, nombre, id_respon, id_departement);
                d.updateFiliere(d, namep);
                namefil.ResetText();
                typefil.ResetText();
                nmbrfil.ResetText();
                add.Enabled = true;

                disp_filiere();
                remplirFilieresModule();
            }
        }

        private void listefiliere_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return ;
            }
            else
            {
                DataGridViewRow selectedRow = listefiliere.Rows[index];
                namefil.Text = selectedRow.Cells[0].Value.ToString();
                typefil.Text = selectedRow.Cells[1].Value.ToString();
                nmbrfil.Text = selectedRow.Cells[2].Value.ToString();
                nameprecedentfiliere.Text = selectedRow.Cells[0].Value.ToString();
                nomdepartements.SelectedValue = selectedRow.Cells[3].Value.ToString();
                add.Enabled = false;
               
            }





        }

        private void Reset(object sender, EventArgs e)
        {
            add.Enabled = true;
            deleteFil.Enabled = true;
            updateFiliere.Enabled = true;
            namefil.ResetText();
            typefil.ResetText();
            nmbrfil.ResetText();
            errornombreyears.Visible = false;
            errornumberh.Visible = false;
             disp_filiere();
            
        }

        private void Select(object sender, EventArgs e)
        {
            listefiliere.Select();
        }

        private void addModule_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NomModule.Text.ToString()) || String.IsNullOrEmpty(Nombre_heurestext.Text.ToString())   )

            {
                if (MetroFramework.MetroMessageBox.Show(this, "Verifie data", "Please", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    return;


            }
            else
            {
                string pattern = "^[0-9]{2}$";
                Regex reg = new Regex(pattern);
                String nombre_heures = Nombre_heurestext.Text.ToString();
                if (nombre_heures == "" || !reg.IsMatch(nombre_heures))
                {
                    errornumberh.Visible = true;
                    return;

                }
                    String nom = NomModule.Text.ToString();
                String type = typefil.Text.ToString();
                String b = TeachersModule.SelectedItem.ToString();
                int id_enseigant = EnseignatDao.EnseignatIdByNom(b);

                String c = FiliereModules.SelectedItem.ToString();
                int id_filiere = FiliereDao.getIdByNom(c);

                try
                {
                    ModuleDao m = new ModuleDao(nom, int.Parse(nombre_heures), id_filiere, id_enseigant);
                    m.insertModule(m);

                }
                catch (Exception exps)
                {


                }
                NomModule.ResetText();
                Nombre_heurestext.ResetText();
                errornumberh.Visible = false;
                disp_module();
            }
        }

        private void UpdateModule_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NomModule.Text.ToString()) || String.IsNullOrEmpty(Nombre_heurestext.Text.ToString()) || TeachersModule.SelectedIndex < 0 || FiliereModules.SelectedIndex < 0)
                return;
            else
            {
                ModuleDao.UpdateModule(nomprecedentModule, NomModule.Text.ToString(), Nombre_heurestext.Text.ToString(), TeachersModule.SelectedItem.ToString(), FiliereModules.SelectedItem.ToString());
                addModule.Enabled = true;
                DeleteModule.Enabled = true;
                UpdateModule.Enabled = true;
                NomModule.ResetText();
                Nombre_heurestext.ResetText();
                disp_module();


            }
        }

        private void DeleteModule_Click(object sender, EventArgs e)
        {

        }

        private void ResetModule_Click(object sender, EventArgs e)
        {
           
        }

        private void listmoduleclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            else
            {
                
                DataGridViewRow selectedRow = listmodule.Rows[index];
                nomprecedentModule = selectedRow.Cells[0].Value.ToString();
                NomModule.Text = selectedRow.Cells[0].Value.ToString();
                Nombre_heurestext.Text = selectedRow.Cells[1].Value.ToString();
                addModule.Enabled = false;

            }

        }

        private void TeachersModule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchParMotCleModule(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MotCleModuleSearche.Text.ToString()) || comboboxSearchModule.SelectedIndex <0)
            {
      
                return;

            }
            else

            {
                String query= "select *from module_filiere_enseignat"; String mot = MotCleModuleSearche.Text.ToString();
                NomModule.Text = mot;
                switch (comboboxSearchModule.SelectedItem.ToString())
                {
         
                    case "Name": { query = "select * from module_filiere_enseignat where nom='" + mot+ "'"; break; }
                    case "Departement": { query = "select * from module_filiere_enseignat where departement='" + mot + "'"; break; }
                    case "Filiere": {query = "select * from module_filiere_enseignat where filiere='" + mot + "'"; break; }
                    case "Number Of Houres": {query = "select * from module_filiere_enseignat where nombre_heure='" + mot + "'"; break; }
                    case "Teacher": { query = "select * from module_filiere_enseignat where teacher='" + mot + "'"; break; }
                }
          
                bdd b = new bdd();
                b.openConnection();
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.ExecuteNonQuery();
                DataTable datatable = new DataTable();
                MySqlDataAdapter oleDbData = new MySqlDataAdapter(cmd);
                oleDbData.Fill(datatable);
                b.closeConnection();
                listmodule.DataSource = datatable;
         


            }
        }

        private void updateDepartement(object sender, EventArgs e)
        {
            
    
            if (!String.IsNullOrEmpty(depText.Text.ToString())) {

                DepartementDao d = new DepartementDao(depText.Text.ToString());
                d.updateDepartement(d,deptextclicked);
                depText.ResetText();
                udpatedep.Visible = false;
                disp_module();
                disp_filiere();
                disp_departement();

            }
            else return;

        }

        private void deleteDepartement(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(depText.Text.ToString())) {
                DepartementDao d = new DepartementDao(depText.Text.ToString());
                d.deleteDepartement(d);
                depText.Enabled = true;
                depText.ResetText();
                udpatedep.Visible = false;
                disp_module();
                disp_filiere();
                disp_departement();
            }
            else return;



        }

        private void gridformations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            else
            {
                DataGridViewRow selectedRow = griddepartement.Rows[index];
                depText.Text = selectedRow.Cells[0].Value.ToString();
                udpatedep.Visible = true;
                details.Visible = true;

            }
            this.deptextclicked = "";
            this.deptextclicked =""+depText.Text.ToString();

        }

        private void detailsDepartement_Click(object sender, EventArgs e)
        {

        }

        private void FiliereModules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Moduletab_Click(object sender, EventArgs e)
        {

        }

        private void adddep_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(depText.Text.ToString()))
            {
                DepartementDao d = new DepartementDao(depText.Text.ToString());
                d.insertDepartement(d); 
                depText.ResetText();
                disp_module();
                disp_filiere();
                disp_departement();
            }
            else return;

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            disp_module();
            disp_filiere();
            disp_departement();
            remplirdep();
            remplirDepartementsModule();
            remplirEnseg();
            remplirFilieresModule();
            remplirTeachersModule();
        }
    }
}
