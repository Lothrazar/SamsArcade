using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeDataLayer.Objects
{
    public class Emulator
    {

        public Emulator()
        {
            list_file_exts = new List<string>();
        }
        public string name { get; set; }
        public string homepage { get; set; }
        public string filepath { get; set; }
        public string icon { get; set; }

        public List<string> list_file_exts { get; set; }
         
        public string display_file_exts
        {
            get
            {
                if(list_file_exts == null) { list_file_exts = new List<string>(); }

                return String.Join(",", list_file_exts);
            }
        }
    }
}
