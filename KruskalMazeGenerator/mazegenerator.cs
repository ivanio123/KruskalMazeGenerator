using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace MazeGenerator
{
    class TreeLink
    {
        public Node From, To;
        public TreeLink(Node from, Node to)//описує вузол та сусід вузла
        {
            From = from;
            To = to;
        }
    }
    class MazeGenerator//створення шляху між вузлами from і to//шлях між клітинками
    {
        public static Node[,] MazeNodes(int width, int height, int Ymin, int Xmin, int CellSize)
        {
            // Створення початкової сітки лабіринту
            Node[,] grid = new Node[height, width];
            for (int i = 0; i < height; ++i)
            {
                int y = Ymin + CellSize * i;
                for (int j = 0; j < width; ++j)
                {
                    int x = Xmin + CellSize * j;
                    grid[i, j] = new Node(x, y, CellSize, CellSize);
                }
            }
            // Створення масиву, у якому зберігаються сусіди кожного з вузлів
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if (i > 0)
                        grid[i, j].nodeNeighbors[Node.N] = grid[i - 1, j];
                    if (i < height - 1)
                        grid[i, j].nodeNeighbors[Node.S] = grid[i + 1, j];
                    if (j > 0)
                        grid[i, j].nodeNeighbors[Node.W] = grid[i, j - 1];
                    if (j < width - 1)
                        grid[i, j].nodeNeighbors[Node.E] = grid[i, j + 1];
                }
            }
            return grid;
        }
        public static void MST(Node root)//метод знаходження мінімального остовного дерева
        {
            Random rand = new Random();
            List<TreeLink> pathList = new List<TreeLink>();//колекція, у якій зберігається поточна клітинка та сусідні їй
            foreach (Node neighbor in root.nodeNeighbors)
            {
                if (neighbor != null)
                    pathList.Add(new TreeLink(root, neighbor));//додається пара: поточний вузол та сусід
            }
            
            while (pathList.Count > 0)//поки існують незадіяні клітини
            {
                int linkNum = rand.Next(0, pathList.Count);
                TreeLink link = pathList[linkNum];
                pathList.RemoveAt(linkNum);//обирається випадковий сусід клітинки, ця пара видаляється зі списку
               
                Node end_node = link.To;
                link.To.Parent = link.From;//занесення сусідньої клітинки до дерева, її призначення як поточної

                foreach (Node neighbor in end_node.nodeNeighbors)
                {
                    if ((neighbor != null) && (neighbor.Parent == null)) 
                    {
                        pathList.Add(new TreeLink(end_node, neighbor));//шукає сусідів поточної клітинки
                    }
                }
            }
        }

        public static Bitmap DisplayMaze(Node[,] grid, int picWidth, int picHeight, Color color, int lineWidth)//метод, що відповідає за виведення зображення лабіринта//створюємо кінцевий вузол до шляху//попередній вузол стає батьківським для даного, тобто проклали шлях між двома вузлами, і так кожну ітерацію циклу//перебираємо усіх сусідів вузла, якщо вони існують та ще не задіяні у шляху, то додаємо до шляху
        {

            Pen pen = new Pen(color, lineWidth);
            int height = grid.GetUpperBound(0) + 1;
            int width = grid.GetUpperBound(1) + 1;
            Bitmap bm = new Bitmap(picWidth, picHeight);
            int rand = new Random().Next(1,17);  
            int count = 0; 
            using (Graphics gr = Graphics.FromImage(bm))
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                       pen.Color = color;
                        if (count % 17 == rand && i != 0 && i != height - 1 && j != 0 && j != width - 1) // випадково обирається стіна
                        {
                            pen.Color = Color.FromArgb(25, 35, 35); //колір стіни стає кольором фону
                        }
                        grid[i, j].DrawWalls(gr, pen);//перехід до методу, що визначає, які стіни малювати
                        count++; 

                    }
                }
            }
            return bm;
        }
    }
    public class Node
    {
        public const int N = 0;
        public const int S = 1;
        public const int E = 2;
        public const int W = 3;//напрямки сусідів


        public Node[] nodeNeighbors = new Node[4];//масив сусідів вузла
        public Node Parent;//попередній вузол
        public Rectangle Bounds;//межі вузла
        public Node(int x, int y, int wid, int hgt)//конструктор вузлів-клітинок
        {
            Bounds = new Rectangle(x, y, wid, hgt);
        }

        public void DrawWalls(Graphics graphics, Pen pen)//метод, що обирає, які стіни малювати 
        {
            for (int side = 0; side < 4; side++)//перебор сторін вузла 
            {
                if ((nodeNeighbors[side] == null) || ((nodeNeighbors[side].Parent != this) && (nodeNeighbors[side] != Parent)))//якщо відсутній сусід з цієї сторони, або якщо через цей вузол ще не прокладено шлях, тоді малюємо стіну   
                {
                    DrawWall(graphics, pen, side);
                }
            }
        }
        private void DrawWall(Graphics gr, Pen pen, int side)//власне, сам метод малювання стін
        {
            switch (side)
            {
                case N:
                    gr.DrawLine(pen, Bounds.Left, Bounds.Top, Bounds.Right, Bounds.Top);//малює верхню сторону вузла
                    break;
                case S:
                    gr.DrawLine(pen, Bounds.Left, Bounds.Bottom, Bounds.Right, Bounds.Bottom);//малює нижню сторону вузла
                    break;
                case E:
                    gr.DrawLine(pen, Bounds.Right, Bounds.Top, Bounds.Right, Bounds.Bottom);//малює праву сторону вузла
                    break;
                case W:
                    gr.DrawLine(pen, Bounds.Left, Bounds.Top, Bounds.Left, Bounds.Bottom);//малює ліву сторону вузла
                    break;
            }
        }
    }
    public class Asciiimage
    {
        public static string ConvertToAscii(Bitmap image)//метод переведення зображення у набір символів

        {
            Boolean toggle = false;
            StringBuilder sb = new StringBuilder();
            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    Color pixelColor = image.GetPixel(w, h);
                    int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color grayColor = Color.FromArgb(red, green, blue);//перетворення у чорно-білий
                    if (!toggle)
                    {
                        int index = (grayColor.R * _AsciiChars.Length - 1) / 255;//шукає та порівнює відтінок сірого з елементами масиву
                        sb.Append(_AsciiChars[index]);
                    }
                }
                if (!toggle)
                {
                    sb.Append("\n");
                    toggle = true;
                }
                else
                {
                    toggle = false;
                }
            }
            sb.Replace('#', ' ');
            return sb.ToString();
        }
        private static string[] _AsciiChars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", "."};//масив символів, які використовуються для відображення
        public static Bitmap GetReSizedImage(Bitmap inputBitmap, int asciiWidth)//метод, у якому пропорційно зменшується розмір зображення 
        {
            int asciiHeight = (int)Math.Ceiling((double)inputBitmap.Height * asciiWidth / inputBitmap.Width);
            Bitmap result = new Bitmap(asciiWidth, asciiHeight);
            Graphics gr = Graphics.FromImage((Image)result);
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            gr.DrawImage(inputBitmap, 0, 0, asciiWidth, asciiHeight);
            gr.Dispose();
            return result;

        }
    }
}
