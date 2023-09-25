using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Disco
    {
        public int IdDisco { get; set; }
        public string Titulo { get; set; }
        public TimeSpan? Duracion { get; set; }
        public DateTime Año { get; set; }
        public int? Ventas { get; set; }
        public string Disponibilidad { get; set; }
        public ML.Artista Artista { get; set; }
        public ML.Distribuidora Distribuidora { get; set; }
        public ML.Genero Genero { get; set; }
        public List<object> Discos { get; set; }
    }
}
