using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int broj = 67;
        public Form1()
        {
            InitializeComponent();
            label2.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == broj.ToString())
            {
                label1.Text = "true";
            }
            else 
            {
                label1.Text = "false";
                label2.Text = (int.Parse(label2.Text) + 1).ToString();
            }
        }
    }
}
