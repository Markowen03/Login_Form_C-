namespace ite1l_chap5_PT1_Badua_Markowen___
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit :< ?", "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username, Password;
            Username = txtUsername.Text;
            Password = txtPassword.Text;

            if (Username == "admin" && Password == "password")
            {
                MessageBox.Show(" Login Successful!");
            }
            else
            {
                MessageBox.Show(" Login failed. Please try again. ");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}