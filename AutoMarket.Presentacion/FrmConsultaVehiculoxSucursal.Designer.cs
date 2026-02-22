namespace AutoMarket.Presentacion
{
    partial class FrmConsultaVehiculoxSucursal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            panelFiltros = new FlowLayoutPanel();
            lblSucursalFiltro = new Label();
            cboSucursalFiltro = new ComboBox();
            btnFiltrar = new Button();
            btnLimpiarFiltro = new Button();
            dgvInventario = new DataGridView();
            colIdSucursal = new DataGridViewTextBoxColumn();
            colSucursal = new DataGridViewTextBoxColumn();
            colIdVehiculo = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colAnio = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colIdCategoria = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            panelAcciones = new FlowLayoutPanel();
            btnRefrescar = new Button();
            lblEstado = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            panelAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(panelFiltros, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvInventario, 0, 2);
            tableLayoutPanel1.Controls.Add(panelAcciones, 0, 3);
            tableLayoutPanel1.Controls.Add(lblEstado, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Size = new Size(1280, 520);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(15, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(348, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consulta de Inventario por Sucursal";
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(lblSucursalFiltro);
            panelFiltros.Controls.Add(cboSucursalFiltro);
            panelFiltros.Controls.Add(btnFiltrar);
            panelFiltros.Controls.Add(btnLimpiarFiltro);
            panelFiltros.Dock = DockStyle.Fill;
            panelFiltros.FlowDirection = FlowDirection.LeftToRight;
            panelFiltros.Location = new Point(15, 43);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Padding = new Padding(0, 8, 0, 0);
            panelFiltros.Size = new Size(1250, 38);
            panelFiltros.TabIndex = 1;
            panelFiltros.WrapContents = false;
            // 
            // lblSucursalFiltro
            // 
            lblSucursalFiltro.AutoSize = true;
            lblSucursalFiltro.Location = new Point(3, 12);
            lblSucursalFiltro.Margin = new Padding(3, 4, 8, 0);
            lblSucursalFiltro.Name = "lblSucursalFiltro";
            lblSucursalFiltro.Size = new Size(49, 15);
            lblSucursalFiltro.TabIndex = 0;
            lblSucursalFiltro.Text = "Sucursal";
            // 
            // cboSucursalFiltro
            // 
            cboSucursalFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursalFiltro.FormattingEnabled = true;
            cboSucursalFiltro.Location = new Point(63, 8);
            cboSucursalFiltro.Margin = new Padding(3, 0, 8, 0);
            cboSucursalFiltro.Name = "cboSucursalFiltro";
            cboSucursalFiltro.Size = new Size(320, 23);
            cboSucursalFiltro.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.AutoSize = true;
            btnFiltrar.Location = new Point(394, 8);
            btnFiltrar.Margin = new Padding(3, 0, 8, 0);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(57, 25);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.AutoSize = true;
            btnLimpiarFiltro.Location = new Point(462, 8);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(104, 25);
            btnLimpiarFiltro.TabIndex = 3;
            btnLimpiarFiltro.Text = "Limpiar filtro";
            btnLimpiarFiltro.UseVisualStyleBackColor = true;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AutoGenerateColumns = false;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colIdSucursal, colSucursal, colIdVehiculo, colMarca, colModelo, colAnio, colPrecio, colIdCategoria, colCategoria, colEstado, colCantidad });
            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.Location = new Point(15, 87);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(1250, 381);
            dgvInventario.TabIndex = 2;
            // 
            // colIdSucursal
            // 
            colIdSucursal.HeaderText = "IdSucursal";
            colIdSucursal.Name = "colIdSucursal";
            colIdSucursal.ReadOnly = true;
            colIdSucursal.Width = 95;
            // 
            // colSucursal
            // 
            colSucursal.HeaderText = "Sucursal";
            colSucursal.Name = "colSucursal";
            colSucursal.ReadOnly = true;
            colSucursal.Width = 170;
            // 
            // colIdVehiculo
            // 
            colIdVehiculo.HeaderText = "IdVehiculo";
            colIdVehiculo.Name = "colIdVehiculo";
            colIdVehiculo.ReadOnly = true;
            colIdVehiculo.Width = 95;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "Marca";
            colMarca.Name = "colMarca";
            colMarca.ReadOnly = true;
            colMarca.Width = 130;
            // 
            // colModelo
            // 
            colModelo.HeaderText = "Modelo";
            colModelo.Name = "colModelo";
            colModelo.ReadOnly = true;
            colModelo.Width = 170;
            // 
            // colAnio
            // 
            colAnio.HeaderText = "Año";
            colAnio.Name = "colAnio";
            colAnio.ReadOnly = true;
            colAnio.Width = 70;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 110;
            // 
            // colIdCategoria
            // 
            colIdCategoria.HeaderText = "IdCategoria";
            colIdCategoria.Name = "colIdCategoria";
            colIdCategoria.ReadOnly = true;
            colIdCategoria.Width = 95;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoría";
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 160;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 85;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 85;
            // 
            // panelAcciones
            // 
            panelAcciones.Controls.Add(btnRefrescar);
            panelAcciones.Dock = DockStyle.Fill;
            panelAcciones.FlowDirection = FlowDirection.LeftToRight;
            panelAcciones.Location = new Point(15, 474);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Padding = new Padding(0, 8, 0, 0);
            panelAcciones.Size = new Size(1250, 38);
            panelAcciones.TabIndex = 3;
            panelAcciones.WrapContents = false;
            // 
            // btnRefrescar
            // 
            btnRefrescar.AutoSize = true;
            btnRefrescar.Location = new Point(3, 11);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(82, 25);
            btnRefrescar.TabIndex = 0;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Dock = DockStyle.Fill;
            lblEstado.Location = new Point(15, 498);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(1250, 22);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Registros: 0 / 0";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmConsultaVehiculoxSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 520);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultaVehiculoxSucursal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Consulta de Inventario por Sucursal";
            Load += FrmConsultaVehiculoxSucursal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            panelAcciones.ResumeLayout(false);
            panelAcciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private FlowLayoutPanel panelFiltros;
        private Label lblSucursalFiltro;
        private ComboBox cboSucursalFiltro;
        private Button btnFiltrar;
        private Button btnLimpiarFiltro;
        private DataGridView dgvInventario;
        private DataGridViewTextBoxColumn colIdSucursal;
        private DataGridViewTextBoxColumn colSucursal;
        private DataGridViewTextBoxColumn colIdVehiculo;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colAnio;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colIdCategoria;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colCantidad;
        private FlowLayoutPanel panelAcciones;
        private Button btnRefrescar;
        private Label lblEstado;
    }
}