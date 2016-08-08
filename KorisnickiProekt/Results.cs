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
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            
        }

        public void setCorrectAnswers(int correctAnswers)
        {
            lblResult.Text = "You have got " + correctAnswers.ToString() + "/7 correct answers.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
