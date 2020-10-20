using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaLogica
{
   public class LCarrera
    {
        public DCarrera d_carrera;

        public LCarrera ()
        {
            this.d_carrera = new DCarrera();    
        }

        public Boolean RegistrarCarrera(Carrera carrera)
        {
            return d_carrera.RegistrarCarrera(carrera);
        }

        public List<Carrera> CargarCarreras()
        {
            return d_carrera.CargarCarrera();
        }
        public Boolean EliminarCarrera (Carrera carrera)
        {
            return d_carrera.EliminarCarrera(carrera);
        }
        public Boolean EditarCarrera(Carrera carrera)
        {
            return d_carrera.EditarCarrera(carrera);
        }
    }
}
