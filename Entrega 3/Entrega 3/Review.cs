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
    class Review : Atributtes
    {
        private string Title;
        private string Text;
        private string user;

        public void SetReview(string Title, string Text, string user)
        {
            this.Title = Title;
            this.Text = Text;
            this.user = user;

        }
        public string GetReview()
        {
            return (user+":"+"\n"+"Titulo: "+Title + "\n" + Text+"\n");
        }
    }

}