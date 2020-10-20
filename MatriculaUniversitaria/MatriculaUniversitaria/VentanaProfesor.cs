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
    public partial class VentanaProfesor : Form
    {
        public VentanaProfesor()
        {
            InitializeComponent();
        }

        private void btncerrarsesionadmin_Click(object sender, EventArgs e)
        {
            ventanaLogin ventanal = new ventanaLogin();
            ventanal.Show(this);
            this.Hide();
        }
    }
}
