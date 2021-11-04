using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGeneratingPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {

        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Form1 newForm = new();
            newForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ScrllBannerLabel_Click(object sender, EventArgs e)
        {

        }
        private void SectionNameInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SectionTitleLable_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {
            var backgroundColorPalette = new ColorDialog();
            backgroundColorPalette.ShowDialog();
        }

        private void BackgroundColorLabel_Click(object sender, EventArgs e)
        {

        }

        private void ImageLabel_Click(object sender, EventArgs e)
        {

        }

        private void BrowseImageButton_Click(object sender, EventArgs e)
        {

        }

        private void FontStyleLabel_Click(object sender, EventArgs e)
        {

        }

        private void FontSizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void FontSizeInputBox_Click(object sender, EventArgs e)
        {

        }

        private void FontColorLabel_Click(object sender, EventArgs e)
        {

        }

        private void FontColorPaletteButton_Click(object sender, EventArgs e)
        {
            var fontColorPalette = new ColorDialog();
            fontColorPalette.ShowDialog();
        }

        private void BrowsePicLeftOrRight_Click(object sender, EventArgs e)
        {

        }

		private void BtnNext_Click_1(object sender, EventArgs e)
		{

		}

		private void BannerAddPicture_Click(object sender, EventArgs e)
		{

		}

		private void BtnWithLink_Click(object sender, EventArgs e)
		{

		}

		private void SectionTitleInputBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void SectionNameLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
