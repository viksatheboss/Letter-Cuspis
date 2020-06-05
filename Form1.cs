using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Letter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 500;
            this.Width = 500;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen =new  Pen(Color.Black);
            Point point1 = new Point(10, 300);
            Point point2 = new Point(400, 300);
            Point point3 = new Point(10, 50);
            Point point4 = new Point(400, 50);
            Point point5 = new Point(195, 5);
            Point[] curvePoints =
            {
                point1,
                point2,
                point3,
                point5,
                point4,
                point1,
                point3,
                point4,
                point2
            };

            g.DrawPolygon(myPen, curvePoints);
        }
    }
}
