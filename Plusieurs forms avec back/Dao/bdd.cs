using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Plusieurs_forms_avec_back.Dao
{
    class bdd
    {

       private  static   String server = "localhost";
       private   String database = "gestionensa";
       private  String uid = "root";
       private  String password = "";
       private string connectionString;
        public MySqlConnection connection;
        public bdd() {

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                     database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString); 
        }
        


        


        public Boolean openConnection()
        {
            try
            {
              
                connection.Open();
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        public Boolean closeConnection() {
            try
            {
             
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
