using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        public void AddSong()
        {

        }

        public void AddVid()
        {

        }
        
        public List<Song> SearchAndPlaySong(List<string> filter)
        {
            List<Song> songFilter = new List<Song>();

            foreach (var b in filter)
            {

                foreach (var a in allSongs)
                {

                    if (a.GetName() == b)
                    {
                        songFilter.Add(a);
                    }
                    if (a.GetArtistSong() == b)
                    {
                        songFilter.Add(a);
                    }
                    if (a.GetGender() == b)
                    {
                        songFilter.Add(a);
                    }
                    if (a.GetAlbum() == b)
                    {
                        songFilter.Add(a);
                    }

                }
            }
            return songFilter;
        }

        public void SearchAndPlayVid()
        {

        }

        public void PlayPlaylist()
        {

        }

        public string FilterSongs()
        {
            return "";
        }

        public string FilterVids()
        {
            return "";
        }

        public string FilterAwards()
        {
            return "";
        }

        public string TopViewed()
        {
            return "";
        }

        public string TopRated()
        {
            return "";
        }

        public void AddToQueue(Multimedia archive)
        {

        }

        public void ResetQueue(string queueType)
        {

        }

        public void GetQueue(string queueType)
        {

        }

        public string PlayQueue(string queueType)
        {
            if (queueType == "Songs")
            {
                return "Escuchando cola de canciones";
            }

            else if (queueType == "Videos")
            {
                return "Escuchando cola de videos";
            }

            else
            {
                return "No se encontro la cola";
            }
        }

        public bool CheckMembership(User usercheck)
        {
            return (usercheck.GetMember());
        }

        public Server GetServer()
        {
            return server;
        }

        public string CloseApp()
        {
            //guardar datos de usuario etc etc para recordar//
            
            return "Cerrando aplicacion";
        }

    }
}
