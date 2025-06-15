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
    public partial class UpdateAllowance : Form
    {

        public string userUsername;
        public string userPassword;
        int days;
        public UpdateAllowance(string userUsername, string userPassword, int days)
        {
            InitializeComponent();
            this.userUsername = userUsername;
            this.userPassword = userPassword;
            this.days = days;
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            double ToDo = 1;
            var Amount = Convert.ToDouble(tbxAmounToUpdate.Text);
            BBProcess.UpdateWeeklyAllowance(Amount, ToDo, userUsername, days, userPassword);
            MessageBox.Show("Allowance Updated!", "Notification");
            tbxAmounToUpdate.Clear();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            double ToDo = 2;
            var Amount = Convert.ToDouble(tbxAmounToUpdate.Text);
            BBProcess.UpdateWeeklyAllowance(Amount, ToDo, userUsername, days, userPassword);
            MessageBox.Show("Allowance Updated!", "Notification");
            tbxAmounToUpdate.Clear();
        }
    }
}
