namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Verify_Click(object sender, EventArgs e)
        {
            int Age = int.Parse(txtAge.Text);
            if (Age > 18)
            {
                MessageBox.Show("Eligible for vote");
            }
            else
            {
                MessageBox.Show("Not eligible for vote");

            }

                    
            }

        }
    }
