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
    public partial class Update_Patient : UserControl
    {


        public string con_string_record = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";

        public static Update_Patient _instance;

        public static Update_Patient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Update_Patient();

                return _instance;

            }
        }
        void clear()
        {
            textBox1.Text = textBox11.Text = textBox12.Text = textBox2.Text = textBox1.Text = textBox6.Text = textBox8.Text  = textBox3.Text = textBox4.Text = textBox6.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
        }
        public Update_Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Boolean b1 = false;
            int count = 0;
            SqlConnection connection_sql = new SqlConnection(con_string_record);
            connection_sql.Open();
            if (connection_sql.State == System.Data.ConnectionState.Open)
            {
                if (textBox4.Text.ToString() != "")
                {
                    string update = "UPDATE Patients ";
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
                            update += "CNIC = '" + textBox1.Text.ToString() + "'";
                        }
                        else
                        {
                            update += ",CNIC = '" + textBox1.Text.ToString() + "'";
                        }

                    }

                    if (textBox12.Text != "")
                    {
                        if (b1 == false)
                        {
                            update += "SET ";
                            b1 = true;

                        }
                        count++;
                        if (count == 1)
                        {
                            update += "First_Name = '" + textBox12.Text.ToString() + "'";
                        }
                        else
                        {
                            update += ", First_Name = '" + textBox12.Text.ToString() + "'";
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
                            update += "Last_Name = '" + textBox11.Text.ToString() + "'";
                        }
                        else
                        {
                            update += ", Last_Name = '" + textBox11.Text.ToString() + "'";
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
                            update += "Gender = '" + comboBox1.Text.ToString() + "'";
                        }
                        else
                        {
                            update += ", Gender = '" + comboBox1.Text.ToString() + "'";
                        }

                    }
                    if (comboBox2.Text != "")
                    {
                        if (b1 == false)
                        {
                            update += "SET ";
                            b1 = true;

                        }
                        count++;
                        if (count == 1)
                        {
                            update += "Health_Status = '" + comboBox2.Text.ToString() + "'";
                        }
                        else
                        {
                            update += ", Health_Status = '" + comboBox2.Text.ToString() + "'";
                        }
                    }
                    if (dateTimePicker1.Value.ToString() != "")
                    {
                        DateTime current_date1 = DateTime.Now;
                        DateTime DOB1 = dateTimePicker1.Value;
                        TimeSpan Age1 = current_date1 - DOB1;
                        int years1 = Age1.Days / 365;

                        if (years1 > 0)
                        {
                            if (b1 == false)
                            {
                                update += "SET ";
                                b1 = true;

                            }
                            count++;
                            if (count == 1)
                            {
                                update += "DOB = '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "'";
                            }
                            else
                            {
                                update += ", DOB = '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "'";
                            }

                        }


                    }
                    if (comboBox3.Text != "")
                    {
                        if (b1 == false)
                        {
                            update += "SET ";
                            b1 = true;

                        }
                        count++;
                        if (count == 1)
                        {
                            update += "Blood_Group = '" + comboBox3.Text.ToString() + "'";
                        }
                        else
                        {
                            update += ", Blood_Group = '" + comboBox3.Text.ToString() + "'";
                        }

                    }
                    if (textBox2.Text != "")
                    {
                        if (b1 == false)
                        {
                            update += "SET ";
                            b1 = true;

                        }
                        count++;
                        if (count == 1)
                        {
                            update += "W_ID = '" + textBox2.Text.ToString() + "'";
                        }
                        else
                        {
                            update += ", W_ID = '" + textBox2.Text.ToString() + "'";
                        }
                    }
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
                            update += "Region = '" + comboBox4.Text.ToString() + "'";
                        }
                        else
                        {
                            update += ", Region = '" + comboBox4.Text.ToString() + "'";
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
                            update += ", Address = '" + textBox8.Text.ToString() + "'";
                        }

                    }
                    DateTime current_date = DateTime.Now;
                    DateTime DOB = dateTimePicker1.Value;
                    TimeSpan Age = current_date - DOB;
                    int years = Age.Days / 365;
                    string Current_Age = years.ToString();
                    if (years > 0)
                    {
                        if (b1 == false)
                        {
                            update += "SET ";
                            b1 = true;
                        }
                        count++;
                        if (count == 1)
                        {
                            update += "Age = '" + Current_Age + "'";
                        }
                        else
                        {
                            update += ", Age = '" + Current_Age + "'";
                        }

                    }

                    if (update != "UPDATE Patients ")
                    {
                        update += " WHERE P_ID = ";
                        update += textBox4.Text.ToString();


                        SqlCommand comm = new SqlCommand(update, connection_sql);
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Patient Data Updated");
                        clear();

                    }
                    if ((textBox6.Text == null || textBox6.Text == "") && (textBox5.Text == null || textBox5.Text == "") && (textBox3.Text == null || textBox3.Text == "") && update == "UPDATE Patients ")
                    {
                        MessageBox.Show("Atleast one field must be Filled!");

                        
                    }
                    else
                    {

                        if (textBox6.Text != null && textBox6.Text != "")
                        {
                            if (textBox3.Text != null && textBox3.Text != "")
                            {
                                string get_pid = "Select count(P_ID)  from PhoneNumbers where Phone_Number = " + textBox6.Text.ToString() + "  ";
                                SqlCommand select_command = new SqlCommand(get_pid, connection_sql);
                                string result = ((int)select_command.ExecuteScalar()).ToString();

                                if (result!="0")
                                {
                                    string insert_phone = "UPDATE PhoneNumbers Set Phone_Number = '" + textBox3.Text.ToString() + "' Where Phone_Number ='" + textBox6.Text.ToString() + "'";
                                    SqlCommand comm1 = new SqlCommand(insert_phone, connection_sql);
                                    comm1.ExecuteNonQuery();
                                    flag = true;
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Previous Contact Or Patient ID ");
                                    clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Fill Updated Contact ");
                                clear();
                            }
                        }
                        else if (textBox3.Text != null && textBox3.Text != "")
                        {
                            MessageBox.Show("Please Fill previous Contact ");
                            
                        }
                        if (textBox5.Text != null && textBox5.Text != "")
                        {
                            string get_pid = "Select count(P_ID) from Patients where P_ID = " + textBox4.Text.ToString() + "  ";
                            SqlCommand select_command = new SqlCommand(get_pid, connection_sql);                          
                            string result = ((int)select_command.ExecuteScalar()).ToString();                         
                            if ( result!="0")
                            {

                                string insert_phone = "Insert into PhoneNumbers (P_ID,Phone_Number) Values('" + textBox4.Text.ToString() + "' , '" + textBox5.Text.ToString() + "'  )  ";
                                SqlCommand comm1 = new SqlCommand(insert_phone, connection_sql);
                                comm1.ExecuteNonQuery();
                                flag = true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Previous Contact Or Patient ID ");
                            }
                        }

                    }
                    if (flag)
                    {
                        MessageBox.Show("Contact Successfully Updated!");
                        clear();
                    }
                        
                }
                else
                {
                    MessageBox.Show("Patient ID is Compulsory");
                }
                   


            }
            connection_sql.Close();

        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            clear();
        
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
