using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeDataLayer.Objects
{
    class GameReleaseImage
    {
        public GameReleaseImage() { }
        
        public GameRelease release;



        public Image image;

        public string imageName;

        /// <summary>
        /// example: cartridge , box, etc
        /// </summary>
        public string type;


        /// <summary>
        /// front, back, etc
        /// </summary>
        public string face;

    }
}
