﻿namespace Practica_6
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
            Valor1 = new TextBox();
            Resultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 29);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 104);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 165);
            label3.Name = "label3";
            label3.Size = new Size(203, 25);
            label3.TabIndex = 2;
            label3.Text = "Opciones de conversion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 323);
            label4.Name = "label4";
            label4.Size = new Size(184, 25);
            label4.TabIndex = 3;
            label4.Text = "Resultados de grados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 381);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 4;
            label5.Text = "Equivalente a grados";
            // 
            // Valor1
            // 
            Valor1.Location = new Point(225, 98);
            Valor1.Name = "Valor1";
            Valor1.Size = new Size(150, 31);
            Valor1.TabIndex = 5;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(211, 381);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(150, 31);
            Resultado.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(101, 221);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Fahrenheit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(223, 257);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(341, 221);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 9;
            button3.Text = "Centigrados";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Resultado);
            Controls.Add(Valor1);
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
        private TextBox Valor1;
        private TextBox Resultado;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
