using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Grupo_6
{
    [Serializable]
    class Playlist
    {
        private string NamePlaylist;
        private User CreatorPlaylist;
        private int SizePlaylist;
        private string KindPlaylist;
        private bool Privacy;
        private string ImagenURL;
        private List<Multimedia> AllFiles;
        private List<User> Followers;

        public void CreatePlaylist(string NamePlaylist, string KindPlaylist, bool Privacy, List<Multimedia> AllFiles, User Creator)
        {
            this.NamePlaylist = NamePlaylist;
            this.SizePlaylist = AllFiles.Count();
            this.KindPlaylist = KindPlaylist;
            this.Privacy = Privacy; //true significa privado//
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

        public string GetNamePL()
        {
            return NamePlaylist;
        }

        public bool GetPrivacy()
        {
            return Privacy;
        }

        public string AddMedia(Multimedia media) //Falta la logica para comprobar si el archivo ya existe dentro de la playlist//
        {
            if (media is Song)
            {
                AllFiles.Add(media);
                return "Se anadio la cancion con exito";
            }
            else
            {
                AllFiles.Add(media);
                return "Se anadio el video con exito";
            }
        }

    }
}
