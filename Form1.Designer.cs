
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
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
            this.Text = "Form1";
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
    }
}

