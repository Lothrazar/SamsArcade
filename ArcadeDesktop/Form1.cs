using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindEmu_Click(object sender, EventArgs e)
        {
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                label1.Text = ofd.FileName;
            }


        }

        private void btnFindGame_Click(object sender, EventArgs e)
        {
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                label2.Text = ofd.FileName;
            } 
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
          //  Process.Start(label2.Text);//TODO: pull from data source not display

            string EXE = label2.Text;
            string gamefile = label1.Text;


            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = EXE;
            startInfo.Arguments = gamefile;
            Process.Start(startInfo);
        }
    }
}
