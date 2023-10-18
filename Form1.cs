using System.Globalization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int counterDot = 0;
        char sign = '!';
        double number1 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text += 3;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text += 2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text += 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text += 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text += 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text += 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text += 9;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (counterDot == 0)
            {
                label1.Text += ".";
                counterDot = 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double number = double.Parse(label1.Text);
            bool isPositive = number > 0;
            if (isPositive)
            {
                label1.Text = "-" + label1.Text;
            }
            else
            {
                label1.Text = (Math.Abs(number)).ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sign == '!')
            {
                number1 = double.Parse(label1.Text);
                label1.Text = "0";
                sign = '+';
            }
            else
            {
                double number2 = double.Parse(label1.Text);
                double outcome = 0;
                switch (sign)
                {
                    case '+': outcome = number1 + number2; break;
                    case '-': outcome = number1 - number2; break;
                    case '*': outcome = number1 * number2; break;
                    case '/': outcome = number1 / number2; break;
                }
                label1.Text = outcome.ToString();
                sign = '!';
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sign == '!')
            {
                number1 = double.Parse(label1.Text);
                label1.Text = "0";
                sign = '-';
            }
            else
            {
                double number2 = double.Parse(label1.Text);
                double outcome = 0;
                switch (sign)
                {
                    case '+': outcome = number1 + number2; break;
                    case '-': outcome = number1 - number2; break;
                    case '*': outcome = number1 * number2; break;
                    case '/': outcome = number1 / number2; break;
                }
                label1.Text = outcome.ToString();
                sign = '!';
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sign == '!')
            {
                number1 = double.Parse(label1.Text);
                label1.Text = "0";
                sign = '*';
            }
            else
            {
                double number2 = double.Parse(label1.Text);
                double outcome = 0;
                switch (sign)
                {
                    case '+': outcome = number1 + number2; break;
                    case '-': outcome = number1 - number2; break;
                    case '*': outcome = number1 * number2; break;
                    case '/': outcome = number1 / number2; break;
                }
                label1.Text = outcome.ToString();
                sign = '!';
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (sign == '!')
            {
                number1 = double.Parse(label1.Text);
                label1.Text = "0";
                sign = '/';
            }
            else
            {
                double number2 = double.Parse(label1.Text);
                double outcome = 0;
                switch (sign)
                {
                    case '+': outcome = number1 + number2; break;
                    case '-': outcome = number1 - number2; break;
                    case '*': outcome = number1 * number2; break;
                    case '/': outcome = number1 / number2; break;
                }
                label1.Text = outcome.ToString();
                sign = '!';
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (number1 != 0)
            {
                double number2 = double.Parse(label1.Text);
                double outcome = 0;
                switch (sign)
                {
                    case '+': outcome = number1 + number2; break;
                    case '-': outcome = number1 - number2; break;
                    case '*': outcome = number1 * number2; break;
                    case '/': outcome = number1 / number2; break;
                }
                label1.Text = outcome.ToString();
                sign = '!';
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                double number = double.Parse(label1.Text);
                number = Math.Pow(number, 2);
                label1.Text = number.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            sign = '!';
            number1 = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(label1.Text != "0")
            {
                string number = label1.Text;
                string newNumber = "";
                for (int i = 0; i < number.Length-1; i++)
                {
                    newNumber += number[i];
                }
                label1.Text = newNumber.ToString();
            }
        }
    }
}
