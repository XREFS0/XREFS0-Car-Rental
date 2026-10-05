using System;
using System.Data;
using System.Data.SQLite;

namespace XREFS0Data
{
    public class clsBookingDataAccess
    {
        public static int AddBooking(int CustomerID, int VehicleID,
            DateTime StartDate, DateTime EndDate,
            string Pickup, string Dropoff,
            int Days, decimal PricePerDay, decimal Total, string Notes, int StartMileage)
        {
            int ID = -1;

            SQLiteConnection conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO RentalBooking
            (CustomerID, VehicleID, RentalStartDate, RentalEndDate,
             PickupLocation, DropoffLocation,
             InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount,
             InitialCheckNotes, StartMileage)
            VALUES
            (@Customer,@Vehicle,@Start,@End,@Pickup,@Dropoff,@Days,@Price,@Total,@Notes,@StartMileage);
            SELECT last_insert_rowid();";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            cmd.Parameters.AddWithValue("@Customer", CustomerID);
            cmd.Parameters.AddWithValue("@Vehicle", VehicleID);
            cmd.Parameters.AddWithValue("@Start", StartDate);
            cmd.Parameters.AddWithValue("@End", EndDate);
            cmd.Parameters.AddWithValue("@Pickup", Pickup);
            cmd.Parameters.AddWithValue("@Dropoff", Dropoff);
            cmd.Parameters.AddWithValue("@Days", Days);
            cmd.Parameters.AddWithValue("@Price", PricePerDay);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@StartMileage", StartMileage);

            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();

            if (result != null)
                ID = Convert.ToInt32(result);

            return ID;
        }

        public static DataTable GetAllBookings()
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT b.BookingID,
                                    c.Name AS Customer,
                                    v.PlateNumber,
                                    b.RentalStartDate,
                                    b.RentalEndDate,
                                    b.InitialTotalDueAmount
                             FROM RentalBooking b
                             JOIN Customer c ON b.CustomerID = c.CustomerID
                             JOIN Vehicles v ON b.VehicleID = v.VehicleID";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            return dt;
        }

        public static bool DeleteBooking(int ID)
        {
            int rowsAffected = 0;

            SQLiteConnection connection =
                new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM RentalBooking WHERE BookingID=@ID";

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

        public static int GetVehicleIDByBooking(int bookingID)
        {
            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;

            try
            {
                conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

                string query = "SELECT VehicleID FROM RentalBooking WHERE BookingID=@ID";

                cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", bookingID);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                    return Convert.ToInt32(result);
            }
            catch { }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return -1;
        }

        public static DateTime GetStartDate(int bookingID)
        {
            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;

            try
            {
                conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

                string query = "SELECT RentalStartDate FROM RentalBooking WHERE BookingID=@ID";

                cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", bookingID);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                    return Convert.ToDateTime(result);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return DateTime.Now;
        }

        public static DataTable GetBookingDetails(int bookingID)
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;

            try
            {
                conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

                string query = @"
                    SELECT
                        b.BookingID,
                        b.CustomerID,
                        b.VehicleID,
                        b.StartMileage,
                        c.Name                    AS CustomerName,
                        m.MakeName || ' ' || mo.ModelName || ' ' 
                            || CAST(v.Year AS TEXT) 
                            || ' (' || v.PlateNumber || ')'
                                                  AS VehicleName,
                        b.RentalStartDate         AS StartDate,
                        b.RentalEndDate           AS EndDate,
                        b.InitialRentalDays       AS Days,
                        b.RentalPricePerDay       AS PricePerDay,
                        b.InitialTotalDueAmount   AS Total,
                        b.PickupLocation          AS Pickup,
                        b.DropoffLocation         AS Dropoff,
                        b.InitialCheckNotes       AS Notes
                    FROM RentalBooking b
                    JOIN Customer  c  ON b.CustomerID = c.CustomerID
                    JOIN Vehicles  v  ON b.VehicleID  = v.VehicleID
                    JOIN Makes     m  ON v.MakeID     = m.MakeID
                    JOIN Models    mo ON v.ModelID    = mo.ModelID
                    WHERE b.BookingID = @ID";

                cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", bookingID);

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

        public static DataTable GetActiveBookings()
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;

            try
            {
                conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

                string query = @"
                SELECT 
                    BookingID,BookingInfo from vw_ActiveBookings ";

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

        public static DataTable ListActiveBookings()
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = new SQLiteConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT BookingID,
                            CustomerName as Name,
                            PlateNumber,
                            RentalStartDate,
                            RentalEndDate,
                            InitialRentalDays as RentalDays,
                            RentalPricePerDay as PricePerDay,
                            InitialTotalDueAmount as TotalDueAmount
                     FROM vw_ActiveBookings";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            return dt;
        }



    }
}
