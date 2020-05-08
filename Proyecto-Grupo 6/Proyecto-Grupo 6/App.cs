using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    class App
    {
        private List<Song> allSongs = new List<Song>();
        private List<Video> allVideos = new List<Video>();
        private List<Playlist> allMusicPL = new List<Playlist>();
        private List<Playlist> allVidPL = new List<Playlist>();
        
        public string SeeMusicPL()
        {
            string PLinfo = "";
            for (int i=0; i < allMusicPL.Count(); i++)
            {
                PLinfo += allMusicPL[i].GetInfoPL() + Environment.NewLine + Environment.NewLine;
            }
            return PLinfo;
        }

        public string SeeVidPL()
        {
            string PLinfo = "";
            for (int i = 0; i < allVidPL.Count(); i++)
            {
                PLinfo += allVidPL[i].GetInfoPL() + Environment.NewLine + Environment.NewLine;
            }
            return PLinfo;
        }

        public string SeeAllSongs()
        {
            string Songs = "";
            for (int i = 0; i< allSongs.Count(); i++)
            {
                Songs += allSongs[i].GetData() + Environment.NewLine + allSongs[i].GetArtistSong() + Environment.NewLine + Environment.NewLine;
            }
            return Songs;
        }
    }
}
