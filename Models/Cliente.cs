using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Models
{
    internal class Cliente
    {
        public string NIT { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nit, string nombre, string apellido,
                       string direccion, string telefono)
        {
            NIT = nit;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
        }

        public string NombreCompleto => $"{Nombre} {Apellido}";

        public override string ToString()
        {
            return $"{NIT} - {Nombre} {Apellido}";
        }
    }
}
