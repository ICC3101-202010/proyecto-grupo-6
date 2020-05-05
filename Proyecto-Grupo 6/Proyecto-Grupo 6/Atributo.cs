using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    class Atributos
    {
        protected string UserName;

        public void SetUser(string UserName)
        {
            this.UserName = UserName;
        }
        public string GetUser()
        {
            return UserName;
        }


    }

}
