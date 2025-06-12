using BB_BusinessDataLogic;

namespace BudgetBuddy_Desktop
{
    public partial class BudgetBuddy : Form
    {
        public BudgetBuddy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

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

            var result = BBProcess.Login(userUsername, userPassword);

            if (result)
            {
                ClearFields();
                MessageBox.Show("Successful");
                Dashboard dashboardForm = new Dashboard(userUsername, userPassword);
                dashboardForm.Show();

                this.Hide();

            }
            else
            {
                ClearFields();
                MessageBox.Show("Failed");
              
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
                txtPassword.UseSystemPasswordChar= false;
            }
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
