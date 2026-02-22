namespace AutoMarket.Presentacion
{
    partial class FrmConsultaVehiculos
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
            dgvVehiculos = new DataGridView();
            colIdVehiculo = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colAnio = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colIdCategoria = new DataGridViewTextBoxColumn();
            colNombreCategoria = new DataGridViewTextBoxColumn();
            colDescripcionCategoria = new DataGridViewTextBoxColumn();
            panelAcciones = new FlowLayoutPanel();
            btnRefrescar = new Button();
            lblEstado = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            panelAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvVehiculos, 0, 1);
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
            tableLayoutPanel1.Size = new Size(1120, 460);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(15, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(202, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consulta de Vehículos";
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.AllowUserToAddRows = false;
            dgvVehiculos.AllowUserToDeleteRows = false;
            dgvVehiculos.AutoGenerateColumns = false;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Columns.AddRange(new DataGridViewColumn[] { colIdVehiculo, colMarca, colModelo, colAnio, colPrecio, colEstado, colIdCategoria, colNombreCategoria, colDescripcionCategoria });
            dgvVehiculos.Dock = DockStyle.Fill;
            dgvVehiculos.Location = new Point(15, 43);
            dgvVehiculos.MultiSelect = false;
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.ReadOnly = true;
            dgvVehiculos.RowHeadersVisible = false;
            dgvVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculos.Size = new Size(1090, 348);
            dgvVehiculos.TabIndex = 1;
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
            colMarca.Width = 140;
            // 
            // colModelo
            // 
            colModelo.HeaderText = "Modelo";
            colModelo.Name = "colModelo";
            colModelo.ReadOnly = true;
            colModelo.Width = 140;
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
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 90;
            // 
            // colIdCategoria
            // 
            colIdCategoria.HeaderText = "IdCategoria";
            colIdCategoria.Name = "colIdCategoria";
            colIdCategoria.ReadOnly = true;
            colIdCategoria.Width = 95;
            // 
            // colNombreCategoria
            // 
            colNombreCategoria.HeaderText = "Categoria (Nombre)";
            colNombreCategoria.Name = "colNombreCategoria";
            colNombreCategoria.ReadOnly = true;
            colNombreCategoria.Width = 180;
            // 
            // colDescripcionCategoria
            // 
            colDescripcionCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcionCategoria.HeaderText = "Categoria (Descripción)";
            colDescripcionCategoria.Name = "colDescripcionCategoria";
            colDescripcionCategoria.ReadOnly = true;
            // 
            // panelAcciones
            // 
            panelAcciones.Controls.Add(btnRefrescar);
            panelAcciones.Dock = DockStyle.Fill;
            panelAcciones.FlowDirection = FlowDirection.LeftToRight;
            panelAcciones.Location = new Point(15, 397);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Padding = new Padding(0, 8, 0, 0);
            panelAcciones.Size = new Size(1090, 38);
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
            lblEstado.Size = new Size(1090, 22);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Registros: 0 / 0";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmConsultaVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 460);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultaVehiculos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Consulta de Vehículos";
            Load += FrmConsultaVehiculos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            panelAcciones.ResumeLayout(false);
            panelAcciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private DataGridView dgvVehiculos;
        private DataGridViewTextBoxColumn colIdVehiculo;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colAnio;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colIdCategoria;
        private DataGridViewTextBoxColumn colNombreCategoria;
        private DataGridViewTextBoxColumn colDescripcionCategoria;
        private FlowLayoutPanel panelAcciones;
        private Button btnRefrescar;
        private Label lblEstado;
    }
}