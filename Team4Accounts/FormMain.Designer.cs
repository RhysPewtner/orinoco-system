namespace Team4Accounts
{
    partial class FormMain
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
            this.btnViewPendingInvoices = new System.Windows.Forms.Button();
            this.btnRecieveMoney = new System.Windows.Forms.Button();
            this.btnViewPayroll = new System.Windows.Forms.Button();
            this.btnRevenueFinances = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewPendingInvoices
            // 
            this.btnViewPendingInvoices.Location = new System.Drawing.Point(8, 12);
            this.btnViewPendingInvoices.Name = "btnViewPendingInvoices";
            this.btnViewPendingInvoices.Size = new System.Drawing.Size(87, 41);
            this.btnViewPendingInvoices.TabIndex = 0;
            this.btnViewPendingInvoices.Text = "View Pending Invoices";
            this.btnViewPendingInvoices.UseVisualStyleBackColor = true;
            this.btnViewPendingInvoices.Click += new System.EventHandler(this.btnViewPendingInvoices_Click);
            this.btnViewPendingInvoices.MouseEnter += new System.EventHandler(this.FormMainBtn_MouseEnter);
            this.btnViewPendingInvoices.MouseLeave += new System.EventHandler(this.FormMainBtn_MouseLeave);
            // 
            // btnRecieveMoney
            // 
            this.btnRecieveMoney.Location = new System.Drawing.Point(101, 12);
            this.btnRecieveMoney.Name = "btnRecieveMoney";
            this.btnRecieveMoney.Size = new System.Drawing.Size(87, 41);
            this.btnRecieveMoney.TabIndex = 1;
            this.btnRecieveMoney.Text = "Recieve Money";
            this.btnRecieveMoney.UseVisualStyleBackColor = true;
            this.btnRecieveMoney.Click += new System.EventHandler(this.btnRecieveMoney_Click);
            this.btnRecieveMoney.MouseEnter += new System.EventHandler(this.FormMainBtn_MouseEnter);
            this.btnRecieveMoney.MouseLeave += new System.EventHandler(this.FormMainBtn_MouseLeave);
            // 
            // btnViewPayroll
            // 
            this.btnViewPayroll.Location = new System.Drawing.Point(194, 12);
            this.btnViewPayroll.Name = "btnViewPayroll";
            this.btnViewPayroll.Size = new System.Drawing.Size(87, 41);
            this.btnViewPayroll.TabIndex = 2;
            this.btnViewPayroll.Text = "View Payroll";
            this.btnViewPayroll.UseVisualStyleBackColor = true;
            this.btnViewPayroll.Click += new System.EventHandler(this.btnViewPayroll_Click);
            this.btnViewPayroll.MouseEnter += new System.EventHandler(this.FormMainBtn_MouseEnter);
            this.btnViewPayroll.MouseLeave += new System.EventHandler(this.FormMainBtn_MouseLeave);
            // 
            // btnRevenueFinances
            // 
            this.btnRevenueFinances.Location = new System.Drawing.Point(287, 12);
            this.btnRevenueFinances.Name = "btnRevenueFinances";
            this.btnRevenueFinances.Size = new System.Drawing.Size(87, 41);
            this.btnRevenueFinances.TabIndex = 3;
            this.btnRevenueFinances.Text = "Chart Revenue and Finances";
            this.btnRevenueFinances.UseVisualStyleBackColor = true;
            this.btnRevenueFinances.Click += new System.EventHandler(this.btnRevenueFinances_Click);
            this.btnRevenueFinances.MouseEnter += new System.EventHandler(this.FormMainBtn_MouseEnter);
            this.btnRevenueFinances.MouseLeave += new System.EventHandler(this.FormMainBtn_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(495, 448);
            this.Controls.Add(this.btnRevenueFinances);
            this.Controls.Add(this.btnViewPayroll);
            this.Controls.Add(this.btnRecieveMoney);
            this.Controls.Add(this.btnViewPendingInvoices);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewPendingInvoices;
        private System.Windows.Forms.Button btnRecieveMoney;
        private System.Windows.Forms.Button btnViewPayroll;
        private System.Windows.Forms.Button btnRevenueFinances;
    }
}

