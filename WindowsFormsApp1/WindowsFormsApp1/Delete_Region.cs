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
    public partial class Delete_Region : UserControl
    {

        public static Delete_Region _instance;

        public static Delete_Region Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Delete_Region();

                return _instance;

            }


        }


        public Delete_Region()
        {
            InitializeComponent();
        }

        private void Delete_Region_Load(object sender, EventArgs e)
        {

        }
    }
}
