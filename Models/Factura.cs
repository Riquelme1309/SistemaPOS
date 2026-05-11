using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Models
{
    internal class Factura
    {
        public int NumeroFactura { get; set; }
        public string NIT { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        // Lista dinámica de productos vendidos
        public LinkedList<DetalleFactura> Detalles { get; set; }

        // Se calcula sumando todos los subtotales
        public double Total => Detalles.Sum(d => d.Subtotal);

        public Factura(int numero, string nit)
        {
            NumeroFactura = numero;
            NIT = nit;
            Fecha = DateTime.Now;
            Estado = "No entregado";
            Detalles = new LinkedList<DetalleFactura>();
        }

        public void AgregarDetalle(DetalleFactura detalle)
        {
            Detalles.AddLast(detalle);
        }

        public override string ToString()
        {
            return $"Factura #{NumeroFactura} | NIT: {NIT} | " +
                   $"Fecha: {Fecha:dd/MM/yyyy} | Estado: {Estado} | " +
                   $"Total: {Total:C}";
        }
    }
}
