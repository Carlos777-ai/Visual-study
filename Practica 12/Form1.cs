namespace Practica_12_For_while_Do
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            while (a <= 20)
            {
                this.a.Items.Add(a);
                a++;
                {


                }
            }
        }
    }
}
