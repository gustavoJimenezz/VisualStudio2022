using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoServices.Models
{
    public class Articulo
    {
        public Articulo(long id, string descripcion, decimal precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        // Atributos 
        public long id { get; private set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
    }
}
