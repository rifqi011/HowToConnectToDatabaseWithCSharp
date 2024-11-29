using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToConnectToDatabaseWithC_
{
    public class DatabaseConnection
    {
        // Koneksi ke database
        static string connectionString = "Server=PANGKUANRIFQI\\SQLEXPRESS;Database=CobaDatabase;Integrated Security=true;TrustServerCertificate=true;";
        public readonly SqlConnection Connection = new SqlConnection(connectionString);

        // Untuk membuka koneksi
        public SqlConnection Open()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            else
            {
                Connection.Close(); // Jika tidak terbuka tutup dulu, lalu buka kembali
                Connection.Open();
            }

            return Connection;
        }

        // Untuk menutup koneksi
        public void Close()
        {
            Connection.Close();
        }
    }
}
