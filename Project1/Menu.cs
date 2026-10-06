using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculator form5 = new Calculator();
            form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MinMax form1 = new MinMax();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToString form2 = new ToString();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Changemoney form3 = new Changemoney();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculation form4 = new Calculation();
            form4.Show();
        }
    }
}
