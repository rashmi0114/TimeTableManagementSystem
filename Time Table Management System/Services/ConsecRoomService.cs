using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;

namespace Time_Table_Management_System.Services
{
    class ConsecRoomService : IConsecRoomService
    {
        public bool addConsecutive(int con_id, ConsecRoom room)
        {
            Boolean result = false;
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {

                string query = "INSERT INTO consecutives (con_id,room) VALUES (@con_id,@room)";
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@con_id", con_id);
                cmd.Parameters.AddWithValue("@room", room);



                cmd.Prepare();


                if (cmd.ExecuteNonQuery() == 1)
                    result = true;
                else
                    result = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }



        public bool deleteConsecutive(int id)
        {
            throw new NotImplementedException();
        }

        public List<ConsecRoom> getAllConsecutives()
        {
            throw new NotImplementedException();
        }

        public ConsecRoom GetConsecutive(int id)
        {
            throw new NotImplementedException();
        }

        public List<Consecutive> searchConsecutive(string key, string type)
        {
            throw new NotImplementedException();
        }

        public bool updateConsecutive(int id, Consecutive consecutive)
        {
            throw new NotImplementedException();
        }
    }
}
