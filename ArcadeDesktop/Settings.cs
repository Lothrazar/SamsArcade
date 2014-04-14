using System;
using System.Collections.Generic;
using System.ComponentModel;
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



            getSettingsFromConfig();
        }

        private void getSettingsFromConfig()
        {
            throw new NotImplementedException();
        }

        private void SetNesEmu_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                nesEmuText.Text = openFileDialog.FileName;
            }
        }

      



        /*Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
    config.AppSettings.Settings.Add("YourKey", "YourValue");
    config.Save(ConfigurationSaveMode.Minimal);*/
    }
}
