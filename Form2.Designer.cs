namespace ScreenTools
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rect = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ellipse = new System.Windows.Forms.Label();
            this.AllScreen = new System.Windows.Forms.Label();
            this.AnyShape = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rect
            // 
            this.rect.AutoSize = true;
            this.rect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rect.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rect.Location = new System.Drawing.Point(3, 0);
            this.rect.Name = "rect";
            this.rect.Size = new System.Drawing.Size(94, 29);
            this.rect.TabIndex = 0;
            this.rect.Text = "矩形截图";
            this.rect.Click += new System.EventHandler(this.rect_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rect);
            this.flowLayoutPanel1.Controls.Add(this.ellipse);
            this.flowLayoutPanel1.Controls.Add(this.AllScreen);
            this.flowLayoutPanel1.Controls.Add(this.AnyShape);
            this.flowLayoutPanel1.Controls.Add(this.Cancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(89, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(482, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ellipse
            // 
            this.ellipse.AutoSize = true;
            this.ellipse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipse.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ellipse.Location = new System.Drawing.Point(103, 0);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(94, 29);
            this.ellipse.TabIndex = 2;
            this.ellipse.Text = "椭圆截图";
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // AllScreen
            // 
            this.AllScreen.AutoSize = true;
            this.AllScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllScreen.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllScreen.Location = new System.Drawing.Point(203, 0);
            this.AllScreen.Name = "AllScreen";
            this.AllScreen.Size = new System.Drawing.Size(94, 29);
            this.AllScreen.TabIndex = 4;
            this.AllScreen.Text = "全屏截图";
            this.AllScreen.Click += new System.EventHandler(this.AllScreen_Click);
            // 
            // AnyShape
            // 
            this.AnyShape.AutoSize = true;
            this.AnyShape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AnyShape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnyShape.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnyShape.Location = new System.Drawing.Point(303, 0);
            this.AnyShape.Name = "AnyShape";
            this.AnyShape.Size = new System.Drawing.Size(134, 29);
            this.AnyShape.TabIndex = 6;
            this.AnyShape.Text = "任意形状截图";
            this.AnyShape.Click += new System.EventHandler(this.AnyShape_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel.Location = new System.Drawing.Point(443, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(28, 29);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "X";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label rect;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label ellipse;
        private Label AllScreen;
        private Label Cancel;
        private Label AnyShape;
    }
}