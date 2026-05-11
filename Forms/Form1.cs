using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proyecto1.Models;
using Proyecto1.DataAccess;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        // ─── Variables globales ───
        private LinkedList<Producto> listaProductos;
        private LinkedList<Cliente> listaClientes;
        private LinkedList<Factura> listaFacturas;
        private LinkedList<DetalleFactura> detallesActuales;
        private ArchivosDAO dao;
        private Producto productoSeleccionado = null;
        private Cliente clienteActual = null;

        public Form1()
        {
            InitializeComponent();
            dao = new ArchivosDAO();
            listaProductos = dao.CargarProductos();
            listaClientes = dao.CargarClientes();
            listaFacturas = dao.CargarFacturas();
            detallesActuales = new LinkedList<DetalleFactura>();
            CargarTablaProductos();
            CargarTablaVenta();
            CargarTablaVentas();
        }

        // ════════════════════════════════════════
        //  CARGAR TABLAS
        // ════════════════════════════════════════
        private void CargarTablaProductos()
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add("Codigo", "Código");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Marca", "Marca");
            dgvProductos.Columns.Add("PCompra", "P. Compra");
            dgvProductos.Columns.Add("PVenta", "P. Venta");
            dgvProductos.Columns.Add("Cantidad", "Existencia");

            foreach (var p in listaProductos)
                dgvProductos.Rows.Add(
                    p.Codigo,
                    p.Nombre,
                    p.Marca,
                    p.PrecioCompra.ToString("C"),
                    p.PrecioVenta.ToString("C"),
                    p.CantidadExistencia
                );
        }

        private void CargarTablaVenta()
        {
            dgvVenta.Rows.Clear();
            dgvVenta.Columns.Clear();
            dgvVenta.Columns.Add("Codigo", "Código");
            dgvVenta.Columns.Add("Nombre", "Nombre");
            dgvVenta.Columns.Add("Cantidad", "Cantidad");
            dgvVenta.Columns.Add("Precio", "Precio");
            dgvVenta.Columns.Add("Subtotal", "Subtotal");

            double total = 0;
            foreach (var d in detallesActuales)
            {
                dgvVenta.Rows.Add(
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
                dgvVentas.Rows.Add(
                    f.NumeroFactura,
                    f.NIT,
                    f.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    f.Estado,
                    f.Total.ToString("C")
                );
        }

        // ════════════════════════════════════════
        //  LIMPIAR
        // ════════════════════════════════════════
        private void LimpiarProducto()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Text = "";
            productoSeleccionado = null;
            txtCodigo.Enabled = true;
        }

        private void LimpiarVenta()
        {
            txtNIT.Text = "";
            txtNombreCliente.Text = "";
            txtCodigoProducto.Text = "";
            txtCantidadVenta.Text = "1";
            clienteActual = null;
            detallesActuales = new LinkedList<DetalleFactura>();
            CargarTablaVenta();
        }

        private void LimpiarCliente()
        {
            txtNITCliente.Text = "";
            txtNombreCliente2.Text = "";
            txtApellidoCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtTelefonoCliente.Text = "";
        }

        // ════════════════════════════════════════
        //  VALIDAR
        // ════════════════════════════════════════
        private bool ValidarProducto()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Código, Nombre y Marca son obligatorios.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtPrecioCompra.Text, out _) ||
                !double.TryParse(txtPrecioVenta.Text, out _))
            {
                MessageBox.Show("Los precios deben ser números válidos.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("La cantidad debe ser un número entero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarCliente()
        {
            if (string.IsNullOrWhiteSpace(txtNITCliente.Text) ||
                string.IsNullOrWhiteSpace(txtNombreCliente2.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoCliente.Text))
            {
                MessageBox.Show("NIT, Nombre y Apellido son obligatorios.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ════════════════════════════════════════
        //  TAB PRODUCTOS — BOTONES
        // ════════════════════════════════════════
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarProducto()) return;

            foreach (var p in listaProductos)
            {
                if (p.Codigo == txtCodigo.Text.Trim())
                {
                    MessageBox.Show("Ya existe un producto con ese código.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            listaProductos.AddLast(new Producto(
                txtCodigo.Text.Trim(),
                txtNombre.Text.Trim(),
                txtMarca.Text.Trim(),
                double.Parse(txtPrecioCompra.Text),
                double.Parse(txtPrecioVenta.Text),
                int.Parse(txtCantidad.Text)
            ));

            dao.GuardarProductos(listaProductos);
            CargarTablaProductos();
            LimpiarProducto();
            MessageBox.Show("Producto agregado ✅", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Selecciona un producto de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarProducto()) return;

            productoSeleccionado.Nombre = txtNombre.Text.Trim();
            productoSeleccionado.Marca = txtMarca.Text.Trim();
            productoSeleccionado.PrecioCompra = double.Parse(txtPrecioCompra.Text);
            productoSeleccionado.PrecioVenta = double.Parse(txtPrecioVenta.Text);
            productoSeleccionado.CantidadExistencia = int.Parse(txtCantidad.Text);

            dao.GuardarProductos(listaProductos);
            CargarTablaProductos();
            LimpiarProducto();
            MessageBox.Show("Producto editado ✅", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarProducto();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            listaProductos = dao.CargarProductos();
            CargarTablaProductos();
            MessageBox.Show("Lista actualizada ✅", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string codigo = dgvProductos.Rows[e.RowIndex]
                                        .Cells["Codigo"].Value.ToString();
            foreach (var p in listaProductos)
            {
                if (p.Codigo == codigo)
                {
                    productoSeleccionado = p;
                    txtCodigo.Text = p.Codigo;
                    txtNombre.Text = p.Nombre;
                    txtMarca.Text = p.Marca;
                    txtPrecioCompra.Text = p.PrecioCompra.ToString();
                    txtPrecioVenta.Text = p.PrecioVenta.ToString();
                    txtCantidad.Text = p.CantidadExistencia.ToString();
                    txtCodigo.Enabled = false;
                    tabControl1.SelectedIndex = 0;
                    break;
                }
            }
        }

        // ════════════════════════════════════════
        //  TAB CLIENTES — BOTONES
        // ════════════════════════════════════════
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCliente()) return;

            foreach (var c in listaClientes)
            {
                if (c.NIT == txtNITCliente.Text.Trim())
                {
                    MessageBox.Show("Ya existe un cliente con ese NIT.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            listaClientes.AddLast(new Cliente(
                txtNITCliente.Text.Trim(),
                txtNombreCliente2.Text.Trim(),
                txtApellidoCliente.Text.Trim(),
                txtDireccionCliente.Text.Trim(),
                txtTelefonoCliente.Text.Trim()
            ));

            dao.GuardarClientes(listaClientes);
            LimpiarCliente();
            MessageBox.Show("Cliente guardado ✅", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            LimpiarCliente();
        }

        // ════════════════════════════════════════
        //  TAB NUEVA VENTA — BOTONES
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
                    txtNombreCliente.Text = clienteActual.NombreCompleto;
                    break;
                }
            }

            if (clienteActual == null)
            {
                var respuesta = MessageBox.Show(
                    "Cliente no encontrado. ¿Desea registrarlo?",
                    "Nuevo Cliente", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    // Ir al tab de clientes y prellenar NIT
                    txtNITCliente.Text = nit;
                    tabControl1.SelectedIndex = 4;
                    MessageBox.Show("Ingresa los datos del cliente,\n" +
                                   "guárdalo y regresa a Nueva Venta.",
                                   "Registrar Cliente",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Cliente: {clienteActual.NombreCompleto} ✅",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoProducto.Text.Trim();
            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingresa un código.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var p in listaProductos)
            {
                if (p.Codigo == codigo)
                {
                    MessageBox.Show($"Producto: {p.Nombre}\n" +
                                   $"Precio: {p.PrecioVenta:C}\n" +
                                   $"Existencia: {p.CantidadExistencia}",
                                   "Encontrado ✅",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("Producto no encontrado.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

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

            if (!int.TryParse(txtCantidadVenta.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.", "Aviso",
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

            if (cantidad > encontrado.CantidadExistencia)
            {
                MessageBox.Show($"Solo hay {encontrado.CantidadExistencia} unidades.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            detallesActuales.AddLast(new DetalleFactura(
                encontrado.Codigo,
                encontrado.Nombre,
                cantidad,
                encontrado.PrecioVenta
            ));

            CargarTablaVenta();
            txtCodigoProducto.Text = "";
            txtCantidadVenta.Text = "1";
        }

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

            int numeroFactura = dao.ObtenerUltimoNumeroFactura(listaFacturas);
            Factura nuevaFactura = new Factura(numeroFactura, clienteActual.NIT);

            foreach (var d in detallesActuales)
            {
                nuevaFactura.AgregarDetalle(d);
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

            LimpiarVenta();
            CargarTablaVentas();
            CargarTablaProductos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("¿Cancelar la venta actual?",
                "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) LimpiarVenta();
        }

        // ════════════════════════════════════════
        //  TAB VENTAS DEL DÍA — BOTONES
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
            MessageBox.Show("Marcada como entregada ✅", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecargarVentas_Click(object sender, EventArgs e)
        {
            listaFacturas = dao.CargarFacturas();
            CargarTablaVentas();
        }
    }
}


