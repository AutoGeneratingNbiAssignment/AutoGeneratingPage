
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
			this.SectionTitleInputBox = new System.Windows.Forms.TextBox();
			this.BackgroundColorButton = new System.Windows.Forms.Button();
			this.backgroundColorLabel = new System.Windows.Forms.Label();
			this.ImageLabel = new System.Windows.Forms.Label();
			this.browseImageButton = new System.Windows.Forms.Button();
			this.fontStyleLabel = new System.Windows.Forms.Label();
			this.fontStyleMenu = new System.Windows.Forms.ComboBox();
			this.FontSizeLabel = new System.Windows.Forms.Label();
			this.FontSizeInputBox = new System.Windows.Forms.TextBox();
			this.fontColorLabel = new System.Windows.Forms.Label();
			this.fontColorPaletteButton = new System.Windows.Forms.Button();
			this.BtnWithLink = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.BtnPreview = new System.Windows.Forms.Button();
			this.checkBoxBtnLink = new System.Windows.Forms.CheckBox();
			this.bannerCheckBox = new System.Windows.Forms.CheckBox();
			this.ctaFirstBtnText = new System.Windows.Forms.TextBox();
			this.ctaScndBtnText = new System.Windows.Forms.TextBox();
			this.ctaThrdBtnText = new System.Windows.Forms.TextBox();
			this.BannerAddPicture = new System.Windows.Forms.Button();
			this.dropDownTxtPos = new System.Windows.Forms.ComboBox();
			this.ScrllBannerLabel = new System.Windows.Forms.Label();
			this.ctaBtnsLabel = new System.Windows.Forms.Label();
			this.txtWithImagePos = new System.Windows.Forms.Label();
			this.imgText = new System.Windows.Forms.TextBox();
			this.pictureBoxMiddle = new System.Windows.Forms.PictureBox();
			this.browsePicLeftOrRight = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddle)).BeginInit();
			this.SuspendLayout();
			// 
			// sectionNameInputBox
			// 
			this.sectionNameInputBox.Location = new System.Drawing.Point(234, 36);
			this.sectionNameInputBox.Name = "sectionNameInputBox";
			this.sectionNameInputBox.Size = new System.Drawing.Size(150, 23);
			this.sectionNameInputBox.TabIndex = 0;
			this.sectionNameInputBox.TextChanged += new System.EventHandler(this.SectionNameInputBox_TextChanged);
			// 
			// sectionNameLabel
			// 
			this.sectionNameLabel.AutoSize = true;
			this.sectionNameLabel.Location = new System.Drawing.Point(235, 8);
			this.sectionNameLabel.Name = "sectionNameLabel";
			this.sectionNameLabel.Size = new System.Drawing.Size(81, 15);
			this.sectionNameLabel.TabIndex = 1;
			this.sectionNameLabel.Text = "Section Name";
			this.sectionNameLabel.Click += new System.EventHandler(this.SectionNameLabel_Click);
			// 
			// sectionTitleLable
			// 
			this.sectionTitleLable.AutoSize = true;
			this.sectionTitleLable.Location = new System.Drawing.Point(26, 9);
			this.sectionTitleLable.Name = "sectionTitleLable";
			this.sectionTitleLable.Size = new System.Drawing.Size(71, 15);
			this.sectionTitleLable.TabIndex = 3;
			this.sectionTitleLable.Text = "Section Title";
			this.sectionTitleLable.Click += new System.EventHandler(this.SectionTitleLable_Click);
			// 
			// SectionTitleInputBox
			// 
			this.SectionTitleInputBox.Location = new System.Drawing.Point(26, 36);
			this.SectionTitleInputBox.Name = "SectionTitleInputBox";
			this.SectionTitleInputBox.Size = new System.Drawing.Size(150, 23);
			this.SectionTitleInputBox.TabIndex = 2;
			this.SectionTitleInputBox.TextChanged += new System.EventHandler(this.SectionTitleInputBox_TextChanged);
			// 
			// BackgroundColorButton
			// 
			this.BackgroundColorButton.BackColor = System.Drawing.Color.White;
			this.BackgroundColorButton.Location = new System.Drawing.Point(189, 96);
			this.BackgroundColorButton.Name = "BackgroundColorButton";
			this.BackgroundColorButton.Size = new System.Drawing.Size(34, 34);
			this.BackgroundColorButton.TabIndex = 5;
			this.BackgroundColorButton.UseVisualStyleBackColor = false;
			this.BackgroundColorButton.Click += new System.EventHandler(this.BackgroundColorButton_Click);
			// 
			// backgroundColorLabel
			// 
			this.backgroundColorLabel.AutoSize = true;
			this.backgroundColorLabel.Location = new System.Drawing.Point(23, 101);
			this.backgroundColorLabel.Name = "backgroundColorLabel";
			this.backgroundColorLabel.Size = new System.Drawing.Size(103, 15);
			this.backgroundColorLabel.TabIndex = 6;
			this.backgroundColorLabel.Text = "Background Color";
			this.backgroundColorLabel.Click += new System.EventHandler(this.BackgroundColorLabel_Click);
			// 
			// ImageLabel
			// 
			this.ImageLabel.AutoSize = true;
			this.ImageLabel.Location = new System.Drawing.Point(236, 101);
			this.ImageLabel.Name = "ImageLabel";
			this.ImageLabel.Size = new System.Drawing.Size(40, 15);
			this.ImageLabel.TabIndex = 8;
			this.ImageLabel.Text = "Image";
			this.ImageLabel.Click += new System.EventHandler(this.ImageLabel_Click);
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
			this.browseImageButton.Click += new System.EventHandler(this.BrowseImageButton_Click);
			// 
			// fontStyleLabel
			// 
			this.fontStyleLabel.AutoSize = true;
			this.fontStyleLabel.Location = new System.Drawing.Point(417, 69);
			this.fontStyleLabel.Name = "fontStyleLabel";
			this.fontStyleLabel.Size = new System.Drawing.Size(59, 15);
			this.fontStyleLabel.TabIndex = 9;
			this.fontStyleLabel.Text = "Font Style";
			this.fontStyleLabel.Click += new System.EventHandler(this.FontStyleLabel_Click);
			// 
			// fontStyleMenu
			// 
			this.fontStyleMenu.FormattingEnabled = true;
			this.fontStyleMenu.Location = new System.Drawing.Point(417, 97);
			this.fontStyleMenu.Name = "fontStyleMenu";
			this.fontStyleMenu.Size = new System.Drawing.Size(182, 23);
			this.fontStyleMenu.TabIndex = 10;
			// 
			// FontSizeLabel
			// 
			this.FontSizeLabel.AutoSize = true;
			this.FontSizeLabel.Location = new System.Drawing.Point(605, 69);
			this.FontSizeLabel.Name = "FontSizeLabel";
			this.FontSizeLabel.Size = new System.Drawing.Size(54, 15);
			this.FontSizeLabel.TabIndex = 12;
			this.FontSizeLabel.Text = "Font Size";
			// 
			// FontSizeInputBox
			// 
			this.FontSizeInputBox.Location = new System.Drawing.Point(605, 98);
			this.FontSizeInputBox.Name = "FontSizeInputBox";
			this.FontSizeInputBox.Size = new System.Drawing.Size(100, 23);
			this.FontSizeInputBox.TabIndex = 11;
			// 
			// fontColorLabel
			// 
			this.fontColorLabel.AutoSize = true;
			this.fontColorLabel.Location = new System.Drawing.Point(724, 101);
			this.fontColorLabel.Name = "fontColorLabel";
			this.fontColorLabel.Size = new System.Drawing.Size(63, 15);
			this.fontColorLabel.TabIndex = 14;
			this.fontColorLabel.Text = "Font Color";
			this.fontColorLabel.Click += new System.EventHandler(this.FontColorLabel_Click);
			// 
			// fontColorPaletteButton
			// 
			this.fontColorPaletteButton.BackColor = System.Drawing.Color.White;
			this.fontColorPaletteButton.Location = new System.Drawing.Point(826, 98);
			this.fontColorPaletteButton.Name = "fontColorPaletteButton";
			this.fontColorPaletteButton.Size = new System.Drawing.Size(34, 34);
			this.fontColorPaletteButton.TabIndex = 13;
			this.fontColorPaletteButton.UseVisualStyleBackColor = false;
			this.fontColorPaletteButton.Click += new System.EventHandler(this.FontColorPaletteButton_Click);
			// 
			// BtnWithLink
			// 
			this.BtnWithLink.Location = new System.Drawing.Point(26, 377);
			this.BtnWithLink.Name = "BtnWithLink";
			this.BtnWithLink.Size = new System.Drawing.Size(98, 35);
			this.BtnWithLink.TabIndex = 0;
			this.BtnWithLink.Text = "text";
			this.BtnWithLink.UseVisualStyleBackColor = true;
			this.BtnWithLink.Click += new System.EventHandler(this.BtnWithLink_Click);
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
			this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(635, 383);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(94, 29);
			this.btnNext.TabIndex = 3;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.BtnNext_Click_1);
			// 
			// BtnPreview
			// 
			this.BtnPreview.Location = new System.Drawing.Point(353, 383);
			this.BtnPreview.Name = "BtnPreview";
			this.BtnPreview.Size = new System.Drawing.Size(94, 29);
			this.BtnPreview.TabIndex = 4;
			this.BtnPreview.Text = "Preview";
			this.BtnPreview.UseVisualStyleBackColor = true;
			this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
			// 
			// checkBoxBtnLink
			// 
			this.checkBoxBtnLink.AutoSize = true;
			this.checkBoxBtnLink.Location = new System.Drawing.Point(26, 337);
			this.checkBoxBtnLink.Name = "checkBoxBtnLink";
			this.checkBoxBtnLink.Size = new System.Drawing.Size(115, 19);
			this.checkBoxBtnLink.TabIndex = 5;
			this.checkBoxBtnLink.Text = "Button with link?";
			this.checkBoxBtnLink.UseVisualStyleBackColor = true;
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
			// BannerAddPicture
			// 
			this.BannerAddPicture.ForeColor = System.Drawing.Color.Blue;
			this.BannerAddPicture.Location = new System.Drawing.Point(21, 177);
			this.BannerAddPicture.Name = "BannerAddPicture";
			this.BannerAddPicture.Size = new System.Drawing.Size(75, 23);
			this.BannerAddPicture.TabIndex = 6;
			this.BannerAddPicture.Text = "Browse";
			this.BannerAddPicture.UseVisualStyleBackColor = true;
			this.BannerAddPicture.Click += new System.EventHandler(this.BannerAddPicture_Click);
			// 
			// dropDownTxtPos
			// 
			this.dropDownTxtPos.FormattingEnabled = true;
			this.dropDownTxtPos.Location = new System.Drawing.Point(427, 157);
			this.dropDownTxtPos.Name = "dropDownTxtPos";
			this.dropDownTxtPos.Size = new System.Drawing.Size(121, 23);
			this.dropDownTxtPos.TabIndex = 7;
			// 
			// ScrllBannerLabel
			// 
			this.ScrllBannerLabel.AutoSize = true;
			this.ScrllBannerLabel.Location = new System.Drawing.Point(12, 128);
			this.ScrllBannerLabel.Name = "ScrllBannerLabel";
			this.ScrllBannerLabel.Size = new System.Drawing.Size(93, 15);
			this.ScrllBannerLabel.TabIndex = 9;
			this.ScrllBannerLabel.Text = "Scrolling Banner";
			this.ScrllBannerLabel.Click += new System.EventHandler(this.ScrllBannerLabel_Click);
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
			// browsePicLeftOrRight
			// 
			this.browsePicLeftOrRight.ForeColor = System.Drawing.Color.Blue;
			this.browsePicLeftOrRight.Location = new System.Drawing.Point(701, 287);
			this.browsePicLeftOrRight.Name = "browsePicLeftOrRight";
			this.browsePicLeftOrRight.Size = new System.Drawing.Size(75, 23);
			this.browsePicLeftOrRight.TabIndex = 14;
			this.browsePicLeftOrRight.Text = "Browse";
			this.browsePicLeftOrRight.UseVisualStyleBackColor = true;
			this.browsePicLeftOrRight.Click += new System.EventHandler(this.BrowsePicLeftOrRight_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.fontColorLabel);
			this.Controls.Add(this.fontColorPaletteButton);
			this.Controls.Add(this.FontSizeLabel);
			this.Controls.Add(this.FontSizeInputBox);
			this.Controls.Add(this.fontStyleMenu);
			this.Controls.Add(this.fontStyleLabel);
			this.Controls.Add(this.ImageLabel);
			this.Controls.Add(this.browseImageButton);
			this.Controls.Add(this.backgroundColorLabel);
			this.Controls.Add(this.BackgroundColorButton);
			this.Controls.Add(this.sectionTitleLable);
			this.Controls.Add(this.SectionTitleInputBox);
			this.Controls.Add(this.sectionNameLabel);
			this.Controls.Add(this.sectionNameInputBox);
			this.Controls.Add(this.checkBoxBtnLink);
			this.Controls.Add(this.BtnPreview);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.BtnWithLink);
			this.Controls.Add(this.browsePicLeftOrRight);
			this.Controls.Add(this.pictureBoxMiddle);
			this.Controls.Add(this.imgText);
			this.Controls.Add(this.txtWithImagePos);
			this.Controls.Add(this.ctaBtnsLabel);
			this.Controls.Add(this.ScrllBannerLabel);
			this.Controls.Add(this.dropDownTxtPos);
			this.Controls.Add(this.BannerAddPicture);
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

        }

        #endregion

        private System.Windows.Forms.TextBox sectionNameInputBox;
        private System.Windows.Forms.Label sectionNameLabel;
        private System.Windows.Forms.Label sectionTitleLable;
        private System.Windows.Forms.TextBox sectionTitleInputBox;
        private System.Windows.Forms.Button BackgroundColorButton;
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
        private System.Windows.Forms.Label ScrllBannerLabel;
		private System.Windows.Forms.Label FontSizeLabel;
		private System.Windows.Forms.Label ctaBtnsLabel;
        private System.Windows.Forms.Label txtWithImagePos;
        private System.Windows.Forms.TextBox imgText;
        private System.Windows.Forms.PictureBox pictureBoxMiddle;
        private System.Windows.Forms.Button browsePicLeftOrRight;
		private System.Windows.Forms.Button BtnPreview;
		private System.Windows.Forms.Button BannerAddPicture;
		private System.Windows.Forms.Button BtnWithLink;
		private System.Windows.Forms.TextBox SectionTitleInputBox;
		private System.Windows.Forms.TextBox FontSizeInputBox;
		private System.Windows.Forms.Label ImageLabel;
	}
}

