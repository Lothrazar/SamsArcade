using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeDataLayer.Objects
{
    public class GameRelease
    {
        public GameRelease() { }
        private Game game;
        private int year;
        private string file;
        private string file_ext; 
        private string region;
        private string system;
        private bool isFirst;
        private List<GameReleaseImage> images;


        public string Gamefile { get { return file; } set { file = value; } }
        public string Extension { get { return file_ext; } set { file_ext = value; } }
    }
}
