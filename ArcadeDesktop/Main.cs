using ArcadeDataLayer.Objects;
using ArcadeDesktop.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace ArcadeDesktop
{
    public partial class Main : Form
    { 
        public Main()
        {
            InitializeComponent();

            filter = new GameFilter();

            bindFilter.DataSource = filter;
        }

        public GameFilter filter;

        public ListViewItem getSelectedListViewItem()
        {
            if (listView == null || listView.SelectedItems.Count == 0) { return null; }

            var row = listView.SelectedItems[0];

            if (row == null) { return null; }

            return row;
        }

        public GameRelease getSelectedGame()
        {
            if (listView == null || listView.SelectedItems.Count == 0) { return null; }

            var row = listView.SelectedItems[0];

            return row.Tag as GameRelease;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            LaunchGame(getSelectedGame());
            /*
            var row = getSelectedListViewItem();
             
            if (row != null)
            {
                LaunchGameByName(row.Text);
            }*/
        }
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LaunchGame(getSelectedGame());

            //var row = getSelectedListViewItem();
            //if (row != null)
            //{
            //    LaunchGameByName(row.Text);
            //}
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
        /// 
        /// TODO: move outside form into an EXE helper
        /// </summary>
        /// <param name="rowText"></param>
        private   void LaunchGame(GameRelease game)
        {
            string exe = string.Empty;
            string file = Properties.Settings.Default.nes_rom + @"\" + game.Gamefile;
            ProcessStartInfo startInfo;
            Process process;

            try
            {
                switch(game.Extension)
                {
                    case ".nes": 
                        exe = Properties.Settings.Default.nes_emu; 
                    
                    
                    //so far most emus work (except fceux, that fails on many roms)
                       //jnes, virtuanes, nestopia are all decent
                        startInfo = new ProcessStartInfo();
                        startInfo.FileName = exe; 
                        startInfo.WorkingDirectory = Properties.Settings.Default.nes_rom + @"\";
                         

                        startInfo.Arguments = game.Gamefile;// file;

                        process = Process.Start(startInfo);

                         
                    break;    case ".smc": 
                        exe = Properties.Settings.Default.smc_emu; 
                    
                    
                        startInfo = new ProcessStartInfo();
                        startInfo.FileName = exe;
                     //   startInfo.WindowStyle = ProcessWindowStyle.Maximized;

                        startInfo.WorkingDirectory = Properties.Settings.Default.nes_rom + @"\";
                         
                        //fullscreen and then the file

                        //the fullscreen DOES work but leave it off for now
                        startInfo.Arguments = "\""+ game.Gamefile+"\"";// file;

                        process = Process.Start(startInfo);


                    
                    break;    default:
                        MessageBox.Show(String.Format("Software not set for game type {0}.  Check the Settings menu", game.Extension));


                    break;
                }//end switch

                if (exe == string.Empty)
                {
                    return;
                }


                #region failedFullScreen
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
                #endregion
            }//end of try
            catch (Exception e)
            {
                MessageBox.Show("Cannot find emulator.  Link to the file in the Settings menu.  If this still does not work, try setting the emulator as the default program to open the files (snes9x needs this sometimes)");
            } //"Cannot find emulator.  Link to the file in the Settings menu."
        
        
        }
         
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshRoms();
        }

        private void refreshRoms()
        {
            Program.GameReleaseList = new List<GameRelease>();
            listView.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(Properties.Settings.Default.nes_rom);

            int INES = 0;
            int ISNES = 1;
             

            
            //filter by the bound checkboxes using file extensions
            var extensions = filter.visibleExtensions();
            var files = extensions.SelectMany(ext => dir.GetFiles(ext));//var files = dir.GetFiles("*.nes");


            
            foreach (var file in files)
            {
                if (string.IsNullOrEmpty(filter.StartsWith) || file.Name.ToLower().StartsWith(filter.StartsWith.ToLower()))  
                {
                   
                    //either the filter is null, or it matches
                    var g = new GameRelease();

                    g.Gamefile = file.Name;
                    g.Extension = file.Extension;

                    Program.GameReleaseList.Add(g);
                } 
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
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //TODO: make SHOWFORM function
            this.Enabled = false;
            var frm = new ArcadeDesktop.Forms.Help();
            frm.ShowDialog();
            this.Enabled = true;
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
            if (row != null)
            { 
                gameReleaseForm.setGame(row.Tag as GameRelease); 
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSettingsWindow();
        }
 
        /// <summary>
        /// on the binding source, not on the control itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindFilter_CurrentItemChanged(object sender, EventArgs e)
        {
           // refreshRoms();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchGames();
        }


        private void SearchGames()
        {
            filter.StartsWith =  SearchBox.Text;
            refreshRoms();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchGames();
            }
        }

        private void checkNes_CheckStateChanged(object sender, EventArgs e)
        {
            filter.ShowNES = ((sender as CheckBox).CheckState == CheckState.Checked);
            refreshRoms();
        }

        private void checkSNES_CheckStateChanged(object sender, EventArgs e)
        { 
            filter.ShowSNES = ((sender as CheckBox).CheckState == CheckState.Checked);
            refreshRoms();
        }

        private void checkGB_CheckedChanged(object sender, EventArgs e)
        {
            filter.ShowGB = ((sender as CheckBox).CheckState == CheckState.Checked);
            refreshRoms();
        }

         
    }
}
