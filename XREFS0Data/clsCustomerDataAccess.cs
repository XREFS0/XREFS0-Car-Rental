using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XREFS0Data
{

    public class clsCustomerDataAccess
    {
        public static bool GetCustomerByID(int ID,
            ref string Name,
            ref string ContactInfo,
            ref string License, ref string ImagePath)
        {
            bool isFound = false;

            SQLiteConnection connection =
                new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Customer WHERE CustomerID=@ID";

            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["Name"];
                    ContactInfo = (string)reader["ContactInformation"];
                    License = (string)reader["DriverLicenseNumber"];
                    ImagePath = reader["ImagePath"] == DBNull.Value ? "" : (string)reader["ImagePath"];

                }

                reader.Close();
            }
            catch { isFound = false; }
            finally { connection.Close(); }

            return isFound;
        }

        public static int AddNewCustomer(string Name,
            string ContactInfo,
            string License, string ImagePath)
        {
            int ID = -1;

            SQLiteConnection connection =
                new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Customer 
                            (Name, ContactInformation, DriverLicenseNumber, ImagePath)
                            VALUES (@Name,@Contact,@License,@ImagePath);
                            SELECT last_insert_rowid();";

            SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Contact", ContactInfo);
            command.Parameters.AddWithValue("@License", License);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null &&
                    int.TryParse(result.ToString(), out int insertedID))
                    ID = insertedID;
            }
            catch { }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateCustomer(int ID,
            string Name,
            string ContactInfo,
            string License, string ImagePath)
        {
            int rowsAffected = 0;

            SQLiteConnection connection =
                new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Customer
                             SET Name=@Name,
                                 ContactInformation=@Contact,
                                 DriverLicenseNumber=@License,ImagePath = @ImagePath
                             WHERE CustomerID=@ID";

            SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Contact", ContactInfo);
            command.Parameters.AddWithValue("@License", License);

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }

            return (rowsAffected > 0);
        }

        public static bool DeleteCustomer(int ID)
        {
            int rowsAffected = 0;

            SQLiteConnection connection =
                new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Customer WHERE CustomerID=@ID";

            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }

            return (rowsAffected > 0);
        }

        public static DataTable ListCustomers()
        {
            DataTable dt = new DataTable();

            SQLiteConnection connection =
                new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Customer";

            SQLiteCommand command = new SQLiteCommand(query, connection);

            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }
    }
}
