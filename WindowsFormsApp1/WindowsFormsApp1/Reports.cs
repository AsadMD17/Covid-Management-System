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
    public partial class Reports : UserControl
    {
      
        public static Reports _instance;
        public static Reports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Reports();

                return _instance;
            }

        }
        public string con_string_record = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";

        private void fillCharts()
        {
            SqlConnection con = new SqlConnection(con_string_record);
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Top 10 EDate,Daily_count from Daily_Stats", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Patient Count"].XValueMember = "EDate";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Patient Count"].YValueMembers = "Daily_count";

            ///////-------------Chart-2--------/////////
            ///
            adapt = new SqlDataAdapter("Select Top 10 D.EDate,count(P.CNIC) AS Male_count From Patients P, Entry_Date D  where P.P_ID = D.P_ID and Gender = 'Male' group by EDate; ", con);
            adapt.Fill(ds);
            adapt = new SqlDataAdapter("Select Top 10 D.EDate,count(P.CNIC) AS Female_count From Patients P, Entry_Date D  where P.P_ID = D.P_ID and Gender = 'Female' group by EDate; ", con);
            adapt.Fill(ds);
            chart2.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart2.Series["Male"].XValueMember = "EDate";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart2.Series["Male"].YValueMembers = "Male_count";
            chart2.Series["Females"].XValueMember = "EDate";
            chart2.Series["Females"].YValueMembers = "Female_count";

            ///////-------------Chart-3--------//////////
            adapt = new SqlDataAdapter("Select D.EDate,count(P.CNIC) AS Deaths From Patients P, Entry_Date D where P.P_ID = D.P_ID and Health_Status = 'Dead' group by EDate", con);
            adapt.Fill(ds);
            adapt = new SqlDataAdapter("Select D.EDate,count(P.CNIC) AS Recoveries From Patients P, Entry_Date D where P.P_ID = D.P_ID and Health_Status = 'Recovered' group by EDate", con);
            adapt.Fill(ds);
            adapt = new SqlDataAdapter("Select D.EDate,count(P.CNIC) AS Confirm From Patients P, Entry_Date D where P.P_ID = D.P_ID and Health_Status = 'Confirmed' group by EDate", con);
            adapt.Fill(ds);
            chart3.DataSource = ds;
            chart3.Series["Active"].XValueMember = "EDate";
            chart3.Series["Active"].YValueMembers = "Confirm";
            chart3.Series["Deaths"].XValueMember = "EDate";
            chart3.Series["Deaths"].YValueMembers = "Deaths";
            chart3.Series["Recoveries"].XValueMember = "EDate";
            chart3.Series["Recoveries"].YValueMembers = "Recoveries";

            ///////-------------Chart-4--------//////////
            adapt = new SqlDataAdapter("Select Top 10 Name ,Patients From  Region order by  Patients desc", con);                      
            adapt.Fill(ds);
            chart4.DataSource = ds;
            chart4.Series["Patient Count"].XValueMember = "Name";
            chart4.Series["Patient Count"].YValueMembers = "Patients";
            chart4.Series[0]["PieLabelStyle"] = "Disabled";
            

            ///////-------------Chart-5--------//////////
            adapt = new SqlDataAdapter("select Age,P_count as P1 from Age_Stats where Age=10", con);
            adapt.Fill(ds);
            adapt = new SqlDataAdapter("select Age,P_count as P2 from Age_Stats where Age=30", con);
            adapt.Fill(ds);
            adapt = new SqlDataAdapter("select Age,P_count as P3 from Age_Stats where Age=50", con);
            adapt.Fill(ds);
            adapt = new SqlDataAdapter("select Age,P_count as P4 from Age_Stats where Age=80", con);
            adapt.Fill(ds);

            chart5.DataSource = ds;
            chart5.Series["Age <= 20"].XValueMember = "Age";
            chart5.Series["Age <= 20"].YValueMembers = "P1";
            chart5.Series["Age >20 and <= 40"].XValueMember = "Age";
            chart5.Series["Age >20 and <= 40"].YValueMembers = "P2";
            chart5.Series["Age > 40 and <= 60"].XValueMember = "Age";
            chart5.Series["Age > 40 and <= 60"].YValueMembers = "P3";
            chart5.Series["Age > 60 and <= 100"].XValueMember = "Age";
            chart5.Series["Age > 60 and <= 100"].YValueMembers = "P4";



            con.Close();
        }

        public Reports()
        {
            InitializeComponent();
        }


        private void Reports_Load(object sender, EventArgs e)
        { 
            fillCharts();
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }
    }
}
