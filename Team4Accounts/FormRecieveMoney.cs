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
    public partial class FormRecieveMoney : Form
    {
        Color MAINTEXTCOLOUR = Color.FromArgb(0, 0, 0);
        Color BACKGROUNDCOLOUR = Color.FromArgb(215, 217, 220);
        Color OBJECTCOLOUR = Color.FromArgb(255, 153, 0);
        Color HIGHLIGHTCOLOUR = Color.FromArgb(255, 219, 23);

        public FormRecieveMoney()
        {
            InitializeComponent();
            this.BackColor = BACKGROUNDCOLOUR;
        }

        private void FormMainBtn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = HIGHLIGHTCOLOUR;
        }

        private void FormMainBtn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = OBJECTCOLOUR;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var previousForm = (FormMain)Tag;
            previousForm.Show();
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            var previousForm = (FormMain)Tag;
            previousForm.Show();
            this.Close();
        }
    }
}
