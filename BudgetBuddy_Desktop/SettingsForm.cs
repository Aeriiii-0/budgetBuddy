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
        public SettingsForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            var userUsername = txtUsername.Text;
            var userPassword = txtPassword.Text;
            var newPassword = txtNewPassword.Text;

            BBProcess.UpdateAccount(userUsername, userPassword, newPassword);
            ClearFields();
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtNewPassword.Clear();
        }
    }
}
