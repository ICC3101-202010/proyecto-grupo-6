using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    class User
    {
        private string Name;
        private string Surname;
        private string Username;
        private string Password;
        private List<Playlist> YourMusic;
        private List<Playlist> YourVideos;
        private bool AVI; //la foto de perfil la definimos momentaneamente como un bool. tiene o no//
        private List<Multimedia> FaveSongs;
        private List<Multimedia> FaveVids;
        private bool AccPrivacy;
        private bool Membership = false;
        private List<Multimedia> Downloads;
        private string Time;
        private List<Multimedia> SongQueue;
        private List<Multimedia> VidQueue;
        private List<Playlist> FollowedPlaylistMusic;
        private List<Playlist> FollowedPlaylistVid;
        private List<Workers> FollowedArtists;
        private List<User> FollowedUsers;
        private bool Admin;

        public void SignUp(string Name, string Surname, string Password, string Username, bool AVI)
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
    }
}
