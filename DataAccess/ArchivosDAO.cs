using Proyecto1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.DataAccess
{
    internal class ArchivosDAO
    {
        //RUTAS DE ARCHIVOS 
        private static string rutaProductos = "productos.txt";
        private static string rutaClientes = "clientes.txt";
        private static string rutaFacturas = "facturas.txt";
        private static string rutaDetalles = "detalles.txt";
        //PRODUCTOS
        public void GuardarProductos(LinkedList<Producto> lista)
        {
            using (StreamWriter sw = new StreamWriter(rutaProductos))
            {
                foreach (var p in lista)
                {
                    sw.WriteLine($"{p.Codigo}|{p.Nombre}|{p.Marca}|" +
                                 $"{p.PrecioCompra}|{p.PrecioVenta}|" +
                                 $"{p.CantidadExistencia}");
                }
            }
        }

        public LinkedList<Producto> CargarProductos()
        {
            var lista = new LinkedList<Producto>();
            if (!File.Exists(rutaProductos)) return lista;

            foreach (var linea in File.ReadAllLines(rutaProductos))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                var d = linea.Split('|');
                lista.AddLast(new Producto(
                    d[0], d[1], d[2],
                    double.Parse(d[3]),
                    double.Parse(d[4]),
                    int.Parse(d[5])
                ));
            }
            return lista;
        }
        //  CLIENTES
        public void GuardarClientes(LinkedList<Cliente> lista)
        {
            using (StreamWriter sw = new StreamWriter(rutaClientes))
            {
                foreach (var c in lista)
                {
                    sw.WriteLine($"{c.NIT}|{c.Nombre}|{c.Apellido}|" +
                                 $"{c.Direccion}|{c.Telefono}");
                }
            }
        }

        public LinkedList<Cliente> CargarClientes()
        {
            var lista = new LinkedList<Cliente>();
            if (!File.Exists(rutaClientes)) return lista;

            foreach (var linea in File.ReadAllLines(rutaClientes))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                var d = linea.Split('|');
                lista.AddLast(new Cliente(
                    d[0], d[1], d[2], d[3], d[4]
                ));
            }
            return lista;
        }
        //  FACTURAS
        public void GuardarFacturas(LinkedList<Factura> lista)
        {
            // Guarda encabezados
            using (StreamWriter sw = new StreamWriter(rutaFacturas))
            {
                foreach (var f in lista)
                {
                    sw.WriteLine($"{f.NumeroFactura}|{f.NIT}|" +
                                 $"{f.Fecha:yyyy-MM-dd HH:mm:ss}|{f.Estado}");
                }
            }

            // Guarda detalles
            using (StreamWriter sw = new StreamWriter(rutaDetalles))
            {
                foreach (var f in lista)
                {
                    foreach (var d in f.Detalles)
                    {
                        sw.WriteLine($"{f.NumeroFactura}|{d.CodigoProducto}|" +
                                     $"{d.NombreProducto}|{d.Cantidad}|{d.PrecioVenta}");
                    }
                }
            }
        }

        public LinkedList<Factura> CargarFacturas()
        {
            var lista = new LinkedList<Factura>();
            if (!File.Exists(rutaFacturas)) return lista;

            // Cargar encabezados
            foreach (var linea in File.ReadAllLines(rutaFacturas))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                var d = linea.Split('|');
                var f = new Factura(int.Parse(d[0]), d[1]);
                f.Fecha = DateTime.Parse(d[2]);
                f.Estado = d[3];
                lista.AddLast(f);
            }

            // Cargar detalles y agregarlos a su factura
            if (File.Exists(rutaDetalles))
            {
                foreach (var linea in File.ReadAllLines(rutaDetalles))
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;
                    var d = linea.Split('|');
                    int numFactura = int.Parse(d[0]);

                    var detalle = new DetalleFactura(
                        d[1], d[2],
                        int.Parse(d[3]),
                        double.Parse(d[4])
                    );

                    // Buscar la factura correspondiente
                    foreach (var f in lista)
                    {
                        if (f.NumeroFactura == numFactura)
                        {
                            f.AgregarDetalle(detalle);
                            break;
                        }
                    }
                }
            }

            return lista;
        }
        //  NÚMERO DE FACTURA (autoincrementable)
        public int ObtenerUltimoNumeroFactura(LinkedList<Factura> facturas)
        {
            int ultimo = 0;
            foreach (var f in facturas)
            {
                if (f.NumeroFactura > ultimo)
                    ultimo = f.NumeroFactura;
            }
            return ultimo + 1;
        }
    }
}

