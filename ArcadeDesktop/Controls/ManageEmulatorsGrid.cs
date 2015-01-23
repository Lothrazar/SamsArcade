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
    public partial class ManageEmulatorsGrid : UserControl
    {
        List<Emulator> emus = new List<Emulator>();

        public ManageEmulatorsGrid()
        {
            InitializeComponent(); 
        }

        private void ManageEmulatorsGrid_Load(object sender, EventArgs e)
        { 
            bindEmus.DataSource = emus;

            bindFormEmu.DataSource = new Emulator();
        }

        private void btnSetNesEmu_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                (bindFormEmu.DataSource  as Emulator).filepath = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            var emu = (bindFormEmu.DataSource  as Emulator);

            if (checkNes.Checked) emu.list_file_exts.Add("nes");
            if (checkSNES.Checked) emu.list_file_exts.Add("snes");
            if (checkGB.Checked) emu.list_file_exts.Add("gb");
             
            emus.Add(emu);
            bindEmus.DataSource = emus;
            listBox1.DataSource = bindEmus;
           // dataGridView1.DataSource = bindEmus;
            //dataGridView1.Refresh();
            bindFormEmu.DataSource = new Emulator();
        }

    }
}
