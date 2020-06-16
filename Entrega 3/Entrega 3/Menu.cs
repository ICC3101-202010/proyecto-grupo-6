using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Entrega_3
{
    public partial class Menu : Form
    {
        
        string NameSong, KindSong, AlbumSong,NameArtist,SexArtist,NameAward,NameAward2;
        string NameVideo,KindVideo,NameDirector,SexDirector,StudioVideo,NamePlvid,NamePlsong;
        int AgeArtist,AgeDirector;
        int i = 0;
        int z = 0;
        int w = 0;
        int x = 0;
        int c = 0;
        int t = 0;
        int s = 0;
        string existe1 = "";
        private string routesong = "";
        private string routevideo = "";

        public Menu()
        {
            InitializeComponent();
        }

        public void GetApp()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_closeregistro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_menucancion_Click(object sender, EventArgs e)
        {
            pn_settingsong.Visible = true;
            pn_video.Visible = false;
            pn_usuario.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pn_settingsong.Visible = false;
        }

        private void bt_secpremios_Click(object sender, EventArgs e)
        {
            pn_premio.Visible = true;
        }

        private void bt_backpremios_Click(object sender, EventArgs e)
        {
            pn_premio.Visible = false;
        }

        private void bt_calsong_Click(object sender, EventArgs e)
        {
            pn_calisong.Visible = true;
        }



        private void bt_buscarsong_Click(object sender, EventArgs e)
        {
            pn_bussong.Visible = true;
        }

        private void bt_backcalisongClick(object sender, EventArgs e)
        {
            pn_calisong.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pn_bussong.Visible = false;
        }



        private void bt_backplay_Click(object sender, EventArgs e)
        {
            pn_playlist.Visible = false;
        }

        private void bt_playlist_Click(object sender, EventArgs e)
        {
            pn_playlist.Visible = true;
        }

        private void bt_menuusario_Click(object sender, EventArgs e)
        {
            pn_usuario.Visible = true;
            pn_settingsong.Visible = false;
            pn_video.Visible = false;
        }

        private void bt_backusu_Click(object sender, EventArgs e)
        {
            pn_usuario.Visible = false;
        }

        private void bt_ustu_Click(object sender, EventArgs e)
        {
            pn_tuusu.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pn_tuusu.Visible = false;
        }

        private void bt_menuvideos_Click(object sender, EventArgs e)
        {
            pn_video.Visible = true;
            pn_settingsong.Visible = false;
            pn_usuario.Visible = false;
        }

        private void bt_backvideo_Click(object sender, EventArgs e)
        {
            pn_video.Visible = false;
        }



        private void bt_calcrivideo_Click(object sender, EventArgs e)
        {
            pn_calivideos.Visible = true;
        }

        private void bt_backcalivideo_Click(object sender, EventArgs e)
        {
            pn_calivideos.Visible = false;
        }

        private void bt_critvideo_Click(object sender, EventArgs e)
        {
            pn_critvideo.Visible = true;
        }

        private void bt_backdarcritvideo_Click(object sender, EventArgs e)
        {
            pn_critvideo.Visible = false;
        }

        private void bt_rativideo_Click(object sender, EventArgs e)
        {
            pn_rativideo.Visible = true;
        }

        private void bt_backdarrativideo_Click(object sender, EventArgs e)
        {
            pn_rativideo.Visible = false;
        }

        private void bt_busvideo_Click(object sender, EventArgs e)
        {
            pn_buscvideo.Visible = true;
        }

        private void bt_backfilvideo_Click(object sender, EventArgs e)
        {
            pn_buscvideo.Visible = false;
        }

        private void bt_playlisyvideo_Click(object sender, EventArgs e)
        {
            pn_playlistvideo.Visible = true;
        }

        private void bt_backplayvideo_Click(object sender, EventArgs e)
        {
            pn_playlistvideo.Visible = false;
        }




        private void bt_downloadsong_Click(object sender, EventArgs e)
        {
            if (openFilesong.ShowDialog() == DialogResult.OK)
            {
                routesong = openFilesong.FileName;
            }
        }
        private void bt_playsong_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            
            if (i > app.GetAllSongs().Count())
            {

            }
            else
            {
                try
                {
                    axWindowsMediaPlayersong.URL = app.GetAllSongs()[i].GetRoute();
                    axWindowsMediaPlayersong.Ctlcontrols.play();
                }
                catch
                {

                }
            }
                

            app.CloseApp();
        }


        private void bt_stopsong_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayersong.Ctlcontrols.stop();
        }

        private void bt_pausesong_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayersong.Ctlcontrols.pause();
        }
        private void bt_pausevideo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayervideo.Ctlcontrols.pause();
        }

        private void bt_downloadvideo_Click(object sender, EventArgs e)
        {
            if (openFileDialogvideo.ShowDialog() == DialogResult.OK)
            {
                routevideo = openFileDialogvideo.FileName;
            }
        }

        private void bt_playvideo_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            if (i > app.Getallvideos().Count())
            {

            }
            else
            {
                try
                {
                    axWindowsMediaPlayervideo.URL =app.Getallvideos()[z].GetRoute();
                    axWindowsMediaPlayervideo.Ctlcontrols.play();
                }
                catch
                {

                }
            }

            app.CloseApp();

        }

        private void bt_stopvideo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayervideo.Ctlcontrols.stop();
        }

        private void bt_reproducirsong_Click(object sender, EventArgs e)
        {
            pn_repsong.Visible = true;
        }

        private void bt_vervideo_Click(object sender, EventArgs e)
        {
            pn_repvideo.Visible = true;
        }

        private void pb_closeall_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_agregarsong_Click(object sender, EventArgs e)
        {
            
            pn_agregarcancion.Visible = true;
            App app = new App();
            app.OpenApp();
            if (app.GetServer().GetActive().GetAdmin())
            {
                pn_Admin.Visible = false;
            }
            else
            {
                pn_Admin.Visible = true;
            }
            app.CloseApp();
        }

        private void bt_backaddsongClick(object sender, EventArgs e)
        {
            pn_agregarcancion.Visible = false;
            lb_exitosong.Visible = false;
            lb_datossong.Visible = false;
            tb_albumsong.Text = "INGRESE ALBUM DE LA CANCION";
            tb_artistasong.Text = "INGRESE EL NOMBRE DEL ARTISTA";
            tb_edadartsong.Text = "EDAD ARTISTA";
            tb_generosong.Text = "INGRESE GENERO DE LA CANCION";
            tb_nombresong.Text = "INGRESE NOMBRE DE LA CANCION";
            tb_sexoartista.Text = "SEXO DEL ARTISTA ( HOMBRE-MUJER )";
        }
        
        private void bt_cargarsong_Click(object sender, EventArgs e)
        {
            if (tb_albumsong.Text == "" || tb_artistasong.Text == "" || tb_edadartsong.Text == "" || tb_generosong.Text == "" || tb_nombresong.Text == "" || tb_sexoartista.Text == "")
            {
                lb_datossong.Visible = true;

            }
            else
            {

                if (openFilesong.ShowDialog() == DialogResult.OK)
                {
                    App app = new App();
                    routesong = openFilesong.FileName;
                    NameSong = tb_nombresong.Text;
                    KindSong = tb_generosong.Text;
                    AgeArtist = Convert.ToInt32(tb_edadartsong.Text);
                    NameArtist = tb_artistasong.Text;
                    SexArtist = tb_sexoartista.Text;
                    AlbumSong = tb_albumsong.Text;
                    Workers worker = new Workers();
                    worker.SetName(NameArtist);
                    worker.SetAge(AgeArtist);
                    worker.SetSex(SexArtist);
                    worker.SetSurname(NameArtist);
                    
                    List<Awards> awardslist = new List<Awards>();
                    if (cb_grammy.Checked == true)
                    {
                        Awards award = new Awards();
                        NameAward = "Grammy";
                        award.setName(NameAward);
                        award.setCategory(KindSong);
                        awardslist.Add(award);
                    }
                    if (cb_brit.Checked == true)
                    {
                        Awards award = new Awards();
                        NameAward2 = "Brit";
                        award.setName(NameAward2);
                        award.setCategory(KindSong);
                        awardslist.Add(award);
                    }
                    if (cb_brit.Checked == false && cb_grammy.Checked == false)
                    {

                    }
                    List<Workers> workerlist = new List<Workers>();
                    workerlist.Add(worker);

                    app.OpenApp();
                    app.AddSong(NameSong, KindSong, AlbumSong, workerlist, awardslist, workerlist, routesong);
                    app.CloseApp();

                    
                }


                lb_datossong.Visible = false;
                lb_exitosong.Visible = true;
            }

        }



        private void tb_nombresong_Click(object sender, EventArgs e)
        {
            tb_nombresong.Text = "";
        }

        private void tb_generosong_Click(object sender, EventArgs e)
        {
            tb_generosong.Text = "";
        }

        private void tb_albumsong_Click(object sender, EventArgs e)
        {
            tb_albumsong.Text = "";
        }

        private void tb_artistasong_Click(object sender, EventArgs e)
        {
            tb_artistasong.Text = "";
        }

        private void tb_sexoartista_Click(object sender, EventArgs e)
        {
            tb_sexoartista.Text = "";
        }

        private void tb_edadartsong_Click(object sender, EventArgs e)
        {
            tb_edadartsong.Text = "";
        }

        private void bt_agrvideo_Click(object sender, EventArgs e)
        {
            
            pn_addvideo.Visible = true;
            App app = new App();
            app.OpenApp();
            if (app.GetServer().GetActive().GetAdmin())
            {
                pn_Admin.Visible = false;
            }
            else
            {
                pn_Admin.Visible = true;
            }
            app.CloseApp();
        }

        private void bt_backaddvideo_Click(object sender, EventArgs e)
        {
            pn_addvideo.Visible = false;
            lb_datavideo.Visible = false;
            lb_exitovideo.Visible = false;
            tb_nombrevideo.Text = "INGRESE NOMBRE DEL VIDEO";
            tb_generovideo.Text = "INGRESE GENERO DEL VIDEO";
            tb_direcvideo.Text = "INGRESE NOMBRE DEL DIRECTOR DEL VIDEO";
            tb_canalvideo.Text = "INGRESE CANAL DEL VIDEO";
            tb_sexodirecvideo.Text = "SEXO DIRECTOR DEL VIDEO (HOMBRE-MUJER)";
            tb_edaddirect.Text = "EDAD DEL DIRECTOR";
        }

        private void bt_cargarvideo_Click(object sender, EventArgs e)
        {
            App app = new App();
            if (tb_nombrevideo.Text == "" || tb_generovideo.Text == "" || tb_direcvideo.Text == "" || tb_canalvideo.Text == "" || tb_sexodirecvideo.Text == "" || tb_edaddirect.Text == "")
            {
                lb_datavideo.Visible = true;
            }
            else
            {
                if (openFileDialogvideo.ShowDialog() == DialogResult.OK)
                {
                    routevideo = openFileDialogvideo.FileName;
                    NameVideo = tb_nombrevideo.Text;
                    KindVideo = tb_generovideo.Text;
                    AgeDirector = Convert.ToInt32(tb_edaddirect.Text);
                    NameDirector = tb_direcvideo.Text;
                    SexDirector = tb_sexodirecvideo.Text;
                    StudioVideo= tb_canalvideo.Text;
                    Workers worker = new Workers();
                    worker.SetName(NameDirector);
                    worker.SetAge(AgeDirector);
                    worker.SetSex(SexDirector);
                    worker.SetSurname(NameDirector);
                    List<Workers> workerlist = new List<Workers>();
                    workerlist.Add(worker);
                    app.OpenApp();
                    app.AddVid(NameVideo,KindVideo,StudioVideo,workerlist,workerlist,routevideo);
                    app.CloseApp();


                }

                lb_exitovideo.Visible = true;
                lb_datavideo.Visible = false;
            }
        }

        private void tb_nombrevideo_Click(object sender, EventArgs e)
        {
            tb_nombrevideo.Text = "";
        }

        private void tb_generovideo_Click(object sender, EventArgs e)
        {
            tb_generovideo.Text = "";
        }

        private void tb_canalvideo_Click(object sender, EventArgs e)
        {
            tb_canalvideo.Text = "";

        }

        private void tb_direcvideo_Click(object sender, EventArgs e)
        {
            tb_direcvideo.Text = "";
        }



        private void tb_edaddirect_Click(object sender, EventArgs e)
        {
            tb_edaddirect.Text = "";
        }

        private void tb_sexodirecvideo_Click(object sender, EventArgs e)
        {
            tb_sexodirecvideo.Text = "";
        }

        private void bt_nextvideo_Click(object sender, EventArgs e)
        {
            App app = new App();
            z += 1;
            app.OpenApp();
            if (i <= app.Getallvideos().Count())
            {
                try
                {
                    axWindowsMediaPlayervideo.URL = app.Getallvideos()[z].GetRoute();
                    axWindowsMediaPlayervideo.Ctlcontrols.play();

                }

                catch
                {

                }


            }
            app.CloseApp();
        }

        private void pn_addvideo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_namesongcola_Click(object sender, EventArgs e)
        {
            tb_namesongcola.Text = "";
        }

        private void tb_nameartistcola_Click(object sender, EventArgs e)
        {
            tb_nameartistcola.Text = "";
        }

        private void bt_backaddcola_Click(object sender, EventArgs e)
        {
            pn_addsongcola.Visible = false;
            pn_tuusu.Visible = true;
            rtb_songsaddcola.Clear();
        }

        private void bt_agrcolasong_Click(object sender, EventArgs e)
        {

        }

        private void bt_addsongcola_Click(object sender, EventArgs e)
        {
            App app = new App();
            string namesongcola, nameartistcola,exist;
            namesongcola = tb_namesongcola.Text;
            nameartistcola = tb_nameartistcola.Text;
            exist = "";
            app.OpenApp();
           
            
            foreach(var a in app.GetAllSongs() )
            {
                if (a.GetName()==namesongcola && a.GetArtistName() == nameartistcola)
                {
                    app.AddToQueue(a, 0);
                    lb_addsongcorrectlycola.Text = "CANCION AÑADIDA CORRECTAMENTE";
                    exist = "si";
                    break;
                }
                else
                {

                    continue;
                }
            }
            if (exist == "si")
            {
                lb_addsongcorrectlycola.Text = "CANCION AÑADIDA CORRECTAMENTE";
                 
            }
            else
            {
                lb_addsongcorrectlycola.Text = "ERROR AL INGRESAR CANCION A LA COLA";
            }
            app.CloseApp();
        }

        private void bt_agrcolasong_Click_1(object sender, EventArgs e)
        {
            App app = new App();
            pn_addsongcola.Visible = true;
            pn_tuusu.Visible = false;
            app.OpenApp();
            foreach(var a in app.GetAllSongs())
            {
                rtb_songsaddcola.Text += "cancion: " + a.GetName() + "," + " artista: " + a.GetArtistName()+"\n";
            }
            app.CloseApp();
        }

        private void bt_esccolasong_Click(object sender, EventArgs e)
        {
            pn_repcola.Visible = true;
            pn_tuusu.Visible = false;
        }

        private void bt_vercolvideo_Click(object sender, EventArgs e)
        {
            pn_repvideocola.Visible = true;
            pn_tuusu.Visible = false;
        }

        private void bt_agrecolavideo_Click(object sender, EventArgs e)
        {
            App app = new App();
            pn_addcolavideo.Visible = true;
            pn_tuusu.Visible = false;
            app.OpenApp();
            foreach(var a in app.Getallvideos())
            {
                rtb_addvideocola.Text += "video: " + a.GetName() + " director: " + a.GetNameDirector() + "\n";
            }
            app.CloseApp();
        }

        private void pn_tuusu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Backcola_Click(object sender, EventArgs e)
        {
            pn_repcola.Visible = false;
            pn_tuusu.Visible = true;
            axWMP_Repcola.Ctlcontrols.stop();
        }

        private void bt_repcola_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            if (w > app.GetServer().GetActive().GetQueue(0).Count())
            {

            }
            else
            {
                try
                {
                    axWMP_Repcola.URL = app.GetServer().GetActive().GetQueue(0)[w].GetRoute();
                    axWMP_Repcola.Ctlcontrols.play();
                }
                catch
                {

                }
            }

            app.CloseApp();
        }

        private void bt_pausecola_Click(object sender, EventArgs e)
        {
            axWMP_Repcola.Ctlcontrols.pause();
        }

        private void bt_nextcola_Click(object sender, EventArgs e)
        {
            App app = new App();
            w += 1;
            app.OpenApp();
            if (w <= app.GetServer().GetActive().GetQueue(0).Count())
            {
                try
                {
                    axWMP_Repcola.URL = app.GetServer().GetActive().GetQueue(0)[w].GetRoute();
                    axWMP_Repcola.Ctlcontrols.play();

                }

                catch
                {

                }


            }
            app.CloseApp();
        }

        private void pn_repcola_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_backaddvideocola_Click(object sender, EventArgs e)
        {
            pn_addcolavideo.Visible = false;
            pn_tuusu.Visible = true;
            rtb_addvideocola.Clear();
        }

        private void tb_namevideocola_Click(object sender, EventArgs e)
        {
            tb_namevideocola.Text = "";
        }

        private void tb_directorvideocola_Click(object sender, EventArgs e)
        {
            tb_directorvideocola.Text = "";
        }

        private void bt_addvideocola_Click(object sender, EventArgs e)
        {
            App app = new App();
            string namevideo, namedirector,existe;
            namevideo = tb_namevideocola.Text;
            namedirector = tb_directorvideocola.Text;
            existe = "";
            app.OpenApp();


            foreach (var a in app.Getallvideos())
            {
                if (a.GetName() == namevideo && a.GetNameDirector() == namedirector)
                {
                    app.AddToQueue(a, 1);;
                    existe = "si";
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (existe == "si")
            {
                lb_addvideocola.Text = "VIDEO AÑADIDO CORRECTAMENTE";

            }
            else
            {
                lb_addvideocola.Text = "VIDEO NO ENCONTRADO";
            }
            app.CloseApp();
        }

        private void bt_repvideocola_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            if (x > app.GetServer().GetActive().GetQueue(1).Count())
            {

            }
            else
            {
                try
                {

                    WMPrepvideocola.URL = app.GetServer().GetActive().GetQueue(1)[x].GetRoute();
                    WMPrepvideocola.Ctlcontrols.play();
                }
                catch
                {

                }
            }
            app.CloseApp();
        }

        private void bt_pausevideocola_Click(object sender, EventArgs e)
        {
            WMPrepvideocola.Ctlcontrols.pause();
        }

        private void bt_nextvideocola_Click(object sender, EventArgs e)
        {
            App app = new App();
            x += 1;
            app.OpenApp();
            if (x <= app.GetServer().GetActive().GetQueue(0).Count())
            {
                try
                {
                    WMPrepvideocola.URL = app.GetServer().GetActive().GetQueue(1)[x].GetRoute();
                    WMPrepvideocola.Ctlcontrols.play();

                }

                catch
                {

                }


            }
            app.CloseApp();
        }

        private void bt_backrepvideocola_Click(object sender, EventArgs e)
        {
            pn_repvideocola.Visible = false;
            pn_tuusu.Visible = true;
            WMPrepvideocola.Ctlcontrols.stop();
        }

        private void bt_folplay_Click(object sender, EventArgs e)
        {
            pn_songPL.Visible = true;
            tb_searchsongPL.Visible = true;
            bt_searchsongPL.Visible = true;
            label12.Visible = true;
            lb_songPLTitle.Text = "Follow Playlist";
        }

        private void bt_backsongPL_Click(object sender, EventArgs e)
        {
            pn_songPL.Visible = false;
            tb_searchsongPL.Text = "";
            tb_searchsongPL.Visible = true;
            cb_privsongPL.Visible = false;
            rtb_songPL.Text = "";
            bt_addsongPL.Visible = false;
            bt_deletesongPL.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            tb_editsongPL.Visible = false;
            label12.Text = "Nombre Playlist";
            label12.Visible = false;
            bt_searchsongPL.Visible = true;
            bt_createsongPL.Visible = false;
            cb_privsongPL.Checked = false;
            tb_editsongPL.Text = "";
        }

        private void bt_searchsongPL_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            label12.Visible = true;
            bool checkExistence = app.GetServer().CheckPLExistence(tb_searchsongPL.Text, 0, app);
            if (checkExistence == false)
            {
                
                rtb_songPL.Text=("La playlist no existe");
                
            }
            else
            {
                app.GetServer().GetActive().FollowMusicPL(app.GetServer().GetSpecificPL(tb_searchsongPL.Text, 0, app));
                rtb_songPL.Text=("Seguiste a la playlist");
                
            }
            app.CloseApp();
        }

        private void bt_seguiplay_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            pn_songPL.Visible = true;
            tb_searchsongPL.Visible = false;
            bt_searchsongPL.Visible = false;
            label12.Visible = false;
            lb_songPLTitle.Text = "Playlist seguidas";
            List<Playlist> allFollowed = app.GetServer().GetActive().GetFollowedMusicPL();
            if (allFollowed.Count() != 0)
            {
                for (int i = 0; i < allFollowed.Count(); i++)
                {
                    rtb_songPL.Text=rtb_songPL.Text+"\n"+(i + 1 + ". " + allFollowed[i].GetInfoPL());
                }
            }
            else
            {
                rtb_songPL.Text=("No sigues ninguna playlist");
            }
            app.CloseApp();
        }

        private void bt_allplay_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            pn_songPL.Visible = true;
            tb_searchsongPL.Visible = false;
            bt_searchsongPL.Visible = false;
            label12.Visible = false;
            lb_songPLTitle.Text = "Todas las Playlist";
            if (app.SeeMusicPL() != "")
            {
                rtb_songPL.Text = app.SeeMusicPL();
            }
            else
            {
                rtb_songPL.Text = "El programa no tiene playlists para mostrar";
            }
            app.CloseApp();
        }

        private void bt_addsongPL_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            
            try
            {
                List<string> searchParameter = new List<string>() { tb_editsongPL.Text };
                rtb_songPL.Text=(app.GetServer().GetActive().GetYourMusic()[Convert.ToInt32(tb_searchsongPL.Text)-1].AddMedia(app.SearchAndPlaySong(searchParameter)[0]));
                if ((rtb_songPL.Text == "Se anadio la cancion con exito"))
                {
                    label14.Text = "Se anadio la cancion con exito";
                    label14.Visible = true;
                }
                else
                {
                    label14.Text = "No se encontro la cancion";
                    label14.Visible = true;
                }
            }
            catch (FormatException a)
            {
                label12.Text = "Ingrese un valor correcto";
                label14.Text = "Ingrese valor correcto";
                label14.Visible = true;
            }
            catch(ArgumentOutOfRangeException a)
            {
                label12.Text = "Ingrese un valor correcto";
                
                label14.Visible = true;
            }
            app.CloseApp();
        }

        private void bt_deletesongPL_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<Playlist> userPlaylists = app.GetServer().GetActive().GetYourMusic();
            try
            {
                int choiceDelete = Int32.Parse(tb_editsongPL.Text);
                rtb_songPL.Text=(app.GetServer().GetActive().GetYourMusic()[Convert.ToInt32(tb_searchsongPL.Text)-1].DeleteMedia(userPlaylists[Convert.ToInt32(tb_searchsongPL.Text)-1].GetAllMedia()[choiceDelete]));
            }
            catch (FormatException a)
            {
                label12.Text = "Ingrese un valor correcto";
                label14.Text = "Ingrese valor correcto";
                label14.Visible = true;
            }
            catch (ArgumentOutOfRangeException a)
            {
                label12.Text = "Ingrese un valor correcto";

                label14.Visible = true;
            }
            app.CloseApp();
        }

        private void bt_editarplay_Click(object sender, EventArgs e)
        {
            lb_songPLTitle.Text = "Editar Playlist";
            bt_searchsongPL.Visible = false;
            label12.Text = "Escriba el numero de la playlista editar";
            label12.Visible = true;
            pn_songPL.Visible = true;
            label15.Visible = true;
            bt_addsongPL.Visible = true;
            bt_deletesongPL.Visible = true;
            tb_editsongPL.Visible = true;
            App app = new App();
            app.OpenApp();
            try
            {
                List<Playlist> userPlaylists = app.GetServer().GetActive().GetYourMusic();
            
                for (int i = 0; i < userPlaylists.Count(); i++)
                {
                    rtb_songPL.Text = rtb_songPL.Text + "\n" +(Convert.ToInt32(i)+1)+". "+ userPlaylists[i].GetNamePL() + "\n" + "\n";
                    if (userPlaylists[i].GetAllMedia().Count() >1)
                    {
                        for (int a = 0; a < userPlaylists[i].GetAllMedia().Count(); a++)
                        {
                            if (a == 0)
                            {
                                rtb_songPL.Text = rtb_songPL.Text;
                            }
                            else
                            {
                                rtb_songPL.Text = rtb_songPL.Text + "\n" + a + ". " + userPlaylists[i].GetAllMedia()[a].GetData();
                            }
                        }
                    }
                    else
                    {
                        rtb_songPL.Text = rtb_songPL.Text + "No tiene canciones";
                    }
                    rtb_songPL.Text = rtb_songPL.Text + "\n" + "---------------------------------" + "\n";
                }
                
            }
            catch(NullReferenceException k)
            {
                rtb_songPL.Text = "No existen playlists";
            }
            app.CloseApp();
            
        }

        private void bt_crearplay_Click(object sender, EventArgs e)
        {
            pn_songPL.Visible = true;
            label12.Visible = true;
            bt_createsongPL.Visible = true;
            lb_songPLTitle.Text="Crear Playlist";
            bt_searchsongPL.Visible = false;
            cb_privsongPL.Visible = true;
            label12.Visible = true;
        }

        private void bt_createsongPL_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            Song song = new Song();
            if (tb_searchsongPL.Text != "")
            {
                rtb_songPL.Text=app.MakePL("Songs", tb_searchsongPL.Text, cb_privsongPL.Checked, new List<Multimedia>() { song });
            }
            else
            {
                rtb_songPL.Text = "Pongale nombre a la playlist";
            }
            app.CloseApp();
        }

        private void bt_addvidPL_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();

            try
            {
                List<string> searchParameter = new List<string>() { tb_editvidPL.Text };
                rtb_vidPL.Text = (app.GetServer().GetActive().GetYourVideos()[Convert.ToInt32(tb_VidPL.Text) - 1].AddMedia(app.SearchAndPlayVid(searchParameter)[0]));
                if ((rtb_vidPL.Text == "Se anadio la cancion con exito"))
                {
                    rtb_vidPL.Text = "Se anadio la cancion con exito";
                    
                }
                else
                {
                    rtb_vidPL.Text = "No se encontro la cancion";
                    
                }
            }
            catch (FormatException a)
            {
                rtb_vidPL.Text = "Ingrese un valor correcto";
                
            }
            catch (ArgumentOutOfRangeException a)
            {
                rtb_vidPL.Text = "Ingrese un valor correcto";

                
            }
            app.CloseApp();
        }

        private void bt_backvidPL_Click(object sender, EventArgs e)
        {
            pn_vidPL.Visible = false;
            label16.Visible = true;
            label16.Text = "Nombre Playlist";
            tb_VidPL.Visible = true;
            bt_searchvidPL.Visible = true;
            rtb_vidPL.Text = "";
            tb_VidPL.Text = "";
            cb_privvidPL.Checked = false;
            bt_addvidPL.Visible = false;
            bt_deletevidPL.Visible = false;
            tb_editvidPL.Visible = false;
            tb_editvidPL.Text = "";
            bt_createvidPL.Visible = false;
            label17.Visible = false;
        }

        private void bt_searchvidPL_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            label16.Visible = true;
            tb_VidPL.Visible = true;
            bt_searchvidPL.Visible = true;
            bool checkExistence = app.GetServer().CheckPLExistence(tb_VidPL.Text, 1, app);
            if (checkExistence == false)
            {

                rtb_vidPL.Text = ("La playlist no existe");

            }
            else
            {
                app.GetServer().GetActive().FollowMusicPL(app.GetServer().GetSpecificPL(tb_VidPL.Text, 1, app));
                rtb_vidPL.Text = ("Seguiste a la playlist");

            }
            app.CloseApp();
        }

        private void bt_createvidPL_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            Video vid = new Video();
            if (tb_VidPL.Text != "")
            {
                rtb_vidPL.Text = app.MakePL("Videos", tb_VidPL.Text, cb_privvidPL.Checked, new List<Multimedia>() { vid });
            }
            else
            {
                rtb_vidPL.Text = "Pongale nombre a la playlist";
            }
            app.CloseApp();
        }

        private void bt_folplayvideo_Click(object sender, EventArgs e)
        {
            pn_vidPL.Visible = true;
            lb_vidPL.Text="Follow Playlist";
        }

        private void bt_playseguivideo_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            bt_searchvidPL.Visible = false;
            tb_VidPL.Visible = false;
            label16.Visible = false;
            lb_vidPL.Text = "Playlist Seguidas";
            List<Playlist> allFollowed = app.GetServer().GetActive().GetFollowedVidPL();
            if (allFollowed.Count() != 0)
            {
                for (int i = 0; i < allFollowed.Count(); i++)
                {
                    rtb_vidPL.Text = rtb_vidPL.Text + "\n" + (i + 1 + ". " + allFollowed[i].GetInfoPL());
                }
            }
            else
            {
                rtb_vidPL.Text = ("No sigues ninguna playlist");
            }
            app.CloseApp();


        }

        private void bt_verplayvideo_Click(object sender, EventArgs e)
        {
            pn_vidPL.Visible = true;
            bt_searchvidPL.Visible = false;
            tb_VidPL.Visible = false;
            label16.Visible = false;
            App app = new App();
            app.OpenApp();
            lb_vidPL.Text = "Todas las Playlist";
            if (app.SeeVidPL() != "")
            {
                rtb_vidPL.Text = app.SeeVidPL();
            }
            else
            {
                rtb_vidPL.Text = "El programa no tiene playlists para mostrar";
            }
            app.CloseApp();
        }

        private void bt_ediplayvideo_Click(object sender, EventArgs e)
        {
            pn_vidPL.Visible = true;
            bt_searchvidPL.Visible = true;
            tb_VidPL.Visible = true;
            label16.Visible = true;
            bt_addvidPL.Visible = true;
            bt_deletevidPL.Visible = true;
            label17.Visible = true;
            tb_editvidPL.Visible = true;
            label16.Text = "Ingrese numero de la playlist";
            App app = new App();
            app.OpenApp();
            try
            {
                List<Playlist> userPlaylists = app.GetServer().GetActive().GetYourVideos();

                for (int i = 0; i < userPlaylists.Count(); i++)
                {
                    rtb_vidPL.Text = rtb_vidPL.Text + "\n" + (Convert.ToInt32(i) + 1) + ". " + userPlaylists[i].GetNamePL() + "\n" + "\n";
                    if (userPlaylists[i].GetAllMedia().Count() > 1)
                    {
                        for (int a = 0; a < userPlaylists[i].GetAllMedia().Count(); a++)
                        {
                            if (a == 0)
                            {
                                rtb_vidPL.Text = rtb_vidPL.Text;
                            }
                            else
                            {
                                rtb_vidPL.Text = rtb_vidPL.Text + "\n" + a + ". " + userPlaylists[i].GetAllMedia()[a].GetData();
                            }
                        }
                    }
                    else
                    {
                        rtb_vidPL.Text = rtb_vidPL.Text + "No tiene videos";
                    }
                    rtb_vidPL.Text = rtb_vidPL.Text + "\n" + "---------------------------------" + "\n";
                }

            }
            catch (NullReferenceException k)
            {
                rtb_vidPL.Text = "No existen playlists";
            }
            app.CloseApp();
        }

        private void bt_deletevidPL_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<Playlist> userPlaylists = app.GetServer().GetActive().GetYourVideos();
            try
            {
                int choiceDelete = Int32.Parse(tb_editvidPL.Text);
                rtb_vidPL.Text = (app.GetServer().GetActive().GetYourVideos()[Convert.ToInt32(tb_VidPL.Text) - 1].DeleteMedia(userPlaylists[Convert.ToInt32(tb_VidPL.Text) - 1].GetAllMedia()[choiceDelete]));
            }
            catch (FormatException a)
            {
                rtb_vidPL.Text = "Ingrese un valor correcto";
                
            }
            catch (ArgumentOutOfRangeException a)
            {
                rtb_vidPL.Text = "Ingrese un valor correcto";

                
            }
            app.CloseApp();
        }

        private void bt_crearplayvideo_Click(object sender, EventArgs e)
        {
            lb_vidPL.Text = "Crear Playlist";
            tb_VidPL.Visible = true;
            bt_searchvidPL.Visible = false;
            label16.Visible = true;
            cb_privvidPL.Visible = true;
            bt_createvidPL.Visible = true;
            pn_vidPL.Visible = true;
        }

        private void bt_bussim_Click(object sender, EventArgs e)
        {
            pn_searchSong.Visible = true;
            tb_searchSong.Text = "";
            rtb_searchSong.Text = "";
            label18.Text = "Busqueda Simple";

        }

        private void bt_backsearchSong_Click(object sender, EventArgs e)
        {
            pn_searchSong.Visible = false;
        }

        private void bt_searchSong_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<string> filterList = new List<string>();
            char[] delimit = { ',' };
            string[] stringlist = tb_searchSong.Text.Split(delimit);
            foreach (var filter in stringlist)
            {
                filterList.Add(filter);
            }
            List<Song> filteredList = app.SearchAndPlaySong(filterList);
            if (filteredList.Count != 0)
            {
                foreach (var a in filteredList)
                {
                    rtb_searchSong.Text = rtb_searchSong.Text + "\n" + (a.GetData() + ", " + a.GetArtistSong());
                }
            }
            else
            {
                rtb_searchSong.Text = "No se encontraron canciones con esos parametros";
            }
            app.CloseApp();
        }

        private void bt_busmulti_Click(object sender, EventArgs e)
        {
            pn_searchSong.Visible = true;
            tb_searchSong.Text = "";
            rtb_searchSong.Text = "";
            label18.Text = "Busqueda Multiple";
        }

        private void bt_backmenuUser_Click(object sender, EventArgs e)
        {
            pn_menuUser.Visible = false;
            rtb_menuUser.Text = "";
            tb_User.Text = "";
        }

        private void bt_searchUser_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<User> allfollowed = app.GetServer().GetActive().GetFollowedUsers();
            
            string username = tb_User.Text;
            bool searchtry = app.GetServer().CheckUserExistence(username);
            if (searchtry == false)
            {

                rtb_menuUser.Text = "El usuario no existe";

            }
            else
            {
                User followUser = app.GetServer().SearchUser(username);
                app.GetServer().GetActive().FollowUser(followUser);
                rtb_menuUser.Text = "Se comenzo a seguir el usuario";
            }
            app.CloseApp();
        }

        private void bt_ussegui_Click(object sender, EventArgs e)
        {
            pn_menuUser.Visible = true;
            tb_User.Visible = false;
            bt_searchUser.Visible = false;
            label20.Text = "Usuarios Seguidos";
            App app = new App();
            app.OpenApp();
            List<User> allfollowed = app.GetServer().GetActive().GetFollowedUsers();
            string users = "";
            if (allfollowed.Count() != 0)
            {
                for (int i = 0; i < allfollowed.Count(); i++)
                {
                    users += allfollowed[i].GetUsername() + Environment.NewLine;
                }
                rtb_menuUser.Text = users;
            }
            else
            {
                rtb_menuUser.Text=  "No sigues a nadie";
            }
            app.CloseApp(); 
        }

        private void bt_bususu_Click(object sender, EventArgs e)
        {
            pn_menuUser.Visible = true;
            tb_User.Visible = true;
            bt_searchUser.Visible = true;
            label20.Text = "Buscar y Seguir Usuario";
        }

        private void bt_backcritVid_Click(object sender, EventArgs e)
        {
            pn_vidCrit.Visible = false;
            tb_critTitle.Text = "";
            tb_vidCrit.Text = "";
            bt_commcritVid.Visible = false;
            tb_critTitle.Visible = false;
            rtb_critVid.Text = "";
            label24.Visible = false;
            rtb_critVid.ReadOnly = true;
            bt_searchcritVid.Visible = true;
            tb_vidCrit.Text="";
        }

        private void bt_searchcritVid_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();

            string name = tb_vidCrit.Text;
            Video vid = app.SearchforVid(name);
            List<Review> review = vid.GetListReview();
            
            if (review == null)
            {
                rtb_critVid.Text=("El video no tiene criticas");
            }
            else
            {
                rtb_critVid.Text = (vid.GetReview());
            }
            app.CloseApp();
        }

        private void bt_commcritVid_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();

            string name = tb_vidCrit.Text;
            
            Video vid = app.SearchforVid(name);
            if (vid.GetListReview() != null)
            {
                List<Review> review = vid.GetListReview();
                Review userReview = new Review();
                
                string title = tb_critTitle.Text;
                rtb_critVid.ReadOnly = false;
                string comment = rtb_critVid.Text;
                userReview.SetReview(title, comment);
                review.Add(userReview);
                app.ReviewVid(app.GetServer().GetActive().GetUsername(), review);
            }
            else
            {
                List<Review> review = new List<Review>();
                Review userReview = new Review();
                string title = tb_critTitle.Text;
                rtb_critVid.ReadOnly = false;
                string comment = rtb_critVid.Text;
                userReview.SetReview(title, comment);
                review.Add(userReview);
                app.ReviewVid(name, review);
            }
            app.CloseApp();
        }

        private void rtb_critVid_Click(object sender, EventArgs e)
        {
            rtb_critVid.Text="";
        }

        private void bt_makecritvideo_Click(object sender, EventArgs e)
        {
            pn_vidCrit.Visible = true;
            tb_critTitle.Visible = true;
            rtb_critVid.Text = "Agregue su comentario aqui";
            bt_searchcritVid.Visible = false;
            bt_commcritVid.Visible = true;
            label24.Visible = true;
            label22.Text = "Criticar un video";
        }

        private void bt_vercriticavideo_Click(object sender, EventArgs e)
        {
            pn_vidCrit.Visible = true;
            rtb_critVid.Text = "";
            label24.Visible = false;
            label22.Text = "Ver criticas de un video";
        }

        private void bt_backratiVid_Click(object sender, EventArgs e)
        {
            pn_vidRating.Visible = false;
            clb_rateVid.Visible = false;
            bt_rateVid.Visible = false;
            bt_searchratVid.Visible = true;
            tb_ratingVid.Text = "";
        }

        private void bt_searchratVid_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<Video> allVid = app.Getallvideos();
            int index = 0;
            bool found = false;

            if (tb_ratingVid.Text == "")
            {
                tb_ratingVid.Text = "Rellene el campo";
            }

            else
            {
                for (int i = 0; i < allVid.Count(); i++)
                {
                    if (tb_ratingVid.Text == allVid[i].GetName())
                    {
                        index = i;
                        found = true;
                    }
                }
                if (found)
                {
                    lb_vidRating.Text = allVid[index].GetRating() + " " + "estrellas";
                }
                else
                {
                    lb_vidRating.Text = "No se encontro el video buscado";
                }
            }
            app.CloseApp();
        }

        private void bt_rateVid_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<Video> allVid = app.Getallvideos();
            int index = 0;
            bool found = false;

            if (tb_ratingVid.Text == "")
            {
                tb_ratingVid.Text = "Rellene el campo";
            }
            else
            {
                for (int i = 0; i < allVid.Count(); i++)
                {
                    if (tb_ratingVid.Text == allVid[i].GetName())
                    {
                        index = i;
                        found = true;
                    }
                }
                if (found)
                {
                    if (clb_rateVid.GetItemChecked(0))
                    {
                        List<Rating> allRating = allVid[index].GetListRating();
                        Rating rating = new Rating();
                        rating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.SetRating(1);
                        allRating.Add(rating);
                        allVid[index].SetRating(allRating);

                    }
                    else if (clb_rateVid.GetItemChecked(1))
                    {
                        List<Rating> allRating = allVid[index].GetListRating();
                        Rating rating = new Rating();
                        rating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.SetRating(2);
                        allRating.Add(rating);
                        allVid[index].SetRating(allRating);
                    }
                    else if (clb_rateVid.GetItemChecked(2))
                    {
                        List<Rating> allRating = allVid[index].GetListRating();
                        Rating rating = new Rating();
                        rating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.SetRating(3);
                        allRating.Add(rating);
                        allVid[index].SetRating(allRating);
                    }
                    else if (clb_rateVid.GetItemChecked(3))
                    {
                        List<Rating> allRating = allVid[index].GetListRating();
                        Rating rating = new Rating();
                        rating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.SetRating(4);
                        allRating.Add(rating);
                        allVid[index].SetRating(allRating);
                    }
                    else if (clb_rateVid.GetItemChecked(4))
                    {
                        List<Rating> allRating = allVid[index].GetListRating();
                        Rating rating = new Rating();
                        rating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.SetRating(5);
                        allRating.Add(rating);
                        allVid[index].SetRating(allRating);
                    }
                    else
                    {
                        tb_ratingVid.Text = "Marque una opcion";
                    }
                }
                else
                {

                    tb_ratingVid.Text = "El video no pudo encontrarse";
                }
            }
            app.CloseApp();
        }

        private void bt_verrativideo_Click(object sender, EventArgs e)
        {
            tb_ratingVid.Text = "";
            pn_vidRating.Visible = true;
            clb_rateVid.Visible = false;
            bt_rateVid.Visible = false;
            bt_searchratVid.Visible = true;
        }

        private void bt_darrativideo_Click(object sender, EventArgs e)
        {
            tb_ratingVid.Text = "";
            pn_vidRating.Visible = true;
            clb_rateVid.Visible = true;
            bt_rateVid.Visible = true;
            bt_searchratVid.Visible = false;

        }

        private void tb_ratingVid_TextChanged(object sender, EventArgs e)
        {
            tb_ratingVid.Text = "";
        }

        private void bt_backvidSearch_Click(object sender, EventArgs e)
        {
            pn_searchVid.Visible = false;
            tb_vidSearch.Text = "";
            rtb_vidSearch.Text = "";
        }

        private void bt_searchVid_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<string> filterList = new List<string>();
            char[] delimit = {  ',' };
            string[] stringlist = tb_vidSearch.Text.Split(delimit);
            foreach (var filter in stringlist)
            {
                filterList.Add(filter);
            }
            List<Video> filteredList = app.SearchAndPlayVid(filterList);
            if (filteredList.Count != 0)
            {
                foreach (var a in filteredList)
                {
                    rtb_vidSearch.Text = rtb_vidSearch.Text + "\n" + (a.GetData());
                }
            }
            else
            {
                rtb_vidSearch.Text = "No se encontraron videos con esos parametros";
            }
            app.CloseApp();
        }

        private void bt_multivideo_Click(object sender, EventArgs e)
        {
            pn_searchVid.Visible = true;
            tb_vidSearch.Text = "";
            rtb_vidSearch.Text = "";
            label27.Text = "Busqueda Multiple";
        }

        private void bt_simvideo_Click(object sender, EventArgs e)
        {
            pn_searchVid.Visible = true;
            tb_vidSearch.Text = "";
            rtb_vidSearch.Text = "";
            label27.Text = "Busqueda Simple";
        }

        private void bt_backrepsong_Click(object sender, EventArgs e)
        {
            pn_repsong.Visible = false;
            pn_settingsong.Visible = true;
            axWindowsMediaPlayersong.Ctlcontrols.stop();
        }

        private void bt_backrepvideo_Click(object sender, EventArgs e)
        {
            pn_video.Visible = true;
            pn_repvideo.Visible = false;
            axWindowsMediaPlayervideo.Ctlcontrols.stop();
        }

        private void bt_reproplayvideo_Click(object sender, EventArgs e)
        {   App app = new App();
            pn_askvideoplaylist.Visible = true;
            pn_playlistvideo.Visible = false;
            app.OpenApp();
            if (app.GetServer().GetActive().GetYourVideos() == null)
            {

            }
            else
            {
                foreach (var a in app.GetServer().GetActive().GetYourVideos())
                {
                    rtb_playlistvideosname.Text += "nombre: " + a.GetNamePL() + "\n";
                }

            }
            app.CloseApp();
            
        }

        private void bt_backrepvideoplaylist_Click(object sender, EventArgs e)
        {
            pn_repvideoplaylist.Visible = false;
            pn_playlistvideo.Visible = true;
            rtb_playlistvideosname.Clear();
            WMPrepvideoplaylist.Ctlcontrols.stop();
           
        }

        private void bt_repvideoplaylist_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            foreach(var a in app.GetServer().GetActive().GetYourVideos())
            {
                if (a.GetNamePL()==NamePlvid)
                {
                    if (c> a.GetAllMedia().Count())
                    {

                    }
                    else
                    {
                        try
                        {
                            WMPrepvideoplaylist.URL = a.GetAllMedia()[c+1].GetRoute();
                            WMPrepvideoplaylist.Ctlcontrols.play();
                        }
                        catch
                        {

                        }
                        
                    }
                }
                else
                {

                }
            }
            
            

            app.CloseApp();
        }

        private void tb_asknamevideoplaylist_Click(object sender, EventArgs e)
        {
            tb_asknamevideoplaylist.Clear();
        }

        private void bt_backaskvideoplaylist_Click(object sender, EventArgs e)
        {
            pn_playlistvideo.Visible = true;
            pn_askvideoplaylist.Visible = false;
            rtb_playlistvideosname.Clear();
        }

        private void bt_nextvideoplaylist_Click(object sender, EventArgs e)
        {
            c += 1;
            App app = new App();
            app.OpenApp();
            foreach(var a in app.GetServer().GetActive().GetYourVideos())
            {
                if (a.GetNamePL() == NamePlvid)
                {

                    if (c <= app.GetServer().GetActive().GetYourVideos().Count())
                    {
                        try
                        {
                            WMPrepvideoplaylist.URL = a.GetAllMedia()[c+1].GetRoute();
                            WMPrepvideoplaylist.Ctlcontrols.play();

                        }

                        catch
                        {

                        }
                    }


                }
            }

            app.CloseApp();

        }

        private void tb_askplaylistsong_Click(object sender, EventArgs e)
        {
            tb_askplaylistsong.Clear();
        }

        private void bt_backaskplsong_Click(object sender, EventArgs e)
        {
            rtb_namesongplaylist.Clear();
            pn_asksongplaylist.Visible = false;
        }

        private void bt_repplay_Click(object sender, EventArgs e)
        {
            pn_asksongplaylist.Visible = true;
            pn_playlist.Visible = false;
            App app = new App();
            app.OpenApp();
            if (app.GetServer().GetActive().GetYourMusic() == null)
            {

            }
            else
            {
                foreach (var a in app.GetServer().GetActive().GetYourMusic())
                {
                    rtb_namesongplaylist.Text  += "nombre: " + a.GetNamePL() + "\n";
                }

            }
            app.CloseApp();
        }

        private void bt_backrepplsong_Click(object sender, EventArgs e)
        {
            pn_asksongplaylist.Visible = true;
            pn_repplyalistsong.Visible = false;
            WMPrepsongplaylist.Ctlcontrols.stop();
        }

        private void bt_repplaylistsong_Click(object sender, EventArgs e)
        {
            s = 0;
            App app = new App();
            app.OpenApp();
            foreach (var a in app.GetServer().GetActive().GetYourMusic())
            {
                if (a.GetNamePL() == NamePlsong)
                {

                    if (t <= a.GetAllMedia().Count())
                    {
                        try
                        {
                            WMPrepsongplaylist.URL = a.GetAllMedia()[t+1].GetRoute();
                            WMPrepsongplaylist.Ctlcontrols.play();

                        }

                        catch
                        {

                        }
                    }



                }

            }
            


            app.CloseApp();
        }

        private void bt_nextsongplaylistsong_Click(object sender, EventArgs e)
        {
            s = 0;
            t += 1;
            App app = new App();
            app.OpenApp();
            foreach (var a in app.GetServer().GetActive().GetYourMusic())
            {
                if (a.GetNamePL() == NamePlsong)
                {

                    if (t <= a.GetAllMedia().Count())
                    {
                        try
                        {
                            WMPrepsongplaylist.URL = a.GetAllMedia()[t+1].GetRoute();
                            WMPrepsongplaylist.Ctlcontrols.play();

                        }

                        catch
                        {

                        }
                    }


                }
                s += 1;
            }
            if (existe1 == "si")
            {
                if (t <= app.GetServer().GetActive().GetYourMusic().Count())
                {
                    try
                    {
                        WMPrepsongplaylist.URL = app.GetServer().GetActive().GetYourMusic()[s].GetAllMedia()[t].GetRoute();
                        WMPrepsongplaylist.Ctlcontrols.play();

                    }

                    catch
                    {

                    }
                }
            }

            app.CloseApp();

        }

        private void bt_deletesongcola_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<Multimedia> queue = new List<Multimedia>();
            app.GetServer().GetActive().SetQueue(0,queue);
            if (app.GetServer().GetActive().GetQueue(0).Count() == 0)
            {
                lb_deletesongcola.Text += "cola vaciada completamente";
            }
            else
            {
                lb_deletesongcola.Text += "error al vaciar cola";
            }
            app.CloseApp();
        }

        private void bt_backdeletesongcola_Click(object sender, EventArgs e)
        {
            pn_tuusu.Visible = true;
            pn_deletesongqueue.Visible = false;
            lb_deletesongcola.Text = "";
        }

        private void bt_vaccolasong_Click(object sender, EventArgs e)
        {
            pn_tuusu.Visible = false;
            pn_deletesongqueue.Visible = true;
        }

        private void bt_backdeletevideoqueue_Click(object sender, EventArgs e)
        {
            pn_deletevideoqueue.Visible = false;
            pn_tuusu.Visible = true;
        }

        private void bt_deletevideoqueue_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            app.GetServer().GetActive().GetQueue(1).Clear();
            if (app.GetServer().GetActive().GetQueue(1).Count() == 0)
            {
               lb_deletevideoqueue.Text += "cola vaciada completamente";
            }
            else
            {
                lb_deletevideoqueue.Text += "error al vaciar cola";
            }
            app.CloseApp();
        }

        private void bt_vaccolavideo_Click(object sender, EventArgs e)
        {
            pn_deletevideoqueue.Visible = true;
            pn_tuusu.Visible = false;
        }

        private void pn_repvideoplaylist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_repplyalistsong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_backAdmin_Click(object sender, EventArgs e)
        {
            pn_Admin.Visible = false;
            tb_Admin.Text = "";
            pn_agregarcancion.Visible = false;
            pn_addvideo.Visible = false;
        }

        private void tb_Admin_Click(object sender, EventArgs e)
        {
            tb_Admin.Text = "";
            
        }

        private void bt_enterAdmin_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            if (app.GetServer().GetActive().GetAdmin() == false)
            {
                if (tb_Admin.Text == "adminadmin")
                {
                    pn_Admin.Visible = false;
                    lb_Admin.Visible = true;
                    tb_Admin.Text = "";
                    app.GetServer().GetActive().ToggleAdmin(true);
                }
                else
                {
                    lb_Admin.Visible = true;
                }
            }
            app.CloseApp();
        }

        private void bt_Artist_Click(object sender, EventArgs e)
        {
            pn_Artists.Visible = true;
        }

        private void bt_Settings_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            lb_SettUN.Text = "User: "+app.GetServer().GetActive().GetUsername();
            pn_Settings.Visible = true;
            cb_AccPriv.Checked = app.GetServer().GetActive().GetPrivacy();
            app.CloseApp();
        }

        private void bt_backArtists_Click(object sender, EventArgs e)
        {
            pn_Artists.Visible = false;
        }

        private void bt_followArtists_Click(object sender, EventArgs e)
        {
            pn_ArtistEdit.Visible = true;
            bt_enterArtist.Visible = true;
            lb_followArtist.Visible = true;
            tb_searchArtist.Visible = true;
            tb_searchArtist.Text = "";
            rtb_Artist.Text = "";
        }

        private void bt_followedArtists_Click(object sender, EventArgs e)
        {
            pn_ArtistEdit.Visible = true;
            bt_enterArtist.Visible = false;
            lb_followArtist.Visible = false;
            tb_searchArtist.Visible = false;
            tb_searchArtist.Text = "";
            rtb_Artist.Text = "";
            App app = new App();
            app.OpenApp();

            List<Workers> artists = app.GetServer().GetActive().GetFollowedArtists();

            if (artists.Count != 0)
            {
                for (int i = 0; i < artists.Count(); i++)
                {
                    rtb_Artist.Text = rtb_Artist.Text + "\n" + artists[i].GetName() + " " + artists[i].GetSurname()+ "\n";
                }
            }
            else
            {
                rtb_Artist.Text = "No sigue artistas";
            }
            app.CloseApp();
        }

        private void bt_backArtistedit_Click(object sender, EventArgs e)
        {
            pn_ArtistEdit.Visible = false;
            bt_enterArtist.Visible = true;
        }

        private void bt_enterArtist_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<Workers> allWorkers = app.GetWorkers();
            if (allWorkers.Count() != 0)
            {
                for (int i = 0; i < allWorkers.Count(); i++)
                {
                    if (tb_searchArtist.Text == allWorkers[i].GetName() + " " + allWorkers[i].GetSurname())
                    {
                        app.GetServer().GetActive().FollowArtist(allWorkers[i]);
                        rtb_Artist.Text = "Se siguio al artista exitosamente";
                        break;
                    }
                }
            }
            else
            {
                rtb_Artist.Text = "No hay artistas para seguir";
            }
            app.CloseApp();
        }

        private void bt_backsettings_Click(object sender, EventArgs e)
        {
            pn_Settings.Visible = false;
            label33.Visible = false;
        }

        private void bt_settApply_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            app.GetServer().GetActive().TogglePrivacy(cb_AccPriv.Checked);
            app.CloseApp();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void bt_nextaskplsong_Click(object sender, EventArgs e)
        {
            pn_asksongplaylist.Visible = false;
            pn_repplyalistsong.Visible = true;
            NamePlsong = tb_askplaylistsong.Text;
        }

        private void bt_nextaskvideoplaylist_Click(object sender, EventArgs e)
        {
            NamePlvid = tb_asknamevideoplaylist.Text;
            pn_repvideoplaylist.Visible = true;
            pn_askvideoplaylist.Visible = false;
        }

        private void bt_grammy_Click(object sender, EventArgs e)
        {
            lb_premios.Visible = true;
            pn_premios.Visible = true;
            rtb_premios.Text = "";
            lb_premios.Text = "CANCIONES CON GRAMMY";
            App app = new App();
            app.OpenApp();
            List<Song> allSongs = app.GetAllSongs();

            int counter = 1;
            for (int i = 0; i < allSongs.Count(); i++)
            {
                if ((allSongs[i].GetAwards().Count() == 1 && (allSongs[i].GetAwards()[0].getName() == "Grammy" || allSongs[i].GetAwards()[0].getName() == "grammy")) || (allSongs[i].GetAwards().Count() == 2 && (allSongs[i].GetAwards()[0].getName() == "Grammy" || allSongs[i].GetAwards()[0].getName() == "grammy" || allSongs[i].GetAwards()[1].getName() == "Grammy" || allSongs[i].GetAwards()[1].getName() == "grammy")))
                {
                    rtb_premios.Text=rtb_premios.Text+"\n"+(counter + ". " + allSongs[i].GetData() + ", " + allSongs[i].GetArtistSong());
                    counter++;
                }
                else
                {
                    continue;
                }
            }
            if (counter == 1)
            {
                rtb_premios.Text=("No existen canciones con Grammy");
            }
            app.CloseApp();
        }

        private void bt_brit_Click(object sender, EventArgs e)
        {
            lb_premios.Visible = true;
            pn_premios.Visible = true;
            rtb_premios.Text = "";
            lb_premios.Text = "CANCIONES CON BRIT";
            App app = new App();
            app.OpenApp();
            List<Song> allSongs = app.GetAllSongs();

            int counter = 1;
            for (int i = 0; i < allSongs.Count(); i++)
            {
                if ((allSongs[i].GetAwards().Count() == 1 && (allSongs[i].GetAwards()[0].getName() == "Brit" || allSongs[i].GetAwards()[0].getName() == "brit")) || (allSongs[i].GetAwards().Count() == 2 && (allSongs[i].GetAwards()[0].getName() == "Brit" || allSongs[i].GetAwards()[0].getName() == "brit" || allSongs[i].GetAwards()[1].getName() == "Brit" || allSongs[i].GetAwards()[1].getName() == "brit")))
                {
                    rtb_premios.Text = rtb_premios.Text + "\n" + (counter + ". " + allSongs[i].GetData() + ", " + allSongs[i].GetArtistSong());
                    counter++;
                }
                else
                {
                    continue;
                }
            }
            if (counter == 1)
            {
                rtb_premios.Text=("No existen canciones con Brit");
            }
            app.CloseApp();
        }

        private void bt_ambos_Click(object sender, EventArgs e)
        {
            lb_premios.Visible = true;
            pn_premios.Visible = true;
            rtb_premios.Text = "";
            lb_premios.Text = "CANCIONES CON AMBOS PREMIOS";
            App app = new App();
            app.OpenApp();
            List<Song> allSongs = app.GetAllSongs();

            int counter = 1;
            for (int i = 0; i < allSongs.Count(); i++)
            {
                if (allSongs[i].GetAwards().Count() == 2)
                {
                    rtb_premios.Text=rtb_premios.Text+"\n"+(counter + ". " + allSongs[i].GetData() + ", " + allSongs[i].GetArtistSong());
                    counter++;
                }
                else
                {
                    continue;
                }
            }
            if (counter == 1)
            {
                rtb_premios.Text=("No existen canciones con ambos premios");
            }
            app.CloseApp();
        }

        private void bt_pnpremiosback_Click(object sender, EventArgs e)
        {
            lb_premios.Visible = false;
            pn_premios.Visible = false;
            rtb_premios.Text = "";
        }

        private void bt_nextsong_Click(object sender, EventArgs e)
        {
            App app = new App();
            i += 1;
            app.OpenApp();
            if (i <= app.GetAllSongs().Count())
            {
                try
                {
                    axWindowsMediaPlayersong.URL = app.GetAllSongs()[i].GetRoute();
                    axWindowsMediaPlayersong.Ctlcontrols.play();

                }

                catch
                {

                }


            }
            app.CloseApp();
        }


        private void bt_searchsongrat_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<Song> allSongs = app.GetAllSongs();
            int index = 0;
            bool found = false;

            if (tb_searchsongrat.Text == "")
            {
                lb_songrating.Text = "Rellene el campo";
            }

            else
            {
                for (int i = 0; i < allSongs.Count(); i++)
                {
                    if (tb_searchsongrat.Text == allSongs[i].GetName())
                    {
                        index = i;
                        found = true;
                    }
                }
                if (found)
                {
                    lb_songrating.Text = allSongs[index].GetRating() + " " + "estrellas";
                }
                else
                {
                    lb_songrating.Text = "No se encontro la cancion buscada";
                }
            }
            app.CloseApp();
        }

        private void tb_edadartsong_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_ratesong_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            List<Song> allSongs = app.GetAllSongs();
            int index = 0;
            bool found = false;

            if (tb_searchsongrat.Text == "")
            {
                lb_songrating.Text = "Rellene el campo";
            }
            else
            {
                for (int i = 0; i < allSongs.Count(); i++)
                {
                    if (tb_searchsongrat.Text == allSongs[i].GetName())
                    {
                        index = i;
                        found = true;
                    }
                }
                if (found)
                {
                    if (clb_ratesong.GetItemChecked(0))
                    {
                        List<Rating> allRating = allSongs[index].GetListRating();
                        Rating rating = new Rating();
                        rating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.SetRating(1);
                        allRating.Add(rating);
                        allSongs[index].SetRating(allRating);

                    }
                    else if (clb_ratesong.GetItemChecked(1))
                    {
                        List<Rating> allRating = allSongs[index].GetListRating();
                        Rating rating = new Rating();
                        rating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.SetRating(2);
                        allRating.Add(rating);
                        allSongs[index].SetRating(allRating);
                    }
                    else if (clb_ratesong.GetItemChecked(2))
                    {
                        List<Rating> allRating = allSongs[index].GetListRating();
                        Rating rating = new Rating();
                        rating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.SetRating(3);
                        allRating.Add(rating);
                        allSongs[index].SetRating(allRating);
                    }
                    else if (clb_ratesong.GetItemChecked(3))
                    {
                        List<Rating> allRating = allSongs[index].GetListRating();
                        Rating rating = new Rating();
                        rating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.SetRating(4);
                        allRating.Add(rating);
                        allSongs[index].SetRating(allRating);
                    }
                    else if (clb_ratesong.GetItemChecked(4))
                    {
                        List<Rating> allRating = allSongs[index].GetListRating();
                        Rating rating = new Rating();
                        rating.SetUser(app.GetServer().GetActive().GetUsername());
                        rating.SetRating(5);
                        allRating.Add(rating);
                        allSongs[index].SetRating(allRating);
                    }
                    else
                    {
                        lb_songrating.Text = "Marque una opcion";
                    }
                }
                else
                {
                    lb_songrating.Visible = true;
                    lb_songrating.Text = "La cancion no pudo encontrarse";
                }
            }
            app.CloseApp();
        }

        private void bt_backsongrat_Click(object sender, EventArgs e)
        {
            lb_songrating.Text = "";
            pn_songrating.Visible = false;
            clb_ratesong.Visible = false;
            bt_ratesong.Visible = false;
            bt_searchsongrat.Visible = false;
        }

        private void bt_ratsong_Click(object sender, EventArgs e)
        {
            pn_songrating.Visible = true;
            bt_searchsongrat.Visible = true;
            bt_ratesong.Visible = false;
        }

        private void bt_calisong_Click(object sender, EventArgs e)
        {
            pn_songrating.Visible = true;
            clb_ratesong.Visible = true;
            bt_ratesong.Visible = true;
            bt_searchsongrat.Visible = false;
        }
    }
    
}
