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
        /*
         Método que conecta la capa datos con la capa presentación recibiendo un objeto Carrera
         Retorna metodo de registrar carrera
             */
        public Boolean RegistrarCarrera(Carrera carrera)
        {
            return d_carrera.RegistrarCarrera(carrera);
        }

        /*
        Método que conecta la capa datos con la capa presentación
        Retorna metodo de cargar carrera
            */
        public List<Carrera> CargarCarreras()
        {
            return d_carrera.CargarCarrera();
        }

        /*
        Método que conecta la capa datos con la capa presentación recibiendo un objeto Carrera
        Retorna metodo de eliminar carrera
            */
        public Boolean EliminarCarrera (Carrera carrera)
        {
            return d_carrera.EliminarCarrera(carrera);
        }

        /*
        Método que conecta la capa datos con la capa presentación recibiendo un objeto Carrera
        Retorna metodo de editar carrera
            */
        public Boolean EditarCarrera(Carrera carrera)
        {
            return d_carrera.EditarCarrera(carrera);
        }
    }
}
