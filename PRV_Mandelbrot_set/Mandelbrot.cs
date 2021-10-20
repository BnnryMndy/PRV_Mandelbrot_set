using System;
using System.Collections.Generic;
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
        Complex z = 0;
        double x, y;
        int width, height;
        int xCenter, yCenter;
        public Bitmap picture;// = new Bitmap();
        int maxIterations = 300;
        int infinityBorder = 4;

        public Mandelbrot(int width, int height)
        {
            this.width = width;
            this.height = height;
            picture = new Bitmap(width, height);

            xCenter = width / 3 * 2;
            yCenter = height / 2;
            toPicture();
        }
        
        public Complex InMandelbrotSet(Complex c)
        {
            z = Complex.Zero;

            for (int i = 0; i < maxIterations; i++)
            {
                z = Complex.Pow(z, 2) + c;

                if (z.Magnitude > infinityBorder) break;
            }

            return z;
        }

        public void toPicture()
        {
            int startX = 0 - xCenter;
            int startY = 0 - yCenter;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double relX = ((double)i + (double)startX) / (double)width ;
                    double relY = ((double)j + (double)startY) / (double)height ;

                    Complex c = InMandelbrotSet(new Complex(relX, relY));

                    if (Math.Abs(c.Magnitude) > 2) picture.SetPixel(i, j, Color.White);
                    else picture.SetPixel(i, j, Color.Black);
                }
            }
        }

     

    }
}
