using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team4Accounts
{
    public partial class FormMain : Form
    {
        Color MAINTEXTCOLOUR = Color.FromArgb(0, 0, 0);
        Color BACKGROUNDCOLOUR = Color.FromArgb(215, 217, 220);
        Color OBJECTCOLOUR = Color.FromArgb(255, 153, 0);
        Color HIGHLIGHTCOLOUR = Color.FromArgb(255, 219, 23);

        public FormMain()
        {
            InitializeComponent();
            this.BackColor = BACKGROUNDCOLOUR;
            btnViewPayroll.BackColor = OBJECTCOLOUR;
            btnRecieveMoney.BackColor = OBJECTCOLOUR;
            btnViewPendingInvoices.BackColor = OBJECTCOLOUR;
            btnRevenueFinances.BackColor = OBJECTCOLOUR;
        }

        private void FormMainBtn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = HIGHLIGHTCOLOUR;
        }

        private void FormMainBtn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = OBJECTCOLOUR;
        }

        private void btnViewPendingInvoices_Click(object sender, EventArgs e)
        {
            Form newFormPendingInvoices = new FormPendingInvoices();
            newFormPendingInvoices.Tag = this;
            newFormPendingInvoices.Show(this);
            this.Hide();
        }

        private void btnRecieveMoney_Click(object sender, EventArgs e)
        {
            Form newFormRecieveMoney = new FormRecieveMoney();
            newFormRecieveMoney.Tag = this;
            newFormRecieveMoney.Show(this);
            this.Hide();
        }

        private void btnViewPayroll_Click(object sender, EventArgs e)
        {
            Form newFormViewPayroll = new FormViewPayroll();
            newFormViewPayroll.Tag = this;
            newFormViewPayroll.Show(this);
            this.Hide();
        }

        private void btnRevenueFinances_Click(object sender, EventArgs e)
        {
            Form newFormRevenueFinances = new FormRevenueFinances();
            newFormRevenueFinances.Tag = this;
            newFormRevenueFinances.Show(this);
            this.Hide();
        }
    }
}
