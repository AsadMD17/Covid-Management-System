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
    public partial class Delete_Wards : UserControl
    {
        public static Delete_Wards _instance;

        public static Delete_Wards Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Delete_Wards();

                return _instance;

            }

        }

        public string con_string_entry_form = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";

        public Delete_Wards()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_sql = new SqlConnection(con_string_entry_form);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                string search = "select RName from Wards where W_ID = '" + textBox5.Text.ToString() + "' AND WType = '" + comboBox1.Text.ToString() + "'";
                SqlCommand select_command = new SqlCommand(search, connection_sql);
                string result = (string)select_command.ExecuteScalar();
                if (result == null || result == "")
                {
                    MessageBox.Show("Record Not Found!");
                }
                else
                {
                    string delete = "Delete from Wards where W_ID = '" + textBox5.Text.ToString() + "' AND WType = '" + comboBox1.Text.ToString() + "'";
                    SqlCommand comm = new SqlCommand(delete, connection_sql);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted!");
                }
            }
            connection_sql.Close();
            textBox5.Text = comboBox1.Text = "";
        }

        private void Delete_Wards_Load(object sender, EventArgs e)
        {

        }
    }
}
