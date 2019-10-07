/**
*** Author: Conor Lynch CIT185593
*** Date: 07/10/2019
*** IDE: Microsoft Visual Studio Enterprise 2017
*** IDE Version: 15.9.6
*** Software: Microsoft .NET Framework
*** Software Version: 4.7.02558
*** Platform: Microsoft Windows 8.1 64-bit
*** Platform Version: 6.3.9600 Build 9600
*** Project: Assessment02
*** Objective: Creation of a 2D graphics on a window form
**/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assessment2Graphics
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void house_Paint(object sender, PaintEventArgs e)
        {
            //First Paramater is Horizontal position
            //Second Paramater is Vertical position
            //Third Paramater is total width
            //Forth Paramater is total height

            e.Graphics.FillRectangle(Brushes.SkyBlue, 0, 0, 200, 200);//Background
            e.Graphics.FillRectangle(Brushes.BurlyWood, 20, 50, 160, 130);//House
            e.Graphics.DrawRectangle(Pens.Black, 20, 50, 160, 130);//House Outline
            e.Graphics.FillRectangle(Brushes.Green, 0, 180, 200, 20);//Grass
            Point[] roof = { new Point(5, 50), new Point(195, 50), new Point(100, 20) };//roof points
            e.Graphics.FillPolygon(Brushes.Red, roof);//roof
            e.Graphics.DrawPolygon(Pens.DarkRed, roof);//roof outline
            e.Graphics.FillRectangle(Brushes.Black, 38, 78, 67, 102);//Door outline
            e.Graphics.FillRectangle(Brushes.Moccasin, 40, 80, 63, 100);//Door
            e.Graphics.FillEllipse(Brushes.Gray, new Rectangle(88, 122, 9, 9));//Door handle
            e.Graphics.FillRectangle(Brushes.Moccasin, 120, 90, 50, 40);//Window
            e.Graphics.DrawRectangle(Pens.Black, 120, 90, 50, 40);//Window Outline
            e.Graphics.FillRectangle(Brushes.LightSkyBlue, 124, 94, 43, 33);//Window Class
            e.Graphics.FillRectangle(Brushes.Moccasin, 123, 108, 45, 5);//Window Frames
            e.Graphics.FillRectangle(Brushes.Moccasin, 143, 92, 5, 38);//Window Frames
        }

        private void clear_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(0, 0, 200, 200));
        }


        private void btnDrawHouse_Click(object sender, EventArgs e)
        {
            //panDraw is the panel that the image is being draw on
            panDraw.Paint += new PaintEventHandler(house_Paint);
            panDraw.Invalidate();//Repaints the image
        }

        private void btnDrawClear_Click(object sender, EventArgs e)
        {
            panDraw.Paint += new PaintEventHandler(clear_Paint);
            panDraw.Refresh(); ;//Repaints the image
        }
        
    }
}
