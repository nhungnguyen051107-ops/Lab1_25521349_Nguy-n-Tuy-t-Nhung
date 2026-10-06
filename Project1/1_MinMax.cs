using System.Data;

namespace Project1
{
    public partial class MinMax : Form
    {
        public MinMax()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textmax.Clear();
            textmin.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(textBox1.Text);
            double so2 = Convert.ToDouble(textBox2.Text);
            double so3 = Convert.ToDouble(textBox3.Text);

            double max = so1;
            double min = so1;

            if (so2 > max)
            {
                max = so2;
            }
            if (so3 > max)
            {
                max = so3;
            }

            if (so2 < min)
            {
                min = so2;
            }
            if (so3 < min)
            {
                min = so3;
            }

            textmax.Text = max.ToString();
            textmin.Text = min.ToString();
        }
    }
}
