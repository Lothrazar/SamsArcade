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

namespace ArcadeDesktop
{
    public partial class Main : Form
    {

        private List<GameRelease> GameReleaseList;

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
            GameReleaseList = new List<GameRelease>();

            DirectoryInfo d = new DirectoryInfo(Properties.Settings.Default.nes_rom);

            foreach (var file in d.GetFiles("*.nes"))
            {
                var g = new GameRelease();

                g.gamefile = file.Name;
                GameReleaseList.Add(g);
            }

            bindGames.DataSource = GameReleaseList;


            if (GameReleaseList.Count == 0)
            {
                MessageBox.Show("No roms found in current folder.  Change rom folder in the Settings menu");
            }

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
            setDefaultView();

            refreshRoms();


        }

        private void setDefaultView()
        {
            if (Properties.Settings.Default.view == "plain")
            {
                radioPlain.Checked = true; 
            }
            else if (Properties.Settings.Default.view == "img")
            {
                radioIcons.Checked = true;
            }
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

        private void btnImageFetch_Click(object sender, EventArgs e)
        {
            var image = GetImageFromUrl(txtUrl.Text);

            if (image != null)
            {
                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("Image not found.");
                pictureBox1.Image = null;
            }

        }

        private static Image GetImageFromUrl(string url)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);

                using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (Stream stream = httpWebReponse.GetResponseStream())
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch (Exception) { return null; } 
        }

        private void manageGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
