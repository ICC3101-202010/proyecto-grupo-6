﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    class Rating : Atributttes

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
