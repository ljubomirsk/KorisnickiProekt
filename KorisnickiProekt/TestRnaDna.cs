using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiProekt
{
    public partial class TestRnaDna : Form
    {
        public int CorrectAnswers { get; set; }
        public TestRnaDna()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (rbQ1Correct.Checked)
            {
                CorrectAnswers++;
            }
            if (rbQ2Correct.Checked)
            {
                CorrectAnswers++;
            }
            if (rbQ3Correct.Checked)
            {
                CorrectAnswers++;
            }
            if (rbQ4Correct.Checked)
            {
                CorrectAnswers++;
            }
            if (rbQ5Correct.Checked)
            {
                CorrectAnswers++;
            }
            if (rbQ6Correct.Checked)
            {
                CorrectAnswers++;
            }
            if (rbQ7Correct.Checked)
            {
                CorrectAnswers++;
            }

            Results result = new Results();
            result.setCorrectAnswers(CorrectAnswers);
            result.FormBorderStyle = FormBorderStyle.FixedSingle;
            result.ShowDialog();
            Close();
        }
    }
}
