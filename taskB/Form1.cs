using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnforecolor_Click(object sender, EventArgs e)
        {
            if (checkbox1.Checked==true) {
                colorDialog1.ShowDialog();
                text1.ForeColor = colorDialog1.Color;
            }

            if (checkbox2.Checked == true)
            {
                colorDialog1.ShowDialog();
                text2.ForeColor = colorDialog1.Color;
            }
        }

        private void btnbackcolor_Click(object sender, EventArgs e)
        {
            if (checkbox1.Checked == true)
            {
                colorDialog1.ShowDialog();
                text1.BackColor = colorDialog1.Color;
            }
            if (checkbox2.Checked == true)
            {
                colorDialog1.ShowDialog();
                text2.BackColor = colorDialog1.Color;
            }
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            if (checkbox1.Checked == true)
            {
                fontDialog1.ShowDialog();
                text1.Font = fontDialog1.Font;
            }
            if (checkbox2.Checked == true)
            {
                fontDialog1.ShowDialog();
                text2.Font = fontDialog1.Font;
            }
        }
    }
}
