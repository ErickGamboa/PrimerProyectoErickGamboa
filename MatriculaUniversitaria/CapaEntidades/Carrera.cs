using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidades
{
    public class Carrera
    {
        public string idcarrera { get; set; }
        public string nombreCarrera { get; set; }
        public string creditosCarrera { get; set; }
        public string estado { get; set; }
        public DateTime fechaApertura { get; set; }
        public DateTime fechaCierre {get; set;}
    }
}
