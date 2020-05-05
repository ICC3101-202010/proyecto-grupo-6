﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    
    abstract class Multimedia
        {
            protected string Name;
            protected string Kynd;
            protected int Lenght;
            protected string Date;
            protected int Reproductions;
            protected List<Rating> Rating;
            protected List<Review> Review;
            //protected BadImageFormatException CoverPage;
            protected int Size;
            protected int Likes;
            protected string Studio;

            public virtual void Play()
            {

            }
            public virtual void Add()
            {

            }
            public virtual void SetRating(List<Rating> Rating)
            {

            }
            public virtual void SetReview(List<Review> Review)
            {

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
                return (this.Name + " " + this.Kynd + " " + this.Date + " " + this.Studio);
            }
        
    }
}


        
    
