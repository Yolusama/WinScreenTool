using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTools
{
    enum ScreenShotGetWay
    {
        rect=4,Squre=16,ellipse=30,AnyShape=100,AllScreen=125
    }
    static class ShapeAreaHelper
    {
        public static void ConstructedBy(this ref Rectangle rectangle,Point start,Point end)
        {
            if (start.Y < end.Y)
                rectangle.Location = end.X < start.X ? new Point(end.X, start.Y) : start;
            else
                rectangle.Location = start.X < end.X ? new Point(start.X, end.Y) : end;
            int width = end.X - start.X;
            int height = end.Y - start.Y;
            rectangle.Size = new Size(Math.Abs(width), Math.Abs(height));
        }
        public static void DrawRectangleArea(this Graphics graphics, Point start, Point end)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ConstructedBy(start, end);
            graphics.FillRectangle(Brushes.Black, rectangle);
        }
        public static void DrawEllipseArea(this Graphics graphics,Point start,Point end)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ConstructedBy(start,end);
            graphics.FillEllipse(Brushes.Black, rectangle);
        }
        public static void DrawAnyShapeArea(this Graphics graphics,IEnumerable<Point> points)
        {
            graphics.FillClosedCurve(Brushes.Black, points.ToArray());
        }
        public static void ScreenShotByRect(this Graphics graphics, Point start, Point end, Point destination,Size drawingSize)
        {
            if (start.Y < end.Y)
            {
                if (start.X < end.X)
                    graphics.CopyFromScreen(start, destination, drawingSize);
                else
                    graphics.CopyFromScreen(new Point(end.X, start.Y), destination, drawingSize);
            }
            else
            {
                if (start.X < end.X)
                    graphics.CopyFromScreen(new Point(start.X, end.Y), destination, drawingSize);
                else
                    graphics.CopyFromScreen(end, destination, drawingSize);
            }
        }
        public static Image ScreenShotByEllipse(this Graphics graphics, Point start, Point end, Point destination,Image originalImage,Rectangle drawingArea)
        {  
            GraphicsPath path=new GraphicsPath();
            graphics.ScreenShotByRect(start, end, destination, originalImage.Size);
            Rectangle rectangle = drawingArea;
            path.AddEllipse(new Rectangle(0,0,rectangle.Width,rectangle.Height));
            Image  image=new Bitmap(rectangle.Width,rectangle.Height);
            using (Graphics g = Graphics.FromImage(image))
            { 
                g.SetClip(path);
                g.DrawImage(originalImage,destination);
            }
            originalImage.Dispose();
            return image;
        }
        public static Image ScrrenShotByAny(this Graphics graphics,IEnumerable<Point> points,Rectangle drawingArea,Point start,Point end,Point destination,Image originalImage)
        {
           Image image=new Bitmap(drawingArea.Width,drawingArea.Height);
            graphics.CopyFromScreen(0, 0, 0, 0, drawingArea.Size);
           GraphicsPath path=new GraphicsPath();
           path.AddClosedCurve(points.ToArray());
           using(Graphics g = Graphics.FromImage(image))
            {
                g.SetClip(path);
                g.DrawImage(originalImage,destination);
            }
            originalImage.Dispose();
            return image;
        }
    }
}
