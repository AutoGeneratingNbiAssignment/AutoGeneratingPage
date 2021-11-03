
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
            this.bannerTextBox = new System.Windows.Forms.TextBox();
            this.callToActionText = new System.Windows.Forms.TextBox();
            this.ctaFirstBtnText = new System.Windows.Forms.TextBox();
            this.ctaScndBtnText = new System.Windows.Forms.TextBox();
            this.ctaThrdBtnText = new System.Windows.Forms.TextBox();
            this.bannerAddPicture = new System.Windows.Forms.Button();
            this.dropDownTxtPos = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // bannerTextBox
            // 
            this.bannerTextBox.Location = new System.Drawing.Point(12, 128);
            this.bannerTextBox.Name = "bannerTextBox";
            this.bannerTextBox.Size = new System.Drawing.Size(94, 23);
            this.bannerTextBox.TabIndex = 1;
            this.bannerTextBox.Text = "Scrolling Banner";
            // 
            // callToActionText
            // 
            this.callToActionText.Location = new System.Drawing.Point(198, 128);
            this.callToActionText.Name = "callToActionText";
            this.callToActionText.Size = new System.Drawing.Size(94, 23);
            this.callToActionText.TabIndex = 2;
            this.callToActionText.Text = "CTA Buttons";
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
            this.bannerAddPicture.Location = new System.Drawing.Point(22, 175);
            this.bannerAddPicture.Name = "bannerAddPicture";
            this.bannerAddPicture.Size = new System.Drawing.Size(75, 23);
            this.bannerAddPicture.TabIndex = 6;
            this.bannerAddPicture.Text = "Browse";
            this.bannerAddPicture.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.dropDownTxtPos.FormattingEnabled = true;
            this.dropDownTxtPos.Location = new System.Drawing.Point(427, 164);
            this.dropDownTxtPos.Name = "comboBox1";
            this.dropDownTxtPos.Size = new System.Drawing.Size(121, 23);
            this.dropDownTxtPos.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dropDownTxtPos);
            this.Controls.Add(this.bannerAddPicture);
            this.Controls.Add(this.ctaThrdBtnText);
            this.Controls.Add(this.ctaScndBtnText);
            this.Controls.Add(this.ctaFirstBtnText);
            this.Controls.Add(this.callToActionText);
            this.Controls.Add(this.bannerTextBox);
            this.Controls.Add(this.bannerCheckBox);
            this.Name = "Form1";
            this.Text = "Page Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox bannerCheckBox;
        private System.Windows.Forms.TextBox bannerTextBox;
        private System.Windows.Forms.TextBox callToActionText;
        private System.Windows.Forms.TextBox ctaFirstBtnText;
        private System.Windows.Forms.TextBox ctaScndBtnText;
        private System.Windows.Forms.TextBox ctaThrdBtnText;
        private System.Windows.Forms.Button bannerAddPicture;
        private System.Windows.Forms.ComboBox dropDownTxtPos;
        private System.Windows.Forms.TextBox textBox1;
    }
}

