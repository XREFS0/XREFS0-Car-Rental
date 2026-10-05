using System;
using System.Data;
using System.Data.SQLite;

namespace XREFS0Data
{
    public class clsTransactionDataAccess
    {
        public static int AddTransaction(int bookingID, int returnID,
            string paymentMethod, decimal paid, decimal actual)
        {
            int ID = -1;

            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;

            try
            {
                conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

                string query = @"INSERT INTO RentalTransaction
                (BookingID, ReturnID, PaymentMethod, PaidAmount, ActualAmount)
                VALUES
                (@Booking,@Return,@Method,@Paid,@Actual);
                SELECT last_insert_rowid();";

                cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@Booking", bookingID);
                cmd.Parameters.AddWithValue("@Return", returnID);
                cmd.Parameters.AddWithValue("@Method", paymentMethod);
                cmd.Parameters.AddWithValue("@Paid", paid);
                cmd.Parameters.AddWithValue("@Actual", actual);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                    ID = Convert.ToInt32(result);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            return ID;
        }


        public static DataTable GetAllTransactions()
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;

            try
            {
                conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

                string query = @"
                SELECT t.TransactionID,
                       t.BookingID,
                       t.ReturnID,
                       t.PaymentMethod,
                       t.PaidAmount,
                       t.ActualAmount,
                       t.RemainingAmount,
                       t.RefundAmount,
                       t.TransactionDate
                FROM RentalTransaction t";

                cmd = new SQLiteCommand(query, conn);

                conn.Open();
                dt.Load(cmd.ExecuteReader());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return dt;
        }

        public static bool HasTransaction(int returnID)
        {
            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;

            try
            {
                conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

                string query = "SELECT COUNT(*) FROM RentalTransaction WHERE ReturnID=@ID";

                cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", returnID);

                conn.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}