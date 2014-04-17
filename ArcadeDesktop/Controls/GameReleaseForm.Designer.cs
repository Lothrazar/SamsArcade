namespace ArcadeDesktop.Controls
{
    partial class GameReleaseForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxGame = new System.Windows.Forms.TextBox();
            this.bindGameRelease = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.textBoxImageLoc = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindGameRelease)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxGame
            // 
            this.textBoxGame.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindGameRelease, "Gamefile", true));
            this.textBoxGame.Enabled = false;
            this.textBoxGame.Location = new System.Drawing.Point(3, 6);
            this.textBoxGame.Name = "textBoxGame";
            this.textBoxGame.Size = new System.Drawing.Size(433, 20);
            this.textBoxGame.TabIndex = 0;
            // 
            // bindGameRelease
            // 
            this.bindGameRelease.DataSource = typeof(ArcadeDataLayer.Objects.GameRelease);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.textBoxImageLoc);
            this.panel1.Controls.Add(this.textBoxGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnDownload
            // 
            this.btnDownload.Image = global::ArcadeDesktop.Properties.Resources.image_link;
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(3, 58);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(163, 22);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Add or Change Image";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // textBoxImageLoc
            // 
            this.textBoxImageLoc.Enabled = false;
            this.textBoxImageLoc.Location = new System.Drawing.Point(3, 32);
            this.textBoxImageLoc.Name = "textBoxImageLoc";
            this.textBoxImageLoc.Size = new System.Drawing.Size(433, 20);
            this.textBoxImageLoc.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(439, 394);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // GameReleaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "GameReleaseForm";
            this.Size = new System.Drawing.Size(439, 494);
            ((System.ComponentModel.ISupportInitialize)(this.bindGameRelease)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindGameRelease;
        private System.Windows.Forms.TextBox textBoxGame;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxImageLoc;
        private System.Windows.Forms.Button btnDownload;
    }
}
