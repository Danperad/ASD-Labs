using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        private List<String> myArray;

        public Form1()
        {
            InitializeComponent();
            this.myArray = new List<string>();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.myArray.Add(add_textBox.Text);
            my_listBox.Items.Clear();
            my_listBox.Items.AddRange(myArray.ToArray());
        }
    }
}