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
        }



        /*Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
    config.AppSettings.Settings.Add("YourKey", "YourValue");
    config.Save(ConfigurationSaveMode.Minimal);*/
    }
}
