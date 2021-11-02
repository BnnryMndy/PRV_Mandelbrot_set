using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PRV_Mandelbrot_set
{
    class Mandelbrot
    {
        Complex c;
        public Stopwatch stopwatch = new Stopwatch();
        Complex z = 0;
        double x, y;
        int width, height;
        int xCenter, yCenter;
        public Bitmap picture;
        int maxIterations = 250;
        int infinityBorder = 4;
        int color = 255;

        //делаем приближение
        double hx, hy, x_, y_, n = 0;
        Size size;
        double sizeArea, scaleArea;

        public Mandelbrot(int width, int height)
        {
            this.width = width;
            this.height = height;
            picture = new Bitmap(width, height);

            xCenter = width / 3 * 2;
            yCenter = height / 2;
            sizeArea = 3;
            scaleArea = 3;
            toPicture();
        }
        
        public Complex InMandelbrotSet(Complex c)
        {
            color = 255;
            z = Complex.Zero;

            for (int i = 0; i < maxIterations; i++)
            {
                z = Complex.Pow(z, 2) + c;

                if (z.Magnitude > infinityBorder) {
                    color = i;
                    break;
                } 
            }

            return z;
        }

        public void toPicture()
        {
            double startX = 0 - xCenter / (double)width;
            double startY = 0 - yCenter / (double)width;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double relX = ((double)i / (double)width  + (double)startX) * 3;
                    double relY = ((double)j / (double)height + (double)startY + (double)startY) * 2;

                    Complex c = InMandelbrotSet(new Complex(relX, relY));

                    if (Math.Abs(c.Magnitude) > 2) picture.SetPixel(i, j, Color.FromArgb(color, color, color));
                    else picture.SetPixel(i, j, Color.White);
                }
            }
        }

        public void AsyncPicture(int threads)
        {
            
            double startX = 0 - xCenter / (double)width;
            double startY = 0 - yCenter / (double)width;

            List<Task> tasks = new List<Task>();
            stopwatch.Start();
            for (int i = 0; i < threads; i++)
            {
                tasks.Add(new Task(new Action(()=> {
                    asyncTask((width / threads) * i + 1, (width / threads) * (i + 1), startX, startY);
                })));
            }
            
            foreach (Task task in tasks)
            {
                task.Start();
            }

            Task.WaitAll(tasks.ToArray());
            stopwatch.Stop();
        }

        public void asyncTask(int from, int to, double startX, double startY)
        {
            for (int i = from; i < to; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double relX = ((double)i / (double)width + (double)startX) * 3;
                    double relY = ((double)j / (double)height + (double)startY) * 2;

                    Complex c = InMandelbrotSet(new Complex(relX, relY));

                    if (i < width)
                    {
                        if (Math.Abs(c.Magnitude) > 2) picture.SetPixel(i, j, Color.FromArgb(color, color, color));
                        else picture.SetPixel(i, j, Color.White);
                    }
                }
            }
        }
    }
}
