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


            tryFindImage(game);
        }

        private void tryFindImage(GameRelease game)
        {
            string folder = Properties.Settings.Default.nes_img + "\\";
            string img = game.gamefile + ".png";//image file names are not stored right now
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
    }
}
