using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeDataLayer.Objects
{
    class Emulator
    {
        public Emulator()
        {
            list_file_exts = new List<string>();
        }
        public String filepath { get; set; }
        public String icon { get; set; }

        public List<String> list_file_exts { get; set; }
         
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
