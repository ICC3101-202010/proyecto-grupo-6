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
            string case1 = inp.PrintStartMenu();
            if (case1 == "3")
            {
                Console.WriteLine(app.CloseApp());
            }
            else if (case1 == "1")
            {
                string case2=inp.ProgramSong();
                if (case2 == "3")
                {
                    inp.PrintStartMenu();
                }
            }
            

        }
    }
}
