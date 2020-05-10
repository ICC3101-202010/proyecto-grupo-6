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
                        
                        return "1";

                    case "2":
                        
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

        public void SearchSong(App app)
        {
            Console.WriteLine("ELIJA FILTRACION 1. SIMPLE O 2. MULTIPLE");
            Console.Write("==>  ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Ingrese filtro ==>  ");
                List<string> filterList = new List<string>();
                filterList.Add(Console.ReadLine());
                List<Song> filteredList=app.SearchAndPlaySong(filterList);
                foreach(var a in filteredList)
                {
                    Console.WriteLine(a.GetData()+" "+ a.GetArtistSong());
                }
            }
            if (choice == "2")
            {
                Console.Write("Ingrese filtro ==>  ");
                List<string> filterList = new List<string>();
                filterList.Add(Console.ReadLine());
                while (true)
                {
                    Console.Write("Quiere seguir agregando filtros?(Y/N): ");
                    string condition = Console.ReadLine();
                    if(condition=="Y"||condition== "y")
                    {
                        Console.Write("Ingrese filtro ==>  ");
                        filterList.Add(Console.ReadLine());
                        System.Threading.Thread.Sleep(2000);
                        continue;
                    }
                    else if (condition == "N" || condition == "n")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un input valido!");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();

                    }
                }
                List<Song> filteredList = app.SearchAndPlaySong(filterList);
                foreach (var a in filteredList)
                {
                    Console.WriteLine(a.GetData() + " " + a.GetArtistSong());
                }

            }
        }

        public void ProgramPlaylist(App app, int diff) //el int diff decide si es cancion o video//
        {
            while (true)
            {
                Console.WriteLine("1. Ver todas las playlists" + Environment.NewLine + "2. Ver tus playlists y escucharlas o editarlas" + Environment.NewLine + "3. Crear Playlist" + Environment.NewLine + "4. Volver atras");
                Console.Write("==>  ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    if (diff == 0)
                    {
                        Console.WriteLine(app.SeeMusicPL());
                    }
                    else
                    {
                        Console.WriteLine(app.SeeVidPL());
                    }
                    break;
                }
                else if (choice == "2")
                {
                    if (diff == 0)
                    {
                        List<Playlist> userPlaylists = app.GetServer().GetActive().GetYourMusic();
                        for (int i = 0; i < userPlaylists.Count(); i++)
                        {
                            Console.WriteLine((i+1)+" "+userPlaylists[i].GetInfoPL()+Environment.NewLine);
                        }
                        Console.Write("Elija playlist: ");
                        int plChoice = Int32.Parse(Console.ReadLine())-1;
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine(userPlaylists[plChoice].GetNamePL() + Environment.NewLine);
                            List<Multimedia> playlistFiles = userPlaylists[plChoice].GetAllMedia();
                            int b = 1;
                            foreach (var a in playlistFiles)
                            {
                                Console.WriteLine(b + ". " + a.GetData());
                            }
                            Console.WriteLine("Que desea hacer con la playlist?" + Environment.NewLine + "" + "1. Escuchar playlist" + Environment.NewLine + "2. Agregar cancion" + Environment.NewLine + "3. Eliminar cancion" + Environment.NewLine + "4. Volver atras");
                            Console.Write("==>  ");
                            string choicePL = Console.ReadLine();
                            if (choicePL == "1")
                            {
                                Console.WriteLine("Se esta escuchando la Playlist");
                                break;
                            }
                            else if (choicePL == "2")
                            {
                                Console.WriteLine("Escriba el nombre de la cancion a anadir:");
                                List<string> searchParameter = new List<string>() { Console.ReadLine() };
                                Console.WriteLine(app.GetServer().GetActive().GetYourMusic()[plChoice].AddMedia(app.SearchAndPlaySong(searchParameter)[0]));
                                System.Threading.Thread.Sleep(2000);
                                continue;
                            }
                            else if (choicePL == "3")
                            {
                                Console.Write("Elija la cancion para eliminar: ");
                                int choiceDelete = Int32.Parse(Console.ReadLine());
                                Console.WriteLine(app.GetServer().GetActive().GetYourMusic()[plChoice].DeleteMedia(userPlaylists[plChoice].GetAllMedia()[choiceDelete]));
                                
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                continue;
                            }
                            else if (choicePL == "4")
                            {
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Input invalido");
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                continue;

                            }
                        }
                    }



                    else
                    {

                    }
                    break;
                }
                else if (choice == "3")
                {
                    break;
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input invalido");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    continue;

                }
            }
        }

    }
}
