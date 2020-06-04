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

        public void SetAllAdmins(List<User> allAdmin)
        {
            this.admin = allAdmin;
        }

        public List<User> GetAllAdmins()
        {
            return admin;
        }

    }
}
