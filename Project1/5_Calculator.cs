using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class Calculator : Form
    {
        double sonhotam = 0;
        string operation = "";
        bool nhapsomoi = false;
        public Calculator()
        {
            InitializeComponent();
            txtresult.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click_Number(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((txtresult.Text == "0") || (nhapsomoi == true))
            {
                txtresult.Clear();
                nhapsomoi = false;
            }

            if (button.Text == ".")
            {
                if (!txtresult.Text.Contains("."))
                {
                    txtresult.Text = txtresult.Text + button.Text;
                }
            }
            else
            {
                txtresult.Text = txtresult.Text + button.Text;
            }
            
        }

        private void Operator_CLick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (operation != "")
            {
                btnequal.PerformClick();

            }
            else
            {
                if (txtresult.Text == "")
                {
                    txtresult.Text = "0";
                }
                sonhotam = Convert.ToDouble(txtresult.Text);
            }
            operation = button.Text;
            nhapsomoi = true;

            lbhistory.Text = sonhotam + " " + operation;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            double sothu2 = Convert.ToDouble(txtresult.Text);
            lbhistory.Text = lbhistory.Text + " " + sothu2;
            switch (operation)
            {
                case "+":
                    txtresult.Text = (sonhotam + sothu2).ToString();
                    break;
                case "-":
                    txtresult.Text = (sonhotam - sothu2).ToString();
                    break;
                case "*":
                    txtresult.Text = (sonhotam * sothu2).ToString();
                    break;
                case "/":
                    if (sothu2 != 0)
                    {
                        txtresult.Text = (sonhotam / sothu2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0");
                    }
                    break;
            }
            operation = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sonhotam = 0;
            operation = "";
            sonhotam = 0;
            nhapsomoi = false;
            txtresult.Text = "0";
            lbhistory.Text = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
            lbhistory.Text = "";

        }
    }
}
