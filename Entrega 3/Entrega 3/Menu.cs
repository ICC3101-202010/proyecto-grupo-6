using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_3
{
    public partial class Menu : Form
    {
        App app = new App();
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



        private string routesong = "";
        private string routevideo = "";
        private void bt_downloadsong_Click(object sender, EventArgs e)
        {
            if (openFilesong.ShowDialog() == DialogResult.OK)
            {
                routesong = openFilesong.FileName;
            }
        }
        private void bt_playsong_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayersong.URL = routesong;
            axWindowsMediaPlayersong.Ctlcontrols.play();
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
            axWindowsMediaPlayervideo.URL = routevideo;
            axWindowsMediaPlayervideo.Ctlcontrols.play();
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
            if (tb_nombrevideo.Text == "" || tb_generovideo.Text == "" || tb_direcvideo.Text == "" || tb_canalvideo.Text == "" || tb_sexodirecvideo.Text == "" || tb_edaddirect.Text == "")
            {
                lb_datavideo.Visible = true;
            }
            else
            {
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
        }

        private void bt_pnpremiosback_Click(object sender, EventArgs e)
        {
            lb_premios.Visible = false;
            pn_premios.Visible = false;
            rtb_premios.Text = "";
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
        }

        private void bt_calisong_Click(object sender, EventArgs e)
        {
            pn_songrating.Visible = true;
            clb_ratesong.Visible = true;
            bt_ratesong.Visible = true;
        }
    }
}
