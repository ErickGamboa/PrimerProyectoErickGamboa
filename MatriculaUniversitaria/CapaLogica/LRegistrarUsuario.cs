using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class LRegistrarUsuario
    {
        public DRegistrarUsuario registro;
        public LRegistrarUsuario()
        {
            registro = new DRegistrarUsuario();
        }

        /*
       Método que conecta la capa datos con la capa presentación recibiendo un string cedula
       Retorna metodo de verificar  registro persona
           */
        public Persona VerificarRegistro(string cedula)
        {
            return registro.VerificarRegistro(cedula);
        }

        /*
       Método que conecta la capa datos con la capa presentación recibiendo un objeto Usuario
       Retorna metodo de registrar Usuario
           */
        public Boolean RegistrarUsuario(EUsuario usuario)
        {
            return registro.RegistrarUsuario(usuario);
        }
    }
}
