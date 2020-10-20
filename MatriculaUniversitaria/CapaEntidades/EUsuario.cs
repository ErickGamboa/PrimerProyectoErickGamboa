using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EUsuario
    {
        public string idntificadorUsuario { get; set; }
        public string codigo { get; set; }
        public string idPersona { get; set; }
        public string contrasenna { get; set; }
        public DateTime fechaExpiraContra { get; set; }
        public string estado { get; set; }
    }
}
