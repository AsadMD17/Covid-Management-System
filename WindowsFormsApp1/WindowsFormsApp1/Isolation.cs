using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Isolation : UserControl
    {
        public string con_string_record = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";
        public static Isolation _instance;

        public static Isolation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Isolation();

                return _instance;

            }


        }

        public Isolation()
        {
            InitializeComponent();
            display_grid();
        }
        void display_grid()
        {
            SqlConnection connection_sql = new SqlConnection(con_string_record);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                string display = "select * from Wards where WType = 'Isolation'";
                SqlDataAdapter display_grid = new SqlDataAdapter(display, con_string_record);
                DataTable grid_table = new DataTable();
                display_grid.Fill(grid_table);
                dataGridView1.DataSource = grid_table;

            }

            connection_sql.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection_sql = new SqlConnection(con_string_record);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                if (comboBox1.Text != "" && comboBox1.Text != null)
                {
                    string display = "select * from Wards where WType = 'Isolation' and RName = '" + comboBox1.Text.ToString() + "'";
                    SqlDataAdapter display_grid = new SqlDataAdapter(display, con_string_record);
                    DataTable grid_table = new DataTable();
                    display_grid.Fill(grid_table);
                    dataGridView1.DataSource = grid_table;

                }
                else
                {

                    display_grid();
                }
                comboBox1.SelectedItem = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Isolation_Load(object sender, EventArgs e)
        {

        }
    }
}
