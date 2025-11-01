namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Int32.Parse(textBox1.Text) / Int32.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;

        }
private void button6_Click(object sender, EventArgs e
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}
