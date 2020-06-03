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
    class Review : Atributtes
    {
        private string Title;
        private string Text;

        public void SetReview(string Title, string Text)
        {
            this.Title = Title;
            this.Text = Text;

        }
        public string GetReview()
        {
            return (Title + ":" + Text);
        }
    }

}