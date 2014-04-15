namespace ArcadeDesktop.Forms
{
    partial class ManageGames
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnImageFetch = new System.Windows.Forms.Button();
            this.gameReleaseGrid1 = new ArcadeDesktop.GameReleaseGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(425, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 204);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(62, 428);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(317, 20);
            this.txtUrl.TabIndex = 17;
            // 
            // btnImageFetch
            // 
            this.btnImageFetch.Location = new System.Drawing.Point(62, 454);
            this.btnImageFetch.Name = "btnImageFetch";
            this.btnImageFetch.Size = new System.Drawing.Size(127, 23);
            this.btnImageFetch.TabIndex = 16;
            this.btnImageFetch.Text = "Fetch Image from URL";
            this.btnImageFetch.UseVisualStyleBackColor = true;
            // 
            // gameReleaseGrid1
            // 
            this.gameReleaseGrid1.Location = new System.Drawing.Point(47, 12);
            this.gameReleaseGrid1.Name = "gameReleaseGrid1";
            this.gameReleaseGrid1.Size = new System.Drawing.Size(441, 364);
            this.gameReleaseGrid1.TabIndex = 0;
            // 
            // ManageGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnImageFetch);
            this.Controls.Add(this.gameReleaseGrid1);
            this.Name = "ManageGames";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageGames";
            this.Load += new System.EventHandler(this.ManageGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameReleaseGrid gameReleaseGrid1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnImageFetch;

    }
}