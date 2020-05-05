using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Grupo_6
{
    class Playlist
    {
        private string NamePlaylist;
        private int SizePlaylist;
        private string KindPlaylist;
        private bool Privacity;
        private string ImagenURL;
        private List<Multimedia> AllFiles;
        ///private List<Usuario>Followers;///

        public void CrearPlaylist(string NamePlaylist, int SizePlaylist, string KindPlaylist, bool Privacity, List<Multimedia> AllFiles)
        {
            this.NamePlaylist = NamePlaylist;
            this.SizePlaylist = SizePlaylist;
            this.KindPlaylist = KindPlaylist;
            this.Privacity = Privacity;
            this.AllFiles = AllFiles;

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
