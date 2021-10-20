using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRV_Mandelbrot_set
{
    public partial class Form1 : Form
    {
        Mandelbrot mandelbrot;
        public Form1()
        {
            InitializeComponent();

            mandelbrot = new Mandelbrot(panel1.Width, panel1.Height);

            Graphics gr = panel1.CreateGraphics();

            mandelbrot.toPicture();
            //Image image = new Image(mandelbrot.picture);
            //gr.Dra
            
            //gr.DrawRectangle(pen, 10, 10, 100, 100);
            //gr.DrawImage(mandelbrot.picture, 0, 0);
            //panel1.Refresh();
            //Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 10);
            //e.Graphics.DrawRectangle(pen, 10, 10, 100, 100);
            e.Graphics.DrawImage(mandelbrot.picture, 0, 0);
        }
    }
}
