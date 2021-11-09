namespace Task_5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.my_listBox = new System.Windows.Forms.ListBox();
            this.add_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // my_listBox
            // 
            this.my_listBox.FormattingEnabled = true;
            this.my_listBox.Location = new System.Drawing.Point(12, 12);
            this.my_listBox.Name = "my_listBox";
            this.my_listBox.Size = new System.Drawing.Size(289, 199);
            this.my_listBox.TabIndex = 0;
            // 
            // add_textBox
            // 
            this.add_textBox.Location = new System.Drawing.Point(12, 227);
            this.add_textBox.Name = "add_textBox";
            this.add_textBox.Size = new System.Drawing.Size(208, 20);
            this.add_textBox.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(226, 227);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 266);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.add_textBox);
            this.Controls.Add(this.my_listBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox my_listBox;

        private System.Windows.Forms.TextBox add_textBox;
        private System.Windows.Forms.Button add_button;

        #endregion
    }
}