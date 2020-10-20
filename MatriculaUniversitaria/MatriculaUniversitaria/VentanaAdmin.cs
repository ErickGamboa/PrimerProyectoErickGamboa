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
        public LMateria L_materia;
        public List<Persona> listaTotalDePersonas;
        string id;
        public string admin_id;
        public VentanaAdmin(string id_admin)
        {
            InitializeComponent();
            this.L_persona = new LPersona();
            this.L_carrera = new LCarrera();
            this.L_materia = new LMateria();
            admin_id = id_admin;
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
            persona.usuarioRegistra = admin_id;
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
        /*
         metodo encargado de limpiar lo espacios de texto de la ventana persona
             */
        public void LimpiarDatosPersona()
        {
            txtCed.Text = "";
            txtNom.Text = "";
            txtApellidoUno.Text = "";
            txtApellidoDos.Text = "";
        }
        /*
        metodo encargado de limpiar lo espacios de texto de la ventana carrera
            */
        public void LimpiarDatosCarrera()
        {
            txtnombrec.Text = "";
            txtcreditos.Text = "";

        }
        /*
        metodo encargado de limpiar lo espacios de texto de la ventana materia
            */
        public void LimpiarDatosMateria()
        {
            txtnombremateria.Text = "";
            txtcreditosmateria.Text = "";
            txtidcarreramateria.Text = "";
            txtprecio.Text = "";
            txtcosto.Text = "";

        }

        /*Metodo encargado de cargar la tabla de personas por medio del data grid view
            */
        public void CargarTablaPersonas()
        {
            LPersona lista_personas = new LPersona();
            dgvPersonas.DataSource = lista_personas.CargarPersonas();
        }

        /*Metodo encargado de cargar la tabla de carreras por medio del data grid view
    */
        public void CargarTablaCarreras()
        {
            LCarrera lista_carreras = new LCarrera();
            dgvcarrera.DataSource = lista_carreras.CargarCarreras();
        }

        /*Metodo encargado de cargar la tabla de materias por medio del data grid view
    */
        public void CargarTablaMaterias()
        {
            LMateria lista_materias = new LMateria();
            dgvmaterias.DataSource = lista_materias.CargarMaterias();
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
            Materia materia = new Materia();
            int row = dgvmaterias.SelectedRows.Count > 0 ? dgvmaterias.SelectedRows[0].Index : -1;

            if (row >= 0)
            {
                materia = dgvmaterias.CurrentRow.DataBoundItem as Materia;

                if (L_materia.EliminarMateria(materia))
                {
                    lblmensajemateria.Text = "Se eliminó la materia correctamente";
                    CargarTablaMaterias();
                }
                else
                {
                    lblmensajemateria.Text = "No se pudo eliminar la materia correctamente";
                }
            }
            else
            {
                lblmensajecarrera.Text = "No se pudo eliminar la materia correctamente";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            int row = dgvPersonas.SelectedRows.Count > 0 ? dgvPersonas.SelectedRows[0].Index : -1;

            if (row >= 0)
            {
                persona = dgvPersonas.CurrentRow.DataBoundItem as Persona;

                if (L_persona.EliminarPersona(persona))
                {
                    lblprueba.Text = "Se eliminó la persona correctamente";
                    CargarTablaPersonas();
                }
                else
                {
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

        /*
         Metodo para cargar los datos de la persona seleccionada en el espacio de texto
             */
        private void CargarDatosPersona(Persona persona)
        {
            id = persona.idpersona;
            txtCed.Text = persona.cedula;
            txtNom.Text = persona.nombre;
            txtApellidoUno.Text = persona.apellido1;
            txtApellidoDos.Text = persona.apellido2;
            cbxSexo.Text = persona.sexo;
            cbxnacimiento.Value = persona.fechaNacimiento;
            cbxAcademico.Text = persona.nivelAcademico;
            cbxingreso.Value = persona.fechaIngreso;
            cbxtipo.Text = persona.tipoPersona;
            cbxnacionalidad.Text = persona.nacionalidad;
            cbxestado.Text = persona.estado;
            lblprueba.Text = "Se ha Editado la persona exitosamente.";
            CargarTablaPersonas();
        }

        /*
         Metodo para cargar los datos de la carrera seleccionada en el espacio de texto
             */
        private void CargarDatosCarrera(Carrera carrera)
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

        /*
         Metodo para cargar los datos de la materia seleccionada en el espacio de texto
             */
        private void CargarDatosMateria(Materia materia)
        {
            id = materia.idMateria;
            txtnombremateria.Text = materia.nombreMateria;
            txtcreditosmateria.Text = materia.creditosMateria;
            txtidcarreramateria.Text = materia.idCarreraMateria;
            txtprecio.Text = materia.precioMateria;
            txtcosto.Text = materia.costoMateria;
            CargarTablaMaterias();
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
            lblmensajecarrera.Text = "Se ha guardado la persona exitosamente.";
            CargarTablaCarreras();
            LimpiarDatosCarrera();



        }

        private void btneliminarlista_Click(object sender, EventArgs e)
        {

            Carrera carrera = new Carrera();
            int row = dgvcarrera.SelectedRows.Count > 0 ? dgvcarrera.SelectedRows[0].Index : -1;

            if (row >= 0)
            {
                carrera = dgvcarrera.CurrentRow.DataBoundItem as Carrera;

                if (L_carrera.EliminarCarrera(carrera))
                {
                    lblmensajecarrera.Text = "Se eliminó la carrera correctamente";
                    CargarTablaCarreras();
                }
                else
                {
                    lblmensajecarrera.Text = "No se pudo eliminar la carrera correctamente";
                }
            }
            else
            {
                lblmensajecarrera.Text = "No se pudo eliminar la carrera correctamente";
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

        private void btnguardarCa_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            materia.idMateria = DateTime.Now.Millisecond.ToString() + DateTime.Now.Month.ToString();
            materia.nombreMateria = txtnombremateria.Text;
            materia.creditosMateria = txtcreditosmateria.Text;
            materia.idCarreraMateria = txtidcarreramateria.Text;
            materia.precioMateria = txtprecio.Text;
            materia.costoMateria = txtcosto.Text;
            L_materia.RegistrarMateria(materia);
            lblprueba.Text = "Se ha guardado la persona exitosamente.";
            CargarTablaMaterias();
            LimpiarDatosMateria();
        }

        private void btnselecionarmaterias_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            int row = dgvmaterias.SelectedRows.Count > 0 ? dgvmaterias.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                materia = dgvmaterias.CurrentRow.DataBoundItem as Materia;
                CargarDatosMateria(materia);
            }
        }

        private void btncargarmaterias_Click(object sender, EventArgs e)
        {
            CargarTablaMaterias();
        }

        private void btneditarmateria_Click(object sender, EventArgs e)
        {
            {
                Materia materia = new Materia();
                materia.idMateria = id;
                materia.nombreMateria = txtnombremateria.Text;
                materia.creditosMateria = txtcreditosmateria.Text;
                materia.idCarreraMateria = txtidcarreramateria.Text;
                materia.precioMateria = txtprecio.Text;
                materia.costoMateria = txtcosto.Text;
                L_materia.EditarMateria(materia);
                CargarTablaMaterias();
                LimpiarDatosMateria();
            }
        }

        private void btncerrarsesionadmin_Click(object sender, EventArgs e)
        {
            ventanaLogin ventanal = new ventanaLogin();
            ventanal.Show(this);
            this.Hide();



        }
    }
}
