using SourdoughApp.LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SourdoughApp
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);

            if (register.RegisterAccount(txtUsernameIn.Text, txtPass.Text, txtPassConfirm.Text))
            {
                LoginScreen loginscreen = new LoginScreen();

                this.Close();
                loginscreen.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
