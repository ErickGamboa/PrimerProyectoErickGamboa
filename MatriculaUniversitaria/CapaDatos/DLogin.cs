using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CapaEntidades;
using Newtonsoft.Json;

namespace CapaDatos
{
    public class DLogin
    {
        private List<EAdmin> list_admins;
        private Servicio servicio;

        public DLogin()
        {
            this.servicio = new Servicio("admins.json");
            this.list_admins = JsonConvert.DeserializeObject<List<EAdmin>>(this.servicio.ObtenerArchivo());
        }

        public EAdmin Login(string usuario, string contra)
        {
            foreach (EAdmin item in this.list_admins)
            {
                if (item.usuario.Equals(usuario) && item.contrasenna.Equals(contra))
                {
                    return item;
                }
                
            }
            this.LoginUsuaros(usuario, contra);
            return null;
        }

        public EAdmin LoginUsuaros(string usuario, string contra)
        {
            //TODO: Hacer logica para login con usuarios.
            return null;
        }
    }
}
