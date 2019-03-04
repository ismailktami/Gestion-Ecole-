using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Plusieurs_forms_avec_back.Dao
{
   

    class UtilisateurDao
    {
        public int id;
        public String nom, prenom, cin;
        public String username;
        public String password;



        public UtilisateurDao()
        {
          
        }

        public UtilisateurDao(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }


        public UtilisateurDao(string nom,string prenom,string cin, string username, string password)
        {

            this.nom = nom;
            this.prenom = prenom;
            this.cin = cin;
            this.username = username;
            this.password = password;
        }



        public UtilisateurDao( string username, string password)
        {
         
            this.username = username;
            this.password = password;
        }



        public static int Userid(String a)
        {
            bdd b = new bdd();
            int c = 0;
            b.openConnection();
            String query = "select id from utilisateur where cin='" + a + "'";
            MySqlCommand cmd = new MySqlCommand(query, b.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                c = (int)reader[0];

            }
            b.closeConnection();
            return c;

        }


        public Boolean insertUtilisateur(UtilisateurDao u)
        {
         
            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "INSERT INTO utilisateur(nom,prenom,cin,username,password) values('" + u.nom + "','" + u.prenom + "','" + u.cin + "','" + u.username + "','" + u.password + "')";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd.ExecuteNonQuery();
                b.closeConnection();
                return true;
            }

            catch (Exception )
            {
                return false;
            }
        }


        public Boolean Auhthenfier(UtilisateurDao u)
        {

            try
            {

                int vraie = -1 ;
                bdd b = new bdd();
                b.openConnection();
                String query = "select * from utilisateur where username='"+u.username+"' and password='"+u.password+"'";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                MySqlDataReader reader;
                reader=cmd.ExecuteReader();

                if (reader.Read()) {

                    return true;
                    
                }

                b.closeConnection();
                return false;
                  
            }

            catch (Exception)
            {
                return false;
            }
        }
        public Boolean DeleteUtilisateur(UtilisateurDao u)
        {

            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "delete from utilisateur where username='"+u.username+"' and password='"+u.password+"'";
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

        public static Boolean UpdateUtilisateur(UtilisateurDao u,int id)
        {

            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "update   utilisateur SET nom='" + u.nom + "', prenom='" + u.prenom + "',cin='" + u.cin + "',username='" + u.username + "',password='"+u.password+"' where id='" + id + "' ";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd = new MySqlCommand(query, b.connection);
                cmd.ExecuteNonQuery();
                b.closeConnection();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean closeconnection(UtilisateurDao u)
        {

            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "update utilisateur SET connect='No' where id='"+u.id+"' ";
                MySqlCommand cmd = new MySqlCommand(query, b.connection);
                cmd = new MySqlCommand(query, b.connection);
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
