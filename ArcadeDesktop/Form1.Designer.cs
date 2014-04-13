namespace ArcadeDesktop
{
    partial class Form1
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
            this.btnFindEmu = new System.Windows.Forms.Button();
            this.btnFindGame = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindEmu
            // 
            this.btnFindEmu.Location = new System.Drawing.Point(28, 65);
            this.btnFindEmu.Name = "btnFindEmu";
            this.btnFindEmu.Size = new System.Drawing.Size(127, 23);
            this.btnFindEmu.TabIndex = 0;
            this.btnFindEmu.Text = "Find Game File";
            this.btnFindEmu.UseVisualStyleBackColor = true;
            this.btnFindEmu.Click += new System.EventHandler(this.btnFindEmu_Click);
            // 
            // btnFindGame
            // 
            this.btnFindGame.Location = new System.Drawing.Point(28, 123);
            this.btnFindGame.Name = "btnFindGame";
            this.btnFindGame.Size = new System.Drawing.Size(127, 23);
            this.btnFindGame.TabIndex = 1;
            this.btnFindGame.Text = "Find Game";
            this.btnFindGame.UseVisualStyleBackColor = true;
            this.btnFindGame.Click += new System.EventHandler(this.btnFindGame_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(28, 196);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(127, 23);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnFindGame);
            this.Controls.Add(this.btnFindEmu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindEmu;
        private System.Windows.Forms.Button btnFindGame;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

