using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Grupo_6
{
    class Playlist
    {
        private string NamePlaylist;
        private User CreatorPlaylist;
        private int SizePlaylist;
        private string KindPlaylist;
        private bool Privacity;
        private string ImagenURL;
        private List<Multimedia> AllFiles;
        private List<User> Followers;

        public void CrearPlaylist(string NamePlaylist, int SizePlaylist, string KindPlaylist, bool Privacity, List<Multimedia> AllFiles, User Creator)
        {
            this.NamePlaylist = NamePlaylist;
            this.SizePlaylist = SizePlaylist;
            this.KindPlaylist = KindPlaylist;
            this.Privacity = Privacity;
            this.AllFiles = AllFiles;
            this.CreatorPlaylist = Creator;

        }
        public string GetCoverPagePlaylist() // El trabajo del insert de las imagenes sera desarollado mas adelante
        {
            return ("Se ha agregado un archivo imagen.jpg como caratula de la playlist");
        }
        public void SetFollower(User user)
        {
            this.Followers.Add(user);
        }
        public string GetFollower()
        {
            string follower = "";
            for (int i = 0; i < Followers.Count(); i++)
            {
                follower += Followers[i].GetUsername();
            }
            return follower;
        }
        public string GetInfoPL()
        {
            return NamePlaylist + Environment.NewLine + "Created by: " + CreatorPlaylist;
        }

    }
}
