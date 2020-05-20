using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace MazeGenerator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Width = 1100;
            Height = 720;
            btnSaveAsAscii.Enabled = false;
        }
        Color lineColor = Color.White;
        int lineWid = 1;
        private void tsmiLineColor_Click(object sender, EventArgs e)//зміна кольору лінії
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                lineColor = cd.Color;
            }
        }
        private void tsmiLineWidthMenu_Click(object sender, EventArgs e)//зміна товщини лінії
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            lineWid = Convert.ToInt32(tsmi.Text);
            CheckedFalse(tsmiLineWidthMenu);
            tsmi.Checked = true;
            tsmiLineWidthMenu.Checked = true;
        }
        private void CheckedFalse(ToolStripMenuItem toolStripMenu)
        {
            foreach (ToolStripMenuItem tsmi in toolStripMenu.DropDownItems)
            {
                tsmi.Checked = false;
            }
        }
        /*private void buttonSave_Click(object sender, EventArgs e)//збереження лабіринту у форматі зображення
        {
            //Graphics.Clear(Color.FromArgb(25, 35, 35));
            Bitmap mazeSave = (Bitmap)mazePic.Image;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "png";
            sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                mazeSave.Save(sfd.FileName, ImageFormat.Png);
            }
        }*/
        public int width;
        public int CellSize;
        public void buttonCreate_Click(object sender, EventArgs e)//кнопка створення лабіринту
        {
            btnSaveAsAscii.Enabled = true;
            width = int.Parse(chooseWidth.Text);
            int height = int.Parse(chooseHeight.Text);
            CellSize = int.Parse(chooseCellSize.Text);
            int Xmin = (mazePic.ClientSize.Width - width * CellSize) / 2;
            int Ymin = (mazePic.ClientSize.Height - height * CellSize) / 2;
            Node[,] grid = MazeGenerator.MazeNodes(width, height, Ymin, Xmin, CellSize);
            MazeGenerator.MST(grid[0,0]);
            mazePic.Image = MazeGenerator.DisplayMaze(grid, mazePic.Width, mazePic.Height, lineColor, lineWid);
        }

        private void saveAsAscii_Click(object sender, EventArgs e)//збереження у форматі txt
        {
            Bitmap mazeAsciiPic = (Bitmap)mazePic.Image;
            Bitmap mazeAsciiPicResized = Asciiimage.GetReSizedImage(mazeAsciiPic, width*10 + CellSize*2);
            string ascii = Asciiimage.ConvertToAscii(mazeAsciiPicResized);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File (*.txt)|.txt|HTML (*.htm)|.htm";

            DialogResult diag = saveFileDialog1.ShowDialog();

            if (diag == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, ascii);
            }
        }
    }
}

