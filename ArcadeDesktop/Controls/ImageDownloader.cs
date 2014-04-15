using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using ArcadeDataLayer.Objects;

namespace ArcadeDesktop.Controls
{
    public partial class ImageDownloader : UserControl
    {
        public ImageDownloader()
        {
            InitializeComponent();
        }

        private  GameRelease game;

        public void setGame(GameRelease gr)
        {
            game = gr;

            bindGameRelease.DataSource = game;
        }

        private void btnImageFetch_Click(object sender, EventArgs e)
        { 
             var image = GetImageFromUrl(txtUrl.Text);
             
             if (image != null)
             {
                 pictureBox.Image = image;

                 sizeLabel.Text = image.Width + "x" + image.Height;
             } 
        }



        private Image GetImageFromUrl(string url)
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

        //save to file
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) { return; }

            var folder = Properties.Settings.Default.nes_img + "\\";

            pictureBox.Image.Save(folder + game.gamefile + ".png");
        }
         
    }
}
