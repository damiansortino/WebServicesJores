using Servicios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios.Clases
{
    public class prod
    {
        public int ProductoId { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precioUnitario { get; set; }
        public double porcentajeRentabilidad { get; set; }
        public string talle { get; set; }
        public string color { get; set; }
        public string marca { get; set; }
        public string codigo { get; set; }
        public double precio { get; set; }

        public prod(producto j)
        {
            ProductoId = j.ProductoId;
            nombre = j.nombre;
            descripcion = j.descripcion;
            precioUnitario = j.precioUnitario;
            porcentajeRentabilidad = j.porcentajeRentabilidad;
            talle = j.talle;
            color = j.color;
            marca = j.marca;
            codigo = j.codigo;
            precio = j.precioUnitario + (((j.precioUnitario * j.porcentajeRentabilidad))/100);
        }

        public prod()
        {
        }
    }
}