namespace ScreenTools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Shot = new PictureBox();
            menuStrip1 = new MenuStrip();
            截图ToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            Spin = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)Shot).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Shot
            // 
            Shot.BackColor = Color.White;
            Shot.BackgroundImageLayout = ImageLayout.Center;
            Shot.Location = new Point(99, 46);
            Shot.Name = "Shot";
            Shot.Size = new Size(0, 0);
            Shot.SizeMode = PictureBoxSizeMode.StretchImage;
            Shot.TabIndex = 0;
            Shot.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 截图ToolStripMenuItem, 保存ToolStripMenuItem, Spin });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1104, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // 截图ToolStripMenuItem
            // 
            截图ToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            截图ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            截图ToolStripMenuItem.Name = "截图ToolStripMenuItem";
            截图ToolStripMenuItem.Size = new Size(94, 28);
            截图ToolStripMenuItem.Text = "截图（F)";
            截图ToolStripMenuItem.Click += 截图ToolStripMenuItem_Click;
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(106, 28);
            保存ToolStripMenuItem.Text = "保存（S）";
            保存ToolStripMenuItem.Click += 保存ToolStripMenuItem_Click;
            // 
            // Spin
            // 
            Spin.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Spin.Name = "Spin";
            Spin.Size = new Size(107, 28);
            Spin.Text = "钉住（P）";
            Spin.Click += toolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1104, 658);
            Controls.Add(Shot);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)Shot).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Shot;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 截图ToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem Spin;
    }
}