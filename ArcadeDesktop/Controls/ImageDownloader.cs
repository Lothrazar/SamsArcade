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
using ArcadeDesktop.Forms;

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
            var frm = new PromptUrl();
            var result = frm.ShowDialog();

            if (result != DialogResult.OK) { return; }
             
            var image = GetImageFromUrl(frm.URL);
             
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

            pictureBox.Image.Save(folder + game.Gamefile + ".png");
            this.ParentForm.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First, press 'Search the web', or find an image yourself.  Then copy the direct URL to the box below, and press 'Fetch'.  If this worked, the image will appear on the main screen.  If this is the image you want, press 'Download'");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("http://www.jabosoft.com/downloads/215");
        }

        private void btnImageSelect_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                var f = openFileDialog.FileName;

                pictureBox.Image = System.Drawing.Image.FromFile(f);

                 
            }

        }
         
    }
}
