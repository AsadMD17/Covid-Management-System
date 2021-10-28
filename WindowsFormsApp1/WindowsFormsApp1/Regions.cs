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
    public partial class Regions : UserControl
    {

        public static Regions _instance;

        public static Regions Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Regions();

                return _instance;
            }

        }

        public Regions()
        {
            InitializeComponent();
        }
        public string con_string_entry_form = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";
        private void Regions_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!panel3.Controls.Contains(Update_Region.Instance))
            {
                panel3.Controls.Add(Update_Region.Instance);
                Update_Region.Instance.Dock = DockStyle.Fill;
                Update_Region.Instance.BringToFront();

            }
            else
                Update_Region.Instance.BringToFront();

            Update_Region.Instance.Show();



        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!panel3.Controls.Contains(Delete_Region.Instance))
            {
                panel3.Controls.Add(Delete_Region.Instance);
                Delete_Region.Instance.Dock = DockStyle.Fill;
                Delete_Region.Instance.BringToFront();

            }
            else
                Delete_Region.Instance.BringToFront();

            Delete_Region.Instance.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!panel3.Controls.Contains(Search_Region.Instance))
            {
                panel3.Controls.Add(Search_Region.Instance);
                Search_Region.Instance.Dock = DockStyle.Fill;
                Search_Region.Instance.BringToFront();

            }
            else
                Search_Region.Instance.BringToFront();

            Search_Region.Instance.Show();

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Update_Region.Instance.Hide();
            Delete_Region.Instance.Hide();
            Search_Region.Instance.Hide();




       



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.ToString() != "" && textBox1.Text.ToString() != null) && (textBox9.Text.ToString() != "" && textBox9.Text.ToString() != null))
            {
                SqlConnection connection_sql = new SqlConnection(con_string_entry_form);
                connection_sql.Open();
                string result = "*";
                string search = "Select count(Region_ID) from Region where Region_ID = '" + textBox9.Text.ToString() +  "'";
                SqlCommand select_command = new SqlCommand(search, connection_sql);
                result = ((int)select_command.ExecuteScalar()).ToString();

                if (result != "0")
                {
                    if (connection_sql.State == System.Data.ConnectionState.Open)
                    {
                        string insert = "insert into EmergencyNumbers(Region_ID,EmergencyNum)values('" + textBox9.Text.ToString() + "','" + textBox1.Text.ToString() + "')";
                        SqlCommand comm = new SqlCommand(insert, connection_sql);
                        comm.ExecuteNonQuery();
                    }
                    MessageBox.Show("Successfully Submitted!");
                    textBox1.Text = textBox9.Text = "";
                    connection_sql.Close();
                }
                else
                {
                    MessageBox.Show("Enter valid region id!");
                    textBox1.Text = textBox9.Text = "";
                } 

            }
            else
            {
                MessageBox.Show("Please fill all the mandatory fields!");

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox9.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
