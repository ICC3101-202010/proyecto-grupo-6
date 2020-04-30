using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    class Critica : Atributos
    {
        private string Titulo;
        private string Texto;

        public void SetCritica(string Titulo, string Texto)
        {
            this.Titulo = Titulo;
            this.Texto = Texto;

        }
        public string GetCritica()
        {
            return (Titulo + " " + Texto);
        }

    }

}
