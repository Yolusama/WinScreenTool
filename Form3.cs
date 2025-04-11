using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenTools
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Image Image { get { return container.Image; } set { container.Image = value; } }
        private bool canMove = false;
        private Point startPoint;

        private void Form3_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            DoubleBuffered = true;
            BackColor = Color.SlateBlue;
            Size = new Size(1080, 720);
            int containerWidth =(int)(Width * 0.95);
            int containerHeight = (int)(Height * 0.95);
            container.Size = new Size(containerWidth, containerHeight);
            container.ToCenter();
            InitMenu();
        }

        private void container_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip.Show();
            }
            else if (e.Button == MouseButtons.Left)
            {
                canMove = true;
                startPoint = e.Location;
            }
        }

        private void InitMenu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item = new ToolStripMenuItem("关闭");
            ToolStripMenuItem item1 = new ToolStripMenuItem("另存为");
            item.Click += (sender, e) =>
            
            {
                Owner.Show();
                Dispose();
            };
            item1.Click += (sender, e) =>
            {
                SaveDialogHelper.OpenToSaveImage(Image);
            };
            menu.Items.Add(item);
            menu.Items.Add(item1);
            ContextMenuStrip = menu;
        }

        private void container_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMove)
            {
                Point endPoint = e.Location;
                int deltaX = endPoint.X - startPoint.X;
                int deltaY = endPoint.Y - startPoint.Y;
                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }

        private void container_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                canMove = false;
        }
    }
}
