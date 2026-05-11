using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Models
{
    internal class DetalleFactura
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioVenta { get; set; }

        // Se calcula solo, no se guarda aparte
        public double Subtotal => Cantidad * PrecioVenta;

        public DetalleFactura(string codigo, string nombre,
                              int cantidad, double precioVenta)
        {
            CodigoProducto = codigo;
            NombreProducto = nombre;
            Cantidad = cantidad;
            PrecioVenta = precioVenta;
        }

        public override string ToString()
        {
            return $"{CodigoProducto} - {NombreProducto} | " +
                   $"Cant: {Cantidad} | Precio: {PrecioVenta:C} | " +
                   $"Subtotal: {Subtotal:C}";
        }
    }
}
