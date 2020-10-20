using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaUniversitaria
{
    public partial class VentanaRegistrarse : Form
    {
        public VentanaRegistrarse()
        {
            InitializeComponent();
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
    }
}
