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
        public LCarrera L_carrera;
        public List<Persona> listaTotalDePersonas;
        string id;
        public VentanaAdmin()
        {
            InitializeComponent();
            this.L_persona = new LPersona();
            this.L_carrera = new LCarrera();
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
            L_persona.RegistrarPersona(persona);
            lblprueba.Text = "Se ha guardado la persona exitosamente.";
            CargarTablaPersonas();
            LimpiarDatosPersona();

        }
        public void LimpiarDatosPersona()
        {
            txtCed.Text = "";
            txtNom.Text = "";
            txtApellidoUno.Text = "";
            txtApellidoDos.Text = "";
        }
        public void LimpiarDatosCarrera()
        {
            txtnombrec.Text = "";
            txtcreditos.Text = "";

        }

        public void CargarTablaPersonas()
        {
            LPersona lista_personas = new LPersona();
            dgvPersonas.DataSource = lista_personas.CargarPersonas();
        }
        public void CargarTablaCarreras()
        {
            LCarrera lista_carreras = new LCarrera();
            dgvcarrera.DataSource = lista_carreras.CargarCarreras();
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
            CargarTablaPersonas();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxnacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btneliminarmaterias_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            int row = dgvPersonas.SelectedRows.Count > 0 ? dgvPersonas.SelectedRows[0].Index : -1;
                
                if (row >= 0)
                {
                    persona = dgvPersonas.CurrentRow.DataBoundItem as Persona;
                    
                    if(L_persona.EliminarPersona(persona))
                    {
                        lblprueba.Text = "Se elimino la persona correctamente";
                        CargarTablaPersonas();
                    }
                    else{
                        lblprueba.Text = "No se pudo eliminar la persona correctamente";
                    }
                }
                else
                {
                    lblprueba.Text = "No se pudo eliminar la persona correctamente";
                }
            }

        private void btneditarpersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            int row = dgvPersonas.SelectedRows.Count > 0 ? dgvPersonas.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                persona = dgvPersonas.CurrentRow.DataBoundItem as Persona;
                CargarDatosPersona(persona);
            }
        }

        private void CargarDatosPersona(Persona persona)
        {
            id = persona.idpersona;
            txtCed.Text = persona.cedula;
            txtNom.Text = persona.nombre;
            txtApellidoUno.Text = persona.apellido1;
            txtApellidoDos.Text = persona.apellido2;
            cbxSexo.Text =  persona.sexo;
            cbxnacimiento.Value = persona.fechaNacimiento;
            cbxAcademico.Text = persona.nivelAcademico;
            cbxingreso.Value = persona.fechaIngreso;
            cbxtipo.Text = persona.tipoPersona;
            cbxnacionalidad.Text = persona.nacionalidad;
            cbxestado.Text = persona.estado;
            lblprueba.Text = "Se ha Editado la persona exitosamente.";
            CargarTablaPersonas();
        }
        private void CargarDatosCarrera (Carrera carrera)
        {
            id = carrera.idcarrera;
            txtnombrec.Text = carrera.nombreCarrera;
            txtcreditos.Text = carrera.creditosCarrera;
            cbxestadoc.Text = carrera.estado;
            dtpfechaapertura.Value = carrera.fechaApertura;
            dtpfechacierre.Value = carrera.fechaCierre;
            lblmensajecarrera.Text = "Se ha Editado la carrera exitosamente.";
            CargarTablaCarreras();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.idpersona = id;
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
            L_persona.EditarPersona(persona);
            CargarTablaPersonas();
            LimpiarDatosPersona();
        }

        private void btncargarlista_Click(object sender, EventArgs e)
        {
            CargarTablaCarreras();
        }

        private void btnguardarcarrera_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera();
            carrera.idcarrera = DateTime.Now.Millisecond.ToString() + DateTime.Now.Month.ToString();
            carrera.nombreCarrera = txtnombrec.Text;
            carrera.creditosCarrera = txtcreditos.Text;
            carrera.estado = cbxestadoc.Text;
            carrera.fechaApertura = Convert.ToDateTime(dtpfechaapertura.Text);
            carrera.fechaCierre = Convert.ToDateTime(dtpfechacierre.Text);
            L_carrera.RegistrarCarrera(carrera);
            lblprueba.Text = "Se ha guardado la persona exitosamente.";
            CargarTablaCarreras();
            LimpiarDatosCarrera();



        }

        private void btneliminarlista_Click(object sender, EventArgs e)
        {
            {
                Carrera carrera = new Carrera();
                int row = dgvcarrera.SelectedRows.Count > 0 ? dgvcarrera.SelectedRows[0].Index : -1;

                if (row >= 0)
                {
                    carrera = dgvcarrera.CurrentRow.DataBoundItem as Carrera;

                    if (L_carrera.EliminarCarrera(carrera))
                    {
                        lblmensajecarrera.Text = "Se elimino la carrera correctamente";
                        CargarTablaCarreras();
                    }
                    else
                    {
                        lblmensajecarrera.Text = "No se pudo eliminar la carrera correctamente";
                    }
                }
                else
                {
                    lblmensajecarrera.Text = "No se pudo eliminar la  correctamente";
                }
            }
        }

        private void btnseleccionarca_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera();
            int row = dgvcarrera.SelectedRows.Count > 0 ? dgvcarrera.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                carrera = dgvcarrera.CurrentRow.DataBoundItem as Carrera;
                CargarDatosCarrera(carrera);
            }
        }

        private void btnEditarCa_Click(object sender, EventArgs e)
        {
            Carrera carrera = new Carrera();
            carrera.idcarrera = id;
            carrera.nombreCarrera = txtnombrec.Text;
            carrera.creditosCarrera = txtcreditos.Text;
            carrera.estado = cbxestadoc.Text;
            carrera.fechaApertura = Convert.ToDateTime(dtpfechaapertura.Text);
            carrera.fechaCierre = Convert.ToDateTime(dtpfechacierre.Text);
            L_carrera.EditarCarrera(carrera);
            CargarTablaCarreras();
            LimpiarDatosCarrera();
        }
    }
}
