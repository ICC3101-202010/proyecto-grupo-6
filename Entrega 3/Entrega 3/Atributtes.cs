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
    class Atributtes
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