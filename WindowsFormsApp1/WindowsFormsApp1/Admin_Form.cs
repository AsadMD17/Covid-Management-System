using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }
        public string con_string_admin = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {
           
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result="*";
            SqlConnection connection_sql = new SqlConnection(con_string_admin);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                string get_id = "select Password from Admin where ID = ('" + textBox1.Text.ToString()+"')";                
                SqlCommand select_command = new SqlCommand(get_id, connection_sql);
                result = (string)select_command.ExecuteScalar();
            }
            connection_sql.Close();
            string pass = textBox2.Text.ToString();
            if (result ==pass)
            {
                this.Hide();
                data_entry_form form1 = new data_entry_form();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Admin-ID or Password!");
            }

            



        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_page Home = new Main_page();
            Home.ShowDialog();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection_sql = new SqlConnection(con_string_admin);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                string insert = "insert into Admin(Password,First_Name,Last_Name,CNIC)values('" + textBox6.Text.ToString() + "'," +
                "'" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')";
                SqlCommand comm = new SqlCommand(insert, connection_sql);
                comm.ExecuteNonQuery();
                MessageBox.Show("Successfully Sign-Up!");
                
            }
            connection_sql.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
