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
    abstract class Multimedia
    {
        protected string Name="";
        protected string Kind;
        protected int Length;
        protected string Date="";
        protected int Reproductions;
        
        protected List<Rating> Rating=new List<Rating>() { };
        protected List<Review> Review = new List<Review>() { };
        protected string ImageURL="";
        protected int Size;
        protected int Likes;
        protected string Studio;

        public virtual string Play()
        {
            return ("Se esta reproduciendo");
        }
        public virtual string Image()
        {
            return ("Se ha agregado un archivo imagen.jpg");
        }


        public virtual void SetRating(List<Rating> Rating)
        {
            this.Rating = Rating;
        }
        public virtual void SetReview(List<Review> Review)
        {
            this.Review = Review;
        }
        public virtual int GetRating()
        {
            int Promedio = 0;
            for (int i = 0; i < Rating.Count(); i++)
            {
                Promedio += Rating[i].GetRating();

            }
            return Promedio / Rating.Count();

        }
        public virtual string GetReview()
        {
            string review = "";
            for (int i = 0; i < Review.Count(); i++)
            {
                review += Review[i].GetUser() + ":" + Review[i].GetReview() + Environment.NewLine + Environment.NewLine;

            }
            return review;
        }
        public virtual string GetData()
        {
            return (this.Name + " " + this.Kind + " " + this.Date + " " + this.Studio);
        }
        public virtual int GetDataNumber()
        {
            return (this.Length + this.Likes + this.Reproductions + this.Size);
        }
        public virtual void SetLikes(int Likes)
        {
            this.Likes = Likes;
        }
        public virtual int GetLikes()
        {
            return Likes;
        }
        public virtual void SetReproductions(int Reproductions)
        {
            this.Reproductions = Reproductions;
        }
        public virtual int GetReproductions()
        {
            return Reproductions;
        }

        public virtual string GetName()
        {
            return Name;
        }

        public virtual List<Rating> GetListRating()
        {
            return this.Rating;
        }

    }



}


        
    

