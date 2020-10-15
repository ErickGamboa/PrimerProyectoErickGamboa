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

        public EAdmin Login(string usuario, string contra)
        {
            return login.Login(usuario, contra);
        }

    }
}
