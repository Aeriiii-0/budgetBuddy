namespace BudgetBuddy_Desktop
{
    partial class InputForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForms));
            panel1 = new Panel();
            txtAllowance = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            btnEnter = new Button();
            label1 = new Label();
            label7 = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtAllowance);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnEnter);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(275, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 434);
            panel1.TabIndex = 0;
            // 
            // txtAllowance
            // 
            txtAllowance.BorderStyle = BorderStyle.FixedSingle;
            txtAllowance.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAllowance.Location = new Point(36, 298);
            txtAllowance.Name = "txtAllowance";
            txtAllowance.Size = new Size(402, 27);
            txtAllowance.TabIndex = 23;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 275);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 21;
            label4.Text = "Allowance";
            label4.Click += label4_Click;
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
            label3.Click += label3_Click_1;
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
            btnEnter.Click += btnEnter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(34, 59);
            label1.Name = "label1";
            label1.Size = new Size(402, 20);
            label1.TabIndex = 5;
            label1.Text = "How much money do you plan to spend this week?";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(34, 36);
            label7.Name = "label7";
            label7.Size = new Size(143, 23);
            label7.TabIndex = 4;
            label7.Text = "Welcome, Bud!";
            label7.Click += label7_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(899, 604);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "Back";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // InputForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 657);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "InputForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputForms";
            Load += InputForms_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label1;
        private Button btnEnter;
        private Button btnExit;
        private Label label3;
        private Label label2;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtAllowance;
        private TextBox txtPassword;
    }
}