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
    }
}
