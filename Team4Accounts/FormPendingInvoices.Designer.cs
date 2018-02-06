namespace Team4Accounts
{
    partial class FormPendingInvoices
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
            this.lstInvoices = new System.Windows.Forms.ListBox();
            this.btnPayInvoice = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPayrollMethod = new System.Windows.Forms.Label();
            this.txtPayrollMethod = new System.Windows.Forms.TextBox();
            this.txtPayrollAmount = new System.Windows.Forms.TextBox();
            this.lblDatePaidBy = new System.Windows.Forms.Label();
            this.txtPayrollID = new System.Windows.Forms.TextBox();
            this.lblPayrollAmount = new System.Windows.Forms.Label();
            this.txtPayrollName = new System.Windows.Forms.TextBox();
            this.lblPayrollID = new System.Windows.Forms.Label();
            this.txtDatePaidBy = new System.Windows.Forms.TextBox();
            this.lblPayrollName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstInvoices
            // 
            this.lstInvoices.FormattingEnabled = true;
            this.lstInvoices.Location = new System.Drawing.Point(8, 8);
            this.lstInvoices.Name = "lstInvoices";
            this.lstInvoices.Size = new System.Drawing.Size(239, 394);
            this.lstInvoices.TabIndex = 0;
            this.lstInvoices.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnPayInvoice
            // 
            this.btnPayInvoice.Enabled = false;
            this.btnPayInvoice.Location = new System.Drawing.Point(253, 314);
            this.btnPayInvoice.Name = "btnPayInvoice";
            this.btnPayInvoice.Size = new System.Drawing.Size(87, 41);
            this.btnPayInvoice.TabIndex = 1;
            this.btnPayInvoice.Text = "Pay Invoice";
            this.btnPayInvoice.UseVisualStyleBackColor = true;
            this.btnPayInvoice.Click += new System.EventHandler(this.btnViewPayInvoice_Click);
            this.btnPayInvoice.MouseEnter += new System.EventHandler(this.FormPendingInvoicesBtn_MouseEnter);
            this.btnPayInvoice.MouseLeave += new System.EventHandler(this.FormPendingInvoicesBtn_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(253, 361);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.FormPendingInvoicesBtn_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.FormPendingInvoicesBtn_MouseLeave);
            // 
            // lblPayrollMethod
            // 
            this.lblPayrollMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayrollMethod.AutoSize = true;
            this.lblPayrollMethod.Location = new System.Drawing.Point(264, 116);
            this.lblPayrollMethod.Name = "lblPayrollMethod";
            this.lblPayrollMethod.Size = new System.Drawing.Size(90, 13);
            this.lblPayrollMethod.TabIndex = 28;
            this.lblPayrollMethod.Text = "Payment Method:";
            // 
            // txtPayrollMethod
            // 
            this.txtPayrollMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayrollMethod.Enabled = false;
            this.txtPayrollMethod.Location = new System.Drawing.Point(360, 113);
            this.txtPayrollMethod.Name = "txtPayrollMethod";
            this.txtPayrollMethod.Size = new System.Drawing.Size(132, 20);
            this.txtPayrollMethod.TabIndex = 27;
            // 
            // txtPayrollAmount
            // 
            this.txtPayrollAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayrollAmount.Enabled = false;
            this.txtPayrollAmount.Location = new System.Drawing.Point(360, 60);
            this.txtPayrollAmount.Name = "txtPayrollAmount";
            this.txtPayrollAmount.Size = new System.Drawing.Size(132, 20);
            this.txtPayrollAmount.TabIndex = 26;
            // 
            // lblDatePaidBy
            // 
            this.lblDatePaidBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatePaidBy.AutoSize = true;
            this.lblDatePaidBy.Location = new System.Drawing.Point(254, 90);
            this.lblDatePaidBy.Name = "lblDatePaidBy";
            this.lblDatePaidBy.Size = new System.Drawing.Size(100, 13);
            this.lblDatePaidBy.TabIndex = 25;
            this.lblDatePaidBy.Text = "Payment Due Date:";
            // 
            // txtPayrollID
            // 
            this.txtPayrollID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayrollID.Enabled = false;
            this.txtPayrollID.Location = new System.Drawing.Point(360, 34);
            this.txtPayrollID.Name = "txtPayrollID";
            this.txtPayrollID.Size = new System.Drawing.Size(132, 20);
            this.txtPayrollID.TabIndex = 24;
            // 
            // lblPayrollAmount
            // 
            this.lblPayrollAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayrollAmount.AutoSize = true;
            this.lblPayrollAmount.Location = new System.Drawing.Point(285, 63);
            this.lblPayrollAmount.Name = "lblPayrollAmount";
            this.lblPayrollAmount.Size = new System.Drawing.Size(69, 13);
            this.lblPayrollAmount.TabIndex = 23;
            this.lblPayrollAmount.Text = "Amount Due:";
            // 
            // txtPayrollName
            // 
            this.txtPayrollName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayrollName.Enabled = false;
            this.txtPayrollName.Location = new System.Drawing.Point(360, 8);
            this.txtPayrollName.Name = "txtPayrollName";
            this.txtPayrollName.Size = new System.Drawing.Size(132, 20);
            this.txtPayrollName.TabIndex = 22;
            // 
            // lblPayrollID
            // 
            this.lblPayrollID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayrollID.AutoSize = true;
            this.lblPayrollID.Location = new System.Drawing.Point(333, 37);
            this.lblPayrollID.Name = "lblPayrollID";
            this.lblPayrollID.Size = new System.Drawing.Size(21, 13);
            this.lblPayrollID.TabIndex = 21;
            this.lblPayrollID.Text = "ID:";
            // 
            // txtDatePaidBy
            // 
            this.txtDatePaidBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatePaidBy.Enabled = false;
            this.txtDatePaidBy.Location = new System.Drawing.Point(360, 87);
            this.txtDatePaidBy.Name = "txtDatePaidBy";
            this.txtDatePaidBy.Size = new System.Drawing.Size(132, 20);
            this.txtDatePaidBy.TabIndex = 20;
            // 
            // lblPayrollName
            // 
            this.lblPayrollName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayrollName.AutoSize = true;
            this.lblPayrollName.Location = new System.Drawing.Point(316, 11);
            this.lblPayrollName.Name = "lblPayrollName";
            this.lblPayrollName.Size = new System.Drawing.Size(38, 13);
            this.lblPayrollName.TabIndex = 19;
            this.lblPayrollName.Text = "Name:";
            // 
            // FormPendingInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 420);
            this.Controls.Add(this.lblPayrollMethod);
            this.Controls.Add(this.txtPayrollMethod);
            this.Controls.Add(this.txtPayrollAmount);
            this.Controls.Add(this.lblDatePaidBy);
            this.Controls.Add(this.txtPayrollID);
            this.Controls.Add(this.lblPayrollAmount);
            this.Controls.Add(this.txtPayrollName);
            this.Controls.Add(this.lblPayrollID);
            this.Controls.Add(this.txtDatePaidBy);
            this.Controls.Add(this.lblPayrollName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPayInvoice);
            this.Controls.Add(this.lstInvoices);
            this.Name = "FormPendingInvoices";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FormPendingInvoices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstInvoices;
        private System.Windows.Forms.Button btnPayInvoice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPayrollMethod;
        private System.Windows.Forms.TextBox txtPayrollMethod;
        private System.Windows.Forms.TextBox txtPayrollAmount;
        private System.Windows.Forms.Label lblDatePaidBy;
        private System.Windows.Forms.TextBox txtPayrollID;
        private System.Windows.Forms.Label lblPayrollAmount;
        private System.Windows.Forms.TextBox txtPayrollName;
        private System.Windows.Forms.Label lblPayrollID;
        private System.Windows.Forms.TextBox txtDatePaidBy;
        private System.Windows.Forms.Label lblPayrollName;
    }
}