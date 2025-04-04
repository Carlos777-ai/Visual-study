using System;

namespace Practica_9_For_While_Do
{
    public partial class Form1 : Form
    {
        float f_nuum, Total;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón SumarNumeros
            textBox2.Text = Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botón Añadir
            f_num.Items.Add(textBox1.Text);

            // Aquí es donde pasamos el parámetro
            f_num = float.Parse(textBox1.Text);
            Total += f_num;
            textBox1.Text = "";
            textBox1.Focus();

        }
    }
}
