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
    public partial class Update_Wards : UserControl
    {

        public static Update_Wards _instance;

        public static Update_Wards Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Update_Wards();

                return _instance;
            }

        }

        public string con_string_record = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";

        public Update_Wards()
        {
            InitializeComponent();
        }

        private void Update_Wards_Load(object sender, EventArgs e)
        {

        }
        void clear()
        {
            comboBox1.SelectedItem = null;
            comboBox4.SelectedItem = null;
            textBox1.Text = textBox8.Text = textBox3.Text = textBox4.Text = textBox11.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Boolean b1 = false;
            int count = 0;
            SqlConnection connection_sql = new SqlConnection(con_string_record);
            connection_sql.Open();
            string search = "select RName from Wards where W_ID = '" + textBox3.Text.ToString() + "'";
            SqlCommand select_command = new SqlCommand(search, connection_sql);
            string result = (string)select_command.ExecuteScalar();
            if (result == null || result == "")
            {
                MessageBox.Show("Invalid Ward ID!");
            }
            else

            {
                if (connection_sql.State == System.Data.ConnectionState.Open)
                {
                    if (textBox3.Text.ToString() != "")
                    {
                        string update = "UPDATE Wards ";
                        if (comboBox4.Text != "")
                        {
                            if (b1 == false)
                            {
                                update += "SET ";
                                b1 = true;

                            }
                            count++;
                            if (count == 1)
                            {
                                update += "RName = '" + comboBox4.Text.ToString() + "'";
                            }
                            else
                            {
                                update += ",RName = '" + comboBox4.Text.ToString() + "'";
                            }

                        }
                        if (comboBox1.Text != "")
                        {
                            if (b1 == false)
                            {
                                update += "SET ";
                                b1 = true;

                            }
                            count++;
                            if (count == 1)
                            {
                                update += "WType = '" + comboBox1.Text.ToString() + "'";
                            }
                            else
                            {
                                update += ",WType = '" + comboBox1.Text.ToString() + "'";
                            }

                        }

                        if (textBox8.Text != "")
                        {
                            if (b1 == false)
                            {
                                update += "SET ";
                                b1 = true;

                            }
                            count++;
                            if (count == 1)
                            {
                                update += "Address = '" + textBox8.Text.ToString() + "'";
                            }
                            else
                            {
                                update += ",Address = '" + textBox8.Text.ToString() + "'";
                            }

                        }

                        if (textBox1.Text != "")
                        {
                            if (b1 == false)
                            {
                                update += "SET ";
                                b1 = true;

                            }
                            count++;
                            if (count == 1)
                            {
                                update += "Doctors = '" + textBox1.Text.ToString() + "'";
                            }
                            else
                            {
                                update += ",Doctors = '" + textBox1.Text.ToString() + "'";
                            }

                        }

                        if (textBox4.Text != "")
                        {
                            if (b1 == false)
                            {
                                update += "SET ";
                                b1 = true;

                            }
                            count++;
                            if (count == 1)
                            {
                                update += "Head_Doctor = '" + textBox4.Text.ToString() + "'";
                            }
                            else
                            {
                                update += ",Head_Doctor = '" + textBox4.Text.ToString() + "'";
                            }

                        }

                        if (textBox11.Text != "")
                        {
                            if (b1 == false)
                            {
                                update += "SET ";
                                b1 = true;

                            }
                            count++;
                            if (count == 1)
                            {
                                update += "Capacity = '" + textBox11.Text.ToString() + "'";
                            }
                            else
                            {
                                update += ",Capacity = '" + textBox11.Text.ToString() + "'";
                            }

                        }
                        if (update != "UPDATE Wards ")
                        {
                            update += " WHERE W_ID = ";
                            update += textBox3.Text.ToString();


                            SqlCommand comm1 = new SqlCommand(update, connection_sql);
                            comm1.ExecuteNonQuery();
                            MessageBox.Show("Ward Data Updated!");

                        }
                        else
                        {
                            MessageBox.Show("Atleast one field must be Filed!");
                        }
   
                    }
                }
                clear();
                connection_sql.Close();
            }


        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
