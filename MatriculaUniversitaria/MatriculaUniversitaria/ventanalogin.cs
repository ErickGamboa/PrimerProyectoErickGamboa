using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

namespace MatriculaUniversitaria
{
    public partial class ventanaLogin : Form
    {
        public LLogin login;
        public EAdmin admin;

        public ventanaLogin()
        {
            InitializeComponent();
            login = new LLogin();
            admin = new EAdmin();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.admin = login.Login(txtUsuario.Text, txtContra.Text);
            if( this.admin != null)
            {
                VentanaAdmin admin = new VentanaAdmin();
                admin.Show(this);
                this.Hide();
            }
            else
            {
                lblError.Text = "No existe un usuario con esas credenciales.";
            }

        }

        private void ventanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
