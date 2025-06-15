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
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userUsername, userPassword);
            dashboard.Show();

            this.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
             userUsername = txtUsername.Text;
             userPassword = txtPassword.Text;    
            DialogResult result = MessageBox.Show("Are you sure you want to Delete Your Account?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                BBProcess.DeleteAccount(userUsername, userPassword);
                MessageBox.Show("Account Deleted!");
                
                txtUsername.Clear();
                txtPassword.Clear();

               
            }
        }
    }
}
