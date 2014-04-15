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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnImageFetch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFileType = new System.Windows.Forms.Label();
            this.gameReleaseGrid = new ArcadeDesktop.GameReleaseGrid();
            this.lblSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 588);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(448, 20);
            this.txtUrl.TabIndex = 17;
            // 
            // btnImageFetch
            // 
            this.btnImageFetch.Location = new System.Drawing.Point(466, 586);
            this.btnImageFetch.Name = "btnImageFetch";
            this.btnImageFetch.Size = new System.Drawing.Size(127, 23);
            this.btnImageFetch.TabIndex = 16;
            this.btnImageFetch.Text = "Fetch Image from URL";
            this.btnImageFetch.UseVisualStyleBackColor = true;
            this.btnImageFetch.Click += new System.EventHandler(this.btnImageFetch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(245, 557);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(35, 13);
            this.lblFileType.TabIndex = 19;
            this.lblFileType.Text = "label1";
            // 
            // gameReleaseGrid
            // 
            this.gameReleaseGrid.Location = new System.Drawing.Point(12, 12);
            this.gameReleaseGrid.Name = "gameReleaseGrid";
            this.gameReleaseGrid.Size = new System.Drawing.Size(226, 559);
            this.gameReleaseGrid.TabIndex = 0;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(345, 557);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(35, 13);
            this.lblSize.TabIndex = 20;
            this.lblSize.Text = "label1";
            // 
            // ManageGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 620);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFileType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnImageFetch);
            this.Controls.Add(this.gameReleaseGrid);
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

        private GameReleaseGrid gameReleaseGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnImageFetch;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.Label lblSize;

    }
}