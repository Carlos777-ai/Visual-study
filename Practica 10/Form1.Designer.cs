namespace Practica_10_For_While_Do
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(426, 28);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "z=2x² + x³";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 96);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 1;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 96);
            label3.Name = "label3";
            label3.Size = new Size(27, 25);
            label3.TabIndex = 2;
            label3.Text = "x²";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(628, 96);
            label4.Name = "label4";
            label4.Size = new Size(27, 25);
            label4.TabIndex = 3;
            label4.Text = "x³";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(881, 96);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 4;
            label5.Text = "z";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(95, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 229);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(331, 134);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 229);
            listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(565, 134);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(180, 229);
            listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 25;
            listBox4.Location = new Point(820, 134);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(180, 229);
            listBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(443, 383);
            button1.Name = "button1";
            button1.Size = new Size(244, 34);
            button1.TabIndex = 9;
            button1.Text = "Calcular Valores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 450);
            Controls.Add(button1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Button button1;
    }
}
