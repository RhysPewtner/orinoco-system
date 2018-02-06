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
    public partial class FormPendingInvoices : Form
    {
        Color MAINTEXTCOLOUR = Color.FromArgb(0, 0, 0);
        Color BACKGROUNDCOLOUR = Color.FromArgb(215, 217, 220);
        Color OBJECTCOLOUR = Color.FromArgb(255, 153, 0);
        Color HIGHLIGHTCOLOUR = Color.FromArgb(255, 219, 23);

        public FormPendingInvoices()
        {
            InitializeComponent();
            this.BackColor = BACKGROUNDCOLOUR;
            btnPayInvoice.BackColor = OBJECTCOLOUR;
            btnBack.BackColor = OBJECTCOLOUR;
        }

        private void FormPendingInvoicesBtn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = HIGHLIGHTCOLOUR;
        }

        private void FormPendingInvoicesBtn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = OBJECTCOLOUR;
        }

        private void btnViewPayInvoice_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstInvoices.SelectedIndex != -1)
            {
                btnPayInvoice.Enabled = true;
            }
            else
            {
                btnPayInvoice.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var previousForm = (FormMain)Tag;
            previousForm.Show();
            this.Close();
        }
    }
}
