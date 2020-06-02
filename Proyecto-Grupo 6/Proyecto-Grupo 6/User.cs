using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto_Grupo_6
{
    [Serializable]
    class User
    {
        private string Name;
        private string Surname;
        private string Username;
        private string Password;
        private List<Playlist> YourMusic=new List<Playlist>() { };
        private List<Playlist> YourVideos = new List<Playlist>() { };
        private bool AVI; //la foto de perfil la definimos momentaneamente como un bool. tiene o no//
        private List<Multimedia> FaveSongs = new List<Multimedia>() { };
        private List<Multimedia> FaveVids = new List<Multimedia>() { };
        private bool AccPrivacy;
        private bool Membership = false;
        private List<Multimedia> Downloads = new List<Multimedia>() { };
        private string Time="";
        private List<Multimedia> SongQueue = new List<Multimedia>() { };
        private List<Multimedia> VidQueue = new List<Multimedia>() { };
        private List<Playlist> FollowedPlaylistMusic = new List<Playlist>() { };
        private List<Playlist> FollowedPlaylistVid = new List<Playlist>() { };
        private List<Workers> FollowedArtists = new List<Workers>() { };
        private List<User> FollowedUsers = new List<User>() { };
        private bool Admin;

        public void SignUp(string Name, string Surname, string Username, string Password, bool AVI)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Password = Password;
            this.Username = Username;
            this.AVI = AVI;
        }

        public string GetUsername()
        {
            return Username;
        }

        public void TogglePrivacy(bool Privacy)
        {
            this.AccPrivacy = Privacy;
        }

        public void AddMusicPlaylist(Playlist playlist)
        {
            this.YourMusic.Add(playlist);
        }

        public void AddVidPlaylist(Playlist playlist)
        {
            this.YourVideos.Add(playlist);
        }

        public void AddFavSong(Multimedia song)
        {
            this.FaveSongs.Add(song);
        }

        public void AddFavVid(Multimedia vid)
        {
            this.FaveVids.Add(vid);
        }

        public void FollowUser(User user)
        {
            this.FollowedUsers.Add(user);
        }

        public void FollowMusicPL(Playlist playlist)
        {
            this.FollowedPlaylistMusic.Add(playlist);
        }

        public void FollowVidPL(Playlist playlist)
        {
            this.FollowedPlaylistVid.Add(playlist);
        }

        public void FollowArtist(Workers artist)
        {
            this.FollowedArtists.Add(artist);
        }

        public void ManageMembership(bool membership)
        {
            this.Membership = membership;
        }

        public void DownloadSong(Multimedia song)
        {
            this.Downloads.Add(song);
        }

        public void AddSongQueue(Multimedia song)
        {
            this.SongQueue.Add(song);
        }

        public void AddVidQueue(Multimedia vid)
        {
            this.VidQueue.Add(vid);
        }

        public void ToggleAdmin(bool AdminStatus)
        {
            this.Admin = AdminStatus;
        }

        public string GetPassword()
        {
            return Password;
        }

        public bool GetPrivacy()
        {
            return AccPrivacy;
        }

        public bool GetMember()
        {
            return Membership;
        }

        public List<Playlist> GetYourMusic()
        {
            return this.YourMusic;
        }

        public List<Playlist> GetYourVideos()
        {
            return this.YourVideos;
        }

        public bool GetAdmin()
        {
            return Admin;
        }

        public List<User> GetFollowedUsers()
        {
            return FollowedUsers;
        }

        public List<Playlist> GetFollowedMusicPL()
        {
            return FollowedPlaylistMusic;
        }

        public List<Playlist> GetFollowedVidPL()
        {
            return FollowedPlaylistVid;
        }

        public List<Workers> GetFollowedArtists()
        {
            return FollowedArtists;
        }
        public void ResetQueue(int diff)
        {
            if (diff == 0)
            {
                this.SongQueue = new List<Multimedia>();
            }
            else
            {
                this.VidQueue = new List<Multimedia>();
            }
        }

        public List<Multimedia> GetQueue(int diff)
        {
            if (diff == 0)
            {
                return this.SongQueue;
            }
            else
            {
                return this.VidQueue;
            }
        }

        public void SetQueue(int diff, List<Multimedia> newQueue)
        {
            if (diff == 0)
            {
                this.SongQueue = newQueue;
            }
            else
            {
                this.VidQueue = newQueue;
            }
        }
    }
}
