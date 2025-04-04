namespace Practica_12_For_while_Do
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
            a = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 32);
            label1.Name = "label1";
            label1.Size = new Size(330, 25);
            label1.TabIndex = 0;
            label1.Text = "Genera los numeros del 1 al 20 en While";
            // 
            // a
            // 
            a.FormattingEnabled = true;
            a.ItemHeight = 25;
            a.Location = new Point(261, 74);
            a.Name = "a";
            a.Size = new Size(180, 354);
            a.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(78, 314);
            button1.Name = "button1";
            button1.Size = new Size(142, 69);
            button1.TabIndex = 2;
            button1.Text = "Imprime en pantalla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1451, 450);
            Controls.Add(button1);
            Controls.Add(a);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox a;
        private Button button1;
    }
}
