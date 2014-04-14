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
         
        private void SetNesEmu_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK) 
            {
                nesEmuText.Text = openFileDialog.FileName;
            }
        }

        private void btnSetNesFolder_Click(object sender, EventArgs e)
        {
             FolderBrowserDialog dlg = new FolderBrowserDialog();
      
             if (dlg.ShowDialog() == DialogResult.OK)
             {
                 nesRomText.Text = dlg.SelectedPath;
             }
        } 

        private void Settings_Load(object sender, EventArgs e)
        {
            getSettingsConfig(); 
        }

        private void getSettingsConfig()
        {
            nesEmuText.Text = Properties.Settings.Default.nes_emu;

            nesRomText.Text = Properties.Settings.Default.nes_rom; 
        }

        private void saveSettingsConfig()
        {
            Properties.Settings.Default.nes_emu = nesEmuText.Text;

            Properties.Settings.Default.nes_rom = nesRomText.Text;

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
    }
}
