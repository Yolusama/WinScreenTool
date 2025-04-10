
namespace ScreenTools
{
    public partial class Form2 : Form,IDisposable
    {
        public Form2()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
        public PictureBox ScreenShotContainer { get; set; }
        private Image ImgRes { get { return ScreenShotContainer.Image; } set { ScreenShotContainer.Image = value; } }
        private void Form2_Load(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(10, 12, 15);
            this.BackColor = color;
            this.Opacity = 0.5;
            bufferMap=new Bitmap(this.Width, this.Height);
            flowLayoutPanel1.Location = new Point((this.Width - flowLayoutPanel1.Width)/2, 30);
            flowLayoutPanel1.ForeColor = Color.Red;
            way = ScreenShotGetWay.rect;
            Color locolor = rect.BackColor;
            EventHandler LabelEnter = (sender, e) =>
            {
                Label label = sender as Label;
                label.BackColor = Color.LightGreen;
            };
            EventHandler LabelLeave = (sender, e) =>
              {
                  Label label=sender as Label;
                  label.BackColor = locolor;
              };
            rect.MouseEnter+=LabelEnter;
            rect.MouseLeave+=LabelLeave;
            ellipse.MouseEnter += LabelEnter;
            ellipse.MouseLeave += LabelLeave;
            AnyShape.MouseEnter += LabelEnter;
            AnyShape.MouseLeave += LabelLeave;
            AllScreen.MouseEnter += LabelEnter;
            AllScreen.MouseLeave += LabelLeave;
            Cancel.MouseEnter += LabelEnter;
            Cancel.MouseLeave += LabelLeave;
            CurvedPoints = new List<Point>();
        }
        private bool isDrawing = false;
        private Point startPoint;
        private Point endPoint;
        private Bitmap bufferMap;
        private ScreenShotGetWay way;
        private Point containerLoction { get { return ScreenShotContainer.Location; } }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
            if(way==ScreenShotGetWay.AnyShape)
                CurvedPoints.Add(startPoint);
            flowLayoutPanel1.Hide();
        }
        List<Point> CurvedPoints;
        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;
            isDrawing = false;
            Rectangle rectangle = new Rectangle();
            rectangle.ConstructedBy(startPoint, endPoint);
             if (way == ScreenShotGetWay.AnyShape)
            {
                /*endPoint =  new Point(CurvedPoints.Max(e => e.X),CurvedPoints.Max(e=>e.Y));
                rectangle.ConstructedBy(startPoint, endPoint);*/
                rectangle=Screen.PrimaryScreen.Bounds;
                //CurvedPoints.Add(startPoint);
            }
            ImgRes = new Bitmap(rectangle.Width,rectangle.Height);
            Point destination=Point.Empty;
            using (Graphics screenShot = Graphics.FromImage(ImgRes))
            {
                switch (way)
                {
                    case ScreenShotGetWay.rect:
                        screenShot.ScreenShotByRect(startPoint, endPoint,destination,ImgRes.Size);
                        break;
                    case ScreenShotGetWay.ellipse:
                        ImgRes=screenShot.ScreenShotByEllipse(startPoint,endPoint,destination,ImgRes,rectangle);
                        break;
                    case ScreenShotGetWay.AnyShape:
                        this.Opacity = 0;
                        ImgRes=screenShot.ScrrenShotByAny(CurvedPoints,rectangle,startPoint,endPoint,destination,ImgRes);
                        break;
                }
            }
            ScreenShotContainer.Bounds = rectangle;
            ScreenShotContainer.ImgSizeControl();
            this.Close();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(bufferMap))
                {
                   g.Clear(this.BackColor);
                    switch (way)
                    {
                        case ScreenShotGetWay.rect: g.DrawRectangleArea(startPoint,e.Location);break;
                        case ScreenShotGetWay.ellipse:g.DrawEllipseArea(startPoint,e.Location);break;
                        case ScreenShotGetWay.AnyShape:
                            if(!CurvedPoints.Contains(e.Location))
                            CurvedPoints.Add(e.Location);
                            g.DrawAnyShapeArea(CurvedPoints);
                            break;
                    }
                }
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(bufferMap, Point.Empty);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            bufferMap.Dispose();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rect_Click(object sender, EventArgs e)
        {
            if(way!=ScreenShotGetWay.rect)
                way = ScreenShotGetWay.rect;
            if (ImgRes != null)
                ImgRes.Dispose();
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            if(way!=ScreenShotGetWay.ellipse)
                way = ScreenShotGetWay.ellipse;
            if (ImgRes != null)
                ImgRes.Dispose();
        }

        private void AllScreen_Click(object sender, EventArgs e)
        {
            way = ScreenShotGetWay.AllScreen;            
            flowLayoutPanel1.Hide();
            Rectangle screen = Screen.PrimaryScreen.Bounds;
            if (ImgRes != null)
                ImgRes.Dispose();
            ImgRes=new Bitmap(screen.Width,screen.Height);
            using(Graphics graphics = Graphics.FromImage(ImgRes))
            {
                this.Opacity = 0;
                graphics.CopyFromScreen(0, 0, 0, 0, ImgRes.Size);
            } 
            ScreenShotContainer.Bounds = screen;
            this.Invalidate();
            this.Close();
        }

        private void AnyShape_Click(object sender, EventArgs e)
        {
            if(way!=ScreenShotGetWay.AnyShape)
                way = ScreenShotGetWay.AnyShape;
            if (ImgRes != null)
                ImgRes.Dispose();
        }
    }
}
