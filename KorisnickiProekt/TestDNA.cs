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
    public partial class TestDNA : Form
    {
        public int CorrerctAnswers { get; set; }

        public TestDNA()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (rbQ1Correct.Checked)
            {
                CorrerctAnswers++;
            }
            if (rbQ2Correct.Checked)
            {
                CorrerctAnswers++;
            }
            if (rbQ3Correct.Checked)
            {
                CorrerctAnswers++;
            }
            if (rbQ4Correct.Checked)
            {
                CorrerctAnswers++;
            }
            if (rbQ5Correct.Checked)
            {
                CorrerctAnswers++;
            }
            if (rbQ6Correct.Checked)
            {
                CorrerctAnswers++;
            }
            if (rbQ7Correct.Checked)
            {
                CorrerctAnswers++;
            }

            Results result = new Results();
            result.setCorrectAnswers(CorrerctAnswers);
            result.FormBorderStyle = FormBorderStyle.FixedSingle;
            result.ShowDialog();
            Close();
        }
    }
}
