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

    public partial class Treatments : UserControl
    {


        public static Treatments _instance;

        public static Treatments Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Treatments();

                return _instance;
            }


        }


        public Treatments()
        {
            InitializeComponent();
        }

        private void Treatments_Load(object sender, EventArgs e)
        {

        }
    }
}
