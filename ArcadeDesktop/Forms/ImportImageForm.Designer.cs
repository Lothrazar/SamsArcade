namespace ArcadeDesktop.Forms
{
    partial class ImportImageForm
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
            this.imageDownloader = new ArcadeDesktop.Controls.ImageDownloader();
            this.SuspendLayout();
            // 
            // imageDownloader
            // 
            this.imageDownloader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDownloader.Location = new System.Drawing.Point(0, 0);
            this.imageDownloader.Name = "imageDownloader";
            this.imageDownloader.Size = new System.Drawing.Size(499, 606);
            this.imageDownloader.TabIndex = 0;
            // 
            // ImportImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 606);
            this.Controls.Add(this.imageDownloader);
            this.Name = "ImportImageForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImportImageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ImageDownloader imageDownloader;
    }
}