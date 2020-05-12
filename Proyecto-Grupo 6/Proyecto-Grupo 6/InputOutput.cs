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
    class InputOutput
    {
        public string PrintLogin()
        {
            Console.WriteLine("BIENVENIDO A PEORESNADA");
            Console.WriteLine("1. Iniciar Sesion" + Environment.NewLine + "2. Registrarse" + Environment.NewLine + "3. Salir");
            Console.Write("==>  ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    return "1";

                case "2":
                    return "2";

                case "3":
                    return "3";

                default:
                    return "4";
            }
        }

        public string PrintStartMenu()
        {
            while (true)
            {
                Console.WriteLine("BIENVENIDO A PEORESNADA"+Environment.NewLine);
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
                Console.WriteLine("A. Agregar cancion"+Environment.NewLine+"1. Buscar Canciones" + Environment.NewLine + "2. Playlists" + Environment.NewLine+"3. Volver atras");
                Console.Write("==>  ");
                string input1 = Console.ReadLine();
                switch (input1)
                {
                    case "A":
                        return "A";

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
        
        
        
        public string ProgramVideo()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("USTED ENTRO A MENU DE VIDEOS" + Environment.NewLine);
                Console.WriteLine("A. Agregar Video"+Environment.NewLine+"1. Buscar Videos" + Environment.NewLine + "2. Playlists" + Environment.NewLine + "3. Volver atras");
                Console.Write("==>  ");
                string input1 = Console.ReadLine();
                switch (input1)
                {
                    case "A":
                        return "A";

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
                    Console.WriteLine(a.GetData()+", "+ a.GetArtistSong());
                }
                System.Threading.Thread.Sleep(5000);
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
                    Console.WriteLine(a.GetData() + ", " + a.GetArtistSong());
                }
                System.Threading.Thread.Sleep(2000);

            }
        }

        public void ProgramPlaylist(App app, int diff) //el int diff decide si es cancion o video//
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Ver todas las playlists" + Environment.NewLine + "2. Ver tus playlists y reproducirlas o editarlas" + Environment.NewLine + "3. Crear Playlist" + Environment.NewLine + "4. Volver atras");
                Console.Write("==>  ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    if (diff == 0)
                    {
                        Console.WriteLine(app.SeeMusicPL());
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine(app.SeeVidPL());
                        System.Threading.Thread.Sleep(2000);
                    }
                    continue;
                }
                else if (choice == "2")
                {
                    if (diff == 0)
                    {
                        List<Playlist> userPlaylists = app.GetServer().GetActive().GetYourMusic();
                        for (int i = 0; i < userPlaylists.Count(); i++)
                        {                           
                            Console.WriteLine((i + 1) + ". " + userPlaylists[i].GetInfoPL() + Environment.NewLine);                            
                        }
                        Console.WriteLine(Environment.NewLine+Environment.NewLine);
                        Console.Write("Elija playlist: ");
                        int plChoice = Int32.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine(userPlaylists[plChoice].GetNamePL() + Environment.NewLine);
                            List<Multimedia> playlistFiles = userPlaylists[plChoice].GetAllMedia();
                            
                            for (int i=0;i<playlistFiles.Count();i++)
                            {
                                if (i == 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine(i + ". " + playlistFiles[i].GetData());
                                }
                                
                                
                            }
                            Console.WriteLine(""+Environment.NewLine);
                            Console.WriteLine("Que desea hacer con la playlist?" + Environment.NewLine + "" + "1. Escuchar playlist" + Environment.NewLine + "2. Agregar cancion" + Environment.NewLine + "3. Eliminar cancion" + Environment.NewLine + "4. Volver atras");
                            Console.Write("==>  ");
                            string choicePL = Console.ReadLine();
                            if (choicePL == "1")
                            {
                                Console.WriteLine("Se esta escuchando la Playlist");
                                System.Threading.Thread.Sleep(2000);
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
                        List<Playlist> userPlaylists = app.GetServer().GetActive().GetYourVideos();
                        for (int i = 0; i < userPlaylists.Count(); i++)
                        {
                            Console.WriteLine((i + 1) + " " + userPlaylists[i].GetInfoPL() + Environment.NewLine);
                        }
                        Console.Write("Elija playlist: ");
                        int plChoice = Int32.Parse(Console.ReadLine()) - 1;
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine(userPlaylists[plChoice].GetNamePL() + Environment.NewLine);
                            List<Multimedia> playlistFiles = userPlaylists[plChoice].GetAllMedia();
                            
                            for(int i=0;i<playlistFiles.Count();i++)
                            {
                                if (i == 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine(i + ". " + playlistFiles[i].GetData());
                                }
                            }
                            Console.WriteLine("" + Environment.NewLine);
                            Console.WriteLine("Que desea hacer con la playlist?" + Environment.NewLine + "" + "1. Ver playlist" + Environment.NewLine + "2. Agregar video" + Environment.NewLine + "3. Eliminar video" + Environment.NewLine + "4. Volver atras");
                            Console.Write("==>  ");
                            string choicePL = Console.ReadLine();
                            if (choicePL == "1")
                            {
                                Console.WriteLine("Se esta viendo la Playlist");
                                System.Threading.Thread.Sleep(2000);
                                break;
                            }
                            else if (choicePL == "2")
                            {
                                Console.WriteLine("Escriba el nombre del video a anadir:");
                                List<string> searchParameter = new List<string>() { Console.ReadLine() };
                                Console.WriteLine(app.GetServer().GetActive().GetYourVideos()[plChoice].AddMedia(app.SearchAndPlayVid(searchParameter)[0]));
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                continue;
                            }
                            else if (choicePL == "3")
                            {
                                Console.Write("Elija el video para eliminar: ");
                                int choiceDelete = Int32.Parse(Console.ReadLine());
                                Console.WriteLine(app.GetServer().GetActive().GetYourVideos()[plChoice].DeleteMedia(userPlaylists[plChoice].GetAllMedia()[choiceDelete]));

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
                    
                }
                else if (choice == "3")
                {
                    //crear playlist//
                    if (diff == 0)
                    {
                        Console.Write("Ingrese el nombre de la playlist: ");
                        Song song = new Song();
                        app.MakePL("Songs", Console.ReadLine(), false, new List<Multimedia>() { song});
                    }
                    else
                    {
                        Console.Write("Ingrese el nombre de la playlist: ");
                        Video video = new Video();
                        app.MakePL("Videos", Console.ReadLine(), false, new List<Multimedia>() { video});
                    }
                    continue;
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

        public void SearchVideo(App app)
        {

        }

        public void AddMedia(App app,int diff)
        {
            if (diff == 0)
            {
                Console.Clear();
                Console.Write("Agregue nombre: ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.Write("Agregue genero: ");
                string kind = Console.ReadLine();
                Console.Clear();
                Console.Write("Agregue album: ");
                string album = Console.ReadLine();

                List<Workers> artists = new List<Workers>();
                string choice = "y";
                while (choice == "y" || choice == "Y")
                {
                    Console.Clear();
                    Console.Write("Ingrese nombre del artista: ");
                    string artname=Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese apellido del artista(si tiene, sino apretar enter): ");
                    string surname = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese sexo del artista (hombre o mujer): ");
                    string sex = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese edad del artista: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Workers artist = new Workers();
                    artist.SetName(artname);
                    artist.SetSurname(surname);
                    artist.SetSex(sex);
                    artist.SetAge(age);
                    artists.Add(artist);
                    Console.Write("La cancion tiene mas artistas?(y/n): ");
                    choice = Console.ReadLine();
                }
                string choice2 = "y";
                List<Workers> composers = new List<Workers>();
                while (choice2 == "y" || choice2 == "Y")
                {
                    Console.Clear();
                    Console.Write("Ingrese nombre del composer: ");
                    string artname = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese apellido del composer(si tiene, sino apretar enter): ");
                    string surname = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese sexo del composer (hombre o mujer): ");
                    string sex = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese edad del composer: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Workers artist = new Workers();
                    artist.SetName(artname);
                    artist.SetSurname(surname);
                    artist.SetSex(sex);
                    artist.SetAge(age);
                    composers.Add(artist);
                    Console.Write("La cancion tiene mas composers?(y/n): ");
                    choice2 = Console.ReadLine();
                }
                Console.Clear();
                Console.Write("Esta cancion tiene algun premio Brit o Grammy? (y/n): ");
                List<Awards> listawards = new List<Awards>();
                string choiceaward = Console.ReadLine();
                if (choiceaward=="y"||choiceaward=="Y")
                {
                    Console.Clear();
                    Console.Write("Especifique si tiene:"+Environment.NewLine+"1. Grammy"+Environment.NewLine+"2. Brit"+Environment.NewLine+"Otro. Ambos premios");
                    string checkaward = Console.ReadLine();
                    Console.Clear();
                    if (checkaward == "1")
                    {
                        Awards award = new Awards();
                        award.setName("Grammy");
                        award.setCategory(kind);
                        listawards.Add(award);
                    }
                    else if (checkaward == "2")
                    {
                        Awards award = new Awards();
                        award.setName("Brit");
                        award.setCategory(kind);
                        listawards.Add(award);
                    }
                    else
                    {
                        Awards award1 = new Awards();
                        award1.setName("Grammy");
                        award1.setCategory(kind);
                        listawards.Add(award1);
                        Awards award2 = new Awards();
                        award2.setName("Brit");
                        award2.setCategory(kind);
                        listawards.Add(award2);
                    }
                }
                else
                {
                    Console.Clear();
                    Awards award = new Awards();
                    award.setName("none");
                    award.setCategory("none");
                    listawards.Add(award);
                }
                Console.Clear();
                Console.Write("Cuanto dura la cancion en segundos?: ");
                int length = Convert.ToInt32(Console.ReadLine());
                app.AddSong(name, kind, album, artists, listawards, composers, length);
                Console.Clear();
                Console.WriteLine("Se agrego la cancion");
                System.Threading.Thread.Sleep(2000);
            }

            else
            {
                Console.Clear();
                Console.Write("Ingrese nombre del video: ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.Write("Ingrese genero del video: ");
                string kind = Console.ReadLine();
                Console.Clear();
                Console.Write("Ingrese canal del video: ");
                string studio = Console.ReadLine();

                List<Workers> directors=new List<Workers>();
                string choice = "y";
                while (choice == "y" || choice == "Y")
                {
                    Console.Clear();
                    Console.Write("Ingrese nombre del director: ");
                    string namedir = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese apellido del director: ");
                    string surdir= Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese sexo del director (hombre o mujer): ");
                    string sexdir = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese edad del director: ");
                    int agedir = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Workers dir= new Workers();
                    dir.SetSex(sexdir);
                    dir.SetName(namedir);
                    dir.SetSurname(surdir);
                    dir.SetAge(agedir);
                    directors.Add(dir);
                    Console.Write("Hay otro director? (y/n): ");
                    choice = Console.ReadLine();
                }

                List<Workers> actors = new List<Workers>();
                string choice2 = "y";
                while (choice2 == "y" || choice2 == "Y")
                {
                    Console.Clear();
                    Console.Write("Ingrese nombre del actor: ");
                    string nameact = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese apellido del actor: ");
                    string suract = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese sexo del actor (hombre o mujer): ");
                    string sexact = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Ingrese edad del actor: ");
                    int ageact = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Workers act = new Workers();
                    act.SetName(nameact);
                    act.SetSurname(suract);
                    act.SetSex(sexact);
                    act.SetAge(ageact);
                    actors.Add(act);
                    Console.Write("Hay otro actor? (y/n): ");
                    choice2 = Console.ReadLine();
                }

                Console.Clear();
                Console.Write("Ingrese largo del video en segundos: ");
                int length = Convert.ToInt32(Console.ReadLine());
                app.AddVid(name, kind, studio, directors, actors, length);
                Console.Clear();
                Console.WriteLine("Se agrego el video");
                System.Threading.Thread.Sleep(2000);


            }
        }

    }
}
