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
        static string admin_path = @"C:\Users\Usuario\Desktop\PrimerProyeto\MatriculaUniversitaria\Archivos\admins.json";

        public List<EAdmin> ListaAdmins()
        {
            StreamReader jsonStream = File.OpenText(admin_path);
            var json = jsonStream.ReadToEnd();

            List<EAdmin> list = JsonConvert.DeserializeObject<List<EAdmin>>(json);
            return list;
        }

    }
}
