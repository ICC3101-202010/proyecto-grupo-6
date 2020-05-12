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
    class Server
    {
        private List<User> AllUser = new List<User>();
        private User activeUser;

        public string Login(string Username, string Password)
        {
            User checkuser;
            int counter = 0;
            for (int i = 0; i < AllUser.Count(); i++)
            {
                if (Username == AllUser[i].GetUsername())
                {
                    checkuser = AllUser[i];


                    if (Password == checkuser.GetPassword())
                    {

                        activeUser = checkuser;
                        counter += 1;
                        break;

                    }
                    else
                    {

                        counter -= 1;
                        break;
                    }
                }

                else
                {
                    continue;
                }




            }
            if (counter == 1)
            {
                return ("Login In");
            }
            else if (counter == -1)
            {
                return ("Contraseña o Usuario Incorrecto");
            }
            else
            {
                return ("Contraseña o Usuario Incorrecto");

            }

        }
        public string Logout()
        {
            activeUser = null;
            return ("Ha Cerrado su sesion con exito");
        }
        public string Register(string Name, string SurName, string UserName, string Password, bool AVI)
        {
            int counter = 0;
            for (int i = 0; i < AllUser.Count(); i++)
            {
                if (UserName == AllUser[i].GetUsername())
                {
                    counter += 1;
                    break;
                }
                else
                {
                    continue;
                }

            }
            if (counter != 0)
            {
                return ("El Nombre de usuario no esta disponible");
            }
            else
            {
                User user = new User();
                user.SignUp(Name, SurName, UserName, Password, AVI);
                AllUser.Add(user);
                return ("Se ha creado el usuario con exito");

            }
        }

        public User GetActive()
        {
            return activeUser;
        }

        public void AddMusicPlaylist(Playlist playlist)
        {
            activeUser.AddMusicPlaylist(playlist);
        }

        public void AddVidPlaylist(Playlist playlist)
        {
            activeUser.AddVidPlaylist(playlist);
        }

        public void SetUsers(List<User>listUser)
        {
            AllUser = listUser;
        }

        public List<User> GetUsers()
        {
            return AllUser;
        }

    }
}
