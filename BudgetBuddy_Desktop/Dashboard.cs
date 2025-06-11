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
    public partial class Dashboard : Form
    {
        bool sidebarContainerExpand;
        bool budgetActionCollapsed;
        bool profileExpanded;
        bool profileCollapsed;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            budgetActionTimer.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

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
            Environment.Exit(0);
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
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

        private void panel13_Paint(object sender, PaintEventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void sidebarProfile_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

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
            pnDashboard.Visible = true;
            pnlAllowance.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AboutPnlVisiblity();

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

            //  lblAllowanceCount = BBProcess.DisplayAllowance(userUsername, userPassword); allowance label
        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

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

        private void budgetActContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void budgetActContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            // BBProcess.ClearData(userUsername, userPassword);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            //log another week
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //log
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void AboutPnlVisiblity()
        {
            pnlAbout.Visible = true;
            pnlAllowance.Visible = false;
            pnDashboard.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
