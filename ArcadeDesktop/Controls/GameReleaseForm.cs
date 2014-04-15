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
        }


    }
}
