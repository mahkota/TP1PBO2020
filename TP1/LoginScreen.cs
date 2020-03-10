using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class LoginScreen : Form
    {
        LoginDetails loginDetails = new LoginDetails();
        LoginAuth loginAuth = new LoginAuth();
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginDetails.Username = Convert.ToString(textBoxLogin.Text);
            loginDetails.Password = Convert.ToString(textBoxPass.Text);

            loginDetails.AuthDetails = loginAuth.LoginCheck(loginDetails);

            if (loginDetails.AuthDetails == true)
            {
                this.Hide();
                MainProgram MP = new MainProgram();
                MP.Show();
            }
            else
            {
                MessageBox.Show("Wrong username/password!");
                textBoxPass.Text = "";
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
