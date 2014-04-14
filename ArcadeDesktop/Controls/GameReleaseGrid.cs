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
using System.IO;

namespace ArcadeDesktop
{
    public partial class GameReleaseGrid : UserControl
    {
        public GameReleaseGrid()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = true;
        }

        private void GameReleaseGrid_Load(object sender, EventArgs e)
        {

        }

        public GameRelease GetSelectedRow()
        {
            return dataGridView1.SelectedRows[0].DataBoundItem as GameRelease;
        }

        public void RefreshRoms(List<GameRelease> GameReleaseList)
        {  
            bindGames.DataSource = GameReleaseList;


            if (GameReleaseList.Count == 0)
            {
                MessageBox.Show("No roms found in current folder.  Change rom folder in the Settings menu");
            }

        }
    }
}
