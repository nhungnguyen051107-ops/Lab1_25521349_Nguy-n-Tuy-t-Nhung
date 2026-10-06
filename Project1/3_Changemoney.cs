using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class Changemoney : Form
    {
        public Changemoney()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double tien1 = Convert.ToDouble(txttien1.Text);
            if (boxloaitien1.SelectedItem == null || boxloaitien2.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tỷ giá để thực hiện chuyển đổi.");
                return;
            }

            string tygia1 = boxloaitien1.SelectedItem.ToString()!;
            double tygia = 0;
            string chuoitygia = "";
            switch (tygia1)
            {
                case "USD (Đô-la Mỹ)":
                    tygia = 22772;
                    chuoitygia = "1 USD = 22,772 VND";
                    break;
                case "EUR (Euro)":
                    tygia = 28132;
                    chuoitygia = "1 EUR = 28,132 VND";
                    break;
                case "GBD (Bảng Anh)":
                    tygia = 31538;
                    chuoitygia = "1 GBP = 31,538 VND";
                    break;
                case "SGD (Đô-la Singapore)":
                    tygia = 17286;
                    chuoitygia = "1 SGD = 17,286 VND";
                    break;
                case "JPY (Yên Nhật)":
                    tygia = 214;
                    chuoitygia = "1 JPY = 214 VND";
                    break;
            }

            labeltygia.Text = chuoitygia;
            double ketqua = tien1 * tygia;
            txttien2.Text = ketqua.ToString("#,##0");
        }
    }
}

