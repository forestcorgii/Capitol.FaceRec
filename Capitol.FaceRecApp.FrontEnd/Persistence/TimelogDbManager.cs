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
    public class TimelogDbManager
    {
        private MySqlConnection _connection;

        public TimelogDbManager(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }

        public Timelog FindLatestTimelogByEEId(string eeId)
        {
            //_connection.Open();
            try
            {
                using (MySqlDataReader reader = new MySqlCommand($"SELECT * FROM queued_timelogs WHERE ee_id='{eeId}' ORDER BY timestamp DESC LIMIT 1;", _connection).ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return new Timelog()
                        {
                            EEId = reader.GetString("ee_id"),
                            Timestamp = reader.GetDateTime("timestamp"),
                        };
                    }
                }
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            //finally { _connection.Close(); }

            return null;
        }


        public IEnumerable<Timelog> GetTimelogs(int limit = 100)
        {
            var timelogs = new List<Timelog>();
            //_connection.Open();
            try
            {
                using (MySqlDataReader reader = new MySqlCommand($"SELECT * FROM queued_timelogs ORDER BY timestamp DESC LIMIT {limit};", _connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timelogs.Add(new Timelog()
                        {
                            Id = reader.GetInt32("id"),
                            EEId = reader.GetString("ee_id"),
                            Timestamp = reader.GetDateTime("timestamp"),
                        });
                    }
                }
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            //finally { _connection.Close(); }

            return timelogs;
        }

        public IEnumerable<Timelog> GetQueuedTimelogs()
        {
            var timelogs = new List<Timelog>();
            //_connection.Open();
            try
            {
                using (MySqlDataReader reader = new MySqlCommand($"SELECT * FROM queued_timelogs;", _connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timelogs.Add(new Timelog()
                        {
                            Id = reader.GetInt32("id"),
                            EEId = reader.GetString("ee_id"),
                            Timestamp = reader.GetDateTime("timestamp"),
                        });
                    }
                }
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            //finally { _connection.Close(); }

            return timelogs;
        }

        public int GetQueuedCount()
        {
            int count = 0;
            try
            {
                using (MySqlDataReader reader = new MySqlCommand($"SELECT COUNT(*) FROM queued_timelogs;", _connection).ExecuteReader())
                {
                    reader.Read();
                    count = reader.GetInt32(0);
                }
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            return count;
        }


        public void AddToQueue(Timelog timelog)
        {
            //_connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO queued_timelogs (ee_id,timestamp) VALUES (@ee_id,@timestamp)", _connection);
                command.Parameters.AddWithValue("ee_id", timelog.EEId);
                command.Parameters.AddWithValue("timestamp", timelog.Timestamp);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { Error(ex.Message, ex.Source); }
            //finally { _connection.Close(); }
        }
    }
}
