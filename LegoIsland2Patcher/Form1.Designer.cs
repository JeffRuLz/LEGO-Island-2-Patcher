namespace LegoIsland2Patcher
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
            System.Windows.Forms.LinkLabel linkLabel1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbForce = new System.Windows.Forms.CheckBox();
            this.cbLevelSelect = new System.Windows.Forms.CheckBox();
            this.cbWindowedMode = new System.Windows.Forms.CheckBox();
            this.cbLoadTimes = new System.Windows.Forms.CheckBox();
            this.cbNoIntro = new System.Windows.Forms.CheckBox();
            this.cbSiliconLogo = new System.Windows.Forms.CheckBox();
            this.cbLegoLogo = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLegoSkippable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cbUnskippableSilicon = new System.Windows.Forms.CheckBox();
            this.cbUnskippableIntro = new System.Windows.Forms.CheckBox();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbForce);
            this.groupBox1.Controls.Add(this.cbLevelSelect);
            this.groupBox1.Controls.Add(this.cbWindowedMode);
            this.groupBox1.Controls.Add(this.cbLoadTimes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patches";
            // 
            // cbForce
            // 
            this.cbForce.AutoSize = true;
            this.cbForce.Location = new System.Drawing.Point(7, 89);
            this.cbForce.Name = "cbForce";
            this.cbForce.Size = new System.Drawing.Size(153, 17);
            this.cbForce.TabIndex = 3;
            this.cbForce.Text = "Force /force command line";
            this.cbForce.UseVisualStyleBackColor = true;
            // 
            // cbLevelSelect
            // 
            this.cbLevelSelect.AutoSize = true;
            this.cbLevelSelect.Location = new System.Drawing.Point(7, 66);
            this.cbLevelSelect.Name = "cbLevelSelect";
            this.cbLevelSelect.Size = new System.Drawing.Size(188, 17);
            this.cbLevelSelect.TabIndex = 2;
            this.cbLevelSelect.Text = "Replace Credits With Level Select";
            this.cbLevelSelect.UseVisualStyleBackColor = true;
            // 
            // cbWindowedMode
            // 
            this.cbWindowedMode.AutoSize = true;
            this.cbWindowedMode.Location = new System.Drawing.Point(7, 43);
            this.cbWindowedMode.Name = "cbWindowedMode";
            this.cbWindowedMode.Size = new System.Drawing.Size(107, 17);
            this.cbWindowedMode.TabIndex = 1;
            this.cbWindowedMode.Text = "Windowed Mode";
            this.cbWindowedMode.UseVisualStyleBackColor = true;
            // 
            // cbLoadTimes
            // 
            this.cbLoadTimes.AutoSize = true;
            this.cbLoadTimes.Location = new System.Drawing.Point(7, 20);
            this.cbLoadTimes.Name = "cbLoadTimes";
            this.cbLoadTimes.Size = new System.Drawing.Size(92, 17);
            this.cbLoadTimes.TabIndex = 0;
            this.cbLoadTimes.Text = "Load Time Fix";
            this.cbLoadTimes.UseVisualStyleBackColor = true;
            // 
            // cbNoIntro
            // 
            this.cbNoIntro.AutoSize = true;
            this.cbNoIntro.Location = new System.Drawing.Point(6, 112);
            this.cbNoIntro.Name = "cbNoIntro";
            this.cbNoIntro.Size = new System.Drawing.Size(94, 17);
            this.cbNoIntro.TabIndex = 3;
            this.cbNoIntro.Text = "No Intro Video";
            this.cbNoIntro.UseVisualStyleBackColor = true;
            // 
            // cbSiliconLogo
            // 
            this.cbSiliconLogo.AutoSize = true;
            this.cbSiliconLogo.Location = new System.Drawing.Point(6, 66);
            this.cbSiliconLogo.Name = "cbSiliconLogo";
            this.cbSiliconLogo.Size = new System.Drawing.Size(140, 17);
            this.cbSiliconLogo.TabIndex = 2;
            this.cbSiliconLogo.Text = "No Silicon Dreams Logo";
            this.cbSiliconLogo.UseVisualStyleBackColor = true;
            // 
            // cbLegoLogo
            // 
            this.cbLegoLogo.AutoSize = true;
            this.cbLegoLogo.Location = new System.Drawing.Point(6, 20);
            this.cbLegoLogo.Name = "cbLegoLogo";
            this.cbLegoLogo.Size = new System.Drawing.Size(144, 17);
            this.cbLegoLogo.TabIndex = 0;
            this.cbLegoLogo.Text = "No LEGO Software Logo";
            this.cbLegoLogo.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 299);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUnskippableIntro);
            this.groupBox2.Controls.Add(this.cbUnskippableSilicon);
            this.groupBox2.Controls.Add(this.cbLegoSkippable);
            this.groupBox2.Controls.Add(this.cbLegoLogo);
            this.groupBox2.Controls.Add(this.cbSiliconLogo);
            this.groupBox2.Controls.Add(this.cbNoIntro);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intro";
            // 
            // cbLegoSkippable
            // 
            this.cbLegoSkippable.AutoSize = true;
            this.cbLegoSkippable.Location = new System.Drawing.Point(6, 43);
            this.cbLegoSkippable.Name = "cbLegoSkippable";
            this.cbLegoSkippable.Size = new System.Drawing.Size(207, 17);
            this.cbLegoSkippable.TabIndex = 1;
            this.cbLegoSkippable.Text = "Make LEGO Software Logo Skippable";
            this.cbLegoSkippable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lego Island 2 Patcher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Credits:\r\nIran: Research and discovery\r\nMumboking: HEX offsets\r\nJeffRuLz: Patcher" +
    " creator";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(242, 280);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(138, 13);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "www.rockraidersunited.com";
            linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "Note: Some patches may\r\nnot be compatible with\r\nevery revision of\r\nLego Island 2";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(133, 304);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(247, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "www.github.com/JeffRuLz/LEGO-Island-2-Patcher";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cbUnskippableSilicon
            // 
            this.cbUnskippableSilicon.AutoSize = true;
            this.cbUnskippableSilicon.Location = new System.Drawing.Point(6, 89);
            this.cbUnskippableSilicon.Name = "cbUnskippableSilicon";
            this.cbUnskippableSilicon.Size = new System.Drawing.Size(185, 17);
            this.cbUnskippableSilicon.TabIndex = 4;
            this.cbUnskippableSilicon.Text = "Unskippable Silicon Dreams Logo";
            this.cbUnskippableSilicon.UseVisualStyleBackColor = true;
            // 
            // cbUnskippableIntro
            // 
            this.cbUnskippableIntro.AutoSize = true;
            this.cbUnskippableIntro.Location = new System.Drawing.Point(6, 135);
            this.cbUnskippableIntro.Name = "cbUnskippableIntro";
            this.cbUnskippableIntro.Size = new System.Drawing.Size(139, 17);
            this.cbUnskippableIntro.TabIndex = 5;
            this.cbUnskippableIntro.Text = "Unskippable Intro Video";
            this.cbUnskippableIntro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 332);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lego Island 2 Patcher (v1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbForce;
        private System.Windows.Forms.CheckBox cbLevelSelect;
        private System.Windows.Forms.CheckBox cbWindowedMode;
        private System.Windows.Forms.CheckBox cbNoIntro;
        private System.Windows.Forms.CheckBox cbSiliconLogo;
        private System.Windows.Forms.CheckBox cbLegoLogo;
        private System.Windows.Forms.CheckBox cbLoadTimes;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbLegoSkippable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox cbUnskippableIntro;
        private System.Windows.Forms.CheckBox cbUnskippableSilicon;
    }
}

