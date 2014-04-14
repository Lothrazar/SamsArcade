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
            gameReleaseGrid1.RefreshRoms();
        }
        private void btnImageFetch_Click(object sender, EventArgs e)
        {

        }

        private static Image GetImageFromUrl(string url)
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
