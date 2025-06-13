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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetBuddy_Desktop
{
    public partial class Dashboard : Form
    {
        bool sidebarContainerExpand;
        bool budgetActionCollapsed;
        bool profileExpanded;
        bool profileCollapsed;
        public string userUsername;
        public string userPassword;
        int days, dayInput;

        public Dashboard(string userUsername, string userPassword)
        {
            InitializeComponent();
            this.userUsername = userUsername;
            this.userPassword = userPassword;

        }



        private void Dashboard_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            budgetActionTimer.Start();
        }



        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarContainerExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarContainerExpand = false;
                    sidebarTimer.Stop();
                }
            }

            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarContainerExpand = true;
                    sidebarTimer.Stop();
                }
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //delete this
        }


        private void label1_Click_2(object sender, EventArgs e)
        {

        }





        private void budgetActionTimer_Tick(object sender, EventArgs e)
        {
            if (budgetActionCollapsed)
            {
                budgetActContainer.Height += 10;
                if (budgetActContainer.Height == budgetActContainer.MaximumSize.Height)
                {
                    budgetActionCollapsed = false;
                    budgetActionTimer.Stop();
                }
            }
            else
            {
                budgetActContainer.Height -= 10;
                if (budgetActContainer.Height == budgetActContainer.MinimumSize.Height)
                {
                    budgetActionCollapsed = true;
                    budgetActionTimer.Stop();
                }
            }
        }

        private void sidebarContainer_Paint(object sender, PaintEventArgs e)
        {

        }



        private void profilebarTimer_Tick(object sender, EventArgs e)
        {

            if (!profileExpanded)
            {
                sidebarProfile.Height += 10;
                if (sidebarProfile.Height >= sidebarProfile.MaximumSize.Height)
                {
                    sidebarProfile.Height = sidebarProfile.MaximumSize.Height;
                    profileExpanded = true;
                    profilebarTimer.Stop();
                }
            }
            else
            {
                sidebarProfile.Height -= 10;
                if (sidebarProfile.Height <= sidebarProfile.MinimumSize.Height)
                {
                    sidebarProfile.Height = sidebarProfile.MinimumSize.Height;
                    profileExpanded = false;
                    profilebarTimer.Stop();
                }
            }
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            profilebarTimer.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void button11_Click(object sender, EventArgs e)
        {
            settingsTimer.Start();
        }

        private void settingsTimer_Tick(object sender, EventArgs e)
        {
            if (!profileCollapsed)
            {
                accSettingsContainer.Height += 10;
                if (accSettingsContainer.Height >= accSettingsContainer.MaximumSize.Height)
                {
                    accSettingsContainer.Height = accSettingsContainer.MaximumSize.Height;
                    profileCollapsed = true;
                    settingsTimer.Stop();
                }
            }
            else
            {
                accSettingsContainer.Height -= 10;
                if (accSettingsContainer.Height <= accSettingsContainer.MinimumSize.Height)
                {
                    accSettingsContainer.Height = accSettingsContainer.MinimumSize.Height;
                    profileCollapsed = false;
                    settingsTimer.Stop();
                }
            }
        }



        private void button12_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
            this.Hide();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(); //delete form
            settingsForm.Show();

            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DashboardPnlVisiblity();
            lblAllowanceCount.Text = BBProcess.DisplayAllowance(userUsername, userPassword).ToString("F2");
            lblAllowanceLeft.Text = BBProcess.allocation.ToString("F2");
            lblTotal.Text = BBProcess.TotalDailyExpense.ToString("F2");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AboutPnlVisiblity();

        }





        private void button14_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to log out on your account?", "Log-out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                BudgetBuddy budgetBuddy = new BudgetBuddy();
                budgetBuddy.Show();
                MessageBox.Show("You have Logged out on your account", "Notification");

            }
            this.Hide();
        }



        private void budgetActContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            BBProcess.ClearData(userUsername, userPassword);

            //add panel ask if sure.
        }

        private void AboutPnlVisiblity()
        {
            pnlAbout.Visible = true;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
            pnlLogExpenses.Visible = false;
            pnlDays.Visible = false;
            pnlDailyExpense.Visible = false;
        }

        private void DashboardPnlVisiblity()
        {
            pnlAbout.Visible = false;
            pnlAllowance.Visible = true;
            pnDashboard.Visible = true;
            pnlLogExpenses.Visible = false;
            pnlDays.Visible = false;
            pnlDailyExpense.Visible = false;
        }

        private void LogExpensePnlVisiblity() //allocation panel
        {
            pnlAbout.Visible = false;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
            pnlLogExpenses.Visible = true;
            pnlDays.Visible = false;
            pnlDailyExpense.Visible = false;
        }

        private void LogDaysPnlVisiblity()  //select days panel
        {
            pnlAbout.Visible = false;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
            pnlLogExpenses.Visible = false;
            pnlDays.Visible = true;
            pnlDailyExpense.Visible = false;
        }

        private void DailyExpensePnlVisibility()
        {
            pnlAbout.Visible = false;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
            pnlLogExpenses.Visible = false;
            pnlDays.Visible = false;
            pnlDailyExpense.Visible = true;
        }

        private void btnLogExpense_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Have you registered number of work days? ", "Log Expenses Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LogDaysPnlVisiblity();

            }
            else
            {
                LogExpensePnlVisiblity();
            }

        }

        private void btnLogAnother_Click(object sender, EventArgs e)
        {
            BBProcess.LogAnotherWeek();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            days = comboBox1.SelectedIndex + 1;

            lblAllocationCount.Text = BBProcess.WeeklyAllowance(days, userUsername, userPassword).ToString("F2");
            MessageBox.Show("GREAT!\nNote: Try to keep expenses under the allocation to save money!", "Notification");
            LogDaysPnlVisiblity();

            comboBox1.SelectedIndex = 0;
        }

        private void btnDays_Click(object sender, EventArgs e)
        {
        var dayInput = cmbCurrentDay.SelectedIndex + 1;

        var result =BBProcess.AddUserInput(dayInput);
         DailyExpensePnlVisibility();

        }
        private void btnExpenseSubmit_Click(object sender, EventArgs e)
        {
            var Breakfast = Convert.ToDouble(txtBreakfast.Text);
            var Lunch = Convert.ToDouble(txtLunch.Text);
            var Dinner = Convert.ToDouble(txtDinner.Text);
            var Transportation = Convert.ToDouble(txtMiscellaneous.Text);

            MessageBox.Show($"You have spent {BBProcess.DisplayDailyExpenses(Breakfast, Lunch, Dinner, Transportation, userUsername, userPassword, dayInput)} for today.", "Notification");
            MessageBox.Show("Day recorded!\nCome back tomorrow to log your expense!", "Notification");
            ClearFieldsDayExpense();
        }

        private void pnlDailyExpense_Paint(object sender, PaintEventArgs e)
        {
            //del
        }

        private void ClearFieldsDayExpense()
        {
            txtBreakfast.Clear();
            txtLunch.Clear();
            txtDinner.Clear();
            txtMiscellaneous.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //del
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //del
        }
    }
}
