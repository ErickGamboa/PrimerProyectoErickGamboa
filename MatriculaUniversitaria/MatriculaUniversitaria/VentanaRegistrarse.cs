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
            lblMensaje.Text = "";
            Persona persona = registrarUsu.VerificarRegistro(txtCed.Text);
            if (persona != null)
            {
                VistaConUsuario();
                if (txtContra.Text.Equals(txtReContra.Text))
                {
                    EUsuario usu = new EUsuario();
                    char nombre = persona.nombre.ToCharArray()[0];
                    char apellido1 = persona.apellido1.ToCharArray()[0];
                    char apellido2 = persona.apellido2.ToCharArray()[0];
                    usu.idntificadorUsuario = DateTime.Now.Millisecond.ToString() + DateTime.Now.Month.ToString();
                    usu.codigo = Convert.ToString(nombre).ToUpper() + Convert.ToString(apellido1).ToUpper()
                                 + Convert.ToString(apellido2).ToUpper();
                    usu.idPersona = persona.idpersona;
                    usu.contrasenna = txtContra.Text;
                    int siguienteAnno = DateTime.Now.Year + 1;
                    string date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + siguienteAnno + " 00:00:00";
                    usu.fechaExpiraContra = Convert.ToDateTime(date);
                    usu.estado = "Activo";
                    if (registrarUsu.RegistrarUsuario(usu))
                    {
                        lblMensaje.Text = "Usuario registrado con éxito";
                    }
                    else
                    {
                        lblMensaje.Text = "No se ha podido registrar el usuario";
                    }
                }
                else
                {
                    lblMensaje.Text = "Las contraseñas no coinciden";
                }

            }
            else
            {
                VistaInicial();
                lblMensaje.Text = "No existe un registro previo del usuario";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VentanaRegistrarse_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Persona persona = registrarUsu.VerificarRegistro(txtCed.Text);
            if (persona != null)
            {
                VistaConUsuario();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaLogin log = new ventanaLogin();
            log.Show(this);
            this.Hide();
        }
    }
}
