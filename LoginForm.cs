using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '●';

            btnnotshow.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnnotshow_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';

            btnshow.Visible = false;
            btnnotshow.Visible = true;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';

            btnshow.Visible = true;
            btnnotshow.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // TEMPORARY LOGIN
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Admin Login Success");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
