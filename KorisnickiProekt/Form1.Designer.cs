namespace KorisnickiProekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHome = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panelMaterials = new System.Windows.Forms.Panel();
            this.materialsBtn = new System.Windows.Forms.Button();
            this.testsBtn = new System.Windows.Forms.Button();
            this.panelTests = new System.Windows.Forms.Panel();
            this.linkDnaRnaWatson = new System.Windows.Forms.LinkLabel();
            this.linkGenomeSeq = new System.Windows.Forms.LinkLabel();
            this.linkDnaAdd = new System.Windows.Forms.LinkLabel();
            this.linkDnaRnaBook = new System.Windows.Forms.LinkLabel();
            this.linkDnaVsRna = new System.Windows.Forms.LinkLabel();
            this.linkRnaDetail = new System.Windows.Forms.LinkLabel();
            this.linkRna = new System.Windows.Forms.LinkLabel();
            this.linkGenomes = new System.Windows.Forms.LinkLabel();
            this.linkDnaNotes = new System.Windows.Forms.LinkLabel();
            this.labelAddtional = new System.Windows.Forms.Label();
            this.labelRnaDna = new System.Windows.Forms.Label();
            this.labelRna = new System.Windows.Forms.Label();
            this.labelDna = new System.Windows.Forms.Label();
            this.linkNajbitno = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTestDna = new System.Windows.Forms.Label();
            this.labelTestRna = new System.Windows.Forms.Label();
            this.labelDnaVsRnaTest = new System.Windows.Forms.Label();
            this.panelTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Transparent;
            this.panelHome.Location = new System.Drawing.Point(-1, 64);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1006, 440);
            this.panelHome.TabIndex = 0;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.Location = new System.Drawing.Point(13, 13);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 23);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panelMaterials
            // 
            this.panelMaterials.BackColor = System.Drawing.Color.Transparent;
            this.panelMaterials.Location = new System.Drawing.Point(-1, 64);
            this.panelMaterials.Name = "panelMaterials";
            this.panelMaterials.Size = new System.Drawing.Size(1006, 437);
            this.panelMaterials.TabIndex = 2;
            this.panelMaterials.Visible = false;
            // 
            // materialsBtn
            // 
            this.materialsBtn.BackColor = System.Drawing.Color.Transparent;
            this.materialsBtn.Location = new System.Drawing.Point(94, 13);
            this.materialsBtn.Name = "materialsBtn";
            this.materialsBtn.Size = new System.Drawing.Size(75, 23);
            this.materialsBtn.TabIndex = 3;
            this.materialsBtn.Text = "Materials";
            this.materialsBtn.UseVisualStyleBackColor = false;
            this.materialsBtn.Click += new System.EventHandler(this.materialsBtn_Click);
            // 
            // testsBtn
            // 
            this.testsBtn.BackColor = System.Drawing.Color.Transparent;
            this.testsBtn.Location = new System.Drawing.Point(175, 13);
            this.testsBtn.Name = "testsBtn";
            this.testsBtn.Size = new System.Drawing.Size(75, 23);
            this.testsBtn.TabIndex = 4;
            this.testsBtn.Text = "Tests";
            this.testsBtn.UseVisualStyleBackColor = false;
            this.testsBtn.Click += new System.EventHandler(this.testsBtn_Click);
            // 
            // panelTests
            // 
            this.panelTests.BackColor = System.Drawing.Color.Transparent;
            this.panelTests.Controls.Add(this.labelDnaVsRnaTest);
            this.panelTests.Controls.Add(this.labelTestRna);
            this.panelTests.Controls.Add(this.labelTestDna);
            this.panelTests.Controls.Add(this.linkDnaRnaWatson);
            this.panelTests.Controls.Add(this.linkGenomeSeq);
            this.panelTests.Controls.Add(this.linkDnaAdd);
            this.panelTests.Controls.Add(this.linkDnaRnaBook);
            this.panelTests.Controls.Add(this.linkDnaVsRna);
            this.panelTests.Controls.Add(this.linkRnaDetail);
            this.panelTests.Controls.Add(this.linkRna);
            this.panelTests.Controls.Add(this.linkGenomes);
            this.panelTests.Controls.Add(this.linkDnaNotes);
            this.panelTests.Controls.Add(this.labelAddtional);
            this.panelTests.Controls.Add(this.labelRnaDna);
            this.panelTests.Controls.Add(this.labelRna);
            this.panelTests.Controls.Add(this.labelDna);
            this.panelTests.Controls.Add(this.linkNajbitno);
            this.panelTests.Controls.Add(this.label1);
            this.panelTests.Location = new System.Drawing.Point(-1, 64);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(1006, 437);
            this.panelTests.TabIndex = 5;
            this.panelTests.Visible = false;
            // 
            // linkDnaRnaWatson
            // 
            this.linkDnaRnaWatson.AutoSize = true;
            this.linkDnaRnaWatson.Location = new System.Drawing.Point(16, 355);
            this.linkDnaRnaWatson.Name = "linkDnaRnaWatson";
            this.linkDnaRnaWatson.Size = new System.Drawing.Size(77, 13);
            this.linkDnaRnaWatson.TabIndex = 15;
            this.linkDnaRnaWatson.TabStop = true;
            this.linkDnaRnaWatson.Text = "DNA and RNA";
            this.linkDnaRnaWatson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDnaRnaWatson_LinkClicked);
            // 
            // linkGenomeSeq
            // 
            this.linkGenomeSeq.AutoSize = true;
            this.linkGenomeSeq.Location = new System.Drawing.Point(16, 329);
            this.linkGenomeSeq.Name = "linkGenomeSeq";
            this.linkGenomeSeq.Size = new System.Drawing.Size(105, 13);
            this.linkGenomeSeq.TabIndex = 14;
            this.linkGenomeSeq.TabStop = true;
            this.linkGenomeSeq.Text = "Genome sequencing";
            this.linkGenomeSeq.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGenomeSeq_LinkClicked);
            // 
            // linkDnaAdd
            // 
            this.linkDnaAdd.AutoSize = true;
            this.linkDnaAdd.Location = new System.Drawing.Point(16, 305);
            this.linkDnaAdd.Name = "linkDnaAdd";
            this.linkDnaAdd.Size = new System.Drawing.Size(119, 13);
            this.linkDnaAdd.TabIndex = 13;
            this.linkDnaAdd.TabStop = true;
            this.linkDnaAdd.Text = "DNA Additional Material";
            this.linkDnaAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDnaAdd_LinkClicked);
            // 
            // linkDnaRnaBook
            // 
            this.linkDnaRnaBook.AutoSize = true;
            this.linkDnaRnaBook.Location = new System.Drawing.Point(16, 248);
            this.linkDnaRnaBook.Name = "linkDnaRnaBook";
            this.linkDnaRnaBook.Size = new System.Drawing.Size(134, 13);
            this.linkDnaRnaBook.TabIndex = 12;
            this.linkDnaRnaBook.TabStop = true;
            this.linkDnaRnaBook.Text = "DNA and RNA comparison";
            this.linkDnaRnaBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDnaRnaBook_LinkClicked);
            // 
            // linkDnaVsRna
            // 
            this.linkDnaVsRna.AutoSize = true;
            this.linkDnaVsRna.Location = new System.Drawing.Point(16, 223);
            this.linkDnaVsRna.Name = "linkDnaVsRna";
            this.linkDnaVsRna.Size = new System.Drawing.Size(70, 13);
            this.linkDnaVsRna.TabIndex = 11;
            this.linkDnaVsRna.TabStop = true;
            this.linkDnaVsRna.Text = "DNA vs RNA";
            this.linkDnaVsRna.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDnaVsRna_LinkClicked);
            // 
            // linkRnaDetail
            // 
            this.linkRnaDetail.AutoSize = true;
            this.linkRnaDetail.Location = new System.Drawing.Point(16, 146);
            this.linkRnaDetail.Name = "linkRnaDetail";
            this.linkRnaDetail.Size = new System.Drawing.Size(70, 13);
            this.linkRnaDetail.TabIndex = 10;
            this.linkRnaDetail.TabStop = true;
            this.linkRnaDetail.Text = "RNA detailed";
            this.linkRnaDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRnaDetail_LinkClicked);
            // 
            // linkRna
            // 
            this.linkRna.AutoSize = true;
            this.linkRna.Location = new System.Drawing.Point(16, 122);
            this.linkRna.Name = "linkRna";
            this.linkRna.Size = new System.Drawing.Size(63, 13);
            this.linkRna.TabIndex = 9;
            this.linkRna.TabStop = true;
            this.linkRna.Text = "RNA basics";
            this.linkRna.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRna_LinkClicked);
            // 
            // linkGenomes
            // 
            this.linkGenomes.AutoSize = true;
            this.linkGenomes.Location = new System.Drawing.Point(16, 64);
            this.linkGenomes.Name = "linkGenomes";
            this.linkGenomes.Size = new System.Drawing.Size(99, 13);
            this.linkGenomes.TabIndex = 8;
            this.linkGenomes.TabStop = true;
            this.linkGenomes.Text = "DNA and Genomes";
            this.linkGenomes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGenomes_LinkClicked);
            // 
            // linkDnaNotes
            // 
            this.linkDnaNotes.AutoSize = true;
            this.linkDnaNotes.Location = new System.Drawing.Point(16, 42);
            this.linkDnaNotes.Name = "linkDnaNotes";
            this.linkDnaNotes.Size = new System.Drawing.Size(59, 13);
            this.linkDnaNotes.TabIndex = 7;
            this.linkDnaNotes.TabStop = true;
            this.linkDnaNotes.Text = "DNA notes";
            this.linkDnaNotes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDnaNotes_LinkClicked);
            // 
            // labelAddtional
            // 
            this.labelAddtional.AutoSize = true;
            this.labelAddtional.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddtional.Location = new System.Drawing.Point(13, 273);
            this.labelAddtional.Name = "labelAddtional";
            this.labelAddtional.Size = new System.Drawing.Size(251, 32);
            this.labelAddtional.TabIndex = 6;
            this.labelAddtional.Text = "Additional materials";
            // 
            // labelRnaDna
            // 
            this.labelRnaDna.AutoSize = true;
            this.labelRnaDna.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRnaDna.Location = new System.Drawing.Point(13, 168);
            this.labelRnaDna.Name = "labelRnaDna";
            this.labelRnaDna.Size = new System.Drawing.Size(451, 32);
            this.labelRnaDna.TabIndex = 5;
            this.labelRnaDna.Text = "Comparison between DNA and RNA";
            // 
            // labelRna
            // 
            this.labelRna.AutoSize = true;
            this.labelRna.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRna.Location = new System.Drawing.Point(13, 90);
            this.labelRna.Name = "labelRna";
            this.labelRna.Size = new System.Drawing.Size(72, 32);
            this.labelRna.TabIndex = 4;
            this.labelRna.Text = "RNA";
            // 
            // labelDna
            // 
            this.labelDna.AutoSize = true;
            this.labelDna.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDna.Location = new System.Drawing.Point(13, 0);
            this.labelDna.Name = "labelDna";
            this.labelDna.Size = new System.Drawing.Size(75, 32);
            this.labelDna.TabIndex = 3;
            this.labelDna.Text = "DNA";
            // 
            // linkNajbitno
            // 
            this.linkNajbitno.AutoSize = true;
            this.linkNajbitno.Location = new System.Drawing.Point(16, 200);
            this.linkNajbitno.Name = "linkNajbitno";
            this.linkNajbitno.Size = new System.Drawing.Size(110, 13);
            this.linkNajbitno.TabIndex = 2;
            this.linkNajbitno.TabStop = true;
            this.linkNajbitno.Text = "DNA and RNA basics";
            this.linkNajbitno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNajbitno_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 236);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // labelTestDna
            // 
            this.labelTestDna.AutoSize = true;
            this.labelTestDna.BackColor = System.Drawing.Color.White;
            this.labelTestDna.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTestDna.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestDna.ForeColor = System.Drawing.Color.Coral;
            this.labelTestDna.Location = new System.Drawing.Point(13, 0);
            this.labelTestDna.Name = "labelTestDna";
            this.labelTestDna.Size = new System.Drawing.Size(174, 34);
            this.labelTestDna.TabIndex = 16;
            this.labelTestDna.Text = "Test for DNA";
            // 
            // labelTestRna
            // 
            this.labelTestRna.AutoSize = true;
            this.labelTestRna.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestRna.ForeColor = System.Drawing.Color.Maroon;
            this.labelTestRna.Location = new System.Drawing.Point(13, 106);
            this.labelTestRna.Name = "labelTestRna";
            this.labelTestRna.Size = new System.Drawing.Size(169, 32);
            this.labelTestRna.TabIndex = 17;
            this.labelTestRna.Text = "Test for RNA";
            // 
            // labelDnaVsRnaTest
            // 
            this.labelDnaVsRnaTest.AutoSize = true;
            this.labelDnaVsRnaTest.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDnaVsRnaTest.ForeColor = System.Drawing.Color.Maroon;
            this.labelDnaVsRnaTest.Location = new System.Drawing.Point(13, 213);
            this.labelDnaVsRnaTest.Name = "labelDnaVsRnaTest";
            this.labelDnaVsRnaTest.Size = new System.Drawing.Size(421, 32);
            this.labelDnaVsRnaTest.TabIndex = 18;
            this.labelDnaVsRnaTest.Text = "Test for DNA vs. RNA comparison";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::KorisnickiProekt.Properties.Resources.DNA_Strand;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 501);
            this.Controls.Add(this.panelTests);
            this.Controls.Add(this.testsBtn);
            this.Controls.Add(this.materialsBtn);
            this.Controls.Add(this.panelMaterials);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.panelHome);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTests.ResumeLayout(false);
            this.panelTests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelMaterials;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button materialsBtn;
        private System.Windows.Forms.Button testsBtn;
        private System.Windows.Forms.Panel panelTests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkNajbitno;
        private System.Windows.Forms.Label labelAddtional;
        private System.Windows.Forms.Label labelRnaDna;
        private System.Windows.Forms.Label labelRna;
        private System.Windows.Forms.Label labelDna;
        private System.Windows.Forms.LinkLabel linkDnaNotes;
        private System.Windows.Forms.LinkLabel linkGenomes;
        private System.Windows.Forms.LinkLabel linkRna;
        private System.Windows.Forms.LinkLabel linkRnaDetail;
        private System.Windows.Forms.LinkLabel linkDnaVsRna;
        private System.Windows.Forms.LinkLabel linkDnaRnaBook;
        private System.Windows.Forms.LinkLabel linkDnaAdd;
        private System.Windows.Forms.LinkLabel linkGenomeSeq;
        private System.Windows.Forms.LinkLabel linkDnaRnaWatson;
        private System.Windows.Forms.Label labelDnaVsRnaTest;
        private System.Windows.Forms.Label labelTestRna;
        private System.Windows.Forms.Label labelTestDna;
    }
}

