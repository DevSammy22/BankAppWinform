namespace NationalBankForm
{
    partial class Transfer
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
            this.txtDescriptionTransfer = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSubmitTransfer = new System.Windows.Forms.Label();
            this.txtAmountTransfer = new System.Windows.Forms.TextBox();
            this.txtAccNumSender = new System.Windows.Forms.TextBox();
            this.lblAccNumSender = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtAccNumReceiver = new System.Windows.Forms.TextBox();
            this.lblAccNumReceiver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescriptionTransfer
            // 
            this.txtDescriptionTransfer.Location = new System.Drawing.Point(344, 322);
            this.txtDescriptionTransfer.Name = "txtDescriptionTransfer";
            this.txtDescriptionTransfer.Size = new System.Drawing.Size(436, 31);
            this.txtDescriptionTransfer.TabIndex = 36;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(0, 322);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 32);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Description";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(0, 245);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(107, 32);
            this.lblAmount.TabIndex = 34;
            this.lblAmount.Text = "Amount";
            // 
            // lblSubmitTransfer
            // 
            this.lblSubmitTransfer.AutoSize = true;
            this.lblSubmitTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubmitTransfer.ForeColor = System.Drawing.Color.White;
            this.lblSubmitTransfer.Location = new System.Drawing.Point(362, 394);
            this.lblSubmitTransfer.Name = "lblSubmitTransfer";
            this.lblSubmitTransfer.Size = new System.Drawing.Size(95, 32);
            this.lblSubmitTransfer.TabIndex = 33;
            this.lblSubmitTransfer.Text = "Submit";
            this.lblSubmitTransfer.Click += new System.EventHandler(this.lblSubmitTransfer_Click);
            // 
            // txtAmountTransfer
            // 
            this.txtAmountTransfer.Location = new System.Drawing.Point(344, 245);
            this.txtAmountTransfer.Name = "txtAmountTransfer";
            this.txtAmountTransfer.Size = new System.Drawing.Size(436, 31);
            this.txtAmountTransfer.TabIndex = 32;
            // 
            // txtAccNumSender
            // 
            this.txtAccNumSender.Location = new System.Drawing.Point(344, 99);
            this.txtAccNumSender.Name = "txtAccNumSender";
            this.txtAccNumSender.Size = new System.Drawing.Size(436, 31);
            this.txtAccNumSender.TabIndex = 31;
            // 
            // lblAccNumSender
            // 
            this.lblAccNumSender.AutoSize = true;
            this.lblAccNumSender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccNumSender.ForeColor = System.Drawing.Color.White;
            this.lblAccNumSender.Location = new System.Drawing.Point(0, 96);
            this.lblAccNumSender.Name = "lblAccNumSender";
            this.lblAccNumSender.Size = new System.Drawing.Size(296, 32);
            this.lblAccNumSender.TabIndex = 30;
            this.lblAccNumSender.Text = "Sender Account Number";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Black;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransfer.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(289, 25);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(216, 34);
            this.btnTransfer.TabIndex = 29;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // txtAccNumReceiver
            // 
            this.txtAccNumReceiver.Location = new System.Drawing.Point(346, 167);
            this.txtAccNumReceiver.Name = "txtAccNumReceiver";
            this.txtAccNumReceiver.Size = new System.Drawing.Size(436, 31);
            this.txtAccNumReceiver.TabIndex = 38;
            // 
            // lblAccNumReceiver
            // 
            this.lblAccNumReceiver.AutoSize = true;
            this.lblAccNumReceiver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccNumReceiver.ForeColor = System.Drawing.Color.White;
            this.lblAccNumReceiver.Location = new System.Drawing.Point(0, 164);
            this.lblAccNumReceiver.Name = "lblAccNumReceiver";
            this.lblAccNumReceiver.Size = new System.Drawing.Size(336, 32);
            this.lblAccNumReceiver.TabIndex = 37;
            this.lblAccNumReceiver.Text = "Receipient Account Number";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAccNumReceiver);
            this.Controls.Add(this.lblAccNumReceiver);
            this.Controls.Add(this.txtDescriptionTransfer);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblSubmitTransfer);
            this.Controls.Add(this.txtAmountTransfer);
            this.Controls.Add(this.txtAccNumSender);
            this.Controls.Add(this.lblAccNumSender);
            this.Controls.Add(this.btnTransfer);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescriptionTransfer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSubmitTransfer;
        private System.Windows.Forms.TextBox txtAmountTransfer;
        private System.Windows.Forms.TextBox txtAccNumSender;
        private System.Windows.Forms.Label lblAccNumSender;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtAccNumReceiver;
        private System.Windows.Forms.Label lblAccNumReceiver;
    }
}