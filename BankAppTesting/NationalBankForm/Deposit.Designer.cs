namespace NationalBankForm
{
    partial class Deposit
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblAccNumDeposit = new System.Windows.Forms.Label();
            this.txtAccNumDeposit = new System.Windows.Forms.TextBox();
            this.txtAmountDeposit = new System.Windows.Forms.TextBox();
            this.lblAmountDeposit = new System.Windows.Forms.Label();
            this.lblSubmitDeposit = new System.Windows.Forms.Label();
            this.txtDescriptionDeposit = new System.Windows.Forms.TextBox();
            this.lblDescriptionDeposit = new System.Windows.Forms.Label();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Black;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeposit.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(476, 35);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(216, 34);
            this.btnDeposit.TabIndex = 15;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            // 
            // lblAccNumDeposit
            // 
            this.lblAccNumDeposit.AutoSize = true;
            this.lblAccNumDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccNumDeposit.ForeColor = System.Drawing.Color.White;
            this.lblAccNumDeposit.Location = new System.Drawing.Point(233, 156);
            this.lblAccNumDeposit.Name = "lblAccNumDeposit";
            this.lblAccNumDeposit.Size = new System.Drawing.Size(210, 32);
            this.lblAccNumDeposit.TabIndex = 16;
            this.lblAccNumDeposit.Text = "Account Number";
            // 
            // txtAccNumDeposit
            // 
            this.txtAccNumDeposit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtAccNumDeposit.ForeColor = System.Drawing.Color.Red;
            this.txtAccNumDeposit.Location = new System.Drawing.Point(516, 156);
            this.txtAccNumDeposit.Name = "txtAccNumDeposit";
            this.txtAccNumDeposit.Size = new System.Drawing.Size(436, 31);
            this.txtAccNumDeposit.TabIndex = 17;
            // 
            // txtAmountDeposit
            // 
            this.txtAmountDeposit.Location = new System.Drawing.Point(516, 247);
            this.txtAmountDeposit.Name = "txtAmountDeposit";
            this.txtAmountDeposit.Size = new System.Drawing.Size(436, 31);
            this.txtAmountDeposit.TabIndex = 19;
            // 
            // lblAmountDeposit
            // 
            this.lblAmountDeposit.AutoSize = true;
            this.lblAmountDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountDeposit.ForeColor = System.Drawing.Color.White;
            this.lblAmountDeposit.Location = new System.Drawing.Point(260, 259);
            this.lblAmountDeposit.Name = "lblAmountDeposit";
            this.lblAmountDeposit.Size = new System.Drawing.Size(107, 32);
            this.lblAmountDeposit.TabIndex = 18;
            this.lblAmountDeposit.Text = "Amount";
            // 
            // lblSubmitDeposit
            // 
            this.lblSubmitDeposit.AutoSize = true;
            this.lblSubmitDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubmitDeposit.ForeColor = System.Drawing.Color.White;
            this.lblSubmitDeposit.Location = new System.Drawing.Point(620, 482);
            this.lblSubmitDeposit.Name = "lblSubmitDeposit";
            this.lblSubmitDeposit.Size = new System.Drawing.Size(95, 32);
            this.lblSubmitDeposit.TabIndex = 20;
            this.lblSubmitDeposit.Text = "Submit";
            this.lblSubmitDeposit.Click += new System.EventHandler(this.lblSubmitDeposit_Click);
            // 
            // txtDescriptionDeposit
            // 
            this.txtDescriptionDeposit.Location = new System.Drawing.Point(517, 333);
            this.txtDescriptionDeposit.Name = "txtDescriptionDeposit";
            this.txtDescriptionDeposit.Size = new System.Drawing.Size(436, 31);
            this.txtDescriptionDeposit.TabIndex = 22;
            // 
            // lblDescriptionDeposit
            // 
            this.lblDescriptionDeposit.AutoSize = true;
            this.lblDescriptionDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionDeposit.ForeColor = System.Drawing.Color.White;
            this.lblDescriptionDeposit.Location = new System.Drawing.Point(261, 330);
            this.lblDescriptionDeposit.Name = "lblDescriptionDeposit";
            this.lblDescriptionDeposit.Size = new System.Drawing.Size(146, 32);
            this.lblDescriptionDeposit.TabIndex = 21;
            this.lblDescriptionDeposit.Text = "Description";
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGoBack.ForeColor = System.Drawing.Color.White;
            this.lblGoBack.Location = new System.Drawing.Point(426, 482);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(106, 32);
            this.lblGoBack.TabIndex = 23;
            this.lblGoBack.Text = "Go Back";
            this.lblGoBack.Click += new System.EventHandler(this.lblGoBack_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1155, 649);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.txtDescriptionDeposit);
            this.Controls.Add(this.lblDescriptionDeposit);
            this.Controls.Add(this.lblSubmitDeposit);
            this.Controls.Add(this.txtAmountDeposit);
            this.Controls.Add(this.lblAmountDeposit);
            this.Controls.Add(this.txtAccNumDeposit);
            this.Controls.Add(this.lblAccNumDeposit);
            this.Controls.Add(this.btnDeposit);
            this.MaximumSize = new System.Drawing.Size(1177, 705);
            this.MinimumSize = new System.Drawing.Size(1177, 705);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblAccNumDeposit;
        private System.Windows.Forms.TextBox txtAccNumDeposit;
        private System.Windows.Forms.TextBox txtAmountDeposit;
        private System.Windows.Forms.Label lblAmountDeposit;
        private System.Windows.Forms.Label lblSubmitDeposit;
        private System.Windows.Forms.TextBox txtDescriptionDeposit;
        private System.Windows.Forms.Label lblDescriptionDeposit;
        private System.Windows.Forms.Label lblGoBack;
    }
}