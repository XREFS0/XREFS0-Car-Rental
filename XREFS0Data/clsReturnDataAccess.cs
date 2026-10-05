using System;
using System.Data;
using System.Data.SQLite;

namespace XREFS0Data
{
    public class clsReturnDataAccess
    {
        public static int AddReturn(int bookingID, DateTime returnDate,
    int days, int mileage, int consumed,
    string notes, decimal extra, decimal total)
        {
            int ID = -1;

            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;

            try
            {
                conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

                string query = @"INSERT INTO VehicleReturns
        (BookingID, ActualReturnDate, ActualRentalDays,
         Mileage, ConsumedMileage,
         FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount)
        VALUES
        (@Booking,@Date,@Days,@Mileage,@Consumed,@Notes,@Extra,@Total);
        SELECT last_insert_rowid();";

                cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@Booking", bookingID);
                cmd.Parameters.AddWithValue("@Date", returnDate);
                cmd.Parameters.AddWithValue("@Days", days);
                cmd.Parameters.AddWithValue("@Mileage", mileage);
                cmd.Parameters.AddWithValue("@Consumed", consumed);
                cmd.Parameters.AddWithValue("@Notes", notes);
                cmd.Parameters.AddWithValue("@Extra", extra);
                cmd.Parameters.AddWithValue("@Total", total);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                    ID = Convert.ToInt32(result);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return ID;
        }



        public static DataTable GetAllReturns()
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT ReturnID, BookingID,
                           ActualReturnDate,
                           ActualTotalDueAmount
                    FROM VehicleReturns";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            return dt;
        }


        public static bool DeleteReturn(int returnID)
        {
            int rowsAffected = 0;

            SQLiteConnection conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);
            SQLiteCommand cmd = new SQLiteCommand(
                "DELETE FROM VehicleReturns WHERE ReturnID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", returnID);

            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return rowsAffected > 0;
        }

    }
}