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
        private List<User> AllUser;
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
                return ("Login in...");
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

        public string ToggleAdmin(string Username,string Password, int diff,App app)
        {
            User checkuser;
            int position = 0;
            int counter = 0;
            for (int i = 0; i < AllUser.Count(); i++)
            {
                if (Username == AllUser[i].GetUsername())
                {
                    checkuser = AllUser[i];


                    if (Password == checkuser.GetPassword())
                    {

                        if (diff == 0)
                        {
                            AllUser[position].ToggleAdmin(true);
                            app.GetAdmin().AddAdmin(AllUser[position]);
                            counter += 1;
                            break;
                        }
                        else
                        {
                            AllUser[position].ToggleAdmin(false);
                            app.GetAdmin().RemoveAdmin(AllUser[position]);
                            counter += 1;
                            break;
                        }

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
                if (diff == 0)
                {
                    return ("Se dio admin al usuario exitosamente");
                }
                else
                {
                    return ("Se quito admin al usuario exitosamente");
                }
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

        public bool CheckUserExistence(string username)
        {
            int check = 0;
            for(int i = 0; i < AllUser.Count(); i++)
            {
                if (username == AllUser[i].GetUsername())
                {
                    check += 1;
                }
                else
                {
                    continue;
                }
            }
            if (check == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public User SearchUser(string username)
        {
            User searchuser=new User();
            for (int i = 0; i < AllUser.Count(); i++)
            {
                if (username == AllUser[i].GetUsername())
                {
                    searchuser = AllUser[i];
                }
                else
                {
                    continue;
                }
            }
            return searchuser;
        }

        public bool CheckPLExistence(string name, int diff,App app)
        {

            int check = 0;
            for (int i = 0; i < app.GetPlaylist(diff).Count(); i++)
            {
                if (name == app.GetPlaylist(diff)[i].GetNamePL())
                {
                    check++;
                }
                else
                {
                    continue;
                }
            }
            if (check == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public Playlist GetSpecificPL(string name,int diff, App app)
        {
            List<Playlist> allPL = app.GetPlaylist(diff);
            int check = 0;
            for (int i = 0; i < allPL.Count(); i++)
            {
                if (name == allPL[i].GetNamePL())
                {
                    check = i;
                }
                else
                {
                    continue;
                }
            }
            return allPL[check];

        }

    }
}
