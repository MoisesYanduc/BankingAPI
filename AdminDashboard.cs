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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            PendingAccountPanel frm =
      new PendingAccountPanel();

            OpenPanel(frm);
        }
        private void OpenPanel(Form frm)
        {
            panelContent.Controls.Clear();

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(frm);

            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm frm = new LoginForm();

                frm.Show();

                this.Hide();
            }
        }
    }
}
