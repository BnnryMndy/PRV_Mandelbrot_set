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
        bool isCoffeeTime = false;
        Mandelbrot mandelbrot;
        Stopwatch watch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();

            if (isCoffeeTime)
            {
                mandelbrot = new Mandelbrot(3840 * 5, 2160 * 5);
                mandelbrot.AsyncPicture(8);

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = "mandelbrot";
                saveDialog.DefaultExt = "jpg";
                saveDialog.Filter = "JPG images (*.jpg)|*.jpg";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {


                    var fileName = saveDialog.FileName;
                    if (!System.IO.Path.HasExtension(fileName) || System.IO.Path.GetExtension(fileName) != "jpg")
                        fileName = fileName + ".jpg";

                    mandelbrot.picture.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            Graphics gr = panel1.CreateGraphics();

            //mandelbrot.toPicture();
            //mandelbrot.AsyncPicture(8);
            //throw new Exception();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.Black, 10);
            if(mandelbrot != null) e.Graphics.DrawImage(mandelbrot.picture, 0, 0);
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
