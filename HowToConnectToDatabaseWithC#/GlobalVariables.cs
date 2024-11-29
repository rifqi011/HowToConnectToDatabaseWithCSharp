using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HowToConnectToDatabaseWithC_
{
    public static class GlobalVariables
    {
        public static DatabaseConnection Connection = new DatabaseConnection();
        public static SqlCommand Command;
        public static SqlDataReader Reader;
        public static string SqlQuery;

        public static DataTable table;
    }
}
