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

namespace Proyecto1.Forms
{
    public partial class FrmPOScs : Form
    {
        // ─── Variables globales ───
        private LinkedList<Producto> listaProductos;
        private LinkedList<Cliente> listaClientes;
        private LinkedList<Factura> listaFacturas;
        private LinkedList<DetalleFactura> detallesActuales;
        private ArchivosDAO dao;
        private Cliente clienteActual = null;
        public FrmPOScs()
        {
            InitializeComponent();
            dao = new ArchivosDAO();
            listaProductos = dao.CargarProductos();
            listaClientes = dao.CargarClientes();
            listaFacturas = dao.CargarFacturas();
            detallesActuales = new LinkedList<DetalleFactura>();
            CargarTablaVenta();
            CargarTablaVentas();
        }

        //  CARGAR DATAGRIDVIEW DE VENTA ACTUAL
        // ════════════════════════════════════════
        private void CargarTablaVenta()
        {
            dgvVentas.Rows.Clear();
            dgvVentas.Columns.Clear();

            dgvVentas.Columns.Add("Codigo", "Código");
            dgvVentas.Columns.Add("Nombre", "Nombre");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
            dgvVentas.Columns.Add("Precio", "Precio");
            dgvVentas.Columns.Add("Subtotal", "Subtotal");

            double total = 0;
            foreach (var d in detallesActuales)
            {
                dgvVentas.Rows.Add(
                    d.CodigoProducto,
                    d.NombreProducto,
                    d.Cantidad,
                    d.PrecioVenta.ToString("C"),
                    d.Subtotal.ToString("C")
                );
                total += d.Subtotal;
            }

            lblTotal.Text = $"Total: {total:C}";
        }

        //  CARGAR DATAGRIDVIEW DE VENTAS DEL DÍA
        private void CargarTablaVentas()
        {
            dgvVentas.Rows.Clear();
            dgvVentas.Columns.Clear();

            dgvVentas.Columns.Add("Numero", "N° Factura");
            dgvVentas.Columns.Add("NIT", "NIT");
            dgvVentas.Columns.Add("Fecha", "Fecha");
            dgvVentas.Columns.Add("Estado", "Estado");
            dgvVentas.Columns.Add("Total", "Total");

            foreach (var f in listaFacturas)
            {
                dgvVentas.Rows.Add(
                    f.NumeroFactura,
                    f.NIT,
                    f.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    f.Estado,
                    f.Total.ToString("C")
                );
            }
        }

        //  BUSCAR CLIENTE POR NIT
        // ════════════════════════════════════════
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string nit = txtNIT.Text.Trim();

