using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class ToString : Form
    {
        public ToString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(textBox1.Text);
            string ketqua = "";
            switch (so)
            {
                case 0:
                    ketqua = "Không";
                    break;
                case 1:
                    ketqua = "Một";
                    break;
                case 2:
                    ketqua = "Hai";
                    break;
                case 3:
                    ketqua = "Ba";
                    break;
                case 4:
                    ketqua = "Bốn";
                    break;
                case 5:
                    ketqua = "Năm";
                    break;
                case 6:
                    ketqua = "Sáu";
                    break;
                case 7:
                    ketqua = "Bảy";
                    break;
                case 8:
                    ketqua = "Tám";
                    break;
                case 9:
                    ketqua = "Chín";
                    break;
                default:
                    ketqua = "Số không hợp lệ";
                    break;
            }
            textBox2.Text = ketqua;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
