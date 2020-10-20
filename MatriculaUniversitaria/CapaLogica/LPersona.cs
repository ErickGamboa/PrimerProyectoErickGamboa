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

        public Boolean RegistrarPersona(Persona persona)
        {
            return D_persona.RegistrarPersona(persona);
        }

        public List<Persona> CargarPersonas()
        {
            return D_persona.CargarPersonas();
        }

        public Boolean EliminarPersona(Persona persona)
        {
            return D_persona.EliminarPersona(persona);
        }

        public Boolean EditarPersona(Persona persona)
        {
            return D_persona.EditarPersona(persona);
        }
    }
}
