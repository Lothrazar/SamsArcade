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
            string img = game.gamefile + ".png";
            try
            {
                if(System.IO.File.Exists(folder+img))
                    pictureBox.Image = Image.FromFile( folder+img );
                else
                    pictureBox.Image = null;
            }
            catch(Exception)
            {
                pictureBox.Image = null;
            }
        }


    }
}
