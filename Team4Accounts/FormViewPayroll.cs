using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team4Accounts
{
    public partial class FormViewPayroll : Form
    {
        Color MAINTEXTCOLOUR = Color.FromArgb(0, 0, 0);
        Color BACKGROUNDCOLOUR = Color.FromArgb(215, 217, 220);
        Color OBJECTCOLOUR = Color.FromArgb(255, 153, 0);
        Color HIGHLIGHTCOLOUR = Color.FromArgb(255, 219, 23);

        public FormViewPayroll()
        {
            InitializeComponent();
            this.BackColor = BACKGROUNDCOLOUR;
            btnBack.BackColor = OBJECTCOLOUR;
            btnPayPayroll.BackColor = OBJECTCOLOUR;
        }

        private void FormMainBtn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = HIGHLIGHTCOLOUR;
        }

        private void FormMainBtn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = OBJECTCOLOUR;
        }

        private void lstPayroll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPayroll.SelectedIndex != -1)
            {
                btnPayPayroll.Enabled = true;
            }
            else
            {
                btnPayPayroll.Enabled = false;
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
