using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XREFS0Data
{
    static class clsDataAccessSettings
    {
        // SQLite database file located next to the executable (e.g. bin\Debug\XREFS0CarRental.db)
        public static string ConnectionString = "Data Source=" + System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "XREFS0CarRental.db") + ";Version=3;Foreign Keys=True;";

    }
}
