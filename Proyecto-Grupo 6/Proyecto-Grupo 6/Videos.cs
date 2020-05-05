using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    class Videos : Multimedia 
    {
        private List<Trabajador> Actores;
        private List<Trabajador> Director;
        private List<Critica> Critica;

        public void Reproducir()
        {

        }
        public void Add()
        {

        }
        public void SetRatingVideos(List<Rating> Rating)
        {
            this.Rating = Rating; 

        }
        public void SetCriticaVideos(List<Critica> Critica)
        {
            this.Critica = Critica;
        }
        public int GetRatingVideos()
        {
            int Promedio = 0;
            for (int i = 0; i < Rating.Count(); i++)
            {
                Promedio += Rating[i].GetRating();

            }
            return Promedio / Rating.Count();
        }
        public string GetCriticaVideos()
        {
            string critica = "";
            for (int i = 0; i < Critica.Count(); i++)
            {
                critica += Critica[i].GetUser() + ":" + Critica[i].GetCritica() + Environment.NewLine + Environment.NewLine;

            }
            return critica;
        }
        public string GetDatosVideos()
        {
            return (this.Nombre + " " + this.Genero + " " + this.Fecha + " " + this.Estudio);
        }
        public void SetActoresVideos(List<Trabajador> Actores)
        {
            this.Actores = Actores;
        }
        public void SetDirectorVideos(List<Trabajador> Director)
        {
            this.Director = Director;
        }
        //public string GetActoresVideos()//
        //public string GetDirectoresVideos()//
        


    }
}
