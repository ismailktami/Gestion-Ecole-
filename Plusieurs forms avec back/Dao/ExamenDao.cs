using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plusieurs_forms_avec_back.Dao
{
    class ExamenDao
    {
        private int id_etudiant;
        private int id_module;
        private string note;
        private int year;
        public ExamenDao(int id_etudiant, int id_module, string note,int year)
        {
            this.id_etudiant = id_etudiant;
            this.id_module = id_module;
            this.note = note;
            this.year = year;
        }

        public Boolean insertexamen(ExamenDao e)
        {
            try
            {
                bdd b = new bdd();
                b.openConnection();
                String query = "INSERT INTO `gestionensa`.`evaluation` (`id_etudiant`, `id_module`, `note`, `annee`) VALUES('" + e.id_etudiant + "', '" + e.id_module + "', '" + e.note + "', '" + e.year + "')";

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
