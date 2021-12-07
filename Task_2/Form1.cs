using System;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Университет");
            treeView1.Nodes.Add("Школа");
            treeView1.Nodes.Add("Детский сад");

            cmb_place.Items.Add("Университет");
            cmb_place.Items.Add("Школа");
            cmb_place.Items.Add("Детский сад");


            this.DupD_itap.Text = "Не выбрано";
        }

        public int id = 1;

        private void btn_add_Click(object sender, EventArgs e)
        {
            ListViewItem People = new ListViewItem(Convert.ToString(id));
            People.SubItems.Add(textBox1.Text);
            People.SubItems.Add(cmb_place.Text);
            People.SubItems.Add(this.DupD_itap.Text);
            People.SubItems.Add(Convert.ToString(numericUpDown1.Value));
            foreach (string s in checkedListBox1.CheckedItems)
                People.SubItems.Add(s);
            People.SubItems.Add(Convert.ToString(listBox1.SelectedItem));
            switch (cmb_place.Text)
            {
                case "Университет":
                    treeView1.Nodes[0].Nodes.Add($"{textBox1.Text} (ID {Convert.ToString(id)})");
                    break;
                case "Школа":   
                    treeView1.Nodes[1].Nodes.Add($"{textBox1.Text} (ID {Convert.ToString(id)})");
                    break;
                case "Детский сад":
                    treeView1.Nodes[2].Nodes.Add($"{textBox1.Text} (ID {Convert.ToString(id)})");
                    break;
            }
            id++;
            listView1.Items.Add(People);
        }

        private void cmb_place_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DupD_itap.Text = "Не выбрано";
            DomainUpDown.DomainUpDownItemCollection dude = this.DupD_itap.Items;
            DupD_itap.Items.Clear();
            switch(cmb_place.Text)
            {
                case "Университет":
                    DupD_itap.Items.Add("4-ый курс");
                    DupD_itap.Items.Add("3-ий курс");
                    DupD_itap.Items.Add("2-ой курс");
                    DupD_itap.Items.Add("1-ый курс");
                    break;
                case "Школа":
                    DupD_itap.Items.Add("Старшая школа");
                    DupD_itap.Items.Add("Средняя школа");
                    DupD_itap.Items.Add("Начальная школа");
                    break;
                case "Детский сад":
                    DupD_itap.Items.Add("Старшая группа");
                    DupD_itap.Items.Add("Младшая группа");
                    break;
            }
        }
    }
}