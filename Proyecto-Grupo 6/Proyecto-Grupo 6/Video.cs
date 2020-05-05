using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    class Video : Multimedia
    {
        private List<Workers> Actors;
        private List<Workers> Directors;


        public override string Play()
        {
            return ("Se esta repoduciendo el video");
        }
        public override void Add(string Name,string Kind,string Date,string Studio)
        {
            this.Name = Name;
            this.Kind = Kind;
            this.Date = Date;
            this.Studio = Studio;
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
                review += Review[i].GetUser() + ":" + Review[i].GetReview() + Environment.NewLine + Environment.NewLine;

            }
            return review;
        }
        public override string GetData()
        {
            return (this.Name + " " + this.Kind + " " + this.Date + " " + this.Studio);
        }
        public override int GetDataNumber()
        {
            return (this.Lenght + this.Reproductions + this.Size + this.Likes);
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
                directors += Actors[i].GetName() + " " + Actors[i].GetSurname();
            }
            return directors;
        }





    }
}
