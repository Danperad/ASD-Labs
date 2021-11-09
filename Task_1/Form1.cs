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

        private static double _num = 0;
        private static double _num2;
        private static double _result;
        private static char _ppp;
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "0":
                    _num = Double.Parse(Convert.ToString(_num) + "0");
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "1":
                    _num = Double.Parse(Convert.ToString(_num) + "1");
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "2":
                    _num = Double.Parse(Convert.ToString(_num) + "2");
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "3":
                    _num = Double.Parse(Convert.ToString(_num) + "3");
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "4":
                    _num = Double.Parse(Convert.ToString(_num) + "4");
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "5":
                    _num = Double.Parse(Convert.ToString(_num) + "5");
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "6":
                    _num = Double.Parse(Convert.ToString(_num) + "6");
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "7":
                    _num = Double.Parse(Convert.ToString(_num) + "7");
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "8":
                    _num = Double.Parse(Convert.ToString(_num) + "8");
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "9":
                    _num = Double.Parse(Convert.ToString(_num) + "9");
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "+":
                    _num2 = _num;
                    _num = 0;
                    _ppp = '+';
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "-":
                    _num2 = _num;
                    _num = 0;
                    _ppp = '-';
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "*":
                    _num2 = _num;
                    _num = 0;
                    _ppp = '*';
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "/":
                    _num2 = _num;
                    _num = 0;
                    _ppp = '/';
                    textBox1.Text = Convert.ToString(_num);
                    break;
                case "=":
                    switch (_ppp)
                    {
                       case '+':
                           _result = _num + _num2;
                           break;
                       case '-':
                           _result = _num - _num2;
                           break;
                       case '*':
                           _result = _num * _num2;
                           break;
                       case '/':
                           _result = _num2 / _num;
                           break;
                       default:
                           _result = _num;
                           break;
                    }

                    _num = 0;
                    _num2 = 0;
                    textBox1.Text = Convert.ToString(_result);
                    break;
                
            }
        }
    }
}