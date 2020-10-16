using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using Newtonsoft.Json;


namespace CapaDatos
{
    public class DPersona
    {
        private Servicio servicio;
        public string json;
        private List<Persona> lista_personas;

        public DPersona()
        {
            this.servicio = new Servicio("personas.json");
            this.lista_personas = JsonConvert.DeserializeObject<List<Persona>>(this.servicio.ObtenerArchivo());
            this.servicio = new Servicio();
        }
        public bool Registrar(Persona persona)
        {
            if(lista_personas.Count != 0)
            {
                this.json = "[";
                foreach (Persona item in lista_personas)
                {
                    this.json += JsonConvert.SerializeObject(item) + ",";
                }
                this.json += "[ " + JsonConvert.SerializeObject(persona) + "]";
                return this.servicio.GuardarEnArchivo(json, "personas.json");
            }
            this.json = JsonConvert.SerializeObject(persona);
            return this.servicio.GuardarEnArchivo(json, "personas.json");

        }
    }
}
