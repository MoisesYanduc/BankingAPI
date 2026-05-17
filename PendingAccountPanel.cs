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
    public partial class PendingAccountPanel : Form
    {
        int selectedRow = -1;
        PendingAccountService service = new PendingAccountService();
        PendingAccount selectedAccount;

        public PendingAccountPanel()
        {
            InitializeComponent();
            ReloadPendingAccounts();
        }
        private void PendingAccountPanel_Load(object sender, EventArgs e)
        {
            ReloadPendingAccounts();
        }

        private void dgvPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = e.RowIndex;

                DataGridViewRow row = dgvPending.Rows[e.RowIndex];

                int id = Convert.ToInt32(
                    row.Cells["colID"].Value);

                selectedAccount =
                    service.GetPendingAccounts()
                    .FirstOrDefault(a => a.Id == id);

                lblFullname.Text = selectedAccount.FullName;

                lblUsername.Text = selectedAccount.Username;

                lblContact.Text = selectedAccount.Contact;

                lblDeposit.Text = "₱" + selectedAccount.Deposit;

                lblAddress.Text = selectedAccount.Address;

            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                service.ApproveAccount(selectedAccount.Id);

                ReloadPendingAccounts();

                MessageBox.Show("Account Approved!");

                ClearInformation();
            }
            else
            {
                MessageBox.Show("Select applicant first.");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                service.RejectAccount(selectedAccount.Id);

                ReloadPendingAccounts();

                MessageBox.Show("Account Rejected!");

                ClearInformation();
            }
            else
            {
                MessageBox.Show("Select applicant first.");
            }
        }
        private void ClearInformation()
        {
            lblFullname.Text = "";
            lblUsername.Text = "";
            lblContact.Text = "";
            lblDeposit.Text = "";
            lblAddress.Text = "";

            selectedRow = -1;
        }
        private void ReloadPendingAccounts()
        {
            dgvPending.Rows.Clear();

            List<PendingAccount> accounts =
                service.GetPendingAccounts();

            foreach (PendingAccount account in accounts)
            {
                dgvPending.Rows.Add(
                    account.Id,
                    account.FullName,
                    account.Username,
                    account.Contact,
                    account.Deposit,
                    account.Status
                );
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPending.Rows.Clear();

            List<PendingAccount> accounts =
                service.SearchAccounts(txtSearch.Text);

            foreach (PendingAccount account in accounts)
            {
                dgvPending.Rows.Add(
                    account.Id,
                    account.FullName,
                    account.Username,
                    account.Contact,
                    account.Deposit,
                    account.Status
                );
            }
        }
    }
}
