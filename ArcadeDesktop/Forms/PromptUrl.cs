using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeDesktop.Forms
{
    public partial class PromptUrl : Form
    {
        public PromptUrl()
        {
            InitializeComponent();
        }
        public string URL = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            URL = textUrl.Text;//so that the parent form can grab it
        }
    }
}
