using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plusieurs_forms_avec_back.Dao
{
    class ModuleDao
    {
        private int id;
        private String nom;
        private int nombre_heures;
        private int id_filiere;
        private int id_enseignat;

        public ModuleDao(string nom, int nombre_heures, int id_filiere, int id_enseignat)
        {
            this.nom = nom;
         
            this.nombre_heures = nombre_heures;
            this.id_filiere = id_filiere;
            this.id_enseignat = id_enseignat;
        }

        public ModuleDao()
        {
        }

        public static int getIdModule(String nom) {

            bdd b = new bdd();
            int c = 0;
            b.openConnection();
            String query = "select id from module where nom='" + nom + "'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                c = (int)reader[0];

            }
            b.closeConnection();
            return c;

        }

        public Boolean insertModule(ModuleDao m)
        {
            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "INSERT INTO `module`( `nom`, `nombre_heure`, `id_filiere`, `id_enseigant`)  VALUES('" + m.nom + "','" + m.nombre_heures + "','" + m.id_filiere + "','" + m.id_enseignat + "')";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.ExecuteNonQuery();
                b.closeConnection();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }


        public Boolean deleteModule()
        {


            return true;
        }

        public Boolean DeleteModule(String nom, String filiere)
        {

            int id_filiere = FiliereDao.getIdByNom(filiere);

            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "delete from module where nom='"+nom+"' and id_filiere='"+id_filiere+"' ";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.ExecuteNonQuery();
                b.closeConnection();
                return true;
            }

            catch (Exception)
            {
                return false;
            }

        }

        public static int getIdModuleByFiliere(string nom, int id_filiere)
        {
            bdd b = new bdd();
            int c = 0;
            b.openConnection();
            String query = "select id from module where nom='" + nom + "' and id_filiere='"+id_filiere+"'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                c = (int)reader[0];

            }
            b.closeConnection();
            return c;

        }

        public static  Boolean UpdateModule(String nomprecedent,String nomrecent,String nombre_heure,String teacher, String filiere)
        {
            int id_filiere = FiliereDao.getIdByNom(filiere);
            int id_teacher = EnseignatDao.EnseignatIdByNom(teacher);
    
            try
            {
                bdd b = new bdd();
                b.openConnection();
                int id = ModuleDao.getIdModule(nomprecedent);
                String query = "update   module SET nom='"+nomrecent+"', nombre_heure='"+nombre_heure+ "',id_enseigant='"+id_teacher+"',id_filiere='"+id_filiere+"' where id='"+id+"' ";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.ExecuteNonQuery();
                b.closeConnection();
                return true;
            }

            catch (Exception)
            {
                return false;
            }

        }



    }
}
