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
    public partial class VentanaAdmin : Form
    {
        public LPersona L_persona;
        public List<Persona> listaTotalDePersonas;
        public VentanaAdmin()
        {
            this.L_persona = new LPersona();
            InitializeComponent();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.idpersona = DateTime.Now.Millisecond.ToString() + DateTime.Now.Month.ToString();
            persona.cedula = txtCed.Text;
            persona.nombre = txtNom.Text;
            persona.apellido1 = txtApellidoUno.Text;
            persona.apellido2 = txtApellidoDos.Text;
            persona.sexo = cbxSexo.Text;
            persona.fechaNacimiento = Convert.ToDateTime(cbxnacimiento.Text);
            persona.nivelAcademico = cbxAcademico.Text;
            persona.fechaIngreso = Convert.ToDateTime(cbxingreso.Text);
            persona.tipoPersona = cbxtipo.Text;
            persona.nacionalidad = cbxnacionalidad.Text;
            persona.estado = cbxestado.Text;
            L_persona.Registrar(persona);
            lblprueba.Text =persona.nombre+persona.apellido1+persona.apellido2;

        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = L_persona.CargarPersonas();
        }
    }
}
