using System;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            double ball = 0;
            if (radioButton14.Checked) ball++;
            if (radioButton22.Checked) ball++;
            if (radioButton31.Checked) ball++;
            if (radioButton41.Checked) ball++;
            if (checkBox51.Checked) ball += 0.5;
            if (checkBox52.Checked) ball += 0.5;
            label7.Text = $"Ваш итоговый балл: {ball} из 5";
        }
    }
}