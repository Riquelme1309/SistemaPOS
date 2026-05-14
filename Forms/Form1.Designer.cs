namespace Proyecto1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtNombreCliente = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNombreCliente1 = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.txtCantidadVent = new System.Windows.Forms.Label();
            this.txtCodigoProductoo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNI = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRecargarVentas = new System.Windows.Forms.Button();
            this.btnMarcarEntregado = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente2 = new System.Windows.Forms.TextBox();
            this.txtNITCliente = new System.Windows.Forms.TextBox();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPendientes = new System.Windows.Forms.Button();
            this.btnMasVendidos = new System.Windows.Forms.Button();
            this.btnVentasPorFecha = new System.Windows.Forms.Button();
            this.btnGanancias = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.lblTotalReporte = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.txtNombreCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.txtNombreCliente);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCantidad);
            this.tabPage1.Controls.Add(this.txtPrecioVenta);
            this.tabPage1.Controls.Add(this.txtPrecioCompra);
            this.tabPage1.Controls.Add(this.txtMarca);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(647, 254);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 57);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(647, 154);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 50);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(647, 61);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 51);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(210, 304);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(378, 22);
            this.txtCantidad.TabIndex = 11;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(210, 254);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(378, 22);
            this.txtPrecioVenta.TabIndex = 10;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(210, 206);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(378, 22);
            this.txtPrecioCompra.TabIndex = 9;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(210, 154);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(378, 22);
            this.txtMarca.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(210, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(378, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(210, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(378, 22);
            this.txtCodigo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRecargar);
            this.tabPage2.Controls.Add(this.dgvProductos);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(330, 377);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(125, 36);
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvProductos.Location = new System.Drawing.Point(3, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(786, 368);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Controls.Add(this.btnCancelar);
            this.txtNombreCliente.Controls.Add(this.btnFinalizarVenta);
            this.txtNombreCliente.Controls.Add(this.btnAgregarProducto);
            this.txtNombreCliente.Controls.Add(this.btnBuscarProducto);
            this.txtNombreCliente.Controls.Add(this.btnBuscarCliente);
            this.txtNombreCliente.Controls.Add(this.txtCantidadVenta);
            this.txtNombreCliente.Controls.Add(this.txtCodigoProducto);
            this.txtNombreCliente.Controls.Add(this.txtNombreCliente1);
            this.txtNombreCliente.Controls.Add(this.txtNIT);
            this.txtNombreCliente.Controls.Add(this.lblTotal);
            this.txtNombreCliente.Controls.Add(this.label8);
            this.txtNombreCliente.Controls.Add(this.dgvVenta);
            this.txtNombreCliente.Controls.Add(this.txtCantidadVent);
            this.txtNombreCliente.Controls.Add(this.txtCodigoProductoo);
            this.txtNombreCliente.Controls.Add(this.label7);
            this.txtNombreCliente.Controls.Add(this.txtNI);
            this.txtNombreCliente.Location = new System.Drawing.Point(4, 25);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(792, 421);
            this.txtNombreCliente.TabIndex = 2;
            this.txtNombreCliente.Text = "Nueva Venta";
            this.txtNombreCliente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(684, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Location = new System.Drawing.Point(501, 367);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarVenta.TabIndex = 14;
            this.btnFinalizarVenta.Text = "Finalizar";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click_1);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(501, 227);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(268, 26);
            this.btnAgregarProducto.TabIndex = 13;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click_1);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(684, 286);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 44);
            this.btnBuscarProducto.TabIndex = 12;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click_1);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(502, 284);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 46);
            this.btnBuscarCliente.TabIndex = 11;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(183, 183);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(259, 22);
            this.txtCantidadVenta.TabIndex = 10;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(183, 133);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(259, 22);
            this.txtCodigoProducto.TabIndex = 9;
            // 
            // txtNombreCliente1
            // 
            this.txtNombreCliente1.Location = new System.Drawing.Point(188, 83);
            this.txtNombreCliente1.Name = "txtNombreCliente1";
            this.txtNombreCliente1.Size = new System.Drawing.Size(254, 22);
            this.txtNombreCliente1.TabIndex = 8;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(183, 32);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(259, 22);
            this.txtNIT.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(104, 253);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Q 0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total";
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(537, 23);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersWidth = 51;
            this.dgvVenta.RowTemplate.Height = 24;
            this.dgvVenta.Size = new System.Drawing.Size(233, 175);
            this.dgvVenta.TabIndex = 4;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            // 
            // txtCantidadVent
            // 
            this.txtCantidadVent.AutoSize = true;
            this.txtCantidadVent.Location = new System.Drawing.Point(59, 183);
            this.txtCantidadVent.Name = "txtCantidadVent";
            this.txtCantidadVent.Size = new System.Drawing.Size(61, 16);
            this.txtCantidadVent.TabIndex = 3;
            this.txtCantidadVent.Text = "Cantidad";
            // 
            // txtCodigoProductoo
            // 
            this.txtCodigoProductoo.AutoSize = true;
            this.txtCodigoProductoo.Location = new System.Drawing.Point(23, 131);
            this.txtCodigoProductoo.Name = "txtCodigoProductoo";
            this.txtCodigoProductoo.Size = new System.Drawing.Size(108, 16);
            this.txtCodigoProductoo.TabIndex = 2;
            this.txtCodigoProductoo.Text = "Código Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre Cliente";
            // 
            // txtNI
            // 
            this.txtNI.AutoSize = true;
            this.txtNI.Location = new System.Drawing.Point(32, 32);
            this.txtNI.Name = "txtNI";
            this.txtNI.Size = new System.Drawing.Size(32, 16);
            this.txtNI.TabIndex = 0;
            this.txtNI.Text = "NIT:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRecargarVentas);
            this.tabPage3.Controls.Add(this.btnMarcarEntregado);
            this.tabPage3.Controls.Add(this.dgvVentas);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Ventas del día";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRecargarVentas
            // 
            this.btnRecargarVentas.Location = new System.Drawing.Point(475, 372);
            this.btnRecargarVentas.Name = "btnRecargarVentas";
            this.btnRecargarVentas.Size = new System.Drawing.Size(101, 38);
            this.btnRecargarVentas.TabIndex = 2;
            this.btnRecargarVentas.Text = "Recargar";
            this.btnRecargarVentas.UseVisualStyleBackColor = true;
            this.btnRecargarVentas.Click += new System.EventHandler(this.btnRecargarVentas_Click_1);
            // 
            // btnMarcarEntregado
            // 
            this.btnMarcarEntregado.Location = new System.Drawing.Point(156, 372);
            this.btnMarcarEntregado.Name = "btnMarcarEntregado";
            this.btnMarcarEntregado.Size = new System.Drawing.Size(200, 41);
            this.btnMarcarEntregado.TabIndex = 1;
            this.btnMarcarEntregado.Text = "Marcar Entregado";
            this.btnMarcarEntregado.UseVisualStyleBackColor = true;
            this.btnMarcarEntregado.Click += new System.EventHandler(this.btnMarcarEntregado_Click_1);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(8, 8);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(773, 342);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtTelefonoCliente);
            this.tabPage4.Controls.Add(this.txtDireccionCliente);
            this.tabPage4.Controls.Add(this.txtApellidoCliente);
            this.tabPage4.Controls.Add(this.txtNombreCliente2);
            this.tabPage4.Controls.Add(this.txtNITCliente);
            this.tabPage4.Controls.Add(this.btnLimpiarCliente);
            this.tabPage4.Controls.Add(this.btnGuardarCliente);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 421);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Clientes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(134, 262);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(275, 22);
            this.txtTelefonoCliente.TabIndex = 14;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(134, 207);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(275, 22);
            this.txtDireccionCliente.TabIndex = 13;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(134, 153);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(275, 22);
            this.txtApellidoCliente.TabIndex = 12;
            // 
            // txtNombreCliente2
            // 
            this.txtNombreCliente2.Location = new System.Drawing.Point(127, 94);
            this.txtNombreCliente2.Name = "txtNombreCliente2";
            this.txtNombreCliente2.Size = new System.Drawing.Size(282, 22);
            this.txtNombreCliente2.TabIndex = 11;
            // 
            // txtNITCliente
            // 
            this.txtNITCliente.Location = new System.Drawing.Point(127, 32);
            this.txtNITCliente.Name = "txtNITCliente";
            this.txtNITCliente.Size = new System.Drawing.Size(282, 22);
            this.txtNITCliente.TabIndex = 10;
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(473, 345);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(113, 50);
            this.btnLimpiarCliente.TabIndex = 9;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click_1);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(151, 345);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(125, 50);
            this.btnGuardarCliente.TabIndex = 8;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Dirección:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Teléfono:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "NIT:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblTotalReporte);
            this.tabPage5.Controls.Add(this.dgvReportes);
            this.tabPage5.Controls.Add(this.btnGanancias);
            this.tabPage5.Controls.Add(this.btnVentasPorFecha);
            this.tabPage5.Controls.Add(this.btnMasVendidos);
            this.tabPage5.Controls.Add(this.btnPendientes);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.dtpHasta);
            this.tabPage5.Controls.Add(this.dtpDesde);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 421);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Reportes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(70, 20);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 22);
            this.dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(70, 74);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 22);
            this.dtpHasta.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Desde";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(333, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Hasta";
            // 
            // btnPendientes
            // 
            this.btnPendientes.Location = new System.Drawing.Point(25, 133);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(148, 37);
            this.btnPendientes.TabIndex = 4;
            this.btnPendientes.Text = "Pendientes entregar";
            this.btnPendientes.UseVisualStyleBackColor = true;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);
            // 
            // btnMasVendidos
            // 
            this.btnMasVendidos.Location = new System.Drawing.Point(205, 133);
            this.btnMasVendidos.Name = "btnMasVendidos";
            this.btnMasVendidos.Size = new System.Drawing.Size(131, 37);
            this.btnMasVendidos.TabIndex = 5;
            this.btnMasVendidos.Text = "Mas vendido";
            this.btnMasVendidos.UseVisualStyleBackColor = true;
            this.btnMasVendidos.Click += new System.EventHandler(this.btnMasVendidos_Click);
            // 
            // btnVentasPorFecha
            // 
            this.btnVentasPorFecha.Location = new System.Drawing.Point(407, 133);
            this.btnVentasPorFecha.Name = "btnVentasPorFecha";
            this.btnVentasPorFecha.Size = new System.Drawing.Size(131, 37);
            this.btnVentasPorFecha.TabIndex = 6;
            this.btnVentasPorFecha.Text = "Venta por fecha";
            this.btnVentasPorFecha.UseVisualStyleBackColor = true;
            this.btnVentasPorFecha.Click += new System.EventHandler(this.btnVentasPorFecha_Click);
            // 
            // btnGanancias
            // 
            this.btnGanancias.Location = new System.Drawing.Point(605, 133);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(148, 37);
            this.btnGanancias.TabIndex = 7;
            this.btnGanancias.Text = "Ganancias por fecha";
            this.btnGanancias.UseVisualStyleBackColor = true;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // dgvReportes
            // 
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(25, 187);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 24;
            this.dgvReportes.Size = new System.Drawing.Size(728, 150);
            this.dgvReportes.TabIndex = 8;
            // 
            // lblTotalReporte
            // 
            this.lblTotalReporte.AutoSize = true;
            this.lblTotalReporte.Location = new System.Drawing.Point(345, 367);
            this.lblTotalReporte.Name = "lblTotalReporte";
            this.lblTotalReporte.Size = new System.Drawing.Size(101, 16);
            this.lblTotalReporte.TabIndex = 9;
            this.lblTotalReporte.Text = "lblTotalReporte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.txtNombreCliente.ResumeLayout(false);
            this.txtNombreCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.TabPage txtNombreCliente;
        private System.Windows.Forms.Label txtCantidadVent;
        private System.Windows.Forms.Label txtCodigoProductoo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtNI;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreCliente1;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRecargarVentas;
        private System.Windows.Forms.Button btnMarcarEntregado;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente2;
        private System.Windows.Forms.TextBox txtNITCliente;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnPendientes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnGanancias;
        private System.Windows.Forms.Button btnVentasPorFecha;
        private System.Windows.Forms.Button btnMasVendidos;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Label lblTotalReporte;
    }
}

