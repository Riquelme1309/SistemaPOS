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
            dao = new ArchivosDAO();
            listaProductos = dao.CargarProductos();
            CargarTabla();
        }

        //Cargar datos en el datagridview
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

        //Limpiar datos
        private void LimpiarCampos()
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

        //Validar campos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Código, Nombre y Marca son obligatorios.",
                                "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtPrecioCompra.Text, out _) ||
                !double.TryParse(txtPrecioVenta.Text, out _))
            {
                MessageBox.Show("Los precios deben ser números válidos.",
                                "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("La cantidad debe ser un número entero.",
                                "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            // Verificar que el código no exista
            foreach (var p in listaProductos)
            {
                if (p.Codigo == txtCodigo.Text.Trim())
                {
                    MessageBox.Show("Ya existe un producto con ese código.",
                                    "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }
            }

            var nuevo = new Producto(
                txtCodigo.Text.Trim(),
                txtNombre.Text.Trim(),
                txtMarca.Text.Trim(),
                double.Parse(txtPrecioCompra.Text),
                double.Parse(txtPrecioVenta.Text),
                int.Parse(txtCantidad.Text)
            );

            listaProductos.AddLast(nuevo);
            dao.GuardarProductos(listaProductos);
            CargarTabla();
            LimpiarCampos();

            MessageBox.Show("Producto agregado correctamente",
                            "Éxito", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        //Boton editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Primero selecciona un producto de la lista.",
                                "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            productoSeleccionado.Nombre = txtNombre.Text.Trim();
            productoSeleccionado.Marca = txtMarca.Text.Trim();
            productoSeleccionado.PrecioCompra = double.Parse(txtPrecioCompra.Text);
            productoSeleccionado.PrecioVenta = double.Parse(txtPrecioVenta.Text);
            productoSeleccionado.CantidadExistencia = int.Parse(txtCantidad.Text);

            dao.GuardarProductos(listaProductos);
            CargarTabla();
            LimpiarCampos();

            MessageBox.Show("Producto editado correctamente ✅",
                            "Éxito", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        //Boton limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Boton recargar
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            listaProductos = dao.CargarProductos();
            CargarTabla();
            MessageBox.Show("Lista actualizada", "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        //Cargar en campos
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                    // Ir al tab de edición automáticamente
                    tabControl1.SelectedIndex = 0;
                    break;
                }
            }
        }
    }
}
    

