using BB_BusinessDataLogic;

namespace BudgetBuddy_Desktop
{
    public partial class BudgetBuddy : Form
    {
        double allowance;
        public BudgetBuddy()
        {
            InitializeComponent();
        }



        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            InputForms inputForms = new InputForms();
            inputForms.Show();

            this.Hide();


        }

        private void btnLoginAcc_Click(object sender, EventArgs e)
        {
            var userUsername = txtUsername.Text;
            var userPassword = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userUsername) || string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Please input all the required information.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = BBProcess.Login(userUsername, userPassword);

            if (result)
            {
                ClearFields();
                MessageBox.Show("Log-in Successful!", "Welcome");
                Dashboard dashboardForm = new Dashboard(userUsername, userPassword, allowance);
                dashboardForm.Show();

                this.Hide();

            }
            else
            {
                ClearFields();
                MessageBox.Show("Log-in Failed, Try again.", "Error");

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void BudgetBuddy_Load(object sender, EventArgs e)
        {

        }
    }
}
