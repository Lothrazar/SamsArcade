using ArcadeDataLayer.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeDesktop.Forms
{
    public partial class ImportImageForm : Form
    {
        public ImportImageForm()
        {
            InitializeComponent();
        }
         
        public void setGame(GameRelease game)
        {
            imageDownloader.setGame(game);
        }

    }
}
