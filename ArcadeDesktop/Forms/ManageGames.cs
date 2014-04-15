using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeDesktop.Forms
{
    public partial class ManageGames : Form
    {
        public ManageGames()
        {
            InitializeComponent();
        }

        private void ManageGames_Load(object sender, EventArgs e)
        {
            gameReleaseGrid.RefreshRoms();
        }
        private void btnImageFetch_Click(object sender, EventArgs e)
        {
            var row = gameReleaseGrid.GetSelectedRow();
            if (row == null) { return; }

            
            var image = GetImageFromUrl(txtUrl.Text) ;

            if(image != null)
            {
                pictureBox1.Image = image;

            }

           // var folder = Properties.Settings.Default.nes_img + "\\";


           // image.Save(folder + row.gamefile+".png");
        }
 


        private   Image GetImageFromUrl(string url)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);

                using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (Stream stream = httpWebReponse.GetResponseStream())
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch (Exception) { return null; }
        }

        
    }
}
