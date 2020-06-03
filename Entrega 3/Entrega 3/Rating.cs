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
    class Rating : Atributtes

    {
        private int ValueRating;

        public void SetRating(int ValueRating)
        {
            this.ValueRating = ValueRating;
        }
        public int GetRating()
        {
            return ValueRating;
        }
    }

}
