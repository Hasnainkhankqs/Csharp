using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Writing(int btn)
        {
            output_window.Text = Convert.ToString(btn);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            output_window.Text = btn_7.Text;
        }
    }
}
