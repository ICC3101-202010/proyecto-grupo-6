using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    [Serializable]
    class Admin
    {
        private List<User> admin = new List<User>();

        public void AddAdmin(User user)
        {
            this.admin.Add(user);
        }
        public void RemoveAdmin(User user)
        {
            this.admin.Remove(user);
        }
        
    }
}
