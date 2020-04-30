using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    class Rating : Atributos
    {
        private int ValorRating;

        public void SetRating(int ValorRating)
        {
            this.ValorRating = ValorRating;
        }
        public int GetRating()
        {
            return ValorRating;
        }
    }

}
