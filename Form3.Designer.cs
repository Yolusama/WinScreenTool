namespace ScreenTools
{
    partial class Form3
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
            container = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)container).BeginInit();
            SuspendLayout();
            // 
            // container
            // 
            container.BackgroundImageLayout = ImageLayout.Center;
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.Size = new Size(800, 450);
            container.SizeMode = PictureBoxSizeMode.StretchImage;
            container.TabIndex = 0;
            container.TabStop = false;
            container.MouseDown += container_MouseDown;
            container.MouseMove += container_MouseMove;
            container.MouseUp += container_MouseUp;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(container);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)container).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox container;
    }
}