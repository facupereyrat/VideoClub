using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pelicula
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public decimal Precio { get; set; }
        public int Anio { get; set; }
        public int Duracion { get; set; }
        public int IdGenero { get; set; }
        public int IdCalificacion { get; set; }
        public int IdSucursal { get; set; }

        public Genero Genero { get; set; }
        public Calificacion Calificacion { get; set; }
        public Sucursal Sucursal { get; set; }
    }

}
