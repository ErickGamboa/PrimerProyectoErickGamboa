using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EUsuario
    {
        string idntificadorUsuario { get; set; }
        string codigo { get; set; }
        string idPersona { get; set; }
        string contrasenna { get; set; }
        DateTime fechaExpiraContra { get; set; }
        string estado { get; set; }
    }
}
