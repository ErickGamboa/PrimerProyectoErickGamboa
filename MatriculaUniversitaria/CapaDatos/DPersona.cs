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

        public List<Persona> CargarListadoDePersonas()
        {
            StreamReader jsonStream = File.OpenText(url);
            String json = jsonStream.ReadToEnd();
            jsonStream.Close();
            List<Persona> lista_provicional = JsonConvert.DeserializeObject<List<Persona>>(json);
            return lista_provicional;
        }

        public List<Persona> CargarPersonas()
        {
            return CargarListadoDePersonas();
        }

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

        public bool Eliminar(Persona persona)
        {
            List<Persona> lista_provicional = CargarListadoDePersonas();
            for (int i = 0; i < lista_provicional.Count; i++)
            {
                if (persona.idpersona == lista_provicional[i].idpersona)
                {
                    lista_provicional.RemoveAt(i);
                    Guardar(lista_provicional);
                    return true;
                }
            }
            return false;
        }


        public void Guardar(List<Persona> lista)
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
                //this.servicio.GuardarEnArchivo(nuevojson, "personas.json");
            }
            else
            {
                archivo = null;
                File.WriteAllText(url, archivo);
                //this.servicio.GuardarEnArchivo(nuevojson, "personas.json");
            }
        }

        public bool Editar(Persona persona)
        {
            List<Persona> lista_provicional = CargarListadoDePersonas();
            for (int i = 0; i < lista_provicional.Count; i++)
            {
                if (persona.idpersona == lista_provicional[i].idpersona)
                {
                    lista_provicional.RemoveAt(i);
                    Guardar(lista_provicional);
                    lista_provicional.Add(persona);
                    Guardar(lista_provicional);
                    return true;
                }
            }
            return false;
        }

    }
}