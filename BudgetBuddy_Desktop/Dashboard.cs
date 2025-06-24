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
        public int days, dayInput;

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
            MessageBox.Show("Feature will be released soon...", "Notice");
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




        private void button6_Click_2(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to clear the entire logged expenses on your account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (!BBProcess.ClearData(userUsername, userPassword))
                {
                    MessageBox.Show("No data to delete.", "Notification");
                }
                else
                {
                    MessageBox.Show("Logged days data has been deleted.", "Notification");
                }
            }

        }

        private void AboutPnlVisiblity()
        {
            pnlAbout.Visible = true;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
            pnlLogExpenses.Visible = false;
            pnlDays.Visible = false;
            pnlDailyExpense.Visible = false;
            pnlUpdateAllowance.Visible = false;
            pnlDash.Visible = false;
            pnlDash2.Visible = false;
            pnlDash1.Visible = false;
        }

        private void SummaryPnlVisiblity()
        {
            pnlAbout.Visible = false;
            pnlAllowance.Visible = true;
            pnDashboard.Visible = true;
            pnlLogExpenses.Visible = false;
            pnlDays.Visible = false;
            pnlDailyExpense.Visible = false;
            pnlUpdateAllowance.Visible = false;
            pnlDash.Visible = false;
            pnlDash2.Visible = false;
            pnlDash1.Visible = false;
        }

        private void LogExpensePnlVisiblity() //allocation panel
        {
            pnlAbout.Visible = false;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
            pnlLogExpenses.Visible = true;
            pnlDays.Visible = false;
            pnlDailyExpense.Visible = false;
            pnlUpdateAllowance.Visible = false;
            pnlDash.Visible = false;
        }

        private void LogDaysPnlVisiblity()  //select days panel
        {
            pnlAbout.Visible = false;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
            pnlLogExpenses.Visible = false;
            pnlDays.Visible = true;
            pnlDailyExpense.Visible = false;
            pnlUpdateAllowance.Visible = false;
            pnlDash.Visible = false;
        }

        private void DailyExpensePnlVisibility(int dayInput)
        {
            pnlAbout.Visible = false;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
            pnlLogExpenses.Visible = false;
            pnlDays.Visible = false;
            pnlDailyExpense.Visible = true;
            pnlUpdateAllowance.Visible = false;
            pnlDash.Visible = false;
            pnlDash1.Visible = false;
            pnlDash2.Visible = false;

        }

        private void UpdAllowancePanelVisibility()
        {
            pnlAbout.Visible = false;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
            pnlLogExpenses.Visible = false;
            pnlDays.Visible = false;
            pnlDailyExpense.Visible = false;
            pnlDash.Visible = false;
            pnlUpdateAllowance.Visible = true;
        }

        private void DashPanelVisibility()
        {
            pnlAbout.Visible = false;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
            pnlLogExpenses.Visible = false;
            pnlDays.Visible = false;
            pnlDailyExpense.Visible = false;
            pnlUpdateAllowance.Visible = false;
            pnlDash.Visible = true;
            pnlDash1.Visible = true;
            pnlDash2.Visible = true;
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

            LogExpensePnlVisiblity();
            BBProcess.LogAnotherWeek();

            lblAllocationCount.Text = "0.00";
            lblAllowanceCount.Text = "0.00";
            lblAllowanceLeft.Text = "0.00";
            lblTotal.Text = "0.00";

            Label[] dayLabels = { lblMon, lblTue, lblWed, lblThu, lblFri, lblSat, lblSun };
            foreach (var lbl in dayLabels)
            {
                lbl.Text = "0.00";
            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            days = comboBox1.SelectedIndex;
            lblAllocationCount.Text = BBProcess.WeeklyAllowance(days, userUsername, userPassword).ToString("F2");
            MessageBox.Show("GREAT!\nNote: Try to keep expenses under the allocation to save money!", "Notification");

            comboBox1.SelectedIndex = 0;
            LogDaysPnlVisiblity();


        }

        private void btnDays_Click(object sender, EventArgs e)
        {

            dayInput = cmbCurrentDay.SelectedIndex;

            if (!BBProcess.CheckLoggedDays(days))
            {
                MessageBox.Show("Oh No! You've already logged for all the days you registered.\nPlease come back next week ❤", "Notification");
                return;
            }

            if (!BBProcess.AddUserInput(dayInput))
            {
                MessageBox.Show("You've already logged for the selected day. Please come back tomorrow", "Notification");
                return;
            }

            if (cmbCurrentDay.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid day from the dropdown.", "Invalid Selection");
                return;
            }
            else
            {
                DailyExpensePnlVisibility(dayInput);
            }

            cmbCurrentDay.SelectedIndex = 0;
        }
        private void btnExpenseSubmit_Click(object sender, EventArgs e)
        {
            var Breakfast = Convert.ToDouble(txtBreakfast.Text);
            var Lunch = Convert.ToDouble(txtLunch.Text);
            var Dinner = Convert.ToDouble(txtDinner.Text);
            var Transportation = Convert.ToDouble(txtMiscellaneous.Text);

            MessageBox.Show($"You have spent {BBProcess.DisplayDailyExpenses(Breakfast, Lunch, Dinner, Transportation, userUsername, userPassword, dayInput)} for today.", "Notification");
            AllowanceReminder();
            DisplayDailyExpense();
            ClearFieldsDayExpense();
        }



        private void ClearFieldsDayExpense()
        {
            txtBreakfast.Clear();
            txtLunch.Clear();
            txtDinner.Clear();
            txtMiscellaneous.Clear();
        }



        private static void AllowanceReminder()
        {

            if (!BBProcess.AllowanceModerator())
            {
                MessageBox.Show("You exceeded the expense allocation for the day. Try to spend less for the rest of the week.", "Notification");
            }
            else
            {
                MessageBox.Show("Good, you have spent just the right allocation for the day!", "Notification");
            }

        }

        private void DisplayDailyExpense()
        {
            Label[] dayLabels = { lblMon, lblTue, lblWed, lblThu, lblFri, lblSat, lblSun };

            for (int i = 0; i < BBProcess.dailyExpenses.Count && i < dayLabels.Length; i++)
            {
                dayLabels[i].Text = BBProcess.GetExpenseForDay(i).ToString("F2");
            }
        }

        private void btnWeeklySummary_Click(object sender, EventArgs e)
        {
            SummaryPnlVisiblity();
            lblAllowanceCount.Text = BBProcess.UpdateAllowanceDisplay(userUsername, userPassword).ToString("F2");
            lblAllowanceLeft.Text = BBProcess.allocation.ToString("F2");
            lblTotal.Text = BBProcess.DisplayWeeklyExpenses().ToString("F2");
        }



        private void btnUpdateAllowance_Click(object sender, EventArgs e)
        {
            UpdAllowancePanelVisibility();

        }



        private void btnIncrease_Click(object sender, EventArgs e)
        {
            Actions userAction = Actions.Increase;
            var Amount = Convert.ToDouble(tbxAmounToUpdate.Text);
            BBProcess.UpdateWeeklyAllowance(Amount, userAction, userUsername,  userPassword);
            MessageBox.Show("Allowance Updated!", "Notification");
            tbxAmounToUpdate.Clear();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            Actions userAction = Actions.Decrease;
            var Amount = Convert.ToDouble(tbxAmounToUpdate.Text);

           if(BBProcess.UpdateWeeklyAllowance(Amount, userAction, userUsername, userPassword))
            {
                MessageBox.Show("Allowance Updated!", "Notification");
            }
            else
            {
                MessageBox.Show("Insufficient Balance!", "Notification");
            }
                tbxAmounToUpdate.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashPanelVisibility();

        }

        private void label34_Click(object sender, EventArgs e)
        {
            //
        }

        private void label35_Click(object sender, EventArgs e)
        {
            //
        }

        private void label36_Click(object sender, EventArgs e)
        {
            //
        }

        private void label37_Click(object sender, EventArgs e)
        {
            //
        }

        private void label43_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
