using Proyecto1.DataAccess;
using Proyecto1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        private LinkedList<Producto> listaProductos;
        private ArchivosDAO dao;
        private Producto productoSeleccionado = null;
        public Form1()
        {
            InitializeComponent();
        }

        //CARGAR DATOS EN EL DATAGRIDVIEW
        private void CargarTabla()
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Columns.Clear();

            // Crear columnas
            dgvProductos.Columns.Add("Codigo", "Código");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Marca", "Marca");
            dgvProductos.Columns.Add("PCompra", "P. Compra");
            dgvProductos.Columns.Add("PVenta", "P. Venta");
            dgvProductos.Columns.Add("Cantidad", "Existencia");

            // Llenar filas
            foreach (var p in listaProductos)
            {
                dgvProductos.Rows.Add(
                    p.Codigo,
                    p.Nombre,
                    p.Marca,
                    p.PrecioCompra.ToString("C"),
                    p.PrecioVenta.ToString("C"),
                    p.CantidadExistencia
                );
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
