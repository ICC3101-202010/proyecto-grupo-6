namespace Entrega_3
{
    partial class PSN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_register = new System.Windows.Forms.Panel();
            this.bt_closeregistro = new System.Windows.Forms.PictureBox();
            this.lb_exito = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_crearcuenta = new System.Windows.Forms.Button();
            this.bt_backresgister = new System.Windows.Forms.Button();
            this.lb_rellenecampos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_inContraseña = new System.Windows.Forms.TextBox();
            this.tb_inUsername = new System.Windows.Forms.TextBox();
            this.tb_inLastName = new System.Windows.Forms.TextBox();
            this.tb_inName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_register = new System.Windows.Forms.Label();
            this.lb_cuincorrecto = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.tb_Contraseña = new System.Windows.Forms.TextBox();
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_color_nohacenada = new System.Windows.Forms.Panel();
            this.bt_closeall = new System.Windows.Forms.PictureBox();
            this.UserLogin = new System.Windows.Forms.Label();
            this.cb_cuentapremium = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.pn_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_closeregistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_color_nohacenada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_closeall)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.pn_register);
            this.panel1.Controls.Add(this.lb_register);
            this.panel1.Controls.Add(this.lb_cuincorrecto);
            this.panel1.Controls.Add(this.bt_login);
            this.panel1.Controls.Add(this.tb_Contraseña);
            this.panel1.Controls.Add(this.tb_Usuario);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pn_color_nohacenada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 450);
            this.panel1.TabIndex = 0;
            // 
            // pn_register
            // 
            this.pn_register.Controls.Add(this.cb_cuentapremium);
            this.pn_register.Controls.Add(this.bt_closeregistro);
            this.pn_register.Controls.Add(this.lb_exito);
            this.pn_register.Controls.Add(this.label3);
            this.pn_register.Controls.Add(this.bt_crearcuenta);
            this.pn_register.Controls.Add(this.bt_backresgister);
            this.pn_register.Controls.Add(this.lb_rellenecampos);
            this.pn_register.Controls.Add(this.label2);
            this.pn_register.Controls.Add(this.tb_inContraseña);
            this.pn_register.Controls.Add(this.tb_inUsername);
            this.pn_register.Controls.Add(this.tb_inLastName);
            this.pn_register.Controls.Add(this.tb_inName);
            this.pn_register.Controls.Add(this.label1);
            this.pn_register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_register.Location = new System.Drawing.Point(0, 0);
            this.pn_register.Name = "pn_register";
            this.pn_register.Size = new System.Drawing.Size(554, 450);
            this.pn_register.TabIndex = 8;
            this.pn_register.Visible = false;
            // 
            // bt_closeregistro
            // 
            this.bt_closeregistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bt_closeregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_closeregistro.ImageLocation = "http://icons.iconarchive.com/icons/icojam/blue-bits/24/symbol-delete-icon.png";
            this.bt_closeregistro.Location = new System.Drawing.Point(526, 3);
            this.bt_closeregistro.Name = "bt_closeregistro";
            this.bt_closeregistro.Size = new System.Drawing.Size(25, 25);
            this.bt_closeregistro.TabIndex = 12;
            this.bt_closeregistro.TabStop = false;
            this.bt_closeregistro.Click += new System.EventHandler(this.bt_closeregistro_Click);
            // 
            // lb_exito
            // 
            this.lb_exito.AutoSize = true;
            this.lb_exito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exito.ForeColor = System.Drawing.Color.White;
            this.lb_exito.Location = new System.Drawing.Point(144, 428);
            this.lb_exito.Name = "lb_exito";
            this.lb_exito.Size = new System.Drawing.Size(243, 18);
            this.lb_exito.TabIndex = 11;
            this.lb_exito.Text = "CUENTA CREADA CON EXITO";
            this.lb_exito.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "NOMBRE DE USUARIO YA EXISTENTE";
            this.label3.Visible = false;
            // 
            // bt_crearcuenta
            // 
            this.bt_crearcuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_crearcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_crearcuenta.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.bt_crearcuenta.Location = new System.Drawing.Point(367, 375);
            this.bt_crearcuenta.Name = "bt_crearcuenta";
            this.bt_crearcuenta.Size = new System.Drawing.Size(88, 34);
            this.bt_crearcuenta.TabIndex = 9;
            this.bt_crearcuenta.Text = "CREAR";
            this.bt_crearcuenta.UseVisualStyleBackColor = true;
            this.bt_crearcuenta.Click += new System.EventHandler(this.bt_crearcuenta_Click);
            // 
            // bt_backresgister
            // 
            this.bt_backresgister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_backresgister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_backresgister.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.bt_backresgister.Location = new System.Drawing.Point(77, 376);
            this.bt_backresgister.Name = "bt_backresgister";
            this.bt_backresgister.Size = new System.Drawing.Size(88, 33);
            this.bt_backresgister.TabIndex = 8;
            this.bt_backresgister.Text = "BACK";
            this.bt_backresgister.UseVisualStyleBackColor = true;
            this.bt_backresgister.Click += new System.EventHandler(this.bt_backresgister_Click);
            // 
            // lb_rellenecampos
            // 
            this.lb_rellenecampos.AutoSize = true;
            this.lb_rellenecampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_rellenecampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rellenecampos.ForeColor = System.Drawing.Color.White;
            this.lb_rellenecampos.Location = new System.Drawing.Point(74, 413);
            this.lb_rellenecampos.Name = "lb_rellenecampos";
            this.lb_rellenecampos.Size = new System.Drawing.Size(383, 15);
            this.lb_rellenecampos.TabIndex = 7;
            this.lb_rellenecampos.Text = "PORFAVOR RELLENE TODOS LOS CAMPOS SOLICITADOS";
            this.lb_rellenecampos.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(69, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "QUIERE SER USUARIO PREMIUM";
            // 
            // tb_inContraseña
            // 
            this.tb_inContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_inContraseña.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_inContraseña.Location = new System.Drawing.Point(73, 222);
            this.tb_inContraseña.Multiline = true;
            this.tb_inContraseña.Name = "tb_inContraseña";
            this.tb_inContraseña.Size = new System.Drawing.Size(398, 42);
            this.tb_inContraseña.TabIndex = 4;
            this.tb_inContraseña.Text = "Contraseña";
            this.tb_inContraseña.Click += new System.EventHandler(this.tb_inContraseña_Click);
            // 
            // tb_inUsername
            // 
            this.tb_inUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_inUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_inUsername.Location = new System.Drawing.Point(73, 157);
            this.tb_inUsername.Multiline = true;
            this.tb_inUsername.Name = "tb_inUsername";
            this.tb_inUsername.Size = new System.Drawing.Size(398, 42);
            this.tb_inUsername.TabIndex = 3;
            this.tb_inUsername.Text = "Nombre de Usuario";
            this.tb_inUsername.Click += new System.EventHandler(this.tb_inUsername_Click);
            // 
            // tb_inLastName
            // 
            this.tb_inLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_inLastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_inLastName.Location = new System.Drawing.Point(281, 93);
            this.tb_inLastName.Multiline = true;
            this.tb_inLastName.Name = "tb_inLastName";
            this.tb_inLastName.Size = new System.Drawing.Size(190, 42);
            this.tb_inLastName.TabIndex = 2;
            this.tb_inLastName.Text = "Apellido";
            this.tb_inLastName.Click += new System.EventHandler(this.tb_inLastName_Click);
            // 
            // tb_inName
            // 
            this.tb_inName.BackColor = System.Drawing.Color.White;
            this.tb_inName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_inName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_inName.Location = new System.Drawing.Point(73, 93);
            this.tb_inName.Multiline = true;
            this.tb_inName.Name = "tb_inName";
            this.tb_inName.Size = new System.Drawing.Size(190, 42);
            this.tb_inName.TabIndex = 1;
            this.tb_inName.Text = "Nombre";
            this.tb_inName.Click += new System.EventHandler(this.tb_inName_Click);
            this.tb_inName.TextChanged += new System.EventHandler(this.tb_inName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(172, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO";
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = true;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_register.ForeColor = System.Drawing.Color.White;
            this.lb_register.Location = new System.Drawing.Point(184, 397);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(187, 15);
            this.lb_register.TabIndex = 7;
            this.lb_register.Text = "NUEVO AQUI? REGISTRATE";
            this.lb_register.Click += new System.EventHandler(this.lb_register_Click);
            // 
            // lb_cuincorrecto
            // 
            this.lb_cuincorrecto.AutoSize = true;
            this.lb_cuincorrecto.ForeColor = System.Drawing.Color.White;
            this.lb_cuincorrecto.Location = new System.Drawing.Point(169, 428);
            this.lb_cuincorrecto.Name = "lb_cuincorrecto";
            this.lb_cuincorrecto.Size = new System.Drawing.Size(218, 13);
            this.lb_cuincorrecto.TabIndex = 6;
            this.lb_cuincorrecto.Text = "CONTRASEÑA O USUARIO INCORRECTO";
            this.lb_cuincorrecto.Visible = false;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_login.Location = new System.Drawing.Point(77, 330);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(406, 50);
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "LOGIN";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tb_Contraseña
            // 
            this.tb_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contraseña.Location = new System.Drawing.Point(133, 259);
            this.tb_Contraseña.Name = "tb_Contraseña";
            this.tb_Contraseña.Size = new System.Drawing.Size(350, 44);
            this.tb_Contraseña.TabIndex = 4;
            this.tb_Contraseña.UseSystemPasswordChar = true;
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Usuario.Location = new System.Drawing.Point(133, 181);
            this.tb_Usuario.Multiline = true;
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(350, 50);
            this.tb_Usuario.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "http://icons.iconarchive.com/icons/graphicloads/flat-finance/48/lock-icon.png";
            this.pictureBox2.Location = new System.Drawing.Point(77, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "http://icons.iconarchive.com/icons/graphicloads/flat-finance/48/person-icon.png";
            this.pictureBox1.Location = new System.Drawing.Point(77, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pn_color_nohacenada
            // 
            this.pn_color_nohacenada.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pn_color_nohacenada.Controls.Add(this.bt_closeall);
            this.pn_color_nohacenada.Controls.Add(this.UserLogin);
            this.pn_color_nohacenada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_color_nohacenada.Location = new System.Drawing.Point(0, 0);
            this.pn_color_nohacenada.Name = "pn_color_nohacenada";
            this.pn_color_nohacenada.Size = new System.Drawing.Size(554, 111);
            this.pn_color_nohacenada.TabIndex = 0;
            // 
            // bt_closeall
            // 
            this.bt_closeall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bt_closeall.ImageLocation = "http://icons.iconarchive.com/icons/icojam/blue-bits/24/symbol-delete-icon.png";
            this.bt_closeall.Location = new System.Drawing.Point(526, 3);
            this.bt_closeall.Name = "bt_closeall";
            this.bt_closeall.Size = new System.Drawing.Size(25, 25);
            this.bt_closeall.TabIndex = 1;
            this.bt_closeall.TabStop = false;
            this.bt_closeall.Click += new System.EventHandler(this.bt_closeall_Click);
            // 
            // UserLogin
            // 
            this.UserLogin.AutoSize = true;
            this.UserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogin.Location = new System.Drawing.Point(107, 32);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(348, 42);
            this.UserLogin.TabIndex = 0;
            this.UserLogin.Text = "USER LOGIN PSN";
            this.UserLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_cuentapremium
            // 
            this.cb_cuentapremium.AutoSize = true;
            this.cb_cuentapremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cuentapremium.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.cb_cuentapremium.Location = new System.Drawing.Point(77, 315);
            this.cb_cuentapremium.Name = "cb_cuentapremium";
            this.cb_cuentapremium.Size = new System.Drawing.Size(97, 20);
            this.cb_cuentapremium.TabIndex = 14;
            this.cb_cuentapremium.Text = "PREMIUM";
            this.cb_cuentapremium.UseVisualStyleBackColor = true;
            // 
            // PSN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PSN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_register.ResumeLayout(false);
            this.pn_register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_closeregistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_color_nohacenada.ResumeLayout(false);
            this.pn_color_nohacenada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_closeall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_color_nohacenada;
        private System.Windows.Forms.Label UserLogin;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tb_Contraseña;
        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_register;
        private System.Windows.Forms.Label lb_cuincorrecto;
        private System.Windows.Forms.Panel pn_register;
        private System.Windows.Forms.TextBox tb_inContraseña;
        private System.Windows.Forms.TextBox tb_inUsername;
        private System.Windows.Forms.TextBox tb_inLastName;
        private System.Windows.Forms.TextBox tb_inName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_crearcuenta;
        private System.Windows.Forms.Button bt_backresgister;
        private System.Windows.Forms.Label lb_rellenecampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_exito;
        private System.Windows.Forms.PictureBox bt_closeall;
        private System.Windows.Forms.PictureBox bt_closeregistro;
        private System.Windows.Forms.CheckBox cb_cuentapremium;
    }
}

