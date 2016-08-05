using KorisnickiProekt.Properties;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KorisnickiProekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //System.Diagnostics.Process.Start("watson_06.pdf");
            label1.Parent = panelHome;
            linkNajbitno.Parent = panelMaterials;
            linkDnaAdd.Parent = panelMaterials;
            linkDnaNotes.Parent = panelMaterials;
            linkDnaRnaBook.Parent = panelMaterials;
            linkDnaRnaWatson.Parent = panelMaterials;
            linkDnaVsRna.Parent = panelMaterials;
            linkGenomes.Parent = panelMaterials;
            linkGenomeSeq.Parent = panelMaterials;
            linkRna.Parent = panelMaterials;
            linkRnaDetail.Parent = panelMaterials;
            labelAddtional.Parent = panelMaterials;
            labelDna.Parent = panelMaterials;
            labelRna.Parent = panelMaterials;
            labelRnaDna.Parent = panelMaterials;
            labelDnaVsRnaTest.Parent = panelTests;
            labelTestDna.Parent = panelTests;
            labelTestRna.Parent = panelTests;
        }

        private void homeBtn_Click(object sender, System.EventArgs e)
        {
            panelHome.Show();
            panelMaterials.Hide();
            panelTests.Hide();
            this.BackgroundImage = Properties.Resources.DNA_Strand;
            // Button myButton = new Button();
            // myButton.Text = "some text";
            // // attach event handler for Click event 
            // // (assuming ButtonClickHandler is an existing method in the class)
            //// myButton.Click += ButtonClickHandler;
            // materialsPnl.Controls.Add(myButton);
        }

        private void materialsBtn_Click(object sender, System.EventArgs e)
        {
            panelMaterials.Show();
            panelHome.Hide();
            panelTests.Hide();

            this.BackgroundImage = Properties.Resources.dna_1370603787LgY;
        }

        private void testsBtn_Click(object sender, System.EventArgs e)
        {
            panelMaterials.Hide();
            panelHome.Hide();
            panelTests.Show();
            this.BackgroundImage = Properties.Resources.shutterstock_61775431;
        }

        private void linkNajbitno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("najbitnoto.pdf");
        }

        private void linkDnaNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("DNA-notes.pdf");
        }

        private void linkGenomes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("genome.pdf");
        }

        private void linkRna_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("RNA.pdf");
        }

        private void linkRnaDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("RNA2.pdf");
        }

        private void linkDnaVsRna_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("BIO101-DNA-vs-RNA.pdf");
        }

        private void linkDnaRnaBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("RnaDna.pdf");
        }

        private void linkDnaAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("9780815365099_ch02.pdf");
        }

        private void linkGenomeSeq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Genome-sequencing-PMG-overheads.pdf");
        }

        private void linkDnaRnaWatson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("watson_06.pdf");
        }
    }
}
