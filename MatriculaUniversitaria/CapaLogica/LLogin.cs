using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaLogica
{
    public class LLogin
    {
        public DLogin coneccion = new DLogin();
        public List<EAdmin> cargarDatos() {
            return coneccion.ListaAdmins();
        } 
    }
}
