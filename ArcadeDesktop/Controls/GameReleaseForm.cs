using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArcadeDataLayer.Objects;
using ArcadeDesktop.Forms;
using System.IO;

namespace ArcadeDesktop.Controls
{
    public partial class GameReleaseForm : UserControl
    {
        public GameReleaseForm()
        {
            InitializeComponent();
        }

        private GameRelease game;

        public void setGame(GameRelease gr)
        {
            game = gr;

            bindGameRelease.DataSource = game;

            tryFindImage();

            searchAllSaves();
        }

        private void tryFindImage()
        {
            string folder = Properties.Settings.Default.nes_img + "\\";
            string img = game.Gamefile + ".png";//image file names are not stored right now
            //we just rename them on download to match the game file
            try
            {
                if (System.IO.File.Exists(folder + img)) // try not to throw exception
                {
                    pictureBox.Image = Image.FromFile(folder + img);
                    textBoxImageLoc.Text = folder + img; 
                }
                else
                {
                    pictureBox.Image = null;
                    textBoxImageLoc.Text = String.Empty;
                }
            }
            catch(Exception)
            {
                pictureBox.Image = null;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var frm = new ImportImageForm();
            frm.setGame(this.game);
            frm.ShowDialog();
            this.Enabled = true; 


        }

        private void btnStates_Click(object sender, EventArgs e)
        {
            searchAllSaves();
             
        }

        private void searchAllSaves()
        {
            

            //""ss0 to ss9

            List<string> extsToSearch = new List<string>() { 
                             "ss0","ss1","ss2"
                            ,"ss3","ss4","ss5"
                            ,"ss6","ss7","ss8","ss9"};


            DirectoryInfo dir = new DirectoryInfo(Properties.Settings.Default.nes_rom);


            //filter by the bound checkboxes using file extensions
            //var extensions = filter.visibleExtensions();
            //var files = extsToSearch.SelectMany(ext => dir.GetFiles("*." + ext)).ToList();//var files = dir.GetFiles("*.nes");
            var files = extsToSearch.SelectMany(ext => dir.GetFiles(game.game_id + "." + ext)).ToList();//var files = dir.GetFiles("*.nes");
            //TODO: loop/merge
            game.saveStates = new List<string>();
            game.saveStates.AddRange(files.Select(x => x.FullName));
            textSaves.Text = game.saveStates.Count.ToString();

            //String.Join(",",game.saveStates.Select(x => x).ToArray());

            /*   foreach (var file in files)
            {
                if (string.IsNullOrEmpty(filter.StartsWith) || file.Name.ToLower().StartsWith(filter.StartsWith.ToLower()))  
                {
                   
                    //either the filter is null, or it matches
                    var g = new GameRelease();

                    g.Gamefile = file.Name;
                    g.Extension = file.Extension;

                    Program.GameReleaseList.Add(g);
                } 
            }*/
        }

  
        private void btnFolder_Click(object sender, EventArgs e)
        {

            string search = Properties.Settings.Default.nes_rom + "\\";

            //search for states

            System.Diagnostics.Process.Start(search);
        } 
    }
}
