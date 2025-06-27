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
    public partial class InputForms : Form
    {
        string userUsername, userPassword;
        double allowance;
        public InputForms()
        {
            InitializeComponent();
        }

        private void InputForms_Load(object sender, EventArgs e)
        {

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            BudgetBuddy budget = new BudgetBuddy();
            budget.Show();

            this.Hide();
        }



        private void btnEnter_Click(object sender, EventArgs e)
        {
            userUsername = txtUsername.Text;
            userPassword = txtPassword.Text;
            string allowanceString = txtAllowance.Text;

            if (string.IsNullOrWhiteSpace(userUsername) || string.IsNullOrWhiteSpace(userPassword) || string.IsNullOrEmpty(allowanceString))
            {
                MessageBox.Show("Please input all the required information.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearFields();
                return;
            }

            if (!double.TryParse(allowanceString, out double allowance))
            {
                MessageBox.Show("Please input numerical values only.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearFields();
                return;
            }

            BBProcess.CreateAccount(userUsername, userPassword, allowance);

            clearFields();

            Dashboard dashboard = new Dashboard(userUsername, userPassword, allowance);
            dashboard.Show();
            MessageBox.Show("Congrats, Bud! \nEnjoy setting-up!");

            this.Hide();


        }

        public void clearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtAllowance.Clear();
        }
    }
}
