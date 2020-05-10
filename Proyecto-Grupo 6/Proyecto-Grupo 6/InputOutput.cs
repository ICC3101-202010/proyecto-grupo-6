using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    class InputOutput
    {
        public string PrintStartMenu()
        {
            while (true)
            {
                Console.WriteLine("BIENVENIDO A ERNESTIFAI"+Environment.NewLine);
                Console.WriteLine("1. Modo Cancion" + Environment.NewLine + "2. Modo Video" + Environment.NewLine + "3. Salir");
                Console.Write("==>  ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        
                        return "1";
                        

                    case "2":
                        
                        return "2";
                        

                    case "3":
                        return "3";
                        

                    default:
                        Console.Clear();
                        Console.WriteLine("Input invalido");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        continue;
                }
            }
        }
        public string ProgramSong()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("USTED ENTRO A MENU DE CANCIONES"+ Environment.NewLine);
                Console.WriteLine("1. Buscar Canciones" + Environment.NewLine + "2. Playlists" + Environment.NewLine+"3. Volver atras");
                Console.Write("==>  ");
                string input1 = Console.ReadLine();
                switch (input1)
                {
                    case "1":
                        Console.WriteLine("Elija filtro:"+Environment.NewLine+"1. Nombre" + Environment.NewLine + "2. Artista" + Environment.NewLine + "3. Genero" + Environment.NewLine + "4. Album" + Environment.NewLine + "5. Multiple");
                        Console.Write("==>  ");
                        string input11 = Console.ReadLine();
                        switch (input11)
                        {
                            case "1":
                                Console.Write("ingrese nombre: ");

                                break;
                            case "2":
                                Console.Write("ingrese artista: ");

                                break;
                            case "3":
                                Console.Write("ingrese genero: ");
                                
                                break;
                            case "4":
                                Console.Write("ingrese album: ");

                                break;
                            case "5":

                                break;
                        }
                        return "1";

                    case "2":
                        Console.WriteLine("Cachando dick");
                        return "2";

                    case "3":
                        Console.Clear();
                        return "3";

                    default:
                        Console.Clear();
                        Console.WriteLine("Input erroneo");
                        System.Threading.Thread.Sleep(2000);
                        continue;
                        
                }
            }
        }
        
        
        
        public void ProgramVideo()
        {
            Console.WriteLine("viendo mi pana miguel");
        }

    }
}
