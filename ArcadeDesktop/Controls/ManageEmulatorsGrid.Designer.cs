namespace ArcadeDesktop.Controls
{
    partial class ManageEmulatorsGrid
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
            this.bindEmus = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkSNES = new System.Windows.Forms.CheckBox();
            this.checkGB = new System.Windows.Forms.CheckBox();
            this.checkNes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSetNesEmu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindFormEmu = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindEmus)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindFormEmu)).BeginInit();
            this.SuspendLayout();
            // 
            // bindEmus
            // 
            this.bindEmus.DataSource = typeof(ArcadeDataLayer.Objects.Emulator);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkSNES);
            this.panel1.Controls.Add(this.checkGB);
            this.panel1.Controls.Add(this.checkNes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnSetNesEmu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 383);
            this.panel1.TabIndex = 1;
            // 
            // checkSNES
            // 
            this.checkSNES.AutoSize = true;
            this.checkSNES.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkSNES.Location = new System.Drawing.Point(74, 88);
            this.checkSNES.Name = "checkSNES";
            this.checkSNES.Size = new System.Drawing.Size(55, 17);
            this.checkSNES.TabIndex = 8;
            this.checkSNES.Text = "SNES";
            this.checkSNES.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkSNES.UseVisualStyleBackColor = true;
            // 
            // checkGB
            // 
            this.checkGB.AutoSize = true;
            this.checkGB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkGB.Location = new System.Drawing.Point(88, 111);
            this.checkGB.Name = "checkGB";
            this.checkGB.Size = new System.Drawing.Size(41, 17);
            this.checkGB.TabIndex = 7;
            this.checkGB.Text = "GB";
            this.checkGB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkGB.UseVisualStyleBackColor = true;
            // 
            // checkNes
            // 
            this.checkNes.AutoSize = true;
            this.checkNes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkNes.Location = new System.Drawing.Point(81, 65);
            this.checkNes.Name = "checkNes";
            this.checkNes.Size = new System.Drawing.Size(48, 17);
            this.checkNes.TabIndex = 6;
            this.checkNes.Text = "NES";
            this.checkNes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkNes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "name";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindFormEmu, "name", true));
            this.textBox1.Location = new System.Drawing.Point(65, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnSetNesEmu
            // 
            this.btnSetNesEmu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetNesEmu.Image = global::ArcadeDesktop.Properties.Resources.magnifier;
            this.btnSetNesEmu.Location = new System.Drawing.Point(30, 160);
            this.btnSetNesEmu.Name = "btnSetNesEmu";
            this.btnSetNesEmu.Size = new System.Drawing.Size(110, 23);
            this.btnSetNesEmu.TabIndex = 3;
            this.btnSetNesEmu.Text = "exe location";
            this.btnSetNesEmu.UseVisualStyleBackColor = true;
            this.btnSetNesEmu.Click += new System.EventHandler(this.btnSetNesEmu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindFormEmu
            // 
            this.bindFormEmu.DataSource = typeof(ArcadeDataLayer.Objects.Emulator);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.bindEmus;
            this.listBox1.DisplayMember = "name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(257, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 108);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "name";
            // 
            // ManageEmulatorsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageEmulatorsGrid";
            this.Size = new System.Drawing.Size(925, 383);
            this.Load += new System.EventHandler(this.ManageEmulatorsGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindEmus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindFormEmu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindEmus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSetNesEmu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bindFormEmu;
        private System.Windows.Forms.CheckBox checkSNES;
        private System.Windows.Forms.CheckBox checkGB;
        private System.Windows.Forms.CheckBox checkNes;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox listBox1;
    }
}
