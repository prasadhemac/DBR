using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSoftDBRestoreManager
{
    static class KSoftDbRestore
    {
        static public bool RestoreFile(String connectionString, String fileName)
        {
            //connectionString += "charset=utf8;convertzerodatetime=true;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(fileName);
                            conn.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Logger.log(ex.Message);
                return false;
            }
            
            return true;
        }
    }
}
