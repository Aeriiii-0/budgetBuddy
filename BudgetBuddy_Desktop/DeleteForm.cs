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
    public partial class DeleteForm : Form
    {
        string userUsername, userPassword;
        double allowance;
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userUsername, userPassword, allowance);
            dashboard.Show();

            this.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
             userUsername = txtUsername.Text;
             userPassword = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userUsername) || string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Please input all the required information.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearFields();
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to Delete Your Account?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (BBProcess.DeleteAccount(userUsername, userPassword))
                {
                    MessageBox.Show("Account Deleted!");
                    clearFields();
                }

                else
                {
                    MessageBox.Show("Credentials Incorrect.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearFields();
                    return;
                }
                
            }
        }

        private void clearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();

        }
    }
}
