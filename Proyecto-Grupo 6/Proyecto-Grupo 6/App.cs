using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Grupo_6
{
    [Serializable]
    class App
    {
        private List<Song> allSongs = new List<Song>();
        private List<Video> allVideos = new List<Video>();
        private List<Playlist> allMusicPL = new List<Playlist>();
        private List<Playlist> allVidPL = new List<Playlist>();
        private Server server = new Server();
        
        public string SeeMusicPL() //Solo va a mostrar las playlist publicas de la app//
        {
            string PLinfo = "";
            for (int i=0; i < allMusicPL.Count(); i++)
            {
                if (allMusicPL[i].GetPrivacy() == false)
                {
                    PLinfo += allMusicPL[i].GetInfoPL() + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    continue;
                }
            }
            return PLinfo;
        }

        public string SeeVidPL() //Solo va a mostrar las playlist publicas de la app//
        {
            string PLinfo = "";
            for (int i = 0; i < allVidPL.Count(); i++)
            {
                if (allVidPL[i].GetPrivacy() == false)
                {
                    PLinfo += allVidPL[i].GetInfoPL() + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    continue;
                }
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

        public string SeeAllVid()
        {
            string Vids = "";
            for(int i = 0; i < allVideos.Count(); i++)
            {
                Vids += allVideos[i].GetData() + Environment.NewLine + Environment.NewLine;
            }
            return Vids;
        }

        
        public string MakePL(string PLType,string NamePlaylist, string KindPlaylist, bool Privacy, List<Multimedia> AllFiles)
        {
            if (PLType == "Songs")
            {
                int counter = 0;
                for (int i=0; i<allMusicPL.Count(); i++)
                {
                    if (NamePlaylist == allMusicPL[i].GetNamePL())
                    {
                        counter += 1;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (counter == 0)
                {
                    Playlist playlist = new Playlist();
                    if (server.GetActive().GetPrivacy() == false)
                    {
                        playlist.CreatePlaylist(NamePlaylist, KindPlaylist, Privacy, AllFiles, server.GetActive());
                        allMusicPL.Add(playlist);
                        return "Playlist created successfully";
                    }
                    else
                    {
                        playlist.CreatePlaylist(NamePlaylist, KindPlaylist, true, AllFiles, server.GetActive()); //playlist privada porque usuario privado//
                        allMusicPL.Add(playlist);
                        return "Playlist created successfully";
                    }
                    
                }
                else
                {
                    return "There's already a playlist with that name! Try again.";
                }
            }
            else if (PLType == "Videos")
            {
                int counter = 0;
                for (int i = 0; i < allVidPL.Count(); i++)
                {
                    if (NamePlaylist == allVidPL[i].GetNamePL())
                    {
                        counter += 1;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (counter == 0)
                {
                    Playlist playlist = new Playlist();
                    if (server.GetActive().GetPrivacy() == false)
                    {
                        playlist.CreatePlaylist(NamePlaylist, KindPlaylist, Privacy, AllFiles, server.GetActive());
                        allMusicPL.Add(playlist);
                        return "Playlist created successfully";
                    }
                    else
                    {
                        playlist.CreatePlaylist(NamePlaylist, KindPlaylist, true, AllFiles, server.GetActive()); //playlist provada porque usuario privado//
                        allMusicPL.Add(playlist);
                        return "Playlist created successfully";
                    }
                }
                else
                {
                    return "There's already a playlist with that name! Try again.";
                }
            }

            else
            {
                return "Invalid command";
            }
        }
        

    }
}
