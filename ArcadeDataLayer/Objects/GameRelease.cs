using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeDataLayer.Objects
{
    public class GameRelease
    {
        public GameRelease() 
        {
            images = new List<GameReleaseImage>();
            saves = new List<string>();
            saveStates = new List<string>();
        }

        public Game game {get;set;}
        public int year { get; set; }
        public string file { get; set; }
        public string file_ext { get; set; }
        public string region { get; set; }
        public string system { get; set; }
        public bool isFirst { get; set; }
        public List<GameReleaseImage> images;
        public List<String> saves;
        public List<String> saveStates ;

        public int CountSaveStates { get { return saveStates.Count; } }

        private string nameWithoutExt;

        public string game_id { get{return nameWithoutExt; } }

        public string Gamefile { get { return file; } 
            set 
            {
                file = value;
                nameWithoutExt = file.Split('.').ToList().FirstOrDefault();
            } 
        }
        public string Extension { get { return file_ext; } set { file_ext = value; } }
    }
}
