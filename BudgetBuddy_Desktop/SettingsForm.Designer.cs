namespace BudgetBuddy_Desktop
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            pictureBox1 = new PictureBox();
            btnExt = new Button();
            txtPassword = new TextBox();
            lblNewPass = new Label();
            label3 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            panel1 = new Panel();
            txtNewPassword = new TextBox();
            btnEnter = new Button();
            label1 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-43, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1079, 657);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnExt
            // 
            btnExt.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExt.ForeColor = Color.Black;
            btnExt.Location = new Point(881, 582);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(94, 29);
            btnExt.TabIndex = 21;
            btnExt.Text = "Back";
            btnExt.UseVisualStyleBackColor = true;
            btnExt.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(36, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(402, 27);
            txtPassword.TabIndex = 22;
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.BackColor = Color.Transparent;
            lblNewPass.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPass.ForeColor = Color.Black;
            lblNewPass.Location = new Point(36, 275);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(125, 20);
            lblNewPass.TabIndex = 21;
            lblNewPass.Text = "New Password";
            lblNewPass.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 196);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 20;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 120);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 19;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(36, 143);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(402, 27);
            txtUsername.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblNewPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnEnter);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(271, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 434);
            panel1.TabIndex = 22;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(36, 298);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(402, 27);
            txtNewPassword.TabIndex = 23;
            // 
            // btnEnter
            // 
            btnEnter.AccessibleName = "btnEnter";
            btnEnter.BackColor = Color.FromArgb(40, 89, 157);
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(331, 362);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(107, 30);
            btnEnter.TabIndex = 13;
            btnEnter.Text = "Enter";
            btnEnter.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(34, 59);
            label1.Name = "label1";
            label1.Size = new Size(350, 20);
            label1.TabIndex = 5;
            label1.Text = "Update your password by answering below.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(34, 36);
            label7.Name = "label7";
            label7.Size = new Size(95, 23);
            label7.TabIndex = 4;
            label7.Text = "Hey, Bud!";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 22, 41);
            ClientSize = new Size(1016, 657);
            Controls.Add(panel1);
            Controls.Add(btnExt);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnExt;
        private TextBox txtPassword;
        private Label lblNewPass;
        private Label label3;
        private Label label2;
        private TextBox txtUsername;
        private Panel panel1;
        private TextBox txtNewPassword;
        private Button btnEnter;
        private Label label1;
        private Label label7;
    }
}