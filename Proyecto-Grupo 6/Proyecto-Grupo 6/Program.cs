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
    class Program
    {
        static void Main(string[] args)
        {
            InputOutput inp= new InputOutput();
            App app = new App();
            app.OpenApp();
            while (true)
            {
                Console.Clear();
                string loginMenu = inp.PrintLogin();

                if (loginMenu == "1")
                {
                    Console.Clear();
                    Console.Write("Ingrese nombre de usuario: ");
                    string usn = Console.ReadLine();
                    Console.Write("Ingrese contrasena: ");
                    string psw = Console.ReadLine();
                    string login = app.Login(usn, psw);
                    Console.WriteLine(login);
                    System.Threading.Thread.Sleep(2000);
                    if (login == "Login In")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (loginMenu == "2")
                {
                    Console.Clear();
                    Console.Write("Ingrese Nombre: ");
                    string name = Console.ReadLine();
                    Console.Write("Ingrese Apellido: ");
                    string surn = Console.ReadLine();
                    Console.Write("Ingrese nombre de usuario: ");
                    string usern = Console.ReadLine();
                    Console.Write("Ingrese contrasena: ");
                    string pswd = Console.ReadLine();
                    string register = app.Register(name, surn, usern, pswd);
                    Console.WriteLine(register);
                    System.Threading.Thread.Sleep(2000);
                    if (register== "El Nombre de usuario no esta disponible")
                    {
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                    
                }

                else if (loginMenu == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Cerrando PeorEsNada");
                    System.Threading.Thread.Sleep(2000);
                    app.CloseApp();
                    Environment.Exit(0);
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Input invalido");
                    System.Threading.Thread.Sleep(2000);
                    continue;
                }


                
            }
            while (true)
            {
                Console.Clear();
                string case1 = inp.PrintStartMenu();
                if (case1 == "3")
                {
                    Console.WriteLine(app.CloseApp());
                    break;
                }
                else if (case1 == "1")
                {
                    string case2 = inp.ProgramSong();
                    if (case2 == "3")
                    {
                        continue;
                    }
                    else if (case2 == "1")
                    {
                        inp.SearchSong(app);
                    }
                    else if (case2 == "2")
                    {
                        inp.ProgramPlaylist(app, 0);
                    }
                    else
                    {
                        inp.AddMedia(app, 0);
                    }
                }

                else if (case1 == "2")
                {
                    string case2 = inp.ProgramVideo();
                    if (case2 == "3")
                    {
                        continue;
                    }
                    else if (case2 == "1")
                    {
                        inp.SearchSong(app);
                    }
                    else if (case2 == "2")
                    {
                        inp.ProgramPlaylist(app, 1);
                    }
                    else if (case2 == "A")
                    {
                        inp.AddMedia(app, 1);
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Input Invalido");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
            }
            

        }
    }
}
