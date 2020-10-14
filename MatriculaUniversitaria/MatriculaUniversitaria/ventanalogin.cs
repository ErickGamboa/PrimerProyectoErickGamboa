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
        public List<EAdmin> loginA;

        public ventanaLogin()
        {
            InitializeComponent();
            login = new LLogin();
            loginA = new List<EAdmin>();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginA = login.cargarDatos();
            lblError.Text = loginA[1].usuario;
        }

        private void ventanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
