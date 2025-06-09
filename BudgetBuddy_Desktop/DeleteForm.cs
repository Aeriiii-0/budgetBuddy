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
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var userUsername = txtUsername.Text;
            var userPassword = txtPassword.Text;    
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
