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
            panel1.Visible =true;

            App app = new App();
            app.OpenApp();
            string username = Convert.ToString(tb_Usuario.Text);
            string password = Convert.ToString(tb_Contraseña.Text);
            List<User> allUser = app.GetServer().GetUsers();

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
            cb_cuentapremium.Checked = false;
            label3.Visible = false;
        }

       

        private void tb_inName_Click(object sender, EventArgs e)
        {
            tb_inName.Text = "";
        }

      
        private void tb_inLastName_Click(object sender, EventArgs e)
        {
            tb_inLastName.Text = "";
        }

        private void tb_inUsername_Click(object sender, EventArgs e)
        {
            tb_inUsername.Text = "";
        }

        private void tb_inContraseña_Click(object sender, EventArgs e)
        {
            tb_inContraseña.Text = "";
        }

        private void listb_tipodecuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void bt_crearcuenta_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.OpenApp();
            
            

            if (tb_inLastName.Text == "" || tb_inName.Text == ""|| tb_inUsername.Text == ""|| tb_inContraseña.Text == "" || tb_inName.Text == "Nombre" || tb_inLastName.Text == "Apellido" || tb_inContraseña.Text == "Contraseña" || tb_inUsername.Text == "Nombre de Usuario"  )
           
            {
                lb_rellenecampos.Visible = true;
                
            }
            
            else
            {
                
                lb_rellenecampos.Visible = false;
                User user = new User(tb_inName.Text, tb_inLastName.Text, tb_inUsername.Text, tb_inContraseña.Text, cb_cuentapremium.Checked);
                bool checkreg=app.Register(user);
                if (checkreg)
                {
                    lb_exito.Visible = true;
                    label3.Visible = false;
                }
                else
                {
                    label3.Visible = true;
                    lb_exito.Visible = false;
                }
                
                tb_inName.Text = "Nombre";
                tb_inContraseña.Text = "Contraseña";
                tb_inUsername.Text = "Nombre de Usuario";
                tb_inLastName.Text = "Apellido";
                cb_cuentapremium.Checked = false;
                lb_rellenecampos.Visible = false;
                
                app.CloseApp();




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
            app.OpenApp();
            string username = Convert.ToString(tb_Usuario.Text);
            string password = Convert.ToString(tb_Contraseña.Text);
            List<User> allUser = app.GetServer().GetUsers();
            bool checklogin = false;

            for (int i = 0; i < allUser.Count(); i++)
            {
                if (username == allUser[i].GetUsername())//allUser[i].GetUsername()
                {
                   
                    User user = allUser[i];
                   ;

                    if (password == user.GetPassword())//user.GetPassword()
                    {
                        
                        checklogin = true;
                        app.GetServer().SetActive(allUser[i]);
                        break;
                    }
                }
            }
            if (checklogin==true)
            {
                app.CloseApp();
                lb_cuincorrecto.Visible = false;
                Menu menu = new Menu();
                menu.Show();
                PSN psn = new PSN();
                psn.Hide();
                tb_Usuario.Text = "";
                tb_Contraseña.Text = "";

                    
            }
            else
            {
                app.CloseApp();
                lb_cuincorrecto.Visible = true;
                
            }
            


        }

        private void tb_Usuario_Click(object sender, EventArgs e)
        {
            tb_Usuario.Clear();
        }

        private void tb_Contraseña_Click(object sender, EventArgs e)
        {
            tb_Contraseña.Clear();
        }

        private void pn_verquesucede_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_inUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_inLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
