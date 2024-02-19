namespace parallel_ex1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 184);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 124);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 161);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Bubble sort";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(168, 184);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 124);
            listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(324, 184);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(150, 124);
            listBox3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 161);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Select sort";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 161);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 5;
            label3.Text = "Insertion sort";
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(12, 314);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(150, 124);
            listBox4.TabIndex = 6;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.Location = new Point(168, 314);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(150, 124);
            listBox5.TabIndex = 7;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.Location = new Point(324, 314);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(150, 124);
            listBox6.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 184);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 9;
            label4.Text = "Before sort";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 314);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 10;
            label5.Text = "After sort";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 11;
            label6.Text = "Stats";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(150, 120);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(168, 29);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(268, 29);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 27);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(268, 62);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(90, 27);
            numericUpDown2.TabIndex = 15;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(268, 95);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(90, 27);
            numericUpDown3.TabIndex = 16;
            numericUpDown3.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 29);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 17;
            label7.Text = "Elements count";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 62);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 18;
            label8.Text = "Min value";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(364, 95);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 19;
            label9.Text = "Max value";
            // 
            // button2
            // 
            button2.Location = new Point(168, 62);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 20;
            button2.Text = "Fill random";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 450);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox6);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label2;
        private Label label3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox richTextBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button2;
    }
}
