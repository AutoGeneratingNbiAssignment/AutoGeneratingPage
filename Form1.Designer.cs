
namespace AutoGeneratingPage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWithLink = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.checkBoxBtnLink = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnWithLink
            // 
            this.btnWithLink.Location = new System.Drawing.Point(26, 377);
            this.btnWithLink.Name = "btnWithLink";
            this.btnWithLink.Size = new System.Drawing.Size(98, 35);
            this.btnWithLink.TabIndex = 0;
            this.btnWithLink.Text = "text";
            this.btnWithLink.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(506, 383);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(94, 29);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(635, 383);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(353, 383);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(94, 29);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // checkBoxBtnLink
            // 
            this.checkBoxBtnLink.AutoSize = true;
            this.checkBoxBtnLink.Location = new System.Drawing.Point(26, 337);
            this.checkBoxBtnLink.Name = "checkBoxBtnLink";
            this.checkBoxBtnLink.Size = new System.Drawing.Size(141, 24);
            this.checkBoxBtnLink.TabIndex = 5;
            this.checkBoxBtnLink.Text = "Button with link?";
            this.checkBoxBtnLink.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.bannerCheckBox = new System.Windows.Forms.CheckBox();
            this.ctaFirstBtnText = new System.Windows.Forms.TextBox();
            this.ctaScndBtnText = new System.Windows.Forms.TextBox();
            this.ctaThrdBtnText = new System.Windows.Forms.TextBox();
            this.bannerAddPicture = new System.Windows.Forms.Button();
            this.dropDownTxtPos = new System.Windows.Forms.ComboBox();
            this.scrllBannerLabel = new System.Windows.Forms.Label();
            this.ctaBtnsLabel = new System.Windows.Forms.Label();
            this.txtWithImagePos = new System.Windows.Forms.Label();
            this.imgText = new System.Windows.Forms.TextBox();
            this.pictureBoxMiddle = new System.Windows.Forms.PictureBox();
            this.browsePicLeftOrRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddle)).BeginInit();
            this.SuspendLayout();
            // 
            // bannerCheckBox
            // 
            this.bannerCheckBox.AutoSize = true;
            this.bannerCheckBox.Location = new System.Drawing.Point(50, 157);
            this.bannerCheckBox.Name = "bannerCheckBox";
            this.bannerCheckBox.Size = new System.Drawing.Size(15, 14);
            this.bannerCheckBox.TabIndex = 0;
            this.bannerCheckBox.UseVisualStyleBackColor = true;
            // 
            // ctaFirstBtnText
            // 
            this.ctaFirstBtnText.Location = new System.Drawing.Point(198, 164);
            this.ctaFirstBtnText.Multiline = true;
            this.ctaFirstBtnText.Name = "ctaFirstBtnText";
            this.ctaFirstBtnText.Size = new System.Drawing.Size(118, 34);
            this.ctaFirstBtnText.TabIndex = 3;
            this.ctaFirstBtnText.Text = "Write Your Text Here";
            // 
            // ctaScndBtnText
            // 
            this.ctaScndBtnText.Location = new System.Drawing.Point(198, 205);
            this.ctaScndBtnText.Multiline = true;
            this.ctaScndBtnText.Name = "ctaScndBtnText";
            this.ctaScndBtnText.Size = new System.Drawing.Size(118, 34);
            this.ctaScndBtnText.TabIndex = 4;
            this.ctaScndBtnText.Text = "Write Your Text Here";
            // 
            // ctaThrdBtnText
            // 
            this.ctaThrdBtnText.Location = new System.Drawing.Point(198, 247);
            this.ctaThrdBtnText.Multiline = true;
            this.ctaThrdBtnText.Name = "ctaThrdBtnText";
            this.ctaThrdBtnText.Size = new System.Drawing.Size(118, 34);
            this.ctaThrdBtnText.TabIndex = 5;
            this.ctaThrdBtnText.Text = "Write Your Text Here";
            // 
            // bannerAddPicture
            // 
            this.bannerAddPicture.ForeColor = System.Drawing.Color.Blue;
            this.bannerAddPicture.Location = new System.Drawing.Point(21, 177);
            this.bannerAddPicture.Name = "bannerAddPicture";
            this.bannerAddPicture.Size = new System.Drawing.Size(75, 23);
            this.bannerAddPicture.TabIndex = 6;
            this.bannerAddPicture.Text = "Browse";
            this.bannerAddPicture.UseVisualStyleBackColor = true;
            // 
            // dropDownTxtPos
            // 
            this.dropDownTxtPos.FormattingEnabled = true;
            this.dropDownTxtPos.Location = new System.Drawing.Point(427, 157);
            this.dropDownTxtPos.Name = "dropDownTxtPos";
            this.dropDownTxtPos.Size = new System.Drawing.Size(121, 23);
            this.dropDownTxtPos.TabIndex = 7;
            // 
            // scrllBannerLabel
            // 
            this.scrllBannerLabel.AutoSize = true;
            this.scrllBannerLabel.Location = new System.Drawing.Point(12, 128);
            this.scrllBannerLabel.Name = "scrllBannerLabel";
            this.scrllBannerLabel.Size = new System.Drawing.Size(93, 15);
            this.scrllBannerLabel.TabIndex = 9;
            this.scrllBannerLabel.Text = "Scrolling Banner";
            this.scrllBannerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ctaBtnsLabel
            // 
            this.ctaBtnsLabel.AutoSize = true;
            this.ctaBtnsLabel.Location = new System.Drawing.Point(198, 128);
            this.ctaBtnsLabel.Name = "ctaBtnsLabel";
            this.ctaBtnsLabel.Size = new System.Drawing.Size(72, 15);
            this.ctaBtnsLabel.TabIndex = 10;
            this.ctaBtnsLabel.Text = "CTA Buttons";
            // 
            // txtWithImagePos
            // 
            this.txtWithImagePos.AutoSize = true;
            this.txtWithImagePos.Location = new System.Drawing.Point(427, 128);
            this.txtWithImagePos.Name = "txtWithImagePos";
            this.txtWithImagePos.Size = new System.Drawing.Size(163, 15);
            this.txtWithImagePos.TabIndex = 11;
            this.txtWithImagePos.Text = "Text With Image And Position";
            // 
            // imgText
            // 
            this.imgText.Location = new System.Drawing.Point(427, 193);
            this.imgText.Multiline = true;
            this.imgText.Name = "imgText";
            this.imgText.Size = new System.Drawing.Size(242, 88);
            this.imgText.TabIndex = 12;
            this.imgText.Text = "Write your text here";
            // 
            // pictureBoxMiddle
            // 
            this.pictureBoxMiddle.Location = new System.Drawing.Point(688, 193);
            this.pictureBoxMiddle.Name = "pictureBoxMiddle";
            this.pictureBoxMiddle.Size = new System.Drawing.Size(100, 88);
            this.pictureBoxMiddle.TabIndex = 13;
            this.pictureBoxMiddle.TabStop = false;
            // 
            // button1
            // 
            this.browsePicLeftOrRight.ForeColor = System.Drawing.Color.Blue;
            this.browsePicLeftOrRight.Location = new System.Drawing.Point(701, 287);
            this.browsePicLeftOrRight.Name = "button1";
            this.browsePicLeftOrRight.Size = new System.Drawing.Size(75, 23);
            this.browsePicLeftOrRight.TabIndex = 14;
            this.browsePicLeftOrRight.Text = "Browse";
            this.browsePicLeftOrRight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxBtnLink);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnWithLink);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.Add(this.browsePicLeftOrRight);
            this.Controls.Add(this.pictureBoxMiddle);
            this.Controls.Add(this.imgText);
            this.Controls.Add(this.txtWithImagePos);
            this.Controls.Add(this.ctaBtnsLabel);
            this.Controls.Add(this.scrllBannerLabel);
            this.Controls.Add(this.dropDownTxtPos);
            this.Controls.Add(this.bannerAddPicture);
            this.Controls.Add(this.ctaThrdBtnText);
            this.Controls.Add(this.ctaScndBtnText);
            this.Controls.Add(this.ctaFirstBtnText);
            this.Controls.Add(this.bannerCheckBox);
            this.Name = "Form1";
            this.Text = "Page Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithLink;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox checkBoxBtnLink;

        private System.Windows.Forms.CheckBox bannerCheckBox;
        private System.Windows.Forms.TextBox ctaFirstBtnText;
        private System.Windows.Forms.TextBox ctaScndBtnText;
        private System.Windows.Forms.TextBox ctaThrdBtnText;
        private System.Windows.Forms.Button bannerAddPicture;
        private System.Windows.Forms.ComboBox dropDownTxtPos;
        private System.Windows.Forms.Label scrllBannerLabel;
        private System.Windows.Forms.Label ctaBtnsLabel;
        private System.Windows.Forms.Label txtWithImagePos;
        private System.Windows.Forms.TextBox imgText;
        private System.Windows.Forms.PictureBox pictureBoxMiddle;
        private System.Windows.Forms.Button browsePicLeftOrRight;
    }
}

