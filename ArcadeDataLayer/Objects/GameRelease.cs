using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeDataLayer.Objects
{
    class GameRelease
    {
        public GameRelease() { }
        private Game game;

        private int year;

        private string region;

        private string system;

        private bool isFirst;

        private List<GameReleaseImage> images;
    }
}
