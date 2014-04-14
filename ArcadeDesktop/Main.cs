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
using System.Net;
using ArcadeDesktop.Forms;

namespace ArcadeDesktop
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent(); 
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            GameRelease row = null;// gameReleaseGrid.GetSelectedRow();

            if (row == null) { return; }

            try
            { 
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Properties.Settings.Default.nes_emu;
                startInfo.Arguments = Properties.Settings.Default.nes_rom + @"\" + row.gamefile;
                Process.Start(startInfo);

            }
            catch(Exception )
            {
                MessageBox.Show("Cannot find emulator.  Link to the file in the Settings menu.");
            }
        }
         
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshRoms();
        }

        private void refreshRoms()
        {
            Program.GameReleaseList = new List<GameRelease>(); 
            DirectoryInfo d = new DirectoryInfo(Properties.Settings.Default.nes_rom);

            foreach (var file in d.GetFiles("*.nes"))
            {
                var g = new GameRelease();

                g.gamefile = file.Name;
                Program.GameReleaseList.Add(g);
            }

          //  gameReleaseGrid.RefreshRoms(GameReleaseList);
        }
    

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAboutWindow();
        }

        private void showAboutWindow()
        {
            this.Enabled = false;
            var frm = new About();
            frm.ShowDialog();
            this.Enabled = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSettingsWindow();
        }

        private void showSettingsWindow()
        {
            this.Enabled = false;
            var frm = new Settings();
            frm.ShowDialog();
            this.Enabled = true;

            if (frm.DialogResult == DialogResult.OK)
            {
                refreshRoms();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
         

            refreshRoms(); 
        }
 

        /// <summary>
        /// events for both radio btns go here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioView_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (sender as RadioButton);
            if((sender as RadioButton).Checked)
            {
                Properties.Settings.Default.view = radio.Tag.ToString();

                Properties.Settings.Default.Save();
            }
        }

      

        private void manageGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var frm = new ManageGames();
            frm.ShowDialog();
            this.Enabled = true;
        }
      
    }
}
