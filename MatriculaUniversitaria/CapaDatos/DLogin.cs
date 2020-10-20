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

        /*
         Metodo que recibe un string de usuario y un string de contraseña para 
         compararlo con el item de objeto Administrador y verificar si son los mismos 
         credenciales
         Retorna el item (objeto) si se cumplen con los credenciales de ingreso,
         de lo contrario retorna null
             */
        public EAdmin Login(string usuario, string contra)
        {
            foreach (EAdmin item in this.list_admins)
            {
                if (item.usuario.Equals(usuario) && item.contrasenna.Equals(contra))
                {
                    return item;
                }
                
            }
            return null;
        }

        public Persona LoginUsuaros(string usuario, string contra)
        {
            DRegistrarUsuario usu = new DRegistrarUsuario();
            DPersona per = new DPersona();
            List<EUsuario> lista_Usuarios = usu.CargarListadoDeUsuarios();
            List<Persona> lista_Personas = per.CargarListadoDePersonas();
            foreach (Persona item in lista_Personas)
            {
                if (item.cedula.Equals(usuario))
                {
                    foreach (EUsuario item_dos in lista_Usuarios)
                    {
                        if (item.cedula.Equals(usuario) && item_dos.contrasenna.Equals(contra))
                        {
                            return item;
                        }
                    }
                }
            }
            return null;
        }
    }
}
