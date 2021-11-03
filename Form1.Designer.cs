
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
            this.sectionNameInputBox = new System.Windows.Forms.TextBox();
            this.sectionNameLabel = new System.Windows.Forms.Label();
            this.sectionTitleLable = new System.Windows.Forms.Label();
            this.sectionTitleInputBox = new System.Windows.Forms.TextBox();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.backgroundColorLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.browseImageButton = new System.Windows.Forms.Button();
            this.fontStyleLabel = new System.Windows.Forms.Label();
            this.fontStyleMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontSizeInputBox = new System.Windows.Forms.TextBox();
            this.fontColorLabel = new System.Windows.Forms.Label();
            this.fontColorPaletteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sectionNameInputBox
            // 
            this.sectionNameInputBox.Location = new System.Drawing.Point(234, 36);
            this.sectionNameInputBox.Name = "sectionNameInputBox";
            this.sectionNameInputBox.Size = new System.Drawing.Size(150, 31);
            this.sectionNameInputBox.TabIndex = 0;
            this.sectionNameInputBox.TextChanged += new System.EventHandler(this.sectionNameBox_TextChanged);
            // 
            // sectionNameLabel
            // 
            this.sectionNameLabel.AutoSize = true;
            this.sectionNameLabel.Location = new System.Drawing.Point(235, 8);
            this.sectionNameLabel.Name = "sectionNameLabel";
            this.sectionNameLabel.Size = new System.Drawing.Size(122, 25);
            this.sectionNameLabel.TabIndex = 1;
            this.sectionNameLabel.Text = "Section Name";
            // 
            // sectionTitleLable
            // 
            this.sectionTitleLable.AutoSize = true;
            this.sectionTitleLable.Location = new System.Drawing.Point(26, 9);
            this.sectionTitleLable.Name = "sectionTitleLable";
            this.sectionTitleLable.Size = new System.Drawing.Size(107, 25);
            this.sectionTitleLable.TabIndex = 3;
            this.sectionTitleLable.Text = "Section Title";
            this.sectionTitleLable.Click += new System.EventHandler(this.label2_Click);
            // 
            // sectionTitleInputBox
            // 
            this.sectionTitleInputBox.Location = new System.Drawing.Point(26, 36);
            this.sectionTitleInputBox.Name = "sectionTitleInputBox";
            this.sectionTitleInputBox.Size = new System.Drawing.Size(150, 31);
            this.sectionTitleInputBox.TabIndex = 2;
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.BackColor = System.Drawing.Color.White;
            this.backgroundColorButton.Location = new System.Drawing.Point(189, 96);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(34, 34);
            this.backgroundColorButton.TabIndex = 5;
            this.backgroundColorButton.UseVisualStyleBackColor = false;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // backgroundColorLabel
            // 
            this.backgroundColorLabel.AutoSize = true;
            this.backgroundColorLabel.Location = new System.Drawing.Point(23, 101);
            this.backgroundColorLabel.Name = "backgroundColorLabel";
            this.backgroundColorLabel.Size = new System.Drawing.Size(155, 25);
            this.backgroundColorLabel.TabIndex = 6;
            this.backgroundColorLabel.Text = "Background Color";
            this.backgroundColorLabel.Click += new System.EventHandler(this.backgroundColorLabel_Click);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(236, 101);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(62, 25);
            this.imageLabel.TabIndex = 8;
            this.imageLabel.Text = "Image";
            this.imageLabel.Click += new System.EventHandler(this.imageLabel_Click);
            // 
            // browseImageButton
            // 
            this.browseImageButton.BackColor = System.Drawing.Color.Gainsboro;
            this.browseImageButton.Location = new System.Drawing.Point(308, 96);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(78, 34);
            this.browseImageButton.TabIndex = 7;
            this.browseImageButton.Text = "Browse";
            this.browseImageButton.UseVisualStyleBackColor = false;
            this.browseImageButton.Click += new System.EventHandler(this.browseImageButton_Click);
            // 
            // fontStyleLabel
            // 
            this.fontStyleLabel.AutoSize = true;
            this.fontStyleLabel.Location = new System.Drawing.Point(417, 69);
            this.fontStyleLabel.Name = "fontStyleLabel";
            this.fontStyleLabel.Size = new System.Drawing.Size(90, 25);
            this.fontStyleLabel.TabIndex = 9;
            this.fontStyleLabel.Text = "Font Style";
            this.fontStyleLabel.Click += new System.EventHandler(this.fontStyleLabel_Click);
            // 
            // fontStyleMenu
            // 
            this.fontStyleMenu.FormattingEnabled = true;
            this.fontStyleMenu.Location = new System.Drawing.Point(417, 97);
            this.fontStyleMenu.Name = "fontStyleMenu";
            this.fontStyleMenu.Size = new System.Drawing.Size(182, 33);
            this.fontStyleMenu.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Font Size";
            // 
            // fontSizeInputBox
            // 
            this.fontSizeInputBox.Location = new System.Drawing.Point(605, 98);
            this.fontSizeInputBox.Name = "fontSizeInputBox";
            this.fontSizeInputBox.Size = new System.Drawing.Size(100, 31);
            this.fontSizeInputBox.TabIndex = 11;
            // 
            // fontColorLabel
            // 
            this.fontColorLabel.AutoSize = true;
            this.fontColorLabel.Location = new System.Drawing.Point(724, 101);
            this.fontColorLabel.Name = "fontColorLabel";
            this.fontColorLabel.Size = new System.Drawing.Size(96, 25);
            this.fontColorLabel.TabIndex = 14;
            this.fontColorLabel.Text = "Font Color";
            this.fontColorLabel.Click += new System.EventHandler(this.fontColorLabel_Click);
            // 
            // fontColorPaletteButton
            // 
            this.fontColorPaletteButton.BackColor = System.Drawing.Color.White;
            this.fontColorPaletteButton.Location = new System.Drawing.Point(826, 98);
            this.fontColorPaletteButton.Name = "fontColorPaletteButton";
            this.fontColorPaletteButton.Size = new System.Drawing.Size(34, 34);
            this.fontColorPaletteButton.TabIndex = 13;
            this.fontColorPaletteButton.UseVisualStyleBackColor = false;
            this.fontColorPaletteButton.Click += new System.EventHandler(this.fontColorPaletteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
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
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.fontColorLabel);
            this.Controls.Add(this.fontColorPaletteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fontSizeInputBox);
            this.Controls.Add(this.fontStyleMenu);
            this.Controls.Add(this.fontStyleLabel);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.browseImageButton);
            this.Controls.Add(this.backgroundColorLabel);
            this.Controls.Add(this.backgroundColorButton);
            this.Controls.Add(this.sectionTitleLable);
            this.Controls.Add(this.sectionTitleInputBox);
            this.Controls.Add(this.sectionNameLabel);
            this.Controls.Add(this.sectionNameInputBox);
            this.Name = "Form1";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxBtnLink);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnWithLink);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private System.Windows.Forms.TextBox sectionNameInputBox;
        private System.Windows.Forms.Label sectionNameLabel;
        private System.Windows.Forms.Label sectionTitleLable;
        private System.Windows.Forms.TextBox sectionTitleInputBox;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Label backgroundColorLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Button browseImageButton;
        private System.Windows.Forms.Label fontStyleLabel;
        private System.Windows.Forms.ComboBox fontStyleMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fontSizeInputBox;
        private System.Windows.Forms.Label fontColorLabel;
        private System.Windows.Forms.Button fontColorPaletteButton;

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

