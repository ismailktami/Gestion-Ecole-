using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
namespace Plusieurs_forms_avec_back.Dao
{
    class FiliereDao
    {
       public int id;
        public String nom;
        public String type;
        public int nombre_annee;
        public int id_responsable;
        public int id_departement;


        public static int EnseignatId(String a)
        {
            bdd b = new bdd();
            int c = 0;
            b.openConnection();
            String query = "select id from enseigant where nom='" + a + "'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                c = (int)reader[0];

            }
            b.closeConnection();
            return c;

        }
        public static  int getIdByNom(String a)
        {
            bdd b = new bdd();
            int c = 0;
            b.openConnection();
            String query = "select id from filiere where nom='" + a + "'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                c = (int)reader[0];

            }
            b.closeConnection();
            return c;

        }



        public FiliereDao(string nom, string type, int nombre_annee, int id_responsable, int id_departement)
        {
            this.nom = nom;
            this.type = type;
            this.nombre_annee = nombre_annee;
            this.id_responsable = id_responsable;
            this.id_departement = id_departement;
        }

        public FiliereDao()
        {
        }


        public Boolean insertFiliere(FiliereDao f)
        {
            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "INSERT INTO `filiere`( `nom`, `type`, `id_departement`, `id_responsable`, `nombre_annee`)  VALUES('" + f.nom + "','" + f.type + "','" + f.id_departement + "','" + f.id_responsable + "','" + f.nombre_annee + "')";
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

        public Boolean updateFiliere(FiliereDao f,String a)
        {
            try
            {
                bdd b = new bdd();
                b.openConnection();
              
                String query = "delete from filiere where nom='"+a+"'";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.ExecuteNonQuery();
             
                String query2 = "INSERT INTO `filiere`( `nom`, `type`, `id_departement`, `id_responsable`, `nombre_annee`)  VALUES('" + f.nom + "','" + f.type + "','" + f.id_departement + "','" + f.id_responsable + "','" + f.nombre_annee + "')";
                cmd = new MySqlCommand(query2, b.connection);
                cmd.ExecuteNonQuery();
                b.closeConnection();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public Boolean deleteFilere( String a)
        {
            try
            {
                bdd b = new bdd();
                b.openConnection();

                String query = "delete from filiere where nom='" + a + "'";
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
