namespace ArcadeDesktop.Forms
{
    partial class ManageEmulatorsForm
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
            this.manageEmulatorsGrid1 = new ArcadeDesktop.Controls.ManageEmulatorsGrid();
            this.SuspendLayout();
            // 
            // manageEmulatorsGrid1
            // 
            this.manageEmulatorsGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageEmulatorsGrid1.Location = new System.Drawing.Point(0, 0);
            this.manageEmulatorsGrid1.Name = "manageEmulatorsGrid1";
            this.manageEmulatorsGrid1.Size = new System.Drawing.Size(650, 276);
            this.manageEmulatorsGrid1.TabIndex = 0;
            // 
            // ManageEmulatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 276);
            this.Controls.Add(this.manageEmulatorsGrid1);
            this.Name = "ManageEmulatorsForm";
            this.Text = "ManageEmulatorsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ManageEmulatorsGrid manageEmulatorsGrid1;
    }
}