using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Entrega_3
{
    
    class App
    {
        private List<Song> allSongs = new List<Song>() { };
        private List<Video> allVideos = new List<Video>() { };
        private List<Playlist> allMusicPL = new List<Playlist>() { };
        private List<Playlist> allVidPL = new List<Playlist>() { };
        private List<User> allUser = new List<User>() { };
        private List<Workers> allWorkers = new List<Workers>() { };

        private Server server = new Server();
        private Admin admin = new Admin();

        public string SeeMusicPL() //Solo va a mostrar las playlist publicas de la app//
        {
            string PLinfo = "";
            for (int i = 0; i < allMusicPL.Count(); i++)
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
            for (int i = 0; i < allSongs.Count(); i++)
            {
                Songs += allSongs[i].GetData() + Environment.NewLine + allSongs[i].GetArtistSong() + Environment.NewLine + Environment.NewLine;
            }
            return Songs;
        }

        public string SeeAllVid()
        {
            string Vids = "";
            for (int i = 0; i < allVideos.Count(); i++)
            {
                Vids += allVideos[i].GetData() + Environment.NewLine + Environment.NewLine;
            }
            return Vids;
        }


        public string MakePL(string PLType, string NamePlaylist, bool Privacy, List<Multimedia> AllFiles)
        {
            if (PLType == "Songs")
            {
                int counter = 0;
                for (int i = 0; i < allMusicPL.Count(); i++)
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
                        playlist.CreatePlaylist(NamePlaylist, Privacy, AllFiles, server.GetActive());
                        allMusicPL.Add(playlist);
                        server.AddMusicPlaylist(playlist);
                        return "Playlist created successfully";
                    }
                    else
                    {
                        playlist.CreatePlaylist(NamePlaylist, true, AllFiles, server.GetActive()); //playlist privada porque usuario privado//
                        allMusicPL.Add(playlist);
                        server.AddMusicPlaylist(playlist);
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
                        playlist.CreatePlaylist(NamePlaylist, Privacy, AllFiles, server.GetActive());
                        allVidPL.Add(playlist);
                        server.AddVidPlaylist(playlist);
                        return "Playlist created successfully";
                    }
                    else
                    {
                        playlist.CreatePlaylist(NamePlaylist, true, AllFiles, server.GetActive()); //playlist provada porque usuario privado//
                        allVidPL.Add(playlist);
                        server.AddVidPlaylist(playlist);
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

        public void AddSong(string name, string kind, string album, List<Workers> artists, List<Awards> awards, List<Workers> composers,string route)
        {
            Song song = new Song();
            song.AddSong(name, kind, album, artists, awards, composers, route);
            for (int i = 0; i < artists.Count(); i++)
            {
                allWorkers.Add(artists[i]);
            }
            allSongs.Add(song);
        }

        public void AddVid(string name, string kind, string studio, List<Workers> directors, List<Workers> actors, string route)
        {
            Video video = new Video();
            video.AddVideo(name, kind, studio, directors, actors, route);
            for (int i = 0; i < actors.Count(); i++)
            {
                allWorkers.Add(actors[i]);
            }
            allVideos.Add(video);
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

        public List<Video> SearchAndPlayVid(List<string> filter)
        {
            List<Video> videoFilter = new List<Video>();

            foreach (var b in filter)
            {

                foreach (var a in allVideos)
                {

                    if (a.GetName() == b)
                    {
                        videoFilter.Add(a);
                    }
                    if (a.GetKind() == b)
                    {
                        videoFilter.Add(a);
                    }
                    if (a.GetStudio() == b)
                    {
                        videoFilter.Add(a);
                    }

                }
            }
            return videoFilter;
        }


        public void AddToQueue(Multimedia archive, int diff)
        {
            if (diff == 0)
            {
                server.GetActive().AddSongQueue(archive);
            }
            else
            {
                server.GetActive().AddVidQueue(archive);
            }
        }

        public void ResetQueue(string queueType, int diff)
        {
            ; server.GetActive().ResetQueue(diff);
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
            saveUser(server.GetUsers());
            saveAdmin(admin);
            savePlaylistS(allMusicPL);
            savePlaylistV(allVidPL);
            saveSongs(allSongs);
            saveVideos(allVideos);
            saveWorkers(allWorkers);
            saveServer(server);
            


            return "Cerrando aplicacion";
        }

        public void OpenApp()
        {
            allUser = LoadUser();
            server.SetUsers(allUser);
            admin = LoadAdmin();
            allMusicPL = LoadPlaylistS();
            allVidPL = LoadPlaylistV();
            allWorkers = LoadWorkers();
            allSongs = LoadSongs();
            allVideos = LoadVideo();
            server = LoadServer();
            

        }

        public bool Login(string userName, string passWord)
        {
            return server.Login(userName, passWord);


        }

        public bool Register(User user)
        {
            return server.Register(user);
        }

        public void saveServer(Server server)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Server.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, server);
            stream.Close();
        }

        private Server LoadServer()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Server.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            Server server = (Server)formatter.Deserialize(stream);
            stream.Close();
            return server;
        }

        public void saveUser(List<User> allUser)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, allUser);
            stream.Close();
        }
        private List<User> LoadUser()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            List<User> allUser = (List<User>)formatter.Deserialize(stream);
            stream.Close();
            return allUser;
        }
        public void saveAdmin(Admin admin)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Admin.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, admin);
            stream.Close();
        }
        private Admin LoadAdmin()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Admin.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            Admin admin = (Admin)formatter.Deserialize(stream);
            stream.Close();
            return admin;
        }
        public void saveWorkers(List<Workers> allWorkers)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Worker.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, allWorkers);
            stream.Close();
        }
        private List<Workers> LoadWorkers()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Worker.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            List<Workers> allWorkers = (List<Workers>)formatter.Deserialize(stream);
            stream.Close();
            return allWorkers;
        }
        public void savePlaylistS(List<Playlist> allMusicPL)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("SongPL.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, allMusicPL);
            stream.Close();
        }
        private List<Playlist> LoadPlaylistS()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("SongPL.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            List<Playlist> allMusicPL = (List<Playlist>)formatter.Deserialize(stream);
            stream.Close();
            return allMusicPL;
        }
        public void savePlaylistV(List<Playlist> allVidPL)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("VidPL.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, allVidPL);
            stream.Close();
        }
        private List<Playlist> LoadPlaylistV()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("VidPL.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            List<Playlist> allVidPL = (List<Playlist>)formatter.Deserialize(stream);
            stream.Close();
            return allVidPL;
        }
        public void saveSongs(List<Song> allSongs)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Songs.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, allSongs);
            stream.Close();
        }
        private List<Song> LoadSongs()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Songs.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            List<Song> allSongs = (List<Song>)formatter.Deserialize(stream);
            stream.Close();
            return allSongs;
        }
        public void saveVideos(List<Video> allVideos)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Videos.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, allVideos);
            stream.Close();
        }
        private List<Video> LoadVideo()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Videos.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            List<Video> allVideos = (List<Video>)formatter.Deserialize(stream);
            stream.Close();
            return allVideos;
        }

        public Admin GetAdmin()
        {
            return admin;
        }

        public List<Playlist> GetPlaylist(int diff)
        {
            if (diff == 0)
            {
                return allMusicPL;
            }
            else
            {
                return allVidPL;
            }
        }

        public List<Song> GetAllSongs()
        {
            return allSongs;
        }

        public Song SearchforSong(string name)
        {
            Song song = new Song();
            for (int i = 0; i < allSongs.Count(); i++)
            {
                if (name == allSongs[i].GetName())
                {
                    song = allSongs[i];
                }
            }
            return song;
        }

        public Video SearchforVid(string name)
        {
            Video video = new Video();
            for (int i = 0; i < allVideos.Count(); i++)
            {
                if (name == allVideos[i].GetName())
                {
                    video = allVideos[i];
                }
            }
            return video;

        }

        public void Rate(string name, int diff, List<Rating> rating)
        {
            if (diff == 0)
            {
                for (int i = 0; i < allSongs.Count(); i++)
                {
                    if (name == allSongs[i].GetName())
                    {
                        allSongs[i].SetRating(rating);
                    }
                }
            }

            else
            {
                for (int i = 0; i < allVideos.Count(); i++)
                {
                    if (name == allVideos[i].GetName())
                    {
                        allVideos[i].SetRating(rating);
                    }
                }
            }
        }

        public void ReviewVid(string name, List<Review> review)
        {
            for (int i = 0; i < allVideos.Count(); i++)
            {
                if (name == allVideos[i].GetName())
                {
                    allVideos[i].SetReview(review);
                }
            }


        }
        public List<Video> Getallvideos()
        {
            return allVideos;
        }

        public List<Workers> GetWorkers()
        {
            return allWorkers;
        }
        
    }
}