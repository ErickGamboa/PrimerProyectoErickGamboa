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

        /*
        Método que conecta la capa datos con la capa presentación recibiendo un objeto Persona
        Retorna metodo de registrar persona
            */
        public Boolean RegistrarPersona(Persona persona)
        {
            return D_persona.RegistrarPersona(persona);
        }

        /*
        Método que conecta la capa datos con la capa presentación
        Retorna metodo de cargar persona
            */
        public List<Persona> CargarPersonas()
        {
            return D_persona.CargarPersonas();
        }

        /*
        Método que conecta la capa datos con la capa presentación recibiendo un objeto persona
        Retorna metodo de eliminar persona
            */
        public Boolean EliminarPersona(Persona persona)
        {
            return D_persona.EliminarPersona(persona);
        }

        /*
        Método que conecta la capa datos con la capa presentación recibiendo un objeto persona
        Retorna metodo de editar persona
            */
        public Boolean EditarPersona(Persona persona)
        {
            return D_persona.EditarPersona(persona);
        }
    }
}
