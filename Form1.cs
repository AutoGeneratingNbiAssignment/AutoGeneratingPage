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

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void sectionNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            var backgroundColorPalette = new ColorDialog();
            backgroundColorPalette.ShowDialog();
        }

        private void backgroundColorLabel_Click(object sender, EventArgs e)
        {

        }

        private void imageLabel_Click(object sender, EventArgs e)
        {

        }

        private void browseImageButton_Click(object sender, EventArgs e)
        {

        }

        private void fontStyleLabel_Click(object sender, EventArgs e)
        {

        }

        private void fontSizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void fontSizeInputBox_Click(object sender, EventArgs e)
        {

        }

        private void fontColorLabel_Click(object sender, EventArgs e)
        {

        }

        private void fontColorPaletteButton_Click(object sender, EventArgs e)
        {
            var fontColorPalette = new ColorDialog();
            fontColorPalette.ShowDialog();
        }
    }
}
