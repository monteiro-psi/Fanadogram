namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int userid = 0;
        static string[] usernames = new string[100];
        static string[] passwords = new string[100];

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox2.Text == "")
            {
                MessageBox.Show("Preenche todos os campos.");
                return;
            } else
            {
                foreach (string nome in usernames)
                {
                    
                }
            }
        }
    }
}
