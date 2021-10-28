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
    public partial class Wards : UserControl
    {

        public static Wards _instance;

        public static Wards Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Wards();

                return _instance;
            }

        }


        public string con_string_entry_form = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";
        public Wards()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Update_Wards.Instance))
            {
                panel3.Controls.Add(Update_Wards.Instance);
                Update_Wards.Instance.Dock = DockStyle.Fill;
                Update_Wards.Instance.BringToFront();

            }
            else
                Update_Wards.Instance.BringToFront();

            Update_Wards.Instance.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Delete_Wards.Instance))
            {
                panel3.Controls.Add(Delete_Wards.Instance);
                Delete_Wards.Instance.Dock = DockStyle.Fill;
                Delete_Wards.Instance.BringToFront();

            }
            else
                Delete_Wards.Instance.BringToFront();

            Delete_Wards.Instance.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!panel3.Controls.Contains(Search_Wards.Instance))
            {
                panel3.Controls.Add(Search_Wards.Instance);
                Search_Wards.Instance.Dock = DockStyle.Fill;
                Search_Wards.Instance.BringToFront();

            }
            else
                Search_Wards.Instance.BringToFront();

            Search_Wards.Instance.Show();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Update_Wards.Instance.Hide();
            Delete_Wards.Instance.Hide();
            Search_Wards.Instance.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.ToString() != "" && textBox1.Text.ToString() != null) && (textBox8.Text.ToString() != "" && textBox8.Text.ToString() != null) && (comboBox4.Text.ToString() != "" && comboBox4.Text.ToString() != null) && (textBox11.Text.ToString() != "" && textBox11.Text.ToString() != null) && (textBox4.Text.ToString() != "" && textBox4.Text.ToString() != null) && (comboBox1.Text.ToString() != "" && comboBox1.Text.ToString() != null)&& (textBox3.Text.ToString() != "" && textBox3.Text.ToString() != null))
            {

                SqlConnection connection_sql = new SqlConnection(con_string_entry_form);
                connection_sql.Open();
                if (connection_sql.State == System.Data.ConnectionState.Open)
                {
                    string get_id = "select Region_ID from Region where Name = '" + comboBox4.Text.ToString() + "'";
                    SqlCommand select_command = new SqlCommand(get_id, connection_sql);
                    int result = (int)select_command.ExecuteScalar();
                    string insert = "insert into Wards(Region_ID,WType,Address,Capacity,Doctors,RName,Head_Doctor,Contact)values('" + result + "','" + comboBox1.Text.ToString() + "'," +
                    "'" + textBox8.Text.ToString() + "','" + textBox11.Text.ToString() + "','" + textBox11.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox3.Text.ToString() + "')";
                    SqlCommand comm = new SqlCommand(insert, connection_sql);
                    comm.ExecuteNonQuery();
                }
                MessageBox.Show("Ward Data Entered Successfully!");
                connection_sql.Close();
                textBox1.Text = textBox11.Text = textBox3.Text = textBox4.Text = textBox8.Text = comboBox1.Text = comboBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all the mandatory fields!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox11.Text = textBox3.Text = textBox4.Text = textBox8.Text = comboBox1.Text ="";
            comboBox4.SelectedItem = null;
        }
    }
}
