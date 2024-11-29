using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowToConnectToDatabaseWithC_
{
    using static GlobalVariables;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Fungsi Init
        public void Init()
        {
            LoadData();
        }

        // Fungsi memanggil data dari database
        public void LoadData()
        {
            // variable connect, command, dan reader dari class GlobalVariables
            try
            {
                // Jalankan fungsi buka koneksi
                Connection.Open();
                // Query SQL ke database
                SqlQuery = "SELECT * FROM Users ORDER BY UserName ASC";
                Command = new SqlCommand(SqlQuery, Connection.Connection);
                // Read data dengan SqlDataReader
                Reader = Command.ExecuteReader();

                // Masukan data ke dalam tabel
                table = new DataTable();
                table.Load(Reader);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Init();
        }
    }
}
