using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plusieurs_forms_avec_back.Dao
{
    class EtudiantDao
    {
        private int id;
        private String nom;
        private String prenom;
        private int age;
        private String email;
        private int telephone;
        private String nationalite;
        private String address;
        private String sexe;
        private String CNE;
        private String CIN;
        private String date_naissance;
        private String Lieu_naissance;
        private byte[] image;
        private int id_filiere;
        private int level;

        public  int getIdEt(String a)
        {
       
                bdd b = new bdd();
                int c = 0;
                b.openConnection();
                String query = "select id from etudiant where cin='" + a + "'";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    c = (int)reader[0];

                }
                b.closeConnection();
            return c;
        }

        public static int getIdEtByCne(String a)
        {

            bdd b = new bdd();
            int c = 0;
            b.openConnection();
            String query = "select id from etudiant where cne='" + a + "'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                c = (int)reader[0];

            }
            b.closeConnection();
            return c;
        }


    }
}
