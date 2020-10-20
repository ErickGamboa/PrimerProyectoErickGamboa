using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaLogica
{
    public class LLogin
    {
        public DLogin login;
        public LLogin()
        {
            this.login = new DLogin();
        }

        /*
       Método que conecta la capa datos con la capa presentación recibiendo un string usuario y contraseña
       Retorna admin logueado
           */
        public EAdmin Login(string usuario, string contra)
        {
            return login.Login(usuario, contra);
        }

        /*
       Método que conecta la capa datos con la capa presentación recibiendo un string usuario y contraseña
       Retorna persona logueado
           */
        public Persona LoginPersona(string ced, string contra)
        {
            return login.LoginUsuaros(ced, contra);
        }
    }
}
