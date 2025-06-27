using BB_BusinessDataLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy_Desktop
{
    public partial class SettingsForm : Form
    {
        string userUsername, userPassword;
        double allowance;
        public SettingsForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userUsername, userPassword, allowance);
            dashboard.Show();

            this.Hide();
        }



        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            userUsername = txtUsername.Text;
            userPassword = txtPassword.Text;
            var newPassword = txtNewPassword.Text;

            if (string.IsNullOrWhiteSpace(userUsername) || string.IsNullOrWhiteSpace(userPassword) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please input all the required information.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearFields();
                return;
            }

            if (BBProcess.UpdateAccount(userUsername, userPassword, newPassword))
            {
                MessageBox.Show("Password Updated!", "Notification");
                ClearFields();

                Dashboard dashboard = new Dashboard(userUsername, userPassword, allowance);
                dashboard.Show();

                this.Hide();
            }

            else
            {
                
                MessageBox.Show("Incorrect information entered.", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearFields();
                return;
            }

        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtNewPassword.Clear();
        }
    }
}
