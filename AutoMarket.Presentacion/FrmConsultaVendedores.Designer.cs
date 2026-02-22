namespace AutoMarket.Presentacion
{
    partial class FrmConsultaVendedores
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
            dgvVendedores = new DataGridView();
            colIdVendedor = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPrimerApellido = new DataGridViewTextBoxColumn();
            colSegundoApellido = new DataGridViewTextBoxColumn();
            colCedula = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colFechaIngreso = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            panelAcciones = new FlowLayoutPanel();
            btnRefrescar = new Button();
            lblEstado = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            panelAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvVendedores, 0, 1);
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
            tableLayoutPanel1.Size = new Size(1180, 460);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(15, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(219, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consulta de Vendedores";
            // 
            // dgvVendedores
            // 
            dgvVendedores.AllowUserToAddRows = false;
            dgvVendedores.AllowUserToDeleteRows = false;
            dgvVendedores.AutoGenerateColumns = false;
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Columns.AddRange(new DataGridViewColumn[] { colIdVendedor, colNombre, colPrimerApellido, colSegundoApellido, colCedula, colTelefono, colCorreo, colFechaIngreso, colActivo });
            dgvVendedores.Dock = DockStyle.Fill;
            dgvVendedores.Location = new Point(15, 43);
            dgvVendedores.MultiSelect = false;
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.ReadOnly = true;
            dgvVendedores.RowHeadersVisible = false;
            dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendedores.Size = new Size(1150, 348);
            dgvVendedores.TabIndex = 1;
            // 
            // colIdVendedor
            // 
            colIdVendedor.HeaderText = "IdVendedor";
            colIdVendedor.Name = "colIdVendedor";
            colIdVendedor.ReadOnly = true;
            colIdVendedor.Width = 95;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 140;
            // 
            // colPrimerApellido
            // 
            colPrimerApellido.HeaderText = "PrimerApellido";
            colPrimerApellido.Name = "colPrimerApellido";
            colPrimerApellido.ReadOnly = true;
            colPrimerApellido.Width = 140;
            // 
            // colSegundoApellido
            // 
            colSegundoApellido.HeaderText = "SegundoApellido";
            colSegundoApellido.Name = "colSegundoApellido";
            colSegundoApellido.ReadOnly = true;
            colSegundoApellido.Width = 140;
            // 
            // colCedula
            // 
            colCedula.HeaderText = "Cédula";
            colCedula.Name = "colCedula";
            colCedula.ReadOnly = true;
            colCedula.Width = 140;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            colTelefono.Width = 120;
            // 
            // colCorreo
            // 
            colCorreo.HeaderText = "Correo";
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            colCorreo.Width = 210;
            // 
            // colFechaIngreso
            // 
            colFechaIngreso.HeaderText = "FechaIngreso";
            colFechaIngreso.Name = "colFechaIngreso";
            colFechaIngreso.ReadOnly = true;
            colFechaIngreso.Width = 110;
            // 
            // colActivo
            // 
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            colActivo.Width = 70;
            // 
            // panelAcciones
            // 
            panelAcciones.Controls.Add(btnRefrescar);
            panelAcciones.Dock = DockStyle.Fill;
            panelAcciones.FlowDirection = FlowDirection.LeftToRight;
            panelAcciones.Location = new Point(15, 397);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Padding = new Padding(0, 8, 0, 0);
            panelAcciones.Size = new Size(1150, 38);
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
            lblEstado.Size = new Size(1150, 22);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Registros: 0 / 0";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmConsultaVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 460);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultaVendedores";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Consulta de Vendedores";
            Load += FrmConsultaVendedores_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            panelAcciones.ResumeLayout(false);
            panelAcciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private DataGridView dgvVendedores;
        private DataGridViewTextBoxColumn colIdVendedor;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPrimerApellido;
        private DataGridViewTextBoxColumn colSegundoApellido;
        private DataGridViewTextBoxColumn colCedula;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colFechaIngreso;
        private DataGridViewTextBoxColumn colActivo;
        private FlowLayoutPanel panelAcciones;
        private Button btnRefrescar;
        private Label lblEstado;
    }
}