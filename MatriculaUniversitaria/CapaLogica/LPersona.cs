using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaLogica
{
    public class LPersona
    {
        public DPersona D_persona;

        public LPersona()
        {
            this.D_persona = new DPersona();
        }

        public Boolean Registrar(Persona persona)
        {
            return D_persona.Registrar(persona);
        }

        public List<Persona> CargarPersonas()
        {
            return D_persona.CargarPersonas();
        }

        public Boolean Eliminar(Persona persona)
        {
            return D_persona.Eliminar(persona);
        }

        public Boolean Editar(Persona persona)
        {
            return D_persona.Editar(persona);
        }
    }
}
