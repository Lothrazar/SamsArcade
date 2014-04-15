using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeDesktop
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent(); 
        }

        //TODO: suggested download link : http://www.s9x-w32.de/dl/testbuilds/snes9x_testbuild_22032014.zip



        private void Settings_Load(object sender, EventArgs e)
        {
            getSettingsConfig();
        }

        private void SetNesEmu_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK) 
            {
                nesEmuText.Text = openFileDialog.FileName;
            }
        }
        private void btnSetSNesEmu_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                snesEmuText.Text = openFileDialog.FileName;
            }

        } 
        private void btnSetNesFolder_Click(object sender, EventArgs e)
        {
             FolderBrowserDialog dlg = new FolderBrowserDialog();

             dlg.SelectedPath = Properties.Settings.Default.nes_rom;

             if (dlg.ShowDialog() == DialogResult.OK)
             {
                 nesRomText.Text = dlg.SelectedPath;
             }
        }

        private void btnImageFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            dlg.SelectedPath = Properties.Settings.Default.nes_rom;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imageText.Text = dlg.SelectedPath;
            }
        } 
         
        private void getSettingsConfig()
        {
            nesEmuText.Text = Properties.Settings.Default.nes_emu;

            nesRomText.Text = Properties.Settings.Default.nes_rom;

            imageText.Text = Properties.Settings.Default.nes_img;

            snesEmuText.Text = Properties.Settings.Default.smc_emu;
        }

        private void saveSettingsConfig()
        {
            Properties.Settings.Default.nes_emu = nesEmuText.Text; 
            Properties.Settings.Default.nes_rom = nesRomText.Text;
            Properties.Settings.Default.nes_img = imageText.Text;
            Properties.Settings.Default.smc_emu = snesEmuText.Text; 

            Properties.Settings.Default.Save();

            Close();
        }
         
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveSettingsConfig();
        }

        private void linkSNES_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: maybe direct and indrect versions http://www.snes9x.com/phpbb3/viewtopic.php?f=6&t=12722
            System.Diagnostics.Process.Start("http://www.s9x-w32.de/dl/testbuilds/snes9x_testbuild_22032014.zip");
        }

        private void linkNES_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jabosoft.com/downloads/215");
        }

        
    }
}
