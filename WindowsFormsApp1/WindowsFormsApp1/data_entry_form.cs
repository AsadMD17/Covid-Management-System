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
    public partial class data_entry_form : Form
    {
        public data_entry_form()
        {
            InitializeComponent();


        }
        public string con_string_entry_form = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";

        private void label3_Click(object sender, EventArgs e)
        {

            Regions.Instance.Hide();
            Wards.Instance.Hide();

            Update_Patient.Instance.Hide();
            Delete_Patient.Instance.Hide();
            Search_Patient.Instance.Hide();
            panel2.Hide();
            panel2.Show();
            panel3.Show();

        }

        private void logo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void data_entry_form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Update_Region.Instance.Hide();
            Delete_Region.Instance.Hide();
            Search_Region.Instance.Hide();





            panel2.Hide();

            if (!Entry_panel.Controls.Contains(Regions.Instance))
            {
                Entry_panel.Controls.Add(Regions.Instance);
                Regions.Instance.Dock = DockStyle.Fill;
                Regions.Instance.BringToFront();

            }
            else
                Regions.Instance.BringToFront();
            Regions.Instance.Hide();
            Regions.Instance.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {


            Update_Wards.Instance.Hide();
            Delete_Wards.Instance.Hide();
            Search_Wards.Instance.Hide();


            panel2.Hide();





            if (!Entry_panel.Controls.Contains(Wards.Instance))
            {
                Entry_panel.Controls.Add(Wards.Instance);
                Wards.Instance.Dock = DockStyle.Fill;
                Wards.Instance.BringToFront();

            }
            else
                Wards.Instance.BringToFront();
            Wards.Instance.Hide();
            Wards.Instance.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Update_Patient.Instance.Hide();
            Delete_Patient.Instance.Hide();
            Search_Patient.Instance.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!panel3.Controls.Contains(Update_Patient.Instance))
            {
                panel3.Controls.Add(Update_Patient.Instance);
                Update_Patient.Instance.Dock = DockStyle.Fill;
                Update_Patient.Instance.BringToFront();

            }
            else
                Update_Patient.Instance.BringToFront();

            Update_Patient.Instance.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Delete_Patient.Instance))
            {
                panel3.Controls.Add(Delete_Patient.Instance);
                Delete_Patient.Instance.Dock = DockStyle.Fill;
                Delete_Patient.Instance.BringToFront();

            }
            else
                Delete_Patient.Instance.BringToFront();

            Delete_Patient.Instance.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Search_Patient.Instance))
            {
                panel3.Controls.Add(Search_Patient.Instance);
                Search_Patient.Instance.Dock = DockStyle.Fill;
                Search_Patient.Instance.BringToFront();

            }
            else
                Search_Patient.Instance.BringToFront();

            Search_Patient.Instance.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_page home = new Main_page();
            home.ShowDialog();
            this.Close();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.ToString() != "" && textBox1.Text.ToString() != null) && (textBox2.Text.ToString() != "" && textBox2.Text.ToString() != null) && (textBox6.Text.ToString() != "" && textBox6.Text.ToString() != null) && (textBox8.Text.ToString() != "" && textBox8.Text.ToString() != null) && (textBox11.Text.ToString() != "" && textBox11.Text.ToString() != null) && (textBox12.Text.ToString() != "" && textBox12.Text.ToString() != null) && (comboBox1.Text.ToString() != "" && comboBox1.Text.ToString() != null) && (comboBox2.Text.ToString() != "" && comboBox2.Text.ToString() != null) && (comboBox3.Text.ToString() != "" && comboBox3.Text.ToString() != null) && (comboBox4.Text.ToString() != "" && comboBox4.Text.ToString() != null))
            {
                SqlConnection connection_sql = new SqlConnection(con_string_entry_form);
                connection_sql.Open();

                int id = 0;
                string get_pid = "select count(*) from Wards where W_ID = '" + textBox2.Text.ToString() + "'";
                SqlCommand select_command = new SqlCommand(get_pid, connection_sql);
                id = (int)select_command.ExecuteScalar();
                if(id==0)
                {
                    MessageBox.Show("Ward with such id doesn't exits!");
                }
                else
                {
                    DateTime current_date = DateTime.Now;
                    DateTime DOB = dateTimePicker1.Value;
                    TimeSpan Age = current_date - DOB;
                    int years = Age.Days / 365;
                    string Current_Age = years.ToString();

                    if (connection_sql.State == System.Data.ConnectionState.Open)
                    {
                        string insert = "insert into Patients(W_ID,First_Name,Last_Name,CNIC,Address,Region,Gender,Health_Status,Age,DOB,Blood_Group)values('" + textBox2.Text.ToString() + "','" + textBox12.Text.ToString() + "'," +
                        "'" + textBox11.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox8.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + Current_Age + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "','" + comboBox3.Text.ToString() + "')";
                        SqlCommand comm = new SqlCommand(insert, connection_sql);
                        comm.ExecuteNonQuery();
                    }
                     id = 0;
                     get_pid = "select P_ID from Patients where CNIC = '" + textBox1.Text.ToString() + "'";
                    select_command = new SqlCommand(get_pid, connection_sql);
                    id = (int)select_command.ExecuteScalar();
                    string result = id.ToString();

                    if (textBox3.Text != null && textBox3.Text != "")
                    {
                        string insert_phone = "insert into PhoneNumbers(P_ID,Phone_Number)values('" + result + "','" + textBox3.Text.ToString() + "')";
                        SqlCommand comm = new SqlCommand(insert_phone, connection_sql);
                        comm.ExecuteNonQuery();
                    }
                    if (textBox6.Text != null && textBox6.Text != "")
                    {
                        string insert_phone = "insert into PhoneNumbers(P_ID,Phone_Number)values('" + result + "','" + textBox6.Text.ToString() + "')";
                        SqlCommand comm = new SqlCommand(insert_phone, connection_sql);
                        comm.ExecuteNonQuery();
                    }
                    MessageBox.Show("Successfully Recorded");
                    connection_sql.Close();
                    textBox1.Text = textBox11.Text = textBox12.Text = textBox2.Text = textBox6.Text = textBox8.Text = textBox3.Text = textBox6.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Please fill all the mandatory fields!");
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox11.Text = textBox12.Text = textBox2.Text = textBox6.Text = textBox8.Text = comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = textBox3.Text = textBox6.Text = "";

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
