namespace NationalBankForm
{
    partial class NewAccount
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
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.lblAccType = new System.Windows.Forms.Label();
            this.accountType = new System.Windows.Forms.ComboBox();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.BackColor = System.Drawing.Color.Black;
            this.btnWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWithdrawal.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWithdrawal.ForeColor = System.Drawing.Color.White;
            this.btnWithdrawal.Location = new System.Drawing.Point(421, 18);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(334, 34);
            this.btnWithdrawal.TabIndex = 22;
            this.btnWithdrawal.Text = "New Account";
            this.btnWithdrawal.UseVisualStyleBackColor = false;
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccType.ForeColor = System.Drawing.Color.White;
            this.lblAccType.Location = new System.Drawing.Point(256, 185);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(170, 32);
            this.lblAccType.TabIndex = 23;
            this.lblAccType.Text = "Account Type";
            // 
            // accountType
            // 
            this.accountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountType.FormattingEnabled = true;
            this.accountType.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.accountType.Location = new System.Drawing.Point(529, 188);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(384, 33);
            this.accountType.TabIndex = 24;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReg.ForeColor = System.Drawing.Color.White;
            this.lblReg.Location = new System.Drawing.Point(638, 455);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(133, 38);
            this.lblReg.TabIndex = 25;
            this.lblReg.Text = "Register";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBack.ForeColor = System.Drawing.Color.Transparent;
            this.lblBack.Location = new System.Drawing.Point(353, 455);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(83, 38);
            this.lblBack.TabIndex = 26;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1155, 649);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.accountType);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.btnWithdrawal);
            this.Enabled = false;
            this.MaximumSize = new System.Drawing.Size(1177, 705);
            this.MinimumSize = new System.Drawing.Size(1177, 705);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.ComboBox accountType;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblBack;
    }
}