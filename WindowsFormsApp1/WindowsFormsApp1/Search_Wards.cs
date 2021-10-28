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
    public partial class Search_Wards : UserControl
    {
        public static Search_Wards _instance;

        public static Search_Wards Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Search_Wards();

                return _instance;

            }

        }

        void clear()
        {
            textBox1.Text = comboBox1.Text = "";
            comboBox4.SelectedItem = null;
        }
        public string con_string_entry_form = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";


        public Search_Wards()
        {
            InitializeComponent();
            SqlConnection connection_sql = new SqlConnection(con_string_entry_form);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                string search1 = "select * from Wards";
                SqlCommand comm = new SqlCommand(search1, connection_sql);
                SqlDataAdapter print = new SqlDataAdapter(search1, connection_sql);
                DataTable d_table = new DataTable();
                print.Fill(d_table);
                dataGridView1.DataSource = d_table;
                comm.ExecuteNonQuery();

            }
            connection_sql.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean b1 = false;
            int count = 0;
            SqlConnection connection_sql = new SqlConnection(con_string_entry_form);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                string search = "select * from Wards ";
                if (textBox1.Text != "")
                {
                    if (b1 == false)
                    {
                        search += "where ";
                        b1 = true;

                    }
                    count++;
                    if (count == 1)
                    {
                        search += "W_ID = '" + textBox1.Text.ToString() + "'";
                    }
                    else
                    {
                        search += " and W_ID = '" + textBox1.Text.ToString() + "'";
                    }

                }

                if (comboBox1.Text != "")
                {
                    if (b1 == false)
                    {
                        search += "where ";
                        b1 = true;

                    }
                    count++;
                    if (count == 1)
                    {
                        search += "WType = '" + comboBox1.Text.ToString() + "'";
                    }
                    else
                    {
                        search += "and WType = '" + comboBox1.Text.ToString() + "'";
                    }
                }

                if (comboBox4.Text != "")
                {
                    if (b1 == false)
                    {
                        search += "where ";
                        b1 = true;

                    }
                    count++;
                    if (count == 1)
                    {
                        search += "RName = '" + comboBox4.Text.ToString() + "'";
                    }
                    else
                    {
                        search += "and RName = '" + comboBox4.Text.ToString() + "'";
                    }
                }


                SqlCommand comm = new SqlCommand(search, connection_sql);
                SqlDataAdapter print = new SqlDataAdapter(search, connection_sql);
                DataTable d_table = new DataTable();
                print.Fill(d_table);
                dataGridView1.DataSource = d_table;
                comm.ExecuteNonQuery();

            }
           
            connection_sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void Search_Wards_Load(object sender, EventArgs e)
        {

        }
    }
}
