using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class DRegistrarUsuario
    {
        public Persona Registrar(string cedula)
        {
            DPersona persona = new DPersona();
            List<Persona> lista = persona.CargarPersonas();
            foreach (Persona item in lista)
            {
                if (item.cedula.Equals(cedula))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
