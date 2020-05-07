using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
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
