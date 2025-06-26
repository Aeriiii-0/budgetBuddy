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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userUsername, userPassword, allowance);
            dashboard.Show();

            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
             userUsername = txtUsername.Text;
             userPassword = txtPassword.Text;
            var allowance = Convert.ToDouble(txtAllowance.Text);

            BBProcess.CreateAccount(userUsername, userPassword, allowance);

            txtUsername.Clear();
            txtPassword.Clear();

            Dashboard dashboard = new Dashboard(userUsername, userPassword, allowance);
            dashboard.Show();
            MessageBox.Show("Congrats, Bud! \nEnjoy setting-up!");

            this.Hide();

          


    }
    }
}
