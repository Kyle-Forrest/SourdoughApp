using SourdoughApp.LoginRegister;

namespace SourdoughApp
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public string usernameInput => txtUsername.Text;
        public string passwordInput => txtPassword.Text;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);

            login.CheckUserCredentials(usernameInput, passwordInput);

            if (login.isLoggedIn)
            {
                HomePage homePage = new HomePage();
                this.Hide();
                homePage.Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();

            this.Hide();
            registerScreen.Show();
        }
    }
}
