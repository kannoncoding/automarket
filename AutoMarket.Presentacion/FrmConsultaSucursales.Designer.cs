namespace AutoMarket.Presentacion
{
    partial class FrmConsultaSucursales
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
            dgvSucursales = new DataGridView();
            colIdSucursal = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colIdVendedorEncargado = new DataGridViewTextBoxColumn();
            colVendedorEncargado = new DataGridViewTextBoxColumn();
            colCedulaVendedorEncargado = new DataGridViewTextBoxColumn();
            colActiva = new DataGridViewTextBoxColumn();
            panelAcciones = new FlowLayoutPanel();
            btnRefrescar = new Button();
            lblEstado = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            panelAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvSucursales, 0, 1);
            tableLayoutPanel1.Controls.Add(panelAcciones, 0, 2);
            tableLayoutPanel1.Controls.Add(lblEstado, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Size = new Size(1280, 460);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(15, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consulta de Sucursales";
            // 
            // dgvSucursales
            // 
            dgvSucursales.AllowUserToAddRows = false;
            dgvSucursales.AllowUserToDeleteRows = false;
            dgvSucursales.AutoGenerateColumns = false;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Columns.AddRange(new DataGridViewColumn[] { colIdSucursal, colNombre, colDireccion, colTelefono, colCorreo, colIdVendedorEncargado, colVendedorEncargado, colCedulaVendedorEncargado, colActiva });
            dgvSucursales.Dock = DockStyle.Fill;
            dgvSucursales.Location = new Point(15, 43);
            dgvSucursales.MultiSelect = false;
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.ReadOnly = true;
            dgvSucursales.RowHeadersVisible = false;
            dgvSucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSucursales.Size = new Size(1250, 348);
            dgvSucursales.TabIndex = 1;
            // 
            // colIdSucursal
            // 
            colIdSucursal.HeaderText = "IdSucursal";
            colIdSucursal.Name = "colIdSucursal";
            colIdSucursal.ReadOnly = true;
            colIdSucursal.Width = 95;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 170;
            // 
            // colDireccion
            // 
            colDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDireccion.HeaderText = "Dirección";
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            colTelefono.Width = 130;
            // 
            // colCorreo
            // 
            colCorreo.HeaderText = "Correo";
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            colCorreo.Width = 230;
            // 
            // colIdVendedorEncargado
            // 
            colIdVendedorEncargado.HeaderText = "IdVendedor";
            colIdVendedorEncargado.Name = "colIdVendedorEncargado";
            colIdVendedorEncargado.ReadOnly = true;
            colIdVendedorEncargado.Width = 95;
            // 
            // colVendedorEncargado
            // 
            colVendedorEncargado.HeaderText = "Vendedor Encargado";
            colVendedorEncargado.Name = "colVendedorEncargado";
            colVendedorEncargado.ReadOnly = true;
            colVendedorEncargado.Width = 190;
            // 
            // colCedulaVendedorEncargado
            // 
            colCedulaVendedorEncargado.HeaderText = "Cédula Encargado";
            colCedulaVendedorEncargado.Name = "colCedulaVendedorEncargado";
            colCedulaVendedorEncargado.ReadOnly = true;
            colCedulaVendedorEncargado.Width = 140;
            // 
            // colActiva
            // 
            colActiva.HeaderText = "Activa";
            colActiva.Name = "colActiva";
            colActiva.ReadOnly = true;
            colActiva.Width = 70;
            // 
            // panelAcciones
            // 
            panelAcciones.Controls.Add(btnRefrescar);
            panelAcciones.Dock = DockStyle.Fill;
            panelAcciones.FlowDirection = FlowDirection.LeftToRight;
            panelAcciones.Location = new Point(15, 397);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Padding = new Padding(0, 8, 0, 0);
            panelAcciones.Size = new Size(1250, 38);
            panelAcciones.TabIndex = 2;
            panelAcciones.WrapContents = false;
            // 
            // btnRefrescar
            // 
            btnRefrescar.AutoSize = true;
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
            lblEstado.Location = new Point(15, 436);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(1250, 22);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Registros: 0 / 0";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmConsultaSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 460);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultaSucursales";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Consulta de Sucursales";
            Load += FrmConsultaSucursales_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            panelAcciones.ResumeLayout(false);
            panelAcciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private DataGridView dgvSucursales;
        private DataGridViewTextBoxColumn colIdSucursal;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colIdVendedorEncargado;
        private DataGridViewTextBoxColumn colVendedorEncargado;
        private DataGridViewTextBoxColumn colCedulaVendedorEncargado;
        private DataGridViewTextBoxColumn colActiva;
        private FlowLayoutPanel panelAcciones;
        private Button btnRefrescar;
        private Label lblEstado;
    }
}