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
            Console.WriteLine("1. Iniciar Sesion" + Environment.NewLine + "2. Registrarse" + Environment.NewLine + "A. Admin settings"+Environment.NewLine+"3. Salir");
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

                case "A":
                    return "A";

                default:
                    return "4";
            }
        }

        public string PrintStartMenu()
        {
            while (true)
            {
                Console.WriteLine("BIENVENIDO A PEORESNADA"+Environment.NewLine);
                Console.WriteLine("U. Usuarios"+Environment.NewLine+"1. Modo Cancion" + Environment.NewLine + "2. Modo Video" + Environment.NewLine + "3. Salir"+Environment.NewLine+"B. Suenan canciones wuju sorpresa");
                Console.Write("==>  ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "B":

                        return "B";
                    case "U":

                        return "U";

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
                Console.WriteLine("A. Agregar cancion"+Environment.NewLine+"P. Seccion Premios"+Environment.NewLine+"R. Calificar cancion"+Environment.NewLine+"1. Buscar Canciones" + Environment.NewLine + "2. Playlists" + Environment.NewLine+"3. Volver atras");
                Console.Write("==>  ");
                string input1 = Console.ReadLine();
                switch (input1)
                {
                    case "R":
                        return "R";

                    case "P":
                        return "P";
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
                Console.WriteLine("A. Agregar Video"+Environment.NewLine+"R. Calificar o criticar"+Environment.NewLine+"1. Buscar Videos" + Environment.NewLine + "2. Playlists" + Environment.NewLine + "3. Volver atras");
                Console.Write("==>  ");
                string input1 = Console.ReadLine();
                switch (input1)
                {
                    case "R":
                        return "R";

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
            Console.WriteLine("ELIJA FILTRACION"+Environment.NewLine+ "1. SIMPLE"+ Environment.NewLine+"2. MULTIPLE");
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
                Console.WriteLine("Esta sonando la primera cancion");
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
                Console.WriteLine("F. Follow Playlist"+Environment.NewLine+"S. Playlist seguidas"+Environment.NewLine+"1. Ver todas las playlists" + Environment.NewLine + "2. Ver tus playlists y reproducirlas o editarlas" + Environment.NewLine + "3. Crear Playlist" + Environment.NewLine + "4. Volver atras");
                Console.Write("==>  ");
                string choice = Console.ReadLine();
                if (choice == "F")
                {
                    if (diff == 0)
                    {
                        Console.Write("Ingrese nombre de playlist: ");
                        string name = Console.ReadLine();
                        bool checkExistence = app.GetServer().CheckPLExistence(name,0,app);
                        if (checkExistence == false)
                        {
                            Console.Clear();
                            Console.WriteLine("La playlist no existe");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.Clear();

                            app.GetServer().GetActive().FollowMusicPL(app.GetServer().GetSpecificPL(name,0,app));
                            Console.WriteLine("Seguiste a la playlist");
                            System.Threading.Thread.Sleep(2000);
                        }
                    }

                    else
                    {
                        Console.Write("Ingrese nombre de playlist: ");
                        string name = Console.ReadLine();
                        bool checkExistence = app.GetServer().CheckPLExistence(name, 1, app);
                        if (checkExistence == false)
                        {
                            Console.Clear();
                            Console.WriteLine("La playlist no existe");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.Clear();

                            app.GetServer().GetActive().FollowVidPL(app.GetServer().GetSpecificPL(name, 0, app));
                            Console.WriteLine("Seguiste a la playlist");
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                }

                else if (choice == "S")
                {
                    Console.Clear();
                    if (diff == 0)
                    {
                        List<Playlist> allFollowed = app.GetServer().GetActive().GetFollowedMusicPL();
                        if (allFollowed.Count() != 0)
                        {
                            for (int i = 0; i < allFollowed.Count(); i++)
                            {
                                Console.WriteLine(i+1 + ". "+allFollowed[i].GetInfoPL());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No sigues ninguna playlist");
                        }
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        List<Playlist> allFollowed = app.GetServer().GetActive().GetFollowedVidPL();
                        if (allFollowed.Count() != 0)
                        {
                            for (int i = 0; i < allFollowed.Count(); i++)
                            {
                                Console.WriteLine(i + 1 + ". " + allFollowed[i].GetInfoPL());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No sigues ninguna playlist");
                        }
                        System.Threading.Thread.Sleep(2000);
                    }
                }

                else if (choice == "1")
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
                            Console.WriteLine((i + 1) + ". " + userPlaylists[i].GetInfoPL() + Environment.NewLine);
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
            Console.WriteLine("ELIJA FILTRACION" + Environment.NewLine + "1. SIMPLE" + Environment.NewLine + "2. MULTIPLE");
            Console.Write("==>  ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                Console.Write("Ingrese filtro: ");
                string filter = Console.ReadLine();
                List<string> allFilters = new List<string>() { filter };
                List<Video> filteredVids = app.SearchAndPlayVid(allFilters);
                foreach(var a in filteredVids)
                {
                    Console.WriteLine(a.GetData());
                }
                System.Threading.Thread.Sleep(2000);
            }
            else if (choice == "2")
            {
                string check = "y";
                List<string> allFilters = new List<string>();
                while (check== "y" || check=="Y")
                {
                    Console.Clear();
                    Console.Write("Ingrese filtro: ");
                    string filter = Console.ReadLine();
                    allFilters.Add(filter);
                    Console.Write("Desea seguir agregando filtros? (y/n): ");
                    check = Console.ReadLine();

                }
                List<Video> filteredVids = app.SearchAndPlayVid(allFilters);
                foreach (var a in filteredVids)
                {
                    Console.WriteLine(a.GetData());
                }
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Input invalido");
                System.Threading.Thread.Sleep(2000);
            }
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

        public string UserMenu(App app,int diff)
        {
            if (diff == 0)
            {
                List<User> allfollowed=app.GetServer().GetActive().GetFollowedUsers();
                string users = "";
                if (allfollowed.Count() != 0)
                {
                    for (int i = 0; i < allfollowed.Count(); i++)
                    {
                        users += allfollowed[i].GetUsername() + Environment.NewLine;
                    }
                    return users;
                }
                else
                {
                    return "No sigues a nadie";
                }
            }


            else if(diff==1)
            {
                List<User> allfollowed = app.GetServer().GetActive().GetFollowedUsers();
                Console.Write("Ingrese username: ");
                string username = Console.ReadLine();
                bool searchtry = app.GetServer().CheckUserExistence(username);
                if (searchtry == false)
                {
                    Console.Clear();
                    return"El usuario no existe";

                }
                else
                {
                    User followUser=app.GetServer().SearchUser(username);
                    app.GetServer().GetActive().FollowUser(followUser);
                    return "Se comenzo a seguir el usuario";
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("1. Escuchar cola de musica"+Environment.NewLine+"2. Agregar cancion a la cola"+Environment.NewLine+"3. Vaciar cola de musica"+ Environment.NewLine+"4. Ver cola de video" + Environment.NewLine + "5. Agregar video a la cola" + Environment.NewLine + "6. Vaciar cola de video"+Environment.NewLine+"7. Volver atras");
                Console.Write("==>  ");
                string queueChoice = Console.ReadLine();
                Console.Clear();
                if (queueChoice == "1")
                {
                    if (app.GetServer().GetActive().GetQueue(0).Count() == 0)
                    {
                        return "La cola esta vacia!";
                    }
                    else
                    {
                        return "Se esta escuchando la cola";
                    }
                }

                else if (queueChoice == "2")
                {
                    Console.Write("Ingrese nombre de la cancion: ");
                    string name = Console.ReadLine();
                    Song song=app.SearchforSong(name);
                    if (song.GetName() != "")
                    {
                        app.GetServer().GetActive().AddSongQueue(song);
                        return "Se agrego la cancion a la cola";
                    }
                    else
                    {
                        return "No se encontro la cancion";
                    }
                }

                else if (queueChoice == "3")
                {
                    app.GetServer().GetActive().ResetQueue(0);
                    return "Se vacio la cola";
                }

                else if (queueChoice == "4")
                {
                    if (app.GetServer().GetActive().GetQueue(1).Count() == 0)
                    {
                        return "La cola esta vacia!";
                    }
                    else
                    {
                        return "Se esta viendo la cola";
                    }
                }

                else if (queueChoice == "5")
                {
                    Console.Write("Ingrese nombre de la cancion: ");
                    string name = Console.ReadLine();
                    Video video = app.SearchforVid(name);
                    if (video.GetName() != "")
                    {
                        app.GetServer().GetActive().AddVidQueue(video);
                        return "Se agrego la cancion a la cola";
                    }
                    else
                    {
                        return "No se encontro la cancion";
                    }
                }

                else if (queueChoice == "6")
                {
                    app.GetServer().GetActive().ResetQueue(1);
                    return "Se vacio la cola";
                }

                else
                {
                    return "Volviendo atras";
                }

            }
        }

        public void ProgramAwards(App app)
        {
            List<Song> allSongs = app.GetAllSongs();
            Console.Clear();
            Console.WriteLine("BIENVENIDO A LA SECCION ALL STARS, DONDE SOLO HAY CANCIONES PREMIADAS"+Environment.NewLine);
            Console.WriteLine("Elija un premio:" + Environment.NewLine + "1. Grammy" + Environment.NewLine + "2. Brit" + Environment.NewLine + "3. Ambos" + Environment.NewLine + "4. Volver atras");
            Console.Write("==>  ");
            string diff = Console.ReadLine();
            if (diff == "3")
            {
                Console.Clear();
                int counter = 1;
                for (int i = 0; i < allSongs.Count(); i++)
                {
                    if (allSongs[i].GetAwards().Count() == 2)
                    {
                        Console.WriteLine(counter + ". " + allSongs[i].GetData() + ", " + allSongs[i].GetArtistSong());
                        counter++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (counter == 1)
                {
                    Console.WriteLine("No existen canciones con ambos premios");
                }
                System.Threading.Thread.Sleep(2000);
            }
            else if (diff == "1")
            {
                Console.Clear();
                int counter = 1;
                for (int i = 0; i < allSongs.Count(); i++)
                {
                    if ((allSongs[i].GetAwards().Count() == 1 &&(allSongs[i].GetAwards()[0].getName() == "Grammy" || allSongs[i].GetAwards()[0].getName() == "grammy")) || (allSongs[i].GetAwards().Count() == 2 &&(allSongs[i].GetAwards()[0].getName()=="Grammy"|| allSongs[i].GetAwards()[0].getName() == "grammy"|| allSongs[i].GetAwards()[1].getName() == "Grammy" || allSongs[i].GetAwards()[1].getName() == "grammy")))
                    {
                        Console.WriteLine(counter + ". " + allSongs[i].GetData() + ", " + allSongs[i].GetArtistSong());
                        counter++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (counter == 1)
                {
                    Console.WriteLine("No existen canciones con Grammy");
                }
                System.Threading.Thread.Sleep(2000);
            }
            else if (diff == "2")
            {
                Console.Clear();
                int counter = 1;
                for (int i = 0; i < allSongs.Count(); i++)
                {
                    if ((allSongs[i].GetAwards().Count() == 1 &&(allSongs[i].GetAwards()[0].getName() == "Brit" || allSongs[i].GetAwards()[0].getName() == "brit")) || (allSongs[i].GetAwards().Count() == 2&&(allSongs[i].GetAwards()[0].getName() == "Brit" || allSongs[i].GetAwards()[0].getName() == "brit"|| allSongs[i].GetAwards()[1].getName() == "Brit" || allSongs[i].GetAwards()[1].getName() == "brit")))
                    {
                        Console.WriteLine(counter + ". " + allSongs[i].GetData() + ", " + allSongs[i].GetArtistSong());
                        counter++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (counter == 1)
                {
                    Console.WriteLine("No existen canciones con Brit");
                }
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("LA ELITE MUSICAL TE DESEA UN BUEN VIAJE");
                System.Threading.Thread.Sleep(2000);
            }
        }

        public void ProgramRating(App app,int diff)
        {
            if (diff == 0)
            {
                Console.Clear();
                Console.WriteLine("1. Ver rating de una cancion" + Environment.NewLine + "2. Calificar una cancion" + Environment.NewLine + "3. Volver atras");
                Console.Write("==>  ");
                string choice = Console.ReadLine();
                Console.Clear();
                if (choice == "1")
                {
                    Console.Write("Ingrese nombre de la cancion: ");
                    string name = Console.ReadLine();
                    Song song = app.SearchforSong(name);
                    List<Rating> rating = song.GetListRating();
                    Console.Clear();
                    if (rating==null)
                    {
                        Console.WriteLine("La cancion no tiene calificacion");
                    }
                    else
                    {
                        Console.WriteLine(song.GetRating() + " estrellas");
                    }
                }

                else if (choice == "2")
                {
                    Console.Write("Ingrese nombre de la cancion: ");
                    string name = Console.ReadLine();
                    Song song = app.SearchforSong(name);
                    if (song.GetListRating() != null)
                    {
                        List<Rating> rating = song.GetListRating();
                        Rating userRating = new Rating();
                        Console.Write("Evalua la cancion de 1 a 5: ");
                        userRating.SetRating(Convert.ToInt32(Console.ReadLine()));
                        userRating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.Add(userRating);
                        app.Rate(name, 0, rating);
                        Console.WriteLine("Se agrego la calificacion");
                        Console.Clear();
                    }
                    else
                    {
                        List<Rating> rating = new List<Rating>();
                        Rating userRating = new Rating();
                        Console.Write("Evalua la cancion de 1 a 5: ");
                        userRating.SetRating(Convert.ToInt32(Console.ReadLine()));
                        userRating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.Add(userRating);
                        app.Rate(name, 0, rating);
                        Console.WriteLine("Se agrego la calificacion");
                        Console.Clear();
                    }
                }

                else
                {
                    Console.WriteLine("Volviendo atras");
                }
                System.Threading.Thread.Sleep(2000);
            }

            else
            {
                Console.Clear();
                Console.WriteLine("1. Ver rating de un video" + Environment.NewLine + "2. Calificar un video" + Environment.NewLine + "3. Volver atras");
                Console.Write("==>  ");
                string choice = Console.ReadLine();
                Console.Clear();
                if (choice == "1")
                {
                    Console.Write("Ingrese nombre del video: ");
                    string name = Console.ReadLine();
                    Video vid = app.SearchforVid(name);
                    List<Rating> rating = vid.GetListRating();
                    Console.Clear();
                    if (rating==null)
                    {
                        Console.WriteLine("El video no tiene calificacion");
                    }
                    else
                    {
                        Console.WriteLine(vid.GetRating() + " estrellas");
                    }
                }

                else if (choice == "2")
                {
                    Console.Write("Ingrese nombre del video: ");
                    string name = Console.ReadLine();
                    Video vid = app.SearchforVid(name);
                    if (vid.GetListRating() != null)
                    {
                        List<Rating> rating = vid.GetListRating();
                        Rating userRating = new Rating();
                        Console.Write("Evalue el video de 1 a 5: ");
                        userRating.SetRating(Convert.ToInt32(Console.ReadLine()));
                        userRating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.Add(userRating);
                        app.Rate(name, 1, rating);
                        Console.WriteLine("Se agrego la calificacion");
                        Console.Clear();
                    }
                    else
                    {
                        List<Rating> rating = new List<Rating>();
                        Rating userRating = new Rating();
                        Console.Write("Evalue el video de 1 a 5: ");
                        userRating.SetRating(Convert.ToInt32(Console.ReadLine()));
                        userRating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.Add(userRating);
                        app.Rate(name, 1, rating);
                        Console.WriteLine("Se agrego la calificacion");
                        Console.Clear();
                    }
                }
                

                else
                {
                    Console.WriteLine("Volviendo atras");
                }
                System.Threading.Thread.Sleep(2000);
            }
        }

        public void ProgramReview(App app)
        {
            Console.Clear();
            Console.WriteLine("1. Ver criticas de un video"+Environment.NewLine+"2. Dejar una critica en un video"+ Environment.NewLine+"3. Volver atras");
            Console.Write("==>  ");
            string choice = Console.ReadLine();
            Console.Clear();
            if (choice == "1")
            {
                Console.Write("Ingrese nombre del video: ");
                string name = Console.ReadLine();
                Video vid = app.SearchforVid(name);
                List<Review> review = vid.GetListReview();
                Console.Clear();
                if (review==null)
                {
                    Console.WriteLine("El video no tiene criticas");
                }
                else
                {
                    Console.WriteLine(vid.GetReview());
                }
            }

            else if (choice == "2")
            {
                Console.Write("Ingrese nombre del video: ");
                string name = Console.ReadLine();
                Console.Clear();
                Video vid = app.SearchforVid(name);
                if (vid.GetListReview() != null)
                {
                    List<Review> review = vid.GetListReview();
                    Review userReview = new Review();
                    Console.Write("Pongale titulo a su critica: ");
                    string title = Console.ReadLine();
                    Console.Write("Deje su opinion sobre el video: ");
                    string comment = Console.ReadLine();
                    userReview.SetReview(title, comment);
                    review.Add(userReview);
                    app.ReviewVid(app.GetServer().GetActive().GetUsername(), review);
                }
                else
                {
                    List<Review> review = new List<Review>();
                    Review userReview = new Review();
                    Console.Write("Pongale titulo a su critica: ");
                    string title = Console.ReadLine();
                    Console.Write("Deje su opinion sobre el video: ");
                    string comment = Console.ReadLine();
                    userReview.SetReview(title, comment);
                    review.Add(userReview);
                    app.ReviewVid(name, review);
                }
            }

            else
            {
                Console.WriteLine("Volviendo atras");
            }
            System.Threading.Thread.Sleep(6000);
        }

    }
}
