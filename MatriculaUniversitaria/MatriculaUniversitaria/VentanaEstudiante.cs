﻿using System;
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
    public partial class VentanaEstudiante : Form
    {
        public VentanaEstudiante()
        {
            InitializeComponent();
        }

        private void VentanaEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncerrarsesionadmin_Click(object sender, EventArgs e)
        {
            ventanaLogin ventanal = new ventanaLogin();
            ventanal.Show(this);
            this.Hide();
        }
    }
}
