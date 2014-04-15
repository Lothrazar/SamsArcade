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
            this.imageDownloader1 = new ArcadeDesktop.Controls.ImageDownloader();
            this.SuspendLayout();
            // 
            // imageDownloader1
            // 
            this.imageDownloader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDownloader1.Location = new System.Drawing.Point(0, 0);
            this.imageDownloader1.Name = "imageDownloader1";
            this.imageDownloader1.Size = new System.Drawing.Size(499, 606);
            this.imageDownloader1.TabIndex = 0;
            // 
            // ImportImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 606);
            this.Controls.Add(this.imageDownloader1);
            this.Name = "ImportImageForm";
            this.Text = "ImportImageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ImageDownloader imageDownloader1;
    }
}