﻿namespace Practica_9_For_While_Do
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            f_num = new ListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(465, 18);
            label1.Name = "label1";
            label1.Size = new Size(378, 25);
            label1.TabIndex = 0;
            label1.Text = "Este programa suma los numeros  capturados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 1;
            label2.Text = "Introduce un numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 350);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 2;
            label3.Text = "La suma de todos son:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 350);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // f_num
            // 
            f_num.FormattingEnabled = true;
            f_num.ItemHeight = 25;
            f_num.Location = new Point(673, 86);
            f_num.Name = "f_num";
            f_num.Size = new Size(180, 329);
            f_num.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(410, 350);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Sumar numeros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(377, 86);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Añadir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(f_num);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox f_num;
        private Button button1;
        private Button button2;
    }
}
