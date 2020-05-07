using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    class Song : Multimedia
    {
        private List<Workers> Artist;
        private List<Workers> Composer;
        private string Album;
        private string Lyrics;
        private List<string> Awards;

        public override string Play()
        {
            return ("Se esta reproduciendo la cancion");
        }
        public void AddSong(string Name, string Kind, string Album, List<Workers> Artist, List<string> Awards, List<Workers> Composer, int Lenght)
        {
            this.Name = Name;
            this.Kind = Kind;
            this.Artist = Artist;
            this.Album = Album;
            this.Artist = Artist;
            this.Awards = Awards;
            this.Composer = Composer;
            this.Lenght = Lenght;
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

        public override string GetData()
        {
            return (this.Name + " " + this.Kind + " " + this.Album + " " + this.Artist);
        }
        public override int GetDataNumber()
        {
            return (this.Lenght + this.Reproductions + this.Size + this.Likes);
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
            string artist = "";
            for (int i = 0; i < Artist.Count(); i++)
            {
                artist += Artist[i].GetName() + " " + Artist[i].GetSurname();
            }
            return artist;
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
        //public string GetAwards()
        //{
        //string award = "";
        //for (int i= 0; i < Awards.Count(); i++)
        //{
        //award += Awards[i].();
        //}
        //return award;

    }
}
