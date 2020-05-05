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


        public override void Play()
        {

        }
        public override void Add()
        {

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
            return (this.Name + " " + this.Kynd + " " + this.Date + " " + this.Studio);
        }
        public void SetActoresVideo(List<Workers> Actors)
        {
            this.Actors = Actors;
        }
        public void SetDirectorVideo(List<Workers> Directors)
        {
            this.Directors = Directors;
        }
        
        
        //public string GetDirectoresVideos()//
        


    }
}
