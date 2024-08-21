using Microsoft.VisualBasic.Logging;

namespace CONVERSOR_DE_TEMPERATURA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float F = 0f;
        private void button1_Click(object sender, EventArgs e)
        {
            float F = float.Parse(textBox1.Text);
            float C = (F - 32) / (1.8f);
            textBox2.Text = C.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float C = float.Parse(textBox2.Text);
            float F = ((C * 9f / 5f )+ 32);
            textBox1.Text = F.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0,0";
            textBox2.Text = "0,0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
