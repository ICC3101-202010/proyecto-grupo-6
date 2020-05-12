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
    class Playlist
    {
        private string NamePlaylist;
        private User CreatorPlaylist;
        private int SizePlaylist;
        private bool Privacy;
        private string ImagenURL="";
        private List<Multimedia> AllFiles=new List<Multimedia>() { };
        private List<User> Followers=new List<User>() { };

        public void CreatePlaylist(string NamePlaylist, bool Privacy, List<Multimedia> AllFiles, User Creator)
        {
            this.NamePlaylist = NamePlaylist;
            this.SizePlaylist = AllFiles.Count();
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
            return NamePlaylist + Environment.NewLine + "Created by: " + CreatorPlaylist.GetUsername();
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

        public string DeleteMedia(Multimedia media)
        {
            if (media is Song) 
            {
                bool checkDelete = false;
                foreach (var a in AllFiles)
                {
                    if (media.GetName() == a.GetName() && media.GetHashCode()==a.GetHashCode())
                    {
                        AllFiles.Remove(a);
                        checkDelete = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (checkDelete == true)
                {
                    return "Cancion eliminada con exito";
                }
                else
                {
                    return "No se encontro una cancion que cumpla las caracteristicas";
                }
            }
            else
            {
                bool checkDelete = false;
                foreach (var a in AllFiles)
                {
                    if (media.GetName() == a.GetName() && media.GetHashCode() == a.GetHashCode())
                    {
                        AllFiles.Remove(a);
                        checkDelete = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (checkDelete == true)
                {
                    return "Video eliminado con exito";
                }
                else
                {
                    return "No se encontro un video que cumpla las caracteristicas";
                }
            }
        }

        public List<Multimedia> GetAllMedia()
        {
            return AllFiles;
        }

    }
}
