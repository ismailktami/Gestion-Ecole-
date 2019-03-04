using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Plusieurs_forms_avec_back.Dao
{
    class DepartementDao
    {
        private int id;
        private String nom;


        public int getId()
        {
            return id;
        }
        public String getNom() {
            return nom;
        }

        public void setId(int i)
        {
            id = i;
        }
        public void setNom(String a)
        {
            nom = a;

        }

        public DepartementDao(string nom)
        {
            this.nom = nom;
        }


        public static int DepatementId(String a) {
            bdd b = new bdd();
            int c=0;
            b.openConnection();
            String query = "select id from departement where nom='"+a+"'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
               c= (int) reader[0];

            }
            b.closeConnection();
            return c;

        }

        public Boolean insertDepartement(DepartementDao  d) {
            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "INSERT INTO departement(nom) values('" + d.getNom() + "')";
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

        public Boolean updateDepartement(DepartementDao d,String nomprecedent)
        {
            try
            {
                bdd b = new bdd();
                b.openConnection();
                int id = DepatementId(nomprecedent);
                String query = "Update   departement SET  nom='"+d.getNom()+"' where id='"+id+"'  ";
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
        
     public Boolean deleteDepartement(DepartementDao d)
        {
            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "delete from departement where nom='" + d.getNom() + "'";
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


        internal static int DepatementId(object selectedValue)
        {
            throw new NotImplementedException();
        }
    }



}
