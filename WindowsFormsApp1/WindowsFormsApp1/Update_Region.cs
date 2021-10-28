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
    public partial class Update_Region : UserControl
    {
        public static Update_Region _instance;

        public static Update_Region Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Update_Region();

                return _instance;

            }


        }

        void clear()
        {
            textBox1.Text = textBox2.Text = "";
            comboBox4.SelectedItem = null;
        }
        public Update_Region()
        {
            InitializeComponent();
        }
        public string con_string_record = "Data Source=DESKTOP-7H1BPSF;Initial Catalog=COVID-19;Integrated Security=True";
        private void Update_Region_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.ToString() != "" && textBox1.Text.ToString() != null) && (comboBox4.Text.ToString() != "" && comboBox4.Text.ToString() != null) && (textBox2.Text.ToString() != "" && textBox2.Text.ToString() != null))
            {
                SqlConnection connection_sql = new SqlConnection(con_string_record);
                connection_sql.Open();
                string result = "*";
                string search = "Select count(Region_ID) from Region where Name = '" + comboBox4.Text.ToString() + "'";
                SqlCommand select_command = new SqlCommand(search, connection_sql);
                result = ((int)select_command.ExecuteScalar()).ToString();

                if (result != "0")
                {
                    string get_pid = "Select count(Region_ID)  from EmergencyNumbers where EmergencyNum = " + textBox1.Text.ToString() +"";
                    SqlCommand select_command1 = new SqlCommand(get_pid, connection_sql);
                    string result1 = ((int)select_command1.ExecuteScalar()).ToString();

                    if (result1 != "0")
                    {
                        string insert = "Update EmergencyNumbers set EmergencyNum ='" + textBox2.Text.ToString() + "'Where EmergencyNum = '" + textBox1.Text.ToString() + "'";
                        SqlCommand comm = new SqlCommand(insert, connection_sql);
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated!");
                        clear();
                        connection_sql.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Previous Contact ");
                        clear();
                    }
  
                }
                else
                {
                    MessageBox.Show("Enter valid region id!");
                    clear();
                }

            }
            else
            {
                MessageBox.Show("Please fill all the mandatory fields!");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
