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
                VentanaAdmin admin = new VentanaAdmin(this.admin.id);
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

        private void lblRegistrase_Click(object sender, EventArgs e)
        {
            VentanaRegistrarse reg = new VentanaRegistrarse();
            reg.Show(this);
            this.Hide();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();
            per = login.LoginPersona(txtUsuario.Text, txtContra.Text);
            if (per != null)
            {
                if (per.tipoPersona == "Estudiante")
                {
                    VentanaEstudiante estudiante = new VentanaEstudiante();
                    estudiante.Show(this);
                    this.Hide();
                }
                else
                {
                    VentanaProfesor profe = new VentanaProfesor();
                    profe.Show(this);
                    this.Hide();
                }
                
            }
            else
            {
                lblError.Text = "No existe un usuario con esas credenciales.";
            }
        }
    }
}
