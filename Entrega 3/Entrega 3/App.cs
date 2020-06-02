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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
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
    }
}
