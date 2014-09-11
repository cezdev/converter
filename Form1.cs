using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            int Invoer = Convert.ToInt32(textBox1.Text);
            label1.Text = (Invoer * 1.852).ToString();
            label2.Text = (Invoer / 1.852 * 3281).ToString("0.00");
        }
    }
}