            if (string.IsNullOrWhiteSpace(nit))
            {
                MessageBox.Show("Ingresa un NIT.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clienteActual = null;
            foreach (var c in listaClientes)
            {
                if (c.NIT == nit)
                {
                    clienteActual = c;
                    break;
                }
            }

            if (clienteActual != null)
            {
                txtNombreCliente.Text = clienteActual.NombreCompleto;
                MessageBox.Show("Cliente encontrado ✅", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cliente no existe, preguntar si desea registrarlo
                var respuesta = MessageBox.Show(
                    "Cliente no encontrado. ¿Desea registrarlo?",
                    "Nuevo Cliente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    //FrmCliente frmCliente = new FrmCliente(nit, listaClientes, dao);
                    //frmCliente.ShowDialog();
                    listaClientes = dao.CargarClientes();

                    // Buscar el cliente recién registrado
                    foreach (var c in listaClientes)
                    {
                        if (c.NIT == nit)
                        {
                            clienteActual = c;
                            txtNombreCliente.Text = clienteActual.NombreCompleto;
                            break;
                        }
                    }
                }
            }
        }

        //  BUSCAR PRODUCTO POR CÓDIGO
        // ════════════════════════════════════════
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingresa un código de producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto encontrado = null;
            foreach (var p in listaProductos)
            {
                if (p.Codigo == codigo)
                {
                    encontrado = p;
                    break;
                }
            }

            if (encontrado == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Producto: {encontrado.Nombre}\n" +
                           $"Precio: {encontrado.PrecioVenta:C}\n" +
                           $"Existencia: {encontrado.CantidadExistencia}",
                           "Producto encontrado ✅",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        //  AGREGAR PRODUCTO A LA VENTA
        // ════════════════════════════════════════
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (clienteActual == null)
            {
                MessageBox.Show("Primero busca un cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = txtCodigoProducto.Text.Trim();
            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingresa un código de producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar producto
            Producto productoEncontrado = null;
            foreach (var p in listaProductos)
            {
                if (p.Codigo == codigo)
                {
                    productoEncontrado = p;
                    break;
                }
            }

            if (productoEncontrado == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar existencia
            if (cantidad > productoEncontrado.CantidadExistencia)
            {
                MessageBox.Show($"Existencia insuficiente. Solo hay " +
                               $"{productoEncontrado.CantidadExistencia} unidades.",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar a la lista de detalles
            var detalle = new DetalleFactura(
                productoEncontrado.Codigo,
                productoEncontrado.Nombre,
                cantidad,
                productoEncontrado.PrecioVenta
            );

            detallesActuales.AddLast(detalle);
            CargarTablaVenta();

            // Limpiar campos de producto
            txtCodigoProducto.Text = "";
            txtCantidad.Text = "1";
        }

        //  FINALIZAR VENTA
        // ════════════════════════════════════════
        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (clienteActual == null)
            {
                MessageBox.Show("Busca un cliente primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (detallesActuales.Count == 0)
            {
                MessageBox.Show("Agrega al menos un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear factura
            int numeroFactura = dao.ObtenerUltimoNumeroFactura(listaFacturas);
            Factura nuevaFactura = new Factura(numeroFactura, clienteActual.NIT);

            // Agregar detalles y descontar existencia
            foreach (var d in detallesActuales)
            {
                nuevaFactura.AgregarDetalle(d);

                // Descontar existencia
                foreach (var p in listaProductos)
                {
                    if (p.Codigo == d.CodigoProducto)
                    {
                        p.CantidadExistencia -= d.Cantidad;
                        break;
                    }
                }
            }

            listaFacturas.AddLast(nuevaFactura);
            dao.GuardarFacturas(listaFacturas);
            dao.GuardarProductos(listaProductos);

            MessageBox.Show($"Venta finalizada ✅\n" +
                           $"Factura N°: {numeroFactura}\n" +
                           $"Total: {nuevaFactura.Total:C}",
                           "Éxito", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);

            // Limpiar para nueva venta
            LimpiarVenta();
            CargarTablaVentas();
        }

        //  CANCELAR VENTA
        // ════════════════════════════════════════
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show(
                "¿Deseas cancelar la venta actual?",
                "Cancelar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                LimpiarVenta();
        }

        //  MARCAR ENTREGADO
        // ════════════════════════════════════════
        private void btnMarcarEntregado_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una venta primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numero = int.Parse(dgvVentas.SelectedRows[0]
                                  .Cells["Numero"].Value.ToString());

            foreach (var f in listaFacturas)
            {
                if (f.NumeroFactura == numero)
                {
                    f.Estado = "Entregado";
                    break;
                }
            }

            dao.GuardarFacturas(listaFacturas);
            CargarTablaVentas();

            MessageBox.Show("Venta marcada como entregada ✅", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //  RECARGAR VENTAS
        // ════════════════════════════════════════
        private void btnRecargarVentas_Click(object sender, EventArgs e)
        {
            listaFacturas = dao.CargarFacturas();
            CargarTablaVentas();
        }

        //  LIMPIAR VENTA ACTUAL
        // ════════════════════════════════════════
        private void LimpiarVenta()
        {
            txtNIT.Text = "";
            txtNombreCliente.Text = "";
            txtCodigoProducto.Text = "";
            txtCantidad.Text = "1";
            clienteActual = null;
            detallesActuales = new LinkedList<DetalleFactura>();
            CargarTablaVenta();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
