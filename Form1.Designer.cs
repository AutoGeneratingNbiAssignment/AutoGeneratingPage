﻿
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
            this.TitleLable = new System.Windows.Forms.Label();
            this.sectionTitleInputBox = new System.Windows.Forms.TextBox();
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
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Location = new System.Drawing.Point(26, 9);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(107, 25);
            this.TitleLable.TabIndex = 3;
            this.TitleLable.Text = "Section Title";
            this.TitleLable.Click += new System.EventHandler(this.label2_Click);
            // 
            // sectionTitleInputBox
            // 
            this.sectionTitleInputBox.Location = new System.Drawing.Point(26, 36);
            this.sectionTitleInputBox.Name = "sectionTitleInputBox";
            this.sectionTitleInputBox.Size = new System.Drawing.Size(150, 31);
            this.sectionTitleInputBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TitleLable);
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
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.TextBox sectionTitleInputBox;
    }
}

