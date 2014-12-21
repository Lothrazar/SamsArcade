namespace ArcadeDesktop
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnLaunch = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkSNES = new System.Windows.Forms.CheckBox();
            this.checkGB = new System.Windows.Forms.CheckBox();
            this.checkNes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gameReleaseForm = new ArcadeDesktop.Controls.GameReleaseForm();
            this.bindFilter = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(9, 141);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(72, 23);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(84, 32);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(259, 571);
            this.listView.SmallImageList = this.imageList;
            this.listView.TabIndex = 9;
            this.listView.TileSize = new System.Drawing.Size(184, 30);
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Tile;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "NES-Cartridge.jpg");
            this.imageList.Images.SetKeyName(1, "snes_blank.jpg");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 32);
            this.panel1.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ArcadeDesktop.Properties.Resources.folder_magnify;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(279, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindFilter, "StartsWith", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SearchBox.Location = new System.Drawing.Point(83, 5);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(190, 20);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(573, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(66, 23);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(645, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.checkSNES);
            this.panel2.Controls.Add(this.checkGB);
            this.panel2.Controls.Add(this.checkNes);
            this.panel2.Controls.Add(this.btnLaunch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 571);
            this.panel2.TabIndex = 13;
            // 
            // checkSNES
            // 
            this.checkSNES.AutoSize = true;
            this.checkSNES.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkSNES.Location = new System.Drawing.Point(13, 44);
            this.checkSNES.Name = "checkSNES";
            this.checkSNES.Size = new System.Drawing.Size(55, 17);
            this.checkSNES.TabIndex = 3;
            this.checkSNES.Text = "SNES";
            this.checkSNES.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkSNES.UseVisualStyleBackColor = true;
            this.checkSNES.CheckStateChanged += new System.EventHandler(this.checkSNES_CheckStateChanged);
            // 
            // checkGB
            // 
            this.checkGB.AutoSize = true;
            this.checkGB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkGB.Location = new System.Drawing.Point(27, 67);
            this.checkGB.Name = "checkGB";
            this.checkGB.Size = new System.Drawing.Size(41, 17);
            this.checkGB.TabIndex = 2;
            this.checkGB.Text = "GB";
            this.checkGB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkGB.UseVisualStyleBackColor = true;
            this.checkGB.CheckedChanged += new System.EventHandler(this.checkGB_CheckedChanged);
            // 
            // checkNes
            // 
            this.checkNes.AutoSize = true;
            this.checkNes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkNes.Location = new System.Drawing.Point(20, 21);
            this.checkNes.Name = "checkNes";
            this.checkNes.Size = new System.Drawing.Size(48, 17);
            this.checkNes.TabIndex = 1;
            this.checkNes.Text = "NES";
            this.checkNes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkNes.UseVisualStyleBackColor = true;
            this.checkNes.CheckStateChanged += new System.EventHandler(this.checkNes_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filters";
            // 
            // gameReleaseForm
            // 
            this.gameReleaseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.gameReleaseForm.Location = new System.Drawing.Point(343, 32);
            this.gameReleaseForm.Name = "gameReleaseForm";
            this.gameReleaseForm.Size = new System.Drawing.Size(390, 571);
            this.gameReleaseForm.TabIndex = 10;
            // 
            // bindFilter
            // 
            this.bindFilter.DataSource = typeof(ArcadeDesktop.GameFilter);
            this.bindFilter.CurrentItemChanged += new System.EventHandler(this.bindFilter_CurrentItemChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 603);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gameReleaseForm);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Sam\'s Arcade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageList;
        private Controls.GameReleaseForm gameReleaseForm;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindFilter;
        private System.Windows.Forms.CheckBox checkSNES;
        private System.Windows.Forms.CheckBox checkGB;
        private System.Windows.Forms.CheckBox checkNes;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button btnSearch;
    }
}

