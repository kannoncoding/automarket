namespace AutoMarket.Presentacion
{
    partial class FrmConsultaClientes
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
            dgvClientes = new DataGridView();
            colIdCliente = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPrimerApellido = new DataGridViewTextBoxColumn();
            colSegundoApellido = new DataGridViewTextBoxColumn();
            colCedula = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colFechaRegistro = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            panelAcciones = new FlowLayoutPanel();
            btnRefrescar = new Button();
            lblEstado = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panelAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvClientes, 0, 1);
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
            lblTitulo.Size = new Size(192, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consulta de Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colIdCliente, colNombre, colPrimerApellido, colSegundoApellido, colCedula, colTelefono, colCorreo, colFechaRegistro, colActivo });
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(15, 43);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1150, 348);
            dgvClientes.TabIndex = 1;
            // 
            // colIdCliente
            // 
            colIdCliente.HeaderText = "IdCliente";
            colIdCliente.Name = "colIdCliente";
            colIdCliente.ReadOnly = true;
            colIdCliente.Width = 90;
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
            colPrimerApellido.HeaderText = "Primer Apellido";
            colPrimerApellido.Name = "colPrimerApellido";
            colPrimerApellido.ReadOnly = true;
            colPrimerApellido.Width = 140;
            // 
            // colSegundoApellido
            // 
            colSegundoApellido.HeaderText = "Segundo Apellido";
            colSegundoApellido.Name = "colSegundoApellido";
            colSegundoApellido.ReadOnly = true;
            colSegundoApellido.Width = 140;
            // 
            // colCedula
            // 
            colCedula.HeaderText = "Cédula";
            colCedula.Name = "colCedula";
            colCedula.ReadOnly = true;
            colCedula.Width = 120;
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
            colCorreo.Width = 230;
            // 
            // colFechaRegistro
            // 
            colFechaRegistro.HeaderText = "Fecha Registro";
            colFechaRegistro.Name = "colFechaRegistro";
            colFechaRegistro.ReadOnly = true;
            colFechaRegistro.Width = 115;
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
            // FrmConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 460);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultaClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Consulta de Clientes";
            Load += FrmConsultaClientes_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panelAcciones.ResumeLayout(false);
            panelAcciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn colIdCliente;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPrimerApellido;
        private DataGridViewTextBoxColumn colSegundoApellido;
        private DataGridViewTextBoxColumn colCedula;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colFechaRegistro;
        private DataGridViewTextBoxColumn colActivo;
        private FlowLayoutPanel panelAcciones;
        private Button btnRefrescar;
        private Label lblEstado;
    }
}