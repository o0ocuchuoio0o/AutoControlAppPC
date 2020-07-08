using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Media;


namespace AutoADB
{
    public class ImageScanOpenCV
    {
        public static Bitmap Find(Bitmap mainBitmap, Bitmap subBitmap, double percent = 0.9)
        {
            Image<Bgr, byte> image = new Image<Bgr, byte>(mainBitmap);
            Image<Bgr, byte> template = new Image<Bgr, byte>(subBitmap);
            Image<Bgr, byte> image3 = image.Copy();
            using (Image<Gray, float> image4 = image.MatchTemplate(template, TemplateMatchingType.CcoeffNormed))
            {
                double[] numArray;
                double[] numArray2;
                Point[] pointArray;
                Point[] pointArray2;
                image4.MinMax(out numArray, out numArray2, out pointArray, out pointArray2);
                if (numArray2[0] > percent)
                {
                    Rectangle rect = new Rectangle(pointArray2[0], template.Size);
                    image3.Draw(rect, new Bgr(System.Drawing.Color.Red), 2, LineType.EightConnected, 0);
                }
                else
                {
                    image3 = null;
                }
            }
            return ((image3 == null) ? null : image3.ToBitmap());
        }

        public static Bitmap Find(string main, string sub, double percent = 0.9)
        {
            Bitmap image = GetImage(main);
            Bitmap bitmap2 = GetImage(sub);
            return Find(main, sub, percent);
        }

        public static List<Point> FindColor(Bitmap mainBitmap, System.Drawing.Color color)
        {
            int num = color.ToArgb();
            List<Point> list = new List<Point>();
            using (Bitmap bitmap = mainBitmap)
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        if (num.Equals(bitmap.GetPixel(i, j).ToArgb()))
                        {
                            list.Add(new Point(i, j));
                        }
                    }
                }
            }
            return list;
        }

       
        public static Point? FindOutPoint(Bitmap mainBitmap, Bitmap subBitmap, double percent = 0.9)
        {
            Image<Bgr, byte> image = new Image<Bgr, byte>(mainBitmap);
            Image<Bgr, byte> template = new Image<Bgr, byte>(subBitmap);
            Point? nullable = null;
            using (Image<Gray, float> image3 = image.MatchTemplate(template, TemplateMatchingType.CcoeffNormed))
            {
                double[] numArray;
                double[] numArray2;
                Point[] pointArray;
                Point[] pointArray2;
                image3.MinMax(out numArray, out numArray2, out pointArray, out pointArray2);
                if (numArray2[0] > percent)
                {
                    nullable = new Point?(pointArray2[0]);
                }
            }
            return nullable;
        }

        public static List<Point> FindOutPoints(Bitmap mainBitmap, Bitmap subBitmap, double percent = 0.9)
        {
            Image<Bgr, byte> image = new Image<Bgr, byte>(mainBitmap);
            Image<Bgr, byte> template = new Image<Bgr, byte>(subBitmap);
            List<Point> list = new List<Point>();
            while (true)
            {
                using (Image<Gray, float> image3 = image.MatchTemplate(template, TemplateMatchingType.CcoeffNormed))
                {
                    double[] numArray;
                    double[] numArray2;
                    Point[] pointArray;
                    Point[] pointArray2;
                    image3.MinMax(out numArray, out numArray2, out pointArray, out pointArray2);
                    if (numArray2[0] > percent)
                    {
                        Rectangle rect = new Rectangle(pointArray2[0], template.Size);
                        image.Draw(rect, new Bgr(System.Drawing.Color.Blue), -1, LineType.EightConnected, 0);
                        list.Add(pointArray2[0]);
                    }
                    else
                    {
                        return list;
                    }
                }
            }
        }

        public static Bitmap GetImage(string path)
        {
            return new Bitmap(path);
        }

       

       
    }
}
