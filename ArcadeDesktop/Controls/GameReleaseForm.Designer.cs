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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.textBoxImageLoc = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnStates = new System.Windows.Forms.Button();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textSaves = new System.Windows.Forms.TextBox();
            this.bindGameRelease = new System.Windows.Forms.BindingSource(this.components);
            this.btnFolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGameRelease)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFolder);
            this.panel1.Controls.Add(this.textSaves);
            this.panel1.Controls.Add(this.textYear);
            this.panel1.Controls.Add(this.btnStates);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.textBoxImageLoc);
            this.panel1.Controls.Add(this.textBoxGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 117);
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
            this.pictureBox.Size = new System.Drawing.Size(439, 371);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnStates
            // 
            this.btnStates.Image = global::ArcadeDesktop.Properties.Resources.image_link;
            this.btnStates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStates.Location = new System.Drawing.Point(172, 58);
            this.btnStates.Name = "btnStates";
            this.btnStates.Size = new System.Drawing.Size(100, 22);
            this.btnStates.TabIndex = 9;
            this.btnStates.Text = "Find Saves";
            this.btnStates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStates.UseVisualStyleBackColor = true;
            this.btnStates.Click += new System.EventHandler(this.btnStates_Click);
            // 
            // textYear
            // 
            this.textYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindGameRelease, "year", true));
            this.textYear.Location = new System.Drawing.Point(336, 78);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 20);
            this.textYear.TabIndex = 10;
            // 
            // textSaves
            // 
            this.textSaves.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindGameRelease, "year", true));
            this.textSaves.Location = new System.Drawing.Point(172, 94);
            this.textSaves.Name = "textSaves";
            this.textSaves.Size = new System.Drawing.Size(100, 20);
            this.textSaves.TabIndex = 11;
            // 
            // bindGameRelease
            // 
            this.bindGameRelease.DataSource = typeof(ArcadeDataLayer.Objects.GameRelease);
            // 
            // btnFolder
            // 
            this.btnFolder.Image = global::ArcadeDesktop.Properties.Resources.image_link;
            this.btnFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFolder.Location = new System.Drawing.Point(278, 58);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(100, 22);
            this.btnFolder.TabIndex = 12;
            this.btnFolder.Text = "Open Folder";
            this.btnFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // GameReleaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "GameReleaseForm";
            this.Size = new System.Drawing.Size(439, 494);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGameRelease)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindGameRelease;
        private System.Windows.Forms.TextBox textBoxGame;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxImageLoc;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnStates;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textSaves;
        private System.Windows.Forms.Button btnFolder;
    }
}
