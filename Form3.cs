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
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.White,this.Bounds);
        }
        public Image Image { get { return container.Image; } set { container.Image = value; } }
        private bool canMove = false;
        private Point startPoint;

        private void Form3_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            DoubleBuffered = true;
            this.Opacity = 0.75;
            //Location = new Point(Screen.PrimaryScreen.WorkingArea.Right,Screen.PrimaryScreen.WorkingArea.Bottom);
        }

        private void container_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                OpenMenu();
            }
            else if (e.Button == MouseButtons.Left)
            {
                canMove = true;
                startPoint = e.Location;
            }
        }

        private void OpenMenu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item = new ToolStripMenuItem("关闭");
            item.Click += (sender, e) =>
            {
                Owner.Show();
                Dispose();
            };
            menu.Items.Add(item);
            this.ContextMenuStrip = menu;
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
