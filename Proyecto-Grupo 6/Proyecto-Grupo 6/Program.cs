using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

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
                    Console.Write("Ingrese nombre de usuario (ejemplo: hola): ");
                    string usn = Console.ReadLine();
                    Console.Write("Ingrese contrasena (ejemplo: hola): ");
                    string psw = Console.ReadLine();
                    string login = app.Login(usn, psw);
                    Console.WriteLine(login);
                    System.Threading.Thread.Sleep(2000);
                    if (login == "Login in...")
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

                else if (loginMenu == "A")
                {
                    Console.Clear();
                    Console.WriteLine("Usted entro a manejo admin");
                    Console.WriteLine("Ingrese adminPass (es adminadmin)");
                    Console.Write("==>  ");
                    string adminLogin = Console.ReadLine();
                    if (adminLogin == "adminadmin")
                    {
                        Console.Clear();
                        Console.WriteLine("Bienvenido al Admin Manager"+Environment.NewLine);
                        Console.WriteLine("Ingrese lo que quiere hacer"+Environment.NewLine+"1. Darle admin a un usuario"+Environment.NewLine+"2. Quitarle admin a un usuario"+Environment.NewLine+"3. Volver atras");
                        Console.Write("==>  ");
                        string adminchoice = Console.ReadLine();
                        if (adminchoice == "1")
                        {
                            Console.Clear();
                            Console.Write("Ingrese nombre de usuario: ");
                            string usn = Console.ReadLine();
                            Console.Write("Ingrese contrasena: ");
                            string psw = Console.ReadLine();
                            string login = app.GetServer().ToggleAdmin(usn, psw, 0, app);
                            Console.WriteLine(login);
                            System.Threading.Thread.Sleep(2000);
                            if (login =="Se dio admin al usuario exitosamente")
                            {
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (adminchoice == "2")
                        {
                            Console.Clear();
                            Console.Write("Ingrese nombre de usuario: ");
                            string usn = Console.ReadLine();
                            Console.Write("Ingrese contrasena: ");
                            string psw = Console.ReadLine();
                            string login = app.GetServer().ToggleAdmin(usn, psw, 1, app);
                            Console.WriteLine(login);
                            System.Threading.Thread.Sleep(2000);
                            if (login == "Se quito admin al usuario exitosamente")
                            {
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("El adminPass es incorrecto");
                        System.Threading.Thread.Sleep(2000);
                        continue;
                    }
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

                else if (case1 == "B")
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\FC.wav";
                    player.PlaySync();

                    Console.WriteLine("Si desea escuchar la sig cancion marque x:");
                    Console.WriteLine("Si quiere volver al menu, marque e:");
                    Console.Write("==>  ");
                    string V1 = Console.ReadLine();

                    if (V1 == "x"||V1=="X")
                    {
                        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\A Donde Vamos.wav";
                        player.PlaySync();
                    }
                    else if (V1 == "e" || V1 =="E")
                    {
                        continue;
                    }
                    continue;
                }


                else if (case1 == "U")
                {
                    Console.Clear();
                    Console.WriteLine("USTED ENTRO A MENU DE USUARIOS" + Environment.NewLine);
                    Console.WriteLine("Y. Tu"+Environment.NewLine+"1. Ver usuarios que sigues"+Environment.NewLine+ "2. Buscar usuario por username y seguir" + Environment.NewLine+ "3. Volver atras" + Environment.NewLine);
                    string userchoice = Console.ReadLine();
                    if (userchoice == "3")
                    {
                        continue;
                    }

                    else if (userchoice == "Y")
                    {
                        Console.WriteLine(inp.UserMenu(app, 2));
                        System.Threading.Thread.Sleep(2000);
                    }

                    else if (userchoice == "1")
                    {
                        Console.WriteLine(inp.UserMenu(app, 0));
                        System.Threading.Thread.Sleep(2000);
                    }
                    else if (userchoice == "2")
                    {
                        Console.WriteLine(inp.UserMenu(app, 1));
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Input invalido");
                        System.Threading.Thread.Sleep(2000);
                    }
                }

                else if (case1 == "1")
                {
                    string case2 = inp.ProgramSong();
                    if (case2 == "3")
                    {
                        continue;
                    }
                    else if (case2 == "R")
                    {
                        inp.ProgramRating(app, 0);
                    }
                    else if (case2 == "1")
                    {
                        inp.SearchSong(app);
                    }
                    else if (case2 == "2")
                    {
                        inp.ProgramPlaylist(app, 0);
                    }
                    else if (case2 == "P")
                    {
                        inp.ProgramAwards(app);
                    }
                    else
                    {
                        if (app.GetServer().GetActive().GetAdmin() == true)
                        {
                            inp.AddMedia(app, 0);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No tienes admin!");
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                }

                else if (case1 == "2")
                {
                    string case2 = inp.ProgramVideo();
                    if (case2 == "3")
                    {
                        continue;
                    }
                    else if (case2 == "R")
                    {
                        Console.Clear();
                        Console.WriteLine("1. Critica" + Environment.NewLine + "2. Rating");
                        Console.Write("==>  ");
                        string vidchoice = Console.ReadLine();
                        if (vidchoice == "1")
                        {
                            inp.ProgramReview(app);
                        }
                        else if (vidchoice == "2")
                        {
                            inp.ProgramRating(app, 1);
                        }
                        else
                        {
                            Console.WriteLine("Input invalido");
                        }


                    }
                    else if (case2 == "1")
                    {
                        inp.SearchVideo(app);
                    }
                    else if (case2 == "2")
                    {
                        inp.ProgramPlaylist(app, 1);
                    }
                    else if (case2 == "A")
                    {
                        if (app.GetServer().GetActive().GetAdmin() == true)
                        {
                            inp.AddMedia(app, 1);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No tienes admin!");
                            System.Threading.Thread.Sleep(2000);
                        }
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
