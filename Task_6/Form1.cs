using System;
using System.IO;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string path = openFileDialog1.FileName;
            listBox1.Items.Clear();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string writePath = saveFileDialog1.FileName;
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach (string s in listBox1.Items)
                    {
                        sw.WriteLine(s);
                    }
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
        }

        private int tempIndex = -1;

        private void change_button_Click(object sender, EventArgs e)
        {
            if (tempIndex == -1) return;
            listBox1.Items[tempIndex] = textBox.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempIndex = listBox1.SelectedIndex;
            textBox.Text = (string) listBox1.SelectedItem;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox.Text);
            textBox.Clear();
        }
    }
}