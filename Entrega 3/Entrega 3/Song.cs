﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entrega_3
{
    [Serializable]
    class Song : Multimedia
    {
        private List<Workers> Artist;
        private List<Workers> Composer;
        private string Album;
        private string Lyrics;
        private List<Awards> Awards = new List<Awards>() { };
        private string Route;

        public override string Play()
        {
            return ("Se esta reproduciendo la cancion");
        }
        public void AddSong(string Name, string Kind, string Album, List<Workers> Artist, List<Awards> Awards, List<Workers> Composer, string Route)
        {
            this.Name = Name;
            this.Kind = Kind;
            this.Artist = Artist;
            this.Album = Album;
            this.Artist = Artist;
            this.Awards = Awards;
            this.Composer = Composer;
            this.Route = Route;

        }
        public override string Image()
        {
            return ("Se ha agregado un archivo imagen.jpg a la cancion");
        }
        public override void SetRating(List<Rating> Rating)
        {
            this.Rating = Rating;

        }

        public override int GetRating()
        {
            int Promedio = 0;
            for (int i = 0; i < Rating.Count(); i++)
            {
                Promedio += Rating[i].GetRating();

            }
            return Promedio / Rating.Count();
        }

        public List<Workers> GetArtist()
        {
            return Artist;
        }

        public override string GetData()
        {
            return (this.Name + ", " + this.Album);
        }
        public override int GetDataNumber()
        {
            return (this.Length + this.Reproductions + this.Size + this.Likes);
        }
        public void SetArtistSong(List<Workers> Artist)
        {
            this.Artist = Artist;
        }
        public void SetComposerSong(List<Workers> Composer)
        {
            this.Composer = Composer;
        }

        public string GetArtistSong()
        {
            if (Artist.Count() > 1)
            {
                string artist = "";
                for (int i = 0; i < Artist.Count(); i++)
                {
                    artist += Artist[i].GetName() + " " + Artist[i].GetSurname();
                    if (i == (Artist.Count() - 1))
                    {
                        break;
                    }
                    else
                    {
                        artist += ", ";
                    }
                }
                return artist;
            }
            else
            {
                return this.Artist[0].GetName() + " " + this.Artist[0].GetSurname();
            }
        }
        public string GetComposerSong()
        {
            string composer = "";
            for (int i = 0; i < Composer.Count(); i++)
            {
                composer += Composer[i].GetName() + " " + Composer[i].GetSurname();
            }
            return composer;
        }
        public string GetLyrics()
        {
            return ("Se esta visualizando la letra de la cancion");
        }
        public override void SetLikes(int Likes)
        {
            this.Likes = Likes;
        }
        public override int GetLikes()
        {
            return Likes;
        }
        public override void SetReproductions(int Reproductions)
        {
            this.Reproductions = Reproductions;
        }
        public override int GetReproductions()
        {
            return Reproductions;
        }


        public override string GetName()
        {
            return this.Name;
        }
        public string GetGender()
        {
            return this.Kind;
        }
        public string GetAlbum()
        {
            return this.Album;
        }

        public List<Awards> GetAwards()
        {
            return Awards;
        }
        public override string GetRoute()
        {
            return this.Route;
        }
        public string GetArtistName()
        {
            if (Artist.Count() > 1)
            {
                string artist = "";
                for (int i = 0; i < Artist.Count(); i++)
                {
                    artist += Artist[i].GetName() ;
                    if (i == (Artist.Count() - 1))
                    {
                        break;
                    }
                    else
                    {
                        artist += ", ";
                    }
                }
                return artist;
            }
            else
            {
                return this.Artist[0].GetName() ;
            }
        }
    }
}