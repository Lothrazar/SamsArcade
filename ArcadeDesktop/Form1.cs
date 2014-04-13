using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArcadeDataLayer;
using ArcadeDataLayer.Objects;

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

        private void import_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
            // This is what will execute if the user selects a folder and hits OK (File if you change to FileBrowserDialog)
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = dlg.SelectedPath;

                label3.Text = folder;

                var games = new List<GameRelease>();

                DirectoryInfo d = new DirectoryInfo(folder);
                foreach (var file in d.GetFiles("*.nes"))
                {
                    var g = new GameRelease();

                    g.gamefile = file.Name;

                }



                bindGames.DataSource = games;



            }
           



        }
    }
}
