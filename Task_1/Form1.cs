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

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) <= Convert.ToInt32(textBox2.Text))
                {
                    textBox11.Text = Convert.ToString(0);
                    textBox21.Text = textBox2.Text;
                }
                else
                {
                    textBox11.Text = textBox1.Text;
                    textBox21.Text = textBox2.Text;
                }
            }
            catch
            {
                MessageBox.Show("Введено не число");
            }
        }
    }
}