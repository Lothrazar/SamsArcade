namespace ArcadeDesktop.Controls
{
    partial class ImageDownloader
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
            this.btnImageFetch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImageSelect = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bindGameRelease = new System.Windows.Forms.BindingSource(this.components);
            this.sizeLabel = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindGameRelease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImageFetch
            // 
            this.btnImageFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImageFetch.Location = new System.Drawing.Point(171, 38);
            this.btnImageFetch.Name = "btnImageFetch";
            this.btnImageFetch.Size = new System.Drawing.Size(127, 23);
            this.btnImageFetch.TabIndex = 19;
            this.btnImageFetch.Text = "Import from Web URL";
            this.btnImageFetch.UseVisualStyleBackColor = true;
            this.btnImageFetch.Click += new System.EventHandler(this.btnImageFetch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::ArcadeDesktop.Properties.Resources.image_link;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(483, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save this image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnImageSelect);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sizeLabel);
            this.panel1.Controls.Add(this.gameLabel);
            this.panel1.Controls.Add(this.btnImageFetch);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 72);
            this.panel1.TabIndex = 23;
            // 
            // btnImageSelect
            // 
            this.btnImageSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImageSelect.Location = new System.Drawing.Point(38, 38);
            this.btnImageSelect.Name = "btnImageSelect";
            this.btnImageSelect.Size = new System.Drawing.Size(127, 23);
            this.btnImageSelect.TabIndex = 29;
            this.btnImageSelect.Text = "Import from computer";
            this.btnImageSelect.UseVisualStyleBackColor = true;
            this.btnImageSelect.Click += new System.EventHandler(this.btnImageSelect_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::ArcadeDesktop.Properties.Resources.help;
            this.btnHelp.Location = new System.Drawing.Point(4, 38);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(28, 23);
            this.btnHelp.TabIndex = 28;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindGameRelease, "Gamefile", true));
            this.label2.Location = new System.Drawing.Point(57, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = " ";
            // 
            // bindGameRelease
            // 
            this.bindGameRelease.DataSource = typeof(ArcadeDataLayer.Objects.GameRelease);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(617, 13);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(10, 13);
            this.sizeLabel.TabIndex = 25;
            this.sizeLabel.Text = " ";
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(13, 13);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(38, 13);
            this.gameLabel.TabIndex = 23;
            this.gameLabel.Text = "Game:";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(653, 595);
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            // 
            // ImageDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "ImageDownloader";
            this.Size = new System.Drawing.Size(653, 667);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindGameRelease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImageFetch;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindGameRelease;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnImageSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
