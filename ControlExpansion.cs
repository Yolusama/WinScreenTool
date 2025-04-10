using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTools
{
    static class ControlExpansion
    {
        public static void ToCenter(this Control control)
        {
            Point point=new Point();
            point.X = (control.Parent.Width-control.Width)/2;
            point.Y = (control.Parent.Height-control.Height)/2;
            control.Location = point;
        }
        public static void ImgSizeControl(this PictureBox pictureBox)
        {
            if (pictureBox.Image.Width < pictureBox.Width && pictureBox.Image.Height < pictureBox.Height)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox.Width=pictureBox.Image.Width;
                pictureBox.Height=pictureBox.Image.Height;
                pictureBox.ToCenter();
            }
            else
            {
                pictureBox.SizeMode=PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
