using System;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double num = 0;
        private static double num2;
        private static double result;
        private static char ppp;
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "0":
                    num = Double.Parse(Convert.ToString(num) + "0");
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "1":
                    num = Double.Parse(Convert.ToString(num) + "1");
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "2":
                    num = Double.Parse(Convert.ToString(num) + "2");
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "3":
                    num = Double.Parse(Convert.ToString(num) + "3");
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "4":
                    num = Double.Parse(Convert.ToString(num) + "4");
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "5":
                    num = Double.Parse(Convert.ToString(num) + "5");
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "6":
                    num = Double.Parse(Convert.ToString(num) + "6");
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "7":
                    num = Double.Parse(Convert.ToString(num) + "7");
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "8":
                    num = Double.Parse(Convert.ToString(num) + "8");
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "9":
                    num = Double.Parse(Convert.ToString(num) + "9");
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "+":
                    num2 = num;
                    num = 0;
                    ppp = '+';
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "-":
                    num2 = num;
                    num = 0;
                    ppp = '-';
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "*":
                    num2 = num;
                    num = 0;
                    ppp = '*';
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "/":
                    num2 = num;
                    num = 0;
                    ppp = '/';
                    textBox1.Text = Convert.ToString(num);
                    break;
                case "=":
                    switch (ppp)
                    {
                       case '+':
                           result = num + num2;
                           break;
                       case '-':
                           result = num - num2;
                           break;
                       case '*':
                           result = num * num2;
                           break;
                       case '/':
                           result = num2 / num;
                           break;
                       default:
                           result = num;
                           break;
                    }

                    num = 0;
                    num2 = 0;
                    textBox1.Text = Convert.ToString(result);
                    break;
                
            }
        }
    }
}