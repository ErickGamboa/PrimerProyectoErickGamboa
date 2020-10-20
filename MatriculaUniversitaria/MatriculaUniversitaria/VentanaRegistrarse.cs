using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;

namespace MatriculaUniversitaria
{
    public partial class VentanaRegistrarse : Form
    {
        public LRegistrarUsuario registrarUsu;
        public VentanaRegistrarse()
        {
            InitializeComponent();
            VistaInicial();
            registrarUsu = new LRegistrarUsuario();
        }

        private void VistaInicial()
        {
            lblContra.Visible = false;
            lblReContra.Visible = false;
            txtContra.Visible = false;
            txtReContra.Visible = false;
            btnRegistro.Visible = false;
        }

        private void btnsiguienteregistro_Click(object sender, EventArgs e)
        {
            ventanaLogin log = new ventanaLogin();
            log.Show(this);
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VentanaRegistrarse_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Persona persona = registrarUsu.Registrar(txtCed.Text);
            if (persona != null)
            {
                VistaConUsuario();
                EUsuario usu = new EUsuario();

                
            }
            else
            {
                VistaInicial();
                lblMensaje.Text = "No existe un registro previo del usuario";
            }
        }

        private void VistaConUsuario()
        {
            lblContra.Visible = true;
            lblReContra.Visible = true;
            txtContra.Visible = true;
            txtReContra.Visible = true;
            btnRegistro.Visible = true;
        }
    }
}
