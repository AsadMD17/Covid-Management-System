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
    public partial class Search_Patient : UserControl
    {



        public static Search_Patient _instance;



        public static Search_Patient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Search_Patient();



                return _instance;



            }




        }
        public string con_string_record = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";
        public Search_Patient()
        {
            InitializeComponent();
            SqlConnection connection_sql = new SqlConnection(con_string_record);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                string search1 = "select * from Patient_Records ";
                SqlCommand comm = new SqlCommand(search1, connection_sql);
                SqlDataAdapter print = new SqlDataAdapter(search1, connection_sql);
                DataTable d_table = new DataTable();
                print.Fill(d_table);
                dataGridView1.DataSource = d_table;
                comm.ExecuteNonQuery();

            }
            connection_sql.Close();
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            Boolean b1 = false;
            int count = 0;
            SqlConnection connection_sql = new SqlConnection(con_string_record);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                string search = "select * from Patient_Records ";
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
                        search += "CNIC = '" + textBox1.Text.ToString() + "'";
                    }
                    else
                    {
                        search += " and CNIC = '" + textBox1.Text.ToString() + "'";
                    }

                }
                if (textBox5.Text != "")
                {
                    if (b1 == false)
                    {
                        search += "where ";
                        b1 = true;

                    }
                    count++;
                    if (count == 1)
                    {
                        search += "P_ID = '" + textBox5.Text.ToString() + "'";
                    }
                    else
                    {
                        search += "and P_ID = '" + textBox5.Text.ToString() + "'";
                    }

                }
                if (textBox3.Text != "")
                {
                    if (b1 == false)
                    {
                        search += "where ";
                        b1 = true;

                    }
                    count++;
                    if (count == 1)
                    {
                        search += "First_Name = '" + textBox3.Text.ToString() + "'";
                    }
                    else
                    {
                        search += "and First_Name = '" + textBox3.Text.ToString() + "'";
                    }

                }
                if (textBox2.Text != "")
                {
                    if (b1 == false)
                    {
                        search += "where ";
                        b1 = true;

                    }
                    count++;
                    if (count == 1)
                    {
                        search += "Last_Name = '" + textBox2.Text.ToString() + "'";
                    }
                    else
                    {
                        search += "and Last_Name = '" + textBox2.Text.ToString() + "'";
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
            textBox1.Text = textBox2.Text = textBox3.Text = textBox5.Text = "";
        }

        private void Search_Patient_Load(object sender, EventArgs e)
        {

        }
    }
}