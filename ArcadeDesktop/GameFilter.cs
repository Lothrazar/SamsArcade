using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeDesktop
{
    public class GameFilter
    {

        public bool ShowNES { get; set; }
        public bool ShowSNES { get; set; }
        public bool ShowGB { get; set; }

        /// <summary>
        /// based on the filter flags,which file extensions to we search by
        /// </summary>
        /// <returns></returns>
        public string[] visibleExtensions()
        {
            var vis = new List<string>();
            if (ShowNES) vis.Add("*.nes");
            if (ShowSNES) vis.AddRange(new string[] { "*.smc", "*.fig" ,"*.sfc"});//one missing
            if (ShowGB) vis.Add("*.gb");

            return vis.ToArray();
        }

    }
}
