namespace ProiectPartea1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPassword.Text == "admin")

            {

                MainForm fm = new MainForm();
                fm.Show();
                //this.Hide();

            }

            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}