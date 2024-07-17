namespace CSharp_GiaiPTBac1_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    txtKQ.Text = "Phương trình vô số nghiệm";
                }
                else
                {
                    txtKQ.Text = "Phương trình vô nghiệm";
                }
            }
            else
            {
                txtKQ.Text = "Nghiệm của phương trình x là " + (-b / a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
