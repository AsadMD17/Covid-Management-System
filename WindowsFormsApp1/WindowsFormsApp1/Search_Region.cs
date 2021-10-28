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
    public partial class Search_Region : UserControl
    {

        public static Search_Region _instance;

        public static Search_Region Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Search_Region();

                return _instance;

            }


        }

        public void display()
        {
            SqlConnection connection_sql = new SqlConnection(con_string_entry_form);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                string search = "select * from region_Records";
                SqlCommand comm = new SqlCommand(search, connection_sql);
                SqlDataAdapter print = new SqlDataAdapter(search, connection_sql);
                DataTable d_table = new DataTable();
                print.Fill(d_table);
                dataGridView1.DataSource = d_table;
                comm.ExecuteNonQuery();
                connection_sql.Close();

            }
        }

        public Search_Region()
        {
            InitializeComponent();
            display();
        }
        public string con_string_entry_form = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            string search = "*";
            SqlConnection connection_sql = new SqlConnection(con_string_entry_form);
            connection_sql.Open();

            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                if (comboBox1.Text != "" && comboBox1.Text != null)
                {
                    search = "select * from region_Records where region_name = '" + comboBox1.Text.ToString() + "'";
                    SqlCommand comm = new SqlCommand(search, connection_sql);
                    SqlDataAdapter print = new SqlDataAdapter(search, connection_sql);
                    DataTable d_table = new DataTable();
                    print.Fill(d_table);
                    dataGridView1.DataSource = d_table;
                    comm.ExecuteNonQuery();
                    connection_sql.Close();
                    comboBox1.SelectedItem = null;
                }
                else
                {
                    display();
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null; 
        }

        private void Search_Region_Load(object sender, EventArgs e)
        {

        }
    }
}
