using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Models
{
    internal class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public int CantidadExistencia { get; set; }

        public Producto(string codigo, string nombre, string marca,
                        double precioCompra, double precioVenta, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Marca = marca;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            CantidadExistencia = cantidad;
        }

        // Para mostrar en listas
        public override string ToString()
        {
            return $"{Codigo} - {Nombre} ({Marca}) | Existencia: {CantidadExistencia}";
        }
    }
}
