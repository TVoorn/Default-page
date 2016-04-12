using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Default_page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(DateTime.Now.ToString("HH" + ":" + "mm"));
            label2.Text = Convert.ToString(DateTime.Now.ToString("dd " + "MMMM " + "yyyy"));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
