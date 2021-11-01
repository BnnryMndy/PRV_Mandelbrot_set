using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Stopwatch watch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();

            mandelbrot = new Mandelbrot(panel1.Width, panel1.Height);

            Graphics gr = panel1.CreateGraphics();

            //mandelbrot.toPicture();
            //mandelbrot.AsyncPicture(8);
            //throw new Exception();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.Black, 10);
            
            e.Graphics.DrawImage(mandelbrot.picture, 0, 0);
        }

        private void oneTrheadButton_Click(object sender, EventArgs e)
        {
            mandelbrot = new Mandelbrot(panel1.Width, panel1.Height);
            
            watch.Reset();
            watch.Start();
            mandelbrot.toPicture();
            watch.Stop();
            Refresh();
            statisticLabel.Text = "сгенерировано за "+Convert.ToString(watch.ElapsedMilliseconds) +"мс";
        }

        private void multiThreadButton_Click(object sender, EventArgs e)
        {
            mandelbrot = new Mandelbrot(panel1.Width, panel1.Height);
            watch.Reset();
            watch.Start();
            mandelbrot.AsyncPicture(8);
            
            
            Refresh();
            watch.Stop();
            statisticLabel.Text = "сгенерировано за " + Convert.ToString(watch.ElapsedMilliseconds) + "мс"; //mandelbrot.stopwatch.ElapsedMilliseconds
        }
    }
}
