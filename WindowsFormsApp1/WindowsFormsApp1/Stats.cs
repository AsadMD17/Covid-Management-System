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
    public partial class Stats : UserControl
    {
        public static Stats _instance;

        public static Stats Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Stats();

                return _instance;
 
            }


        }

        public string con_string_record = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";
        public Stats()
        {
            InitializeComponent();
            display_stats();
            dataGridView1.Show();
            display_grid(); 
        }
       
       void  display_stats()
        {
            SqlConnection connection_sql = new SqlConnection(con_string_record);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            { 
                //-------------------------Confirmed Patients---------------//////
                string display = "select sum(Total_Patients) from Stats_data";
                SqlCommand select_command = new SqlCommand(display, connection_sql);
                int count = (int)select_command.ExecuteScalar();
                string confirmed = count.ToString();
                label2.Text = confirmed;
                //-------------------------Recovered Patients---------------//////
                display = "select sum(Recovered) from Stats_data";
                select_command = new SqlCommand(display, connection_sql);
               count = (int)select_command.ExecuteScalar();
                string recovered = count.ToString();
                label7.Text = recovered;
                //-------------------------Dead Patients---------------//////
                display = "select sum(Deaths) from Stats_data";
                select_command = new SqlCommand(display, connection_sql);
                count = (int)select_command.ExecuteScalar();
                string dead = count.ToString();
                label3.Text = dead;
                //-------------------------Active Patients---------------//////
                display = "select sum(Active) from Stats_data";
                select_command = new SqlCommand(display, connection_sql);
                count = (int)select_command.ExecuteScalar();
                string Active = count.ToString();
                label9.Text = Active;
            }
            connection_sql.Close();
        }
        void display_grid()
        {
            SqlConnection connection_sql = new SqlConnection(con_string_record);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {

                string display = "select * from Stats_data";
                SqlDataAdapter display_grid = new SqlDataAdapter(display, con_string_record);
                DataTable grid_table = new DataTable();
                display_grid.Fill(grid_table);
                dataGridView1.DataSource = grid_table;
                
            }
            
            connection_sql.Close();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
           


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_sql = new SqlConnection(con_string_record);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                if(comboBox1.Text!=""&&comboBox1.Text !=null)
                {
                    string display = "select * from Stats_data where Region_Name = '" + comboBox1.Text.ToString() + "'";
                    SqlDataAdapter display_grid = new SqlDataAdapter(display, con_string_record);
                    DataTable grid_table = new DataTable();
                    display_grid.Fill(grid_table);
                    dataGridView1.DataSource = grid_table;
                    //-------------------------Outbreak---------------//////
                   display = "select Outbreak_Percent from Stats_data where Region_Name = '" + comboBox1.Text.ToString() + "'";
                    SqlCommand select_command = new SqlCommand(display, connection_sql);
                    int count = (int)select_command.ExecuteScalar();
                    string outbreak = count.ToString();
                    label13.Text = outbreak;
                    //-------------------------Recommendation---------------//////
                    if(count<=49)
                    {
                        display = "select recommendations from Recommendations where Percentage = 49";
                        select_command = new SqlCommand(display, connection_sql);
                        string temp = (string)select_command.ExecuteScalar();
                        label15.Text = temp;
                    }
                    else
                    {
                        display = "select recommendations from Recommendations where Percentage = 50";
                        select_command = new SqlCommand(display, connection_sql);
                        string temp = (string)select_command.ExecuteScalar();
                        label15.Text = temp;
                    }
                }
                else
                {
                    display_grid();
                }                
            }
            comboBox1.SelectedItem =null;
            connection_sql.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            display_stats();
            display_grid();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
