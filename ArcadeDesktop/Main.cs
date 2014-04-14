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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if( dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) <= 0)
            {
                //no rows selected //TODO: maybe show a message
                return;
            }

            var row = dataGridView1.SelectedRows[0].DataBoundItem as GameRelease;

            if (row == null) { return; }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Properties.Settings.Default.nes_emu;
            startInfo.Arguments = Properties.Settings.Default.nes_rom + @"\" + row.gamefile;
            Process.Start(startInfo);
        }
         
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var games = new List<GameRelease>();

            DirectoryInfo d = new DirectoryInfo(Properties.Settings.Default.nes_rom);
           
            foreach (var file in d.GetFiles("*.nes"))
            {
                var g = new GameRelease();

                g.gamefile = file.Name;
                games.Add(g);
            }

            bindGames.DataSource = games;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var frm = new About();
            frm.ShowDialog();
            this.Enabled = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.Enabled = false;
            var frm = new Settings();
            frm.ShowDialog();
            this.Enabled = true;
        }
    }
}
