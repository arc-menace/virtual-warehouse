using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualWarehouse.Data.Services
{
    public class DatabaseConnection
    {
        public static string ConnectionString()
        {
            return "Server = localhost; Database = VirtualWarehouse; Trusted_Connection = True";
        }
    }
}
