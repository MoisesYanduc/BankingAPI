using BankingSystem.Models;
using BankingSystem.Services;
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
    public partial class RegisterForm : Form
    {
        PendingAccountService service = new PendingAccountService();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            PendingAccount account = new PendingAccount();


            account.Id =
                service.GetPendingAccounts().Count + 1;

            account.FullName = txtFullName.Text;
            account.Username = txtUsername.Text;
            account.Contact = txtContact.Text;

            decimal deposit;

            if (decimal.TryParse(txtDeposit.Text, out deposit))
            {
                account.Deposit = deposit;
            }
            else
            {
                MessageBox.Show("Invalid deposit amount.");
                return;
            }

            account.Address = txtAddress.Text;

            account.Status = "Pending";

            service.AddPendingAccount(account);

            MessageBox.Show(
                "Account application submitted successfully!");

            LoginForm frm = new LoginForm();
            frm.Show();

            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();

            this.Hide();
        }
    }
}
