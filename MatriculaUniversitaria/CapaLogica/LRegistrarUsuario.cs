using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class LRegistrarUsuario
    {
        public DRegistrarUsuario registro;
        public LRegistrarUsuario()
        {
            registro = new DRegistrarUsuario();
        }

        public Persona Registrar(string cedula)
        {
            return registro.Registrar(cedula);
        }
    }
}
