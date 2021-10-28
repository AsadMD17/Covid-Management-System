using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Precautions : UserControl
    {

        public static Precautions _instance;

        public static Precautions Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Precautions();

                return _instance;
            }


        }



        public Precautions()
        {
            InitializeComponent();
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Precautions_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
