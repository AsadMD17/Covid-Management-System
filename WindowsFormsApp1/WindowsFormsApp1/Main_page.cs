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
    public partial class Main_page : Form
    {
        
        private int image_number = 1;
      
        
        public Main_page()
        {
            
          
            InitializeComponent();
         
        }
        public string con_string_main = "Data Source=DESKTOP-ONHU713;Initial Catalog=COVID-19;Integrated Security=True";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label3.Font = new Font("Calibri", 12, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label4.Font = new Font("Calibri", 12, FontStyle.Bold);
            label4.ForeColor = Color.Gray;
            label5.Font = new Font("Calibri", 12, FontStyle.Bold);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font("Calibri", 12, FontStyle.Bold);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font("Calibri", 12, FontStyle.Bold);
            label8.ForeColor = Color.Gray;
            label9.Font = new Font("Calibri", 12, FontStyle.Bold);
            label9.ForeColor = Color.Gray;

            Stats.Instance.Hide();
            Symptoms.Instance.Hide();
            Precautions.Instance.Hide();
            Isolation.Instance.Hide(); 
            Reports.Instance.Hide();
            Quarantine.Instance.Hide();
            Treatments.Instance.Hide();

            panel3.Visible = true;

            Home_panel.Show();


        }

       

        private void logo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slide_show();
        }
        private void slide_show()
        {
           
            slide_box.ImageLocation = string.Format(@"Myths\{0}.png", image_number);
            if (image_number == 5)
            {
                image_number = 1;
            }
            else
            { 
                image_number++;
            }
          
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void transmission_timer_Tick(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slide_box_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {
            label3.Font = new Font("Calibri", 12, FontStyle.Bold | FontStyle.Underline);//For Bold Also
            label3.ForeColor = Color.Maroon;
            label4.Font = new Font("Calibri", 12, FontStyle.Bold);
            label4.ForeColor = Color.Gray;
            label5.Font = new Font("Calibri", 12, FontStyle.Bold);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font("Calibri", 12, FontStyle.Bold);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font("Calibri", 12, FontStyle.Bold);
            label8.ForeColor = Color.Gray;
            label9.Font = new Font("Calibri", 12, FontStyle.Bold);
            label9.ForeColor = Color.Gray;

            if (!Home_panel.Controls.Contains(Stats.Instance))
            {
                Home_panel.Controls.Add(Stats.Instance);
                Stats.Instance.Dock = DockStyle.Fill;
                Stats.Instance.BringToFront();

            }
            else
                Stats.Instance.BringToFront();

            panel3.Visible = false;
           
            Stats.Instance.Show();



        }

        private void label4_Click(object sender, EventArgs e)
        { 
            label4.Font = new Font("Calibri", 12, FontStyle.Bold | FontStyle.Underline);//For Bold Also
            label4.ForeColor = Color.Maroon;
            label3.Font = new Font("Calibri", 12, FontStyle.Bold );
            label3.ForeColor = Color.Gray;
            label5.Font = new Font("Calibri", 12, FontStyle.Bold);
            label5.ForeColor = Color.Gray;
            label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font("Calibri", 12, FontStyle.Bold);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font("Calibri", 12, FontStyle.Bold);
            label8.ForeColor = Color.Gray;
            label9.Font = new Font("Calibri", 12, FontStyle.Bold);
            label9.ForeColor = Color.Gray;


            if(!Home_panel.Controls.Contains(Symptoms.Instance))
            {
                Home_panel.Controls.Add(Symptoms.Instance);
                Symptoms.Instance.Dock = DockStyle.Fill;
                Symptoms.Instance.BringToFront();

            }
            else
                Symptoms.Instance.BringToFront();
            panel3.Visible = false;
            Symptoms.Instance.Show();

        }
        
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Font = new Font("Calibri", 12, FontStyle.Bold | FontStyle.Underline);//For Bold Also
            label5.ForeColor = Color.Maroon;
            label4.Font = new Font("Calibri", 12, FontStyle.Bold);
            label4.ForeColor = Color.Gray;
            label3.Font = new Font("Calibri", 12, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font("Calibri", 12, FontStyle.Bold);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font("Calibri", 12, FontStyle.Bold);
            label8.ForeColor = Color.Gray;
            label9.Font = new Font("Calibri", 12, FontStyle.Bold);
            label9.ForeColor = Color.Gray;


            if (!Home_panel.Controls.Contains(Precautions.Instance))
            {
                Home_panel.Controls.Add(Precautions.Instance);
                Precautions.Instance.Dock = DockStyle.Fill;
                Precautions.Instance.BringToFront();

            }
            else
                Precautions.Instance.BringToFront();
           
            panel3.Visible = false;
            Precautions.Instance.Show();




        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Font = new Font("Calibri", 12, FontStyle.Bold | FontStyle.Underline);//For Bold Also
            label9.ForeColor = Color.Maroon;
            label4.Font = new Font("Calibri", 12, FontStyle.Bold);
            label4.ForeColor = Color.Gray;
            label3.Font = new Font("Calibri", 12, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font("Calibri", 12, FontStyle.Bold);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font("Calibri", 12, FontStyle.Bold);
            label8.ForeColor = Color.Gray;
            label5.Font = new Font("Calibri", 12, FontStyle.Bold);
            label5.ForeColor = Color.Gray;


            if (!Home_panel.Controls.Contains(Treatments.Instance))
            {
                Home_panel.Controls.Add(Treatments.Instance);
                Treatments.Instance.Dock = DockStyle.Fill;
                Treatments.Instance.BringToFront();

            }
            else
               Treatments.Instance.BringToFront();
            panel3.Visible = false;
            Treatments.Instance.Show();


        }
        private void label6_Click(object sender, EventArgs e)
        {
            label6.Font = new Font("Calibri", 12, FontStyle.Bold | FontStyle.Underline);//For Bold Also
            label6.ForeColor = Color.Maroon;
            label4.Font = new Font("Calibri", 12, FontStyle.Bold);
            label4.ForeColor = Color.Gray;
            label3.Font = new Font("Calibri", 12, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label9.Font = new Font("Calibri", 12, FontStyle.Bold);
            label9.ForeColor = Color.Gray;
            label7.Font = new Font("Calibri", 12, FontStyle.Bold);
            label7.ForeColor = Color.Gray;
            label8.Font = new Font("Calibri", 12, FontStyle.Bold);
            label8.ForeColor = Color.Gray;
            label5.Font = new Font("Calibri", 12, FontStyle.Bold);
            label5.ForeColor = Color.Gray;

            if (!Home_panel.Controls.Contains(Quarantine.Instance))
            {
                Home_panel.Controls.Add(Quarantine.Instance);
                Quarantine.Instance.Dock = DockStyle.Fill;
                Quarantine.Instance.BringToFront();

            }
            else
                Quarantine.Instance.BringToFront();
            panel3.Visible = false;
            Quarantine.Instance.Show();


        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Font = new Font("Calibri", 12, FontStyle.Bold | FontStyle.Underline);//For Bold Also
            label7.ForeColor = Color.Maroon;
            label4.Font = new Font("Calibri", 12, FontStyle.Bold);
            label4.ForeColor = Color.Gray;
            label3.Font = new Font("Calibri", 12, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label9.Font = new Font("Calibri", 12, FontStyle.Bold);
            label9.ForeColor = Color.Gray;
            label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            label6.ForeColor = Color.Gray;
            label8.Font = new Font("Calibri", 12, FontStyle.Bold);
            label8.ForeColor = Color.Gray;
            label5.Font = new Font("Calibri", 12, FontStyle.Bold);
            label5.ForeColor = Color.Gray;

            if (!Home_panel.Controls.Contains(Isolation.Instance))
            {
                Home_panel.Controls.Add(Isolation.Instance);
                Isolation.Instance.Dock = DockStyle.Fill;
                Isolation.Instance.BringToFront();

            }
            else
                Isolation.Instance.BringToFront();
            panel3.Visible = false;
            Isolation.Instance.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Font = new Font("Calibri", 12, FontStyle.Bold | FontStyle.Underline);//For Bold Also
            label8.ForeColor = Color.Maroon;
            label4.Font = new Font("Calibri", 12, FontStyle.Bold);
            label4.ForeColor = Color.Gray;
            label3.Font = new Font("Calibri", 12, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label9.Font = new Font("Calibri", 12, FontStyle.Bold);
            label9.ForeColor = Color.Gray;
            label6.Font = new Font("Calibri", 12, FontStyle.Bold);
            label6.ForeColor = Color.Gray;
            label7.Font = new Font("Calibri", 12, FontStyle.Bold);
            label7.ForeColor = Color.Gray;
            label5.Font = new Font("Calibri", 12, FontStyle.Bold);
            label5.ForeColor = Color.Gray;

            if (!Home_panel.Controls.Contains(Reports.Instance))
            {
                Home_panel.Controls.Add(Reports.Instance);
                Reports.Instance.Dock = DockStyle.Fill;
                Reports.Instance.BringToFront();

            }
            else
                Reports.Instance.BringToFront();
            panel3.Visible = false;
            Reports.Instance.Show();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
            Admin_Form form2 = new Admin_Form();
            form2.Show();
            this.Hide();

        }

        private void Main_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
