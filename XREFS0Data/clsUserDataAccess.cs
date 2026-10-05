using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XREFS0Data
{
    public class clsUserDataAccess
    {

        public static bool GetUserByUsernameAndPassword(
            string Username, string Password,
            ref int UserID, ref string Role)
        {
            bool isFound = false;

            SQLiteConnection connection =
                new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT UserID, Role 
                             FROM Users 
                             WHERE Username = @Username 
                             AND Password = @Password";

            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    UserID = Convert.ToInt32(reader["UserID"]);
                    Role = (string)reader["Role"];
                }

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
