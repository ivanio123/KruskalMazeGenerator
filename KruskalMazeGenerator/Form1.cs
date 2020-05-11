using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace KruskalMazeGenerator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Width = 1100;
            Height = 720;
            buttonSave.Enabled = false;
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
        private void buttonSave_Click(object sender, EventArgs e)//збереження лабіринту у форматі зображення
        {
            Bitmap mazeSave = (Bitmap)mazePic.Image;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "png";
            sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                mazeSave.Save(sfd.FileName, ImageFormat.Png);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)//кнопка створення лабіринту
        {
            buttonSave.Enabled = true;
            int width = int.Parse(chooseWidth.Text);
            int height = int.Parse(chooseHeight.Text);
            int CellSize = int.Parse(chooseCellSize.Text);
            int Xmin = (mazePic.ClientSize.Width - width * CellSize) / 2;
            int Ymin = (mazePic.ClientSize.Height - height * CellSize) / 2;
            Node[,] grid = MazeGenerator.MazeNodes(width, height, Ymin, Xmin, CellSize);
            MazeGenerator.KruskalMST(grid[0,0]);
            mazePic.Image = MazeGenerator.DisplayMaze(grid, mazePic.Width, mazePic.Height, lineColor, lineWid);
        }
    }
}

