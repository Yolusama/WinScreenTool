using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace ScreenTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float ratio = 0.8f;
        bool canSave { get { return 保存ToolStripMenuItem.Enabled; } set { 保存ToolStripMenuItem.Enabled = value; } }
        private void 截图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form2 form = new Form2();
                form.ScreenShotContainer = this.Shot;
                form.ShowDialog();
                this.Show();
                if (Shot.Image != null)
                {
                    canSave = true;
                    Spin.Enabled = true;
                    Clipboard.SetImage(Shot.Image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":" + ex.StackTrace);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "截图工具";
            Shot.Width = (int)(this.Width * ratio);
            Shot.Height = (int)(this.Height * ratio);
            Shot.ToCenter();
            canSave = false;
            Shot.SizeChanged += (sender, e) =>
            {
                PictureBox pictureBox = sender as PictureBox;
                if (pictureBox.Width > (int)(this.Width * ratio) || pictureBox.Height > (int)(this.Height * ratio))
                    Form1_SizeChanged(this, e);
                pictureBox.ToCenter();
            };
            Shot.BackColor = this.BackColor;
            Spin.Enabled = false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Shot.Width = (int)(this.Width * ratio);
            Shot.Height = (int)(this.Height * ratio);
            Shot.ToCenter();
            if (Shot.Image != null)
                Shot.ImgSizeControl();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG(*.png)|*.png|JPEG(*.jpeg;*.jpg;*.jpe;*jfif)|*.jpeg;*.jpg;*.jpe;*jfif";
            dialog.Title = "保存";
            string savePath = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            dialog.FileName = savePath + " ScreenShot(屏幕截图).png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string suffix = dialog.FileName.Substring(dialog.FileName.LastIndexOf('.'));
                Regex regex = new Regex(suffix, RegexOptions.IgnoreCase);
                if (regex.IsMatch(suffix))
                    Shot.Image.Save(dialog.FileName, ImageFormat.Png);
                else
                    Shot.Image.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Image = Shot.Image;
            form.Owner = this;
            form.Bounds = Shot.Bounds;
            this.Hide();
            form.Show();
        }
    }
}