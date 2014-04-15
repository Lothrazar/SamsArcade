using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArcadeDataLayer;
using ArcadeDataLayer.Objects;
using System.Net;
using ArcadeDesktop.Forms;
using System.Runtime.InteropServices;
using System.Linq;
namespace ArcadeDesktop
{
    public partial class Main : Form
    { 
        public Main()
        {
            InitializeComponent(); 
        }

        public ListViewItem getSelectedListViewItem()
        {
            if (listView == null || listView.SelectedItems.Count == 0) { return null; }

            var row = listView.SelectedItems[0];

            if (row == null) { return null; }

            return row;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            var row = getSelectedListViewItem();
             
            if (row != null)
            {
                LaunchGameByName(row.Text);
            }
        }
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var row = getSelectedListViewItem();
            if (row != null)
            {
                LaunchGameByName(row.Text);
            }
        }
       /* [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        */
       /* [DllImport("user32.dll")]
        private extern static bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);
        */
        /// <summary>
        /// called by the button and by double click on an item
        /// </summary>
        /// <param name="rowText"></param>
        private   void LaunchGameByName(string rowText)
        {
      
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Properties.Settings.Default.nes_emu;
                startInfo.Arguments = Properties.Settings.Default.nes_rom + @"\" + rowText;
             //   startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                
                var process = Process.Start(startInfo);
/*trying to force it full screen, its not working
                if (process.WaitForInputIdle(15000))//, SetWindowPosFlags.SWP_SHOWWINDOW
                    SetWindowPos(process.MainWindowHandle, this.Handle, 10, 10,this.Width, this.Height,0x0040);
                */

             /*   //try to send alt enter ,. this also didnt work for me
                if (process.WaitForInputIdle(15000)) 
                {
                    //http://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send.aspx
                    SetForegroundWindow(process.Handle); 
                    SendKeys.Send("%({ENTER})");
                   // SendKeys.Flush();
                     

                  }
                */
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot find emulator.  Link to the file in the Settings menu.");
            }
        
        
        }
         
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshRoms();
        }

        private void refreshRoms()
        {
            Program.GameReleaseList = new List<GameRelease>();
            DirectoryInfo dir = new DirectoryInfo(Properties.Settings.Default.nes_rom);

            int INES = 0;
            int ISNES = 1;

            //TODO: list or enumeration in data layer for these extensions
            var extensions = new[] { "*.nes", "*.smc" };
            var files = extensions.SelectMany(ext => dir.GetFiles(ext));//var files = dir.GetFiles("*.nes");
            foreach (var file in files)
            {
                var g = new GameRelease();

                g.Gamefile = file.Name;
                g.Extension = file.Extension;

                Program.GameReleaseList.Add(g);
            }
            ListViewItem item;
             
            //  gameReleaseGrid.RefreshRoms(GameReleaseList);
            foreach (var g in Program.GameReleaseList)
            {
                int imageIndex = g.Extension == ".nes" ? INES : ISNES;
                item = new ListViewItem(g.Gamefile, imageIndex);
                item.Tag = g;
                
                listView.Items.Add(item);
            } 
        }
    

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAboutWindow();
        }

        private void showAboutWindow()
        {
            this.Enabled = false;
            var frm = new About();
            frm.ShowDialog();
            this.Enabled = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSettingsWindow();
        }

        private void showSettingsWindow()
        {
            this.Enabled = false;
            var frm = new Settings();
            frm.ShowDialog();
            this.Enabled = true;

            if (frm.DialogResult == DialogResult.OK)
            {
                refreshRoms();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
         

            refreshRoms(); 
        }
 

        /// <summary>
        /// events for both radio btns go here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioView_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (sender as RadioButton);
            if((sender as RadioButton).Checked)
            {
                Properties.Settings.Default.nes_img = radio.Tag.ToString();

                Properties.Settings.Default.Save();
            }
        }

      

        private void manageGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var frm = new ManageGames();
            frm.ShowDialog();
            this.Enabled = true;
        }

   

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = getSelectedListViewItem();
            if (row == null)
            {
                //TODO: how to get GameRelease object from text
               // labelTest.Text = ""; //nothing selected
            }
            else
            {
                gameReleaseForm.setGame(row.Tag as GameRelease);
            //    imageDownloader.setGame(row.Tag as GameRelease);
               // labelTest.Text = row.Text;
            }
        }

      
    }
}
