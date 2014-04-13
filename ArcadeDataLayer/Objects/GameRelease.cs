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
        public Game game;
        public int year;
        public string gamefile;
        public string region;
        public string system;
        public bool isFirst;
        public List<GameReleaseImage> images;
    }
}
