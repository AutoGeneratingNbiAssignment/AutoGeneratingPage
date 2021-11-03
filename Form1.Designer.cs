
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}

