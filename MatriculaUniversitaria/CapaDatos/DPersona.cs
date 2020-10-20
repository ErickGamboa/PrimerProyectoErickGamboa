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
    public class DPersona
    {
        static string url = @"C:\Users\Usuario\Desktop\PrimerProyeto\MatriculaUniversitaria\Archivos\personas.json";
        public DPersona() {

        }

        /*
        Metodo que carga una lista de objetos tipo Persona 
        que se encuentran almacenadosdesde un archivo jSon
        Retorna listado de las Personas
            */
        public List<Persona> CargarListadoDePersonas()
        {
            StreamReader jsonStream = File.OpenText(url);
            String json = jsonStream.ReadToEnd();
            jsonStream.Close();
            List<Persona> lista_provicional = JsonConvert.DeserializeObject<List<Persona>>(json);
            return lista_provicional;
        }
        /*
        Metodo que retorna una lista de personas hacia la capa lógica
        Retorna lista de carreras
            */
        public List<Persona> CargarPersonas()
        {
            return CargarListadoDePersonas();
        }

        /*
        Metodo que recibe un objeto de tipo Persona, lo serializa y lo guarda en el archivo Json
        Retorna true si el objeto se guarda en el archivo o false si no lo hace 
            */
        public bool RegistrarPersona(Persona persona)
        {
            List<Persona> lista_provicional = CargarListadoDePersonas();
            string archivo;
            if (lista_provicional == null)
            {
                archivo = "[" + JsonConvert.SerializeObject(persona) + "]";
                File.WriteAllText(url, archivo);
                return true;
            }
            if (lista_provicional.Count != 0 )
            {
                archivo = "[";
                foreach (Persona item in lista_provicional)
                {
                    archivo += JsonConvert.SerializeObject(item) + ",";
                }
                archivo += JsonConvert.SerializeObject(persona) + "]";
                File.WriteAllText(url, archivo);
                return true;
            }

            return false;
        }

        /*
        Metodo que se encarga de eliminar un objeto Persona y guardar nuevamente la lista 
        Retorna true si se logra o false si no es así 
            */
        public bool EliminarPersona(Persona persona)
        {
            List<Persona> lista_provicional = CargarListadoDePersonas();
            for (int i = 0; i < lista_provicional.Count; i++)
            {
                if (persona.idpersona == lista_provicional[i].idpersona)
                {
                    lista_provicional.RemoveAt(i);
                    GuardarPersona(lista_provicional);
                    return true;
                }
            }
            return false;
        }

        /*
        Metodo que recibe una nueva lista para sustitur la lista existente en el archivo Json
            */
        public void GuardarPersona(List<Persona> lista)
        {
            string archivo;
            if (lista.Count != 0)
            {
                archivo = "[";
                for (int i = 0; i < lista.Count - 1; i++)
                {
                    archivo += JsonConvert.SerializeObject(lista[i]) + ",";
                }
                int x = lista.Count - 1;
                archivo += JsonConvert.SerializeObject(lista[x]) + "]";
                File.WriteAllText(url, archivo);
            }
            else
            {
                archivo = null;
                File.WriteAllText(url, archivo);
            }
        }

        /*
        Metodo que se encarga de editar un objeto Persona y guardar nuevamente la lista 
        Retorna true si se logra o false si no es así 
            */
        public bool EditarPersona(Persona persona)
        {
            List<Persona> lista_provicional = CargarListadoDePersonas();
            for (int i = 0; i < lista_provicional.Count; i++)
            {
                if (persona.idpersona == lista_provicional[i].idpersona)
                {
                    lista_provicional.RemoveAt(i);
                    GuardarPersona(lista_provicional);
                    lista_provicional.Add(persona);
                    GuardarPersona(lista_provicional);
                    return true;
                }
            }
            return false;
        }

    }
}