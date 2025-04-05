namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string caltotal;
        int num1;
        int num2;
        string option;
        int result;

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);
            if (option.Equals("+"))
            {
                result = num1 + num2;

            }
            if (option.Equals("-"))
            {
                result = num1 - num2;

            }
            if (option.Equals("/"))
            {
                result = num1 / num2;

            }
            if (option.Equals("*"))
            {
                result = num1 * num2;

            }
            textBox1.Text = result + "";
        }
    }
}
