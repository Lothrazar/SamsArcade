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
            //var games = new List<GameRelease>();
            //var g = new GameRelease();

            //g.gamefile = "test";


            //games.Add(g);

            //bindGames.DataSource = games;

            //dataGridView1.DataSource = bindGames;
        }

    

        private void btnLaunch_Click(object sender, EventArgs e)
        { 
            string EXE ="";
            string gamefile = "";
             
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = EXE;
            startInfo.Arguments = gamefile;
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
