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
    public partial class PSN : Form
    {
        public PSN()
        {
            InitializeComponent();
            this.tb_Contraseña.AutoSize = false;
            this.tb_Contraseña.Size = new Size(this.tb_Contraseña.Size.Width, 50);
        }

       
        private void lb_register_Click(object sender, EventArgs e)
        {
            pn_register.Visible = true;
        }

        private void bt_backresgister_Click(object sender, EventArgs e)
        {
            pn_register.Visible = false;
            tb_inName.Text = "Nombre";
            tb_inContraseña.Text = "Contraseña";
            tb_inUsername.Text = "Nombre de Usuario";
            tb_inLastName.Text = "Apellido";
            lb_exito.Visible = false;
            lb_rellenecampos.Visible = false;
        }

        private void tb_inName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_inName_Click(object sender, EventArgs e)
        {
            tb_inName.Text = " ";
        }

      
        private void tb_inLastName_Click(object sender, EventArgs e)
        {
            tb_inLastName.Text = " ";
        }

        private void tb_inUsername_Click(object sender, EventArgs e)
        {
            tb_inUsername.Text = " ";
        }

        private void tb_inContraseña_Click(object sender, EventArgs e)
        {
            tb_inContraseña.Text = " ";
        }

        private void listb_tipodecuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_crearcuenta_Click(object sender, EventArgs e)
        {
            if (tb_inLastName.Text == " " || tb_inName.Text == " "|| tb_inUsername.Text == " "|| tb_inContraseña.Text == " " || tb_inName.Text == "Nombre" || tb_inLastName.Text == "Apellido" || tb_inContraseña.Text == "Contraseña" || tb_inUsername.Text == "Nombre de Usuario"  )
           
            {
                lb_rellenecampos.Visible = true;
                
            }
            
            else
            {
                lb_exito.Visible = true;
                lb_rellenecampos.Visible = false;
                App app = new App();
                app.Show();
                PSN psn = new PSN();
                psn.Hide();
            }
           
        }

        private void bt_closeall_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_closeregistro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            PSN psn = new PSN();
            psn.Hide();
        }
    }
}
