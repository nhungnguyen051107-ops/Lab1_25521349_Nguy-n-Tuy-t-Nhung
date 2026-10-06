using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);

            long giaithuaA = 1;
            long giaithuaB = 1;
            long s1 = 0;
            long s2 = 0;
            long s3 = 0;

            for (int i = 1; i <= a; i++)
            {
                giaithuaA *= i;
                s1 += i;
            }
            for (int i = 1; i <= b; i++)
            {
                giaithuaB *= i;
                s2 += i;
                s3 += (long)Math.Pow(a, i);
            }

            giaithuaa.Text ="A! = " + giaithuaA.ToString("#,##0");
            giaithuab.Text ="B! = " +  giaithuaB.ToString("#,##0");
            tong1.Text ="S1 = " +  s1.ToString("#,##0");
            tong2.Text ="S2 = " + s2.ToString("#,##0");
            tong3.Text = "S3 = " + s3.ToString("#,##0");
        }

        private void tong2_Click(object sender, EventArgs e)
        {

        }

        private void giaithuaa_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            giaithuaa.Text = "";
            giaithuab.Text = "";
            tong1.Text = "";
            tong2.Text = "";
            tong3.Text = "";
            txtA.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
