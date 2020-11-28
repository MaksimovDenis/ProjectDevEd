using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDevEd
{
    public partial class Form1 : Form
    {
        Bitmap mainBm;
        Graphics graphics;
        Pen pen;
        Point prevPoint;
        bool MD;

        public Form1()
        {
            InitializeComponent();
        }

        //ПРЯМОУГОЛЬНЫЙ ТРЕУГОЛЬНИК ПО 2-М ТОЧКМ

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MD)
            {
                graphics.Clear(Color.White);
                Point[] p = new Point[3]
                {
                    prevPoint,
                    new Point(e.X, prevPoint.Y),
                    e.Location,
                };
                
                    graphics.DrawPolygon(pen, p);
                    pictureBox1.Image = mainBm;
            }
        }

        //Четырёхуголник по двум точкам

        //private void pictureBox1_MouseMove(object sender, MouseEventArgs e) 
        //{
        //    if (MD)
        //    {
        //        graphics.Clear(Color.White);
        //        Point[] p = new Point[4]
        //        {
        //            prevPoint,
        //            new Point(e.X, prevPoint.Y),
        //            e.Location,
        //            new Point(prevPoint.X,e.Y),
        //        };
        //        graphics.DrawPolygon(pen, p);

        //        pictureBox1.Image = mainBm;

        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            mainBm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(mainBm);
            pen = new Pen(Color.Black, 1);
            prevPoint = new Point(0, 0);
            MD = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
            MD = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MD = false;
        }
    }
}
