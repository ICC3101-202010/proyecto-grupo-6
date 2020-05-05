using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Grupo_6
{
    class Playlist
    {
        private string Nombre;
        private int Tamaño;
        private string Genero;
        private bool Privacidad;
        private string ImagenURL;
        private List<Multimedia>AllArchivos;
        ///private List<Usuario>Followers;///

        public void CrearPlaylist (string Nombre,int Tamaño,string Genero, bool Privacidad, List<Multimedia> AllArchivos)
        {
            this.Nombre = Nombre;
            this.Tamaño = Tamaño;
            this.Genero = Genero;
            this.Privacidad = Privacidad;
            this.AllArchivos = AllArchivos;

        }
        //private void UserInfo(string ImagenURL)
        //{
            //WebClient client = new WebClient();
            //byte[] imgData = client.DownloadData(ImageURL);//

            // store imgData in database (code depends on what API you're 
            // using to access the DB
       // }


    }
}
