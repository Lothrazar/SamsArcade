namespace ArcadeDesktop
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.nesEmuText = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSetNesEmu = new System.Windows.Forms.Button();
            this.nesRomText = new System.Windows.Forms.TextBox();
            this.btnSetNesFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current NES Emulator";
            // 
            // nesEmuText
            // 
            this.nesEmuText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nesEmuText.Enabled = false;
            this.nesEmuText.Location = new System.Drawing.Point(148, 15);
            this.nesEmuText.Name = "nesEmuText";
            this.nesEmuText.Size = new System.Drawing.Size(327, 20);
            this.nesEmuText.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::ArcadeDesktop.Properties.Resources.delete;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(15, 83);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close (without saving)";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = global::ArcadeDesktop.Properties.Resources.disk;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(409, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Settings";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSetNesEmu
            // 
            this.btnSetNesEmu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetNesEmu.Image = global::ArcadeDesktop.Properties.Resources.magnifier;
            this.btnSetNesEmu.Location = new System.Drawing.Point(481, 12);
            this.btnSetNesEmu.Name = "btnSetNesEmu";
            this.btnSetNesEmu.Size = new System.Drawing.Size(28, 23);
            this.btnSetNesEmu.TabIndex = 2;
            this.btnSetNesEmu.UseVisualStyleBackColor = true;
            this.btnSetNesEmu.Click += new System.EventHandler(this.SetNesEmu_Click);
            // 
            // nesRomText
            // 
            this.nesRomText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nesRomText.Enabled = false;
            this.nesRomText.Location = new System.Drawing.Point(148, 41);
            this.nesRomText.Name = "nesRomText";
            this.nesRomText.Size = new System.Drawing.Size(327, 20);
            this.nesRomText.TabIndex = 8;
            // 
            // btnSetNesFolder
            // 
            this.btnSetNesFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetNesFolder.Image = global::ArcadeDesktop.Properties.Resources.magnifier;
            this.btnSetNesFolder.Location = new System.Drawing.Point(481, 38);
            this.btnSetNesFolder.Name = "btnSetNesFolder";
            this.btnSetNesFolder.Size = new System.Drawing.Size(28, 23);
            this.btnSetNesFolder.TabIndex = 7;
            this.btnSetNesFolder.UseVisualStyleBackColor = true;
            this.btnSetNesFolder.Click += new System.EventHandler(this.btnSetNesFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NES ROM Folder";
            // 
            // Settings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(521, 124);
            this.Controls.Add(this.nesRomText);
            this.Controls.Add(this.btnSetNesFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nesEmuText);
            this.Controls.Add(this.btnSetNesEmu);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetNesEmu;
        private System.Windows.Forms.TextBox nesEmuText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox nesRomText;
        private System.Windows.Forms.Button btnSetNesFolder;
        private System.Windows.Forms.Label label2;
    }
}