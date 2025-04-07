using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_Parcial
{
    internal class InscripcionArchivo
    {
        public void Guardar(string archivo, List<Inscripcion> inscripciones)
        {
            string json = JsonConvert.SerializeObject(inscripciones);
            System.IO.File.WriteAllText(archivo, json);
        }
        public List<Inscripcion> Leer(string archivo)
        {
            List<Inscripcion> lista = new List<Inscripcion>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Inscripcion>>(json);
            return lista;
        }
    }
}
