using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using Newtonsoft.Json;

namespace CapaDatos
{
    public class DRegistrarUsuario
    {
        static string urlUsuarios = @"C:\Users\Usuario\Desktop\PrimerProyeto\MatriculaUniversitaria\Archivos\usuarios.json";

        /*
        Metodo que carga una lista de objetos tipo Usuario 
        que se encuentran almacenadosdesde un archivo jSon
        Retorna listado de los usuarios
            */
        public List<EUsuario> CargarListadoDeUsuarios()
        {
            StreamReader jsonStream = File.OpenText(urlUsuarios);
            String json = jsonStream.ReadToEnd();
            jsonStream.Close();
            List<EUsuario> lista_provicional = JsonConvert.DeserializeObject<List<EUsuario>>(json);
            return lista_provicional;
        }

        /*
        Metodo que recibe un objeto de tipo Usuario, lo serializa y lo guarda en el archivo Json
        Retorna true si el objeto se guarda en el archivo o false si no lo hace 
            */
        public bool RegistrarUsuario(EUsuario usuario)
        {
            List<EUsuario> lista_provicional = CargarListadoDeUsuarios();
            string archivo;
            if (lista_provicional == null)
            {
                archivo = "[" + JsonConvert.SerializeObject(usuario) + "]";
                File.WriteAllText(urlUsuarios, archivo);
                return true;
            }
            if (lista_provicional.Count != 0)
            {
                archivo = "[";
                foreach (EUsuario item in lista_provicional)
                {
                    archivo += JsonConvert.SerializeObject(item) + ",";
                }
                archivo += JsonConvert.SerializeObject(usuario) + "]";
                File.WriteAllText(urlUsuarios, archivo);
                return true;
            }
            return false;
        }

        /*
        Metodo que recibe un string cedula para verificar si el usuario ya lo habia preregistrado el admin
        Retorna el objeto que encuentra
            */
        public Persona VerificarRegistro(string cedula)
        {
            DPersona persona = new DPersona();
            List<Persona> lista = persona.CargarPersonas();
            foreach (Persona item in lista)
            {
                if (item.cedula.Equals(cedula))
                {
                    return item;
                }
            }
            return null;
        }

    }
}
