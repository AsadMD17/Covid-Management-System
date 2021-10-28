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
    public partial class Delete_Patient : UserControl
    {

        public static Delete_Patient _instance;

        public static Delete_Patient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Delete_Patient();

                return _instance;

            }


        }

        public Delete_Patient()
        {
            InitializeComponent();
        }
        public string con_string_entry_form = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_sql = new SqlConnection(con_string_entry_form);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                string result = "*";
                string search = "select First_Name from Patients where CNIC = '" + textBox12.Text.ToString() + "' AND P_ID = '" + textBox5.Text.ToString() + "'";
                SqlCommand select_command = new SqlCommand(search, connection_sql);
                result = (string)select_command.ExecuteScalar();
                if(result==null || result == "")
                {
                    MessageBox.Show("Record Not Found!");
                }
                else
                {
                    string delete = "Delete From Patients Where CNIC = '" + textBox12.Text.ToString() + "' AND P_ID = '" + textBox5.Text.ToString() + "'";
                    SqlCommand comm = new SqlCommand(delete, connection_sql);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted!");
                }
            }
            connection_sql.Close();
            textBox5.Text = textBox12.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = textBox12.Text = "";
        }

        private void Delete_Patient_Load(object sender, EventArgs e)
        {

        }
    }
}
