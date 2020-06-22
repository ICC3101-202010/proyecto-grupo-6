using System;
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
    class Video : Multimedia
    {
        private List<Workers> Actors;
        private List<Workers> Directors;

        string Route;
        public override string Play()
        {
            return ("Se esta reproduciendo el video");
        }
        public override string Image()
        {
            return ("Se ha agregado un archivo imagen.jpg al video");
        }
        public void AddVideo(string Name, string Kind, string Studio, List<Workers> Directors, List<Workers> Actors, string Route)
        {
            this.Name = Name;
            this.Kind = Kind;
            this.Studio = Studio;
            this.Directors = Directors;
            this.Actors = Actors;
            this.Route = Route;
        }
        public override void SetRating(List<Rating> Rating)
        {
            this.Rating = Rating;

        }
        public override void SetReview(List<Review> Review)
        {
            this.Review = Review;
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
        public override string GetReview()
        {
            string review = "";
            for (int i = 0; i < Review.Count(); i++)
            {
                review +=  Review[i].GetReview() + Environment.NewLine + Environment.NewLine;

            }
            return review;
        }
        public override string GetData()
        {
            return (this.Name + ", " + this.Studio);
        }
        public override int GetDataNumber()
        {
            return (this.Length + this.Reproductions + this.Size + this.Likes);
        }
        public void SetActorsVideo(List<Workers> Actors)
        {
            this.Actors = Actors;
        }
        public void SetDirectorsVideo(List<Workers> Directors)
        {
            this.Directors = Directors;
        }

        public string GetActorsVideo()
        {
            string actors = "";
            for (int i = 0; i < Actors.Count(); i++)
            {
                actors += Actors[i].GetName() + " " + Actors[i].GetSurname();
            }
            return actors;
        }
        public string GetDirectorsVideo()
        {
            string directors = "";
            for (int i = 0; i < Directors.Count(); i++)
            {
                directors += Directors[i].GetName() + " " + Directors[i].GetSurname();
            }
            return directors;
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
            return Name;
        }

        public string GetKind()
        {
            return Kind;
        }

        public string GetStudio()
        {
            return Studio;
        }

        public List<Review> GetListReview()
        {
            return this.Review;
        }
        public override string GetRoute()
        {
            return this.Route;
        }
        public string GetNameDirector()
        {
            string directors = "";
            for (int i = 0; i < Directors.Count(); i++)
            {
                directors += Directors[i].GetName();
            }
            return directors;
        }

        public List<Workers> GetArtist()
        {
            return Actors;
        }
    }
}