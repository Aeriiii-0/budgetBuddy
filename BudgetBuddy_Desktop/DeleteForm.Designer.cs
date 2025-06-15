namespace BudgetBuddy_Desktop
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label7 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            btnEnter = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnEnter);
            panel1.Location = new Point(266, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 434);
            panel1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(24, 314);
            label5.Name = "label5";
            label5.Size = new Size(348, 17);
            label5.TabIndex = 25;
            label5.Text = "be permanently removed and cannot be recovered.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(24, 295);
            label4.Name = "label4";
            label4.Size = new Size(417, 17);
            label4.TabIndex = 24;
            label4.Text = "All saved data, including budgets, expenses, and reports, will ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(36, 61);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 23;
            label1.Text = "Delete your password by answering below.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(36, 38);
            label7.Name = "label7";
            label7.Size = new Size(95, 23);
            label7.TabIndex = 22;
            label7.Text = "Hey, Bud!";
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
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.FlatStyle = FlatStyle.System;
            btnExit.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(894, 585);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 16;
            btnExit.Text = "Back";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-26, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1045, 678);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 657);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPassword;
        private Label label3;
        private Label label2;
        private TextBox txtUsername;
        private Button btnEnter;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
        private Label label5;
        private Label label4;
    }
}