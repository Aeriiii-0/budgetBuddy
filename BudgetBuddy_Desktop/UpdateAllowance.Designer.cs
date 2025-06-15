namespace BudgetBuddy_Desktop
{
    partial class UpdateAllowance
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
            pnlUpdateAllowance = new Panel();
            label24 = new Label();
            tbxAmounToUpdate = new TextBox();
            btnDecrease = new Button();
            btnIncrease = new Button();
            label23 = new Label();
            pnlUpdateAllowance.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUpdateAllowance
            // 
            pnlUpdateAllowance.Anchor = AnchorStyles.Right;
            pnlUpdateAllowance.BackColor = Color.FromArgb(11, 22, 41);
            pnlUpdateAllowance.BackgroundImageLayout = ImageLayout.Center;
            pnlUpdateAllowance.Controls.Add(label24);
            pnlUpdateAllowance.Controls.Add(tbxAmounToUpdate);
            pnlUpdateAllowance.Controls.Add(btnDecrease);
            pnlUpdateAllowance.Controls.Add(btnIncrease);
            pnlUpdateAllowance.Controls.Add(label23);
            pnlUpdateAllowance.Location = new Point(233, 35);
            pnlUpdateAllowance.Name = "pnlUpdateAllowance";
            pnlUpdateAllowance.RightToLeft = RightToLeft.Yes;
            pnlUpdateAllowance.Size = new Size(392, 280);
            pnlUpdateAllowance.TabIndex = 24;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.SkyBlue;
            label24.Location = new Point(35, 83);
            label24.Name = "label24";
            label24.Size = new Size(63, 17);
            label24.TabIndex = 26;
            label24.Text = "Amount";
            // 
            // tbxAmounToUpdate
            // 
            tbxAmounToUpdate.BackColor = SystemColors.ActiveCaption;
            tbxAmounToUpdate.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxAmounToUpdate.Location = new Point(43, 108);
            tbxAmounToUpdate.Name = "tbxAmounToUpdate";
            tbxAmounToUpdate.Size = new Size(296, 27);
            tbxAmounToUpdate.TabIndex = 25;
            // 
            // btnDecrease
            // 
            btnDecrease.BackColor = SystemColors.ActiveCaption;
            btnDecrease.FlatStyle = FlatStyle.Flat;
            btnDecrease.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecrease.ForeColor = Color.Transparent;
            btnDecrease.Location = new Point(216, 173);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(113, 29);
            btnDecrease.TabIndex = 21;
            btnDecrease.Text = "Decrease";
            btnDecrease.UseVisualStyleBackColor = false;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.BackColor = SystemColors.ActiveCaption;
            btnIncrease.FlatStyle = FlatStyle.Flat;
            btnIncrease.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncrease.ForeColor = Color.White;
            btnIncrease.Location = new Point(51, 173);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(113, 29);
            btnIncrease.TabIndex = 20;
            btnIncrease.Text = "Increase";
            btnIncrease.UseVisualStyleBackColor = false;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.SkyBlue;
            label23.Location = new Point(43, 34);
            label23.Name = "label23";
            label23.Size = new Size(299, 17);
            label23.TabIndex = 19;
            label23.Text = "Select operation to update your allowance";
            // 
            // UpdateAllowance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(625, 315);
            Controls.Add(pnlUpdateAllowance);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(1200, 0);
            MaximizeBox = false;
            Name = "UpdateAllowance";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateAllowance";
            pnlUpdateAllowance.ResumeLayout(false);
            pnlUpdateAllowance.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUpdateAllowance;
        private Label label24;
        private TextBox tbxAmounToUpdate;
        private Button btnDecrease;
        private Button btnIncrease;
        private Label label23;
    }
}