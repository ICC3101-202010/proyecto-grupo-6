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
