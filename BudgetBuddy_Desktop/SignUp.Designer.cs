
namespace BudgetBuddy_Desktop
{
    partial class BudgetBuddy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetBuddy));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            btnLogin = new Button();
            label11 = new Label();
            label10 = new Label();
            cbShowPassword = new CheckBox();
            txtPassword = new TextBox();
            label9 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnCreateAcc = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(-3, 603);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1044, 64);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1044, 82);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(160, 27);
            label1.TabIndex = 2;
            label1.Text = "Budget Buddy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 159);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 3;
            label2.Text = " APP OVERVIEW";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 205);
            label3.Name = "label3";
            label3.Size = new Size(458, 44);
            label3.TabIndex = 4;
            label3.Text = " Master Your Money with";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gadugi", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 249);
            label4.Name = "label4";
            label4.Size = new Size(267, 44);
            label4.TabIndex = 5;
            label4.Text = "Budget Buddy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Gadugi", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(50, 312);
            label5.Name = "label5";
            label5.Size = new Size(442, 17);
            label5.TabIndex = 6;
            label5.Text = "A friendly, easy-to-use tool for managing your daily expenses, perfect";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Gadugi", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(50, 329);
            label6.Name = "label6";
            label6.Size = new Size(254, 17);
            label6.TabIndex = 7;
            label6.Text = "for students and working professionals.";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuBar;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbShowPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.ImeMode = ImeMode.Katakana;
            panel1.Location = new Point(568, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 409);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint_1;
            // 
            // btnLogin
            // 
            btnLogin.AccessibleName = "btnLogin";
            btnLogin.BackColor = Color.FromArgb(40, 89, 157);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(22, 298);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 29);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Log-in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLoginAcc_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Cambria", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(83, 90, 103);
            label11.Location = new Point(22, 364);
            label11.Name = "label11";
            label11.Size = new Size(259, 15);
            label11.TabIndex = 10;
            label11.Text = "and your data is stored in the Philippines.";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Cambria", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(83, 90, 103);
            label10.Location = new Point(22, 347);
            label10.Name = "label10";
            label10.Size = new Size(332, 15);
            label10.TabIndex = 9;
            label10.Text = "By continuing, you accept our terms of use, our policy, ";
            label10.Click += label10_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Cambria", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPassword.Location = new Point(244, 253);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(116, 19);
            cbShowPassword.TabIndex = 8;
            cbShowPassword.Text = "show password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ButtonHighlight;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(22, 210);
            txtPassword.MaximumSize = new Size(338, 50);
            txtPassword.MinimumSize = new Size(338, 27);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(338, 27);
            txtPassword.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(13, 187);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 6;
            label9.Text = "Password";
            label9.Click += label9_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ButtonHighlight;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(22, 135);
            txtUsername.MaximumSize = new Size(338, 50);
            txtUsername.MinimumSize = new Size(338, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(338, 27);
            txtUsername.TabIndex = 5;
            txtUsername.TextChanged += textBox1_TextChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(13, 112);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 4;
            label8.Text = "Username";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(76, 23);
            label7.Name = "label7";
            label7.Size = new Size(251, 27);
            label7.TabIndex = 3;
            label7.Text = "Log-in to Your Account";
            label7.Click += label7_Click;
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.AccessibleName = "btnCreateAcc";
            btnCreateAcc.BackColor = Color.FromArgb(40, 89, 157);
            btnCreateAcc.BackgroundImageLayout = ImageLayout.None;
            btnCreateAcc.FlatStyle = FlatStyle.Popup;
            btnCreateAcc.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAcc.ForeColor = Color.White;
            btnCreateAcc.Location = new Point(50, 376);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.Size = new Size(187, 42);
            btnCreateAcc.TabIndex = 12;
            btnCreateAcc.Text = "I don't have an Account";
            btnCreateAcc.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCreateAcc.UseVisualStyleBackColor = false;
            btnCreateAcc.Click += btnCreateAcc_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(910, 616);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // BudgetBuddy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 22, 41);
            ClientSize = new Size(1016, 657);
            Controls.Add(btnExit);
            Controls.Add(btnCreateAcc);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BudgetBuddy";
            Text = "Budget Buddy";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private TextBox txtPassword;
        private Label label9;
        private TextBox txtUsername;
        private CheckBox cbShowPassword;
        private Label label11;
        private Label label10;
        private Button btnLogin;
        private Button btnCreateAcc;
        private Button btnExit;
    }
}
