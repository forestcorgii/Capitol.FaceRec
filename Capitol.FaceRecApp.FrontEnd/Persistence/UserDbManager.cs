using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitol.FaceRecApp.FrontEnd.Domain;
using static Capitol.FaceRecApp.FrontEnd.Shared.MessageBoxes;

namespace Capitol.FaceRecApp.FrontEnd.Persistence
{
    public class UserDbManager
    {
        private MySqlConnection _connection;

        public UserDbManager(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }

        public AuthorizedUser FindUser(string eeId)
        {
            //_connection.Open();
            try
            {
                using (MySqlDataReader reader = new MySqlCommand($"SELECT * FROM auth_users WHERE ee_id='{eeId}' LIMIT 1;", _connection).ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return new AuthorizedUser()
                        {
                            EEId = reader.GetString("ee_id"),
                        };
                    }
                }
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            //finally { _connection.Close(); }

            return null ;
        }

      
    }
}
