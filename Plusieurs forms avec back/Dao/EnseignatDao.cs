using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Plusieurs_forms_avec_back.Dao
{
    class EnseignatDao
    {
        private int id;
        private String nom;
        private String prenom;
        private String CNEE;
        private String CIN;


        public EnseignatDao(string nom, string prenom, string cNE, string cIN)
        {
            this.nom = nom;
            this.prenom = prenom;
            CNEE = cNE;
            CIN = cIN;
        }

        public EnseignatDao()
        {
        }
        public int getId()
        {
            return id;
        }


        public Boolean insertEnseignat(EnseignatDao e)
        {

            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "INSERT INTO enseigant(nom,prenom,cnen,cin) values('" + e.nom + "','" + e.prenom + "','"+e.CNEE+"','"+e.CIN+"')";
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



        public Boolean insertEnseignat2(byte[] b2) 
        {

            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "INSERT INTO test(id,image) values('1','"+b2+"')";
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


        public Boolean DeleteEnseigant(EnseignatDao e)
        {

            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "delete from enseigant where cnen='" + e.CNEE + "' ";
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

        public static int EnseignatId(String a)
        {
            bdd b = new bdd();
            int c = 0;
            b.openConnection();
            String query = "select id from enseigant where cin='" + a + "'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                c = (int)reader[0];

            }
            b.closeConnection();
            return c;

        }

        public static int EnseignatIdByNom(String a)
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
        public static byte[] enseignantimage(int a)
        {
            bdd b = new bdd();
            b.openConnection();
            String query = "select image from test where id='" + a + "'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
             return (byte[])reader[0];

            }
            b.closeConnection();
            return null;

        }


    }
}
