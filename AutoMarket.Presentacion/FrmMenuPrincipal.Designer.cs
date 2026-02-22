namespace AutoMarket.Presentacion
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            grpRegistros = new GroupBox();
            grpConsultas = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnRegistroCategorias = new Button();
            btnRegistroVehiculos = new Button();
            btnRegistroVendedores = new Button();
            btnRegistroSucursales = new Button();
            btnRegistroClientes = new Button();
            btnRegistroVehiculosSucursal = new Button();
            btnConsultaCategorias = new Button();
            btnConsultaVehiculos = new Button();
            btnConsultaVendedores = new Button();
            btnConsultaSucursales = new Button();
            btnConsultaClientes = new Button();
            btnConsultaVehiculosSucursal = new Button();
            tableLayoutPanel1.SuspendLayout();
            grpRegistros.SuspendLayout();
            grpConsultas.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(grpRegistros, 0, 0);
            tableLayoutPanel1.Controls.Add(grpConsultas, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // grpRegistros
            // 
            grpRegistros.Controls.Add(flowLayoutPanel1);
            grpRegistros.Dock = DockStyle.Fill;
            grpRegistros.Location = new Point(3, 3);
            grpRegistros.Name = "grpRegistros";
            grpRegistros.Size = new Size(394, 444);
            grpRegistros.TabIndex = 0;
            grpRegistros.TabStop = false;
            grpRegistros.Text = "Registros";
            // 
            // grpConsultas
            // 
            grpConsultas.Controls.Add(flowLayoutPanel2);
            grpConsultas.Dock = DockStyle.Fill;
            grpConsultas.Location = new Point(403, 3);
            grpConsultas.Name = "grpConsultas";
            grpConsultas.Size = new Size(394, 444);
            grpConsultas.TabIndex = 1;
            grpConsultas.TabStop = false;
            grpConsultas.Text = "Consultas";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(btnRegistroCategorias);
            flowLayoutPanel1.Controls.Add(btnRegistroVehiculos);
            flowLayoutPanel1.Controls.Add(btnRegistroVendedores);
            flowLayoutPanel1.Controls.Add(btnRegistroSucursales);
            flowLayoutPanel1.Controls.Add(btnRegistroClientes);
            flowLayoutPanel1.Controls.Add(btnRegistroVehiculosSucursal);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(388, 422);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(btnConsultaCategorias);
            flowLayoutPanel2.Controls.Add(btnConsultaVehiculos);
            flowLayoutPanel2.Controls.Add(btnConsultaVendedores);
            flowLayoutPanel2.Controls.Add(btnConsultaSucursales);
            flowLayoutPanel2.Controls.Add(btnConsultaClientes);
            flowLayoutPanel2.Controls.Add(btnConsultaVehiculosSucursal);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(388, 422);
            flowLayoutPanel2.TabIndex = 0;
            flowLayoutPanel2.WrapContents = false;
            // 
            // btnRegistroCategorias
            // 
            btnRegistroCategorias.AutoSize = true;
            btnRegistroCategorias.Location = new Point(3, 3);
            btnRegistroCategorias.Name = "btnRegistroCategorias";
            btnRegistroCategorias.Size = new Size(220, 25);
            btnRegistroCategorias.TabIndex = 0;
            btnRegistroCategorias.Text = "Registrar Categorías";
            btnRegistroCategorias.UseVisualStyleBackColor = true;
            btnRegistroCategorias.Click += btnRegistroCategorias_Click;
            // 
            // btnRegistroVehiculos
            // 
            btnRegistroVehiculos.AutoSize = true;
            btnRegistroVehiculos.Location = new Point(3, 34);
            btnRegistroVehiculos.Name = "btnRegistroVehiculos";
            btnRegistroVehiculos.Size = new Size(220, 25);
            btnRegistroVehiculos.TabIndex = 1;
            btnRegistroVehiculos.Text = "Registrar Vehículos";
            btnRegistroVehiculos.UseVisualStyleBackColor = true;
            btnRegistroVehiculos.Click += btnRegistroVehiculos_Click;
            // 
            // btnRegistroVendedores
            // 
            btnRegistroVendedores.AutoSize = true;
            btnRegistroVendedores.Location = new Point(3, 65);
            btnRegistroVendedores.Name = "btnRegistroVendedores";
            btnRegistroVendedores.Size = new Size(220, 25);
            btnRegistroVendedores.TabIndex = 2;
            btnRegistroVendedores.Text = "Registrar Vendedor";
            btnRegistroVendedores.UseVisualStyleBackColor = true;
            btnRegistroVendedores.Click += btnRegistroVendedores_Click;
            // 
            // btnRegistroSucursales
            // 
            btnRegistroSucursales.AutoSize = true;
            btnRegistroSucursales.Location = new Point(3, 96);
            btnRegistroSucursales.Name = "btnRegistroSucursales";
            btnRegistroSucursales.Size = new Size(220, 25);
            btnRegistroSucursales.TabIndex = 3;
            btnRegistroSucursales.Text = "Registrar Sucursal";
            btnRegistroSucursales.UseVisualStyleBackColor = true;
            btnRegistroSucursales.Click += btnRegistroSucursales_Click;
            // 
            // btnRegistroClientes
            // 
            btnRegistroClientes.AutoSize = true;
            btnRegistroClientes.Location = new Point(3, 127);
            btnRegistroClientes.Name = "btnRegistroClientes";
            btnRegistroClientes.Size = new Size(220, 25);
            btnRegistroClientes.TabIndex = 4;
            btnRegistroClientes.Text = "Registrar Cliente";
            btnRegistroClientes.UseVisualStyleBackColor = true;
            btnRegistroClientes.Click += btnRegistroClientes_Click;
            // 
            // btnRegistroVehiculosSucursal
            // 
            btnRegistroVehiculosSucursal.AutoSize = true;
            btnRegistroVehiculosSucursal.Location = new Point(3, 158);
            btnRegistroVehiculosSucursal.Name = "btnRegistroVehiculosSucursal";
            btnRegistroVehiculosSucursal.Size = new Size(220, 25);
            btnRegistroVehiculosSucursal.TabIndex = 5;
            btnRegistroVehiculosSucursal.Text = "Registrar Vehículo en Sucursal";
            btnRegistroVehiculosSucursal.UseVisualStyleBackColor = true;
            btnRegistroVehiculosSucursal.Click += btnRegistroVehiculosSucursal_Click;
            // 
            // btnConsultaCategorias
            // 
            btnConsultaCategorias.AutoSize = true;
            btnConsultaCategorias.Location = new Point(3, 3);
            btnConsultaCategorias.Name = "btnConsultaCategorias";
            btnConsultaCategorias.Size = new Size(220, 25);
            btnConsultaCategorias.TabIndex = 0;
            btnConsultaCategorias.Text = "Consultar Categorías";
            btnConsultaCategorias.UseVisualStyleBackColor = true;
            btnConsultaCategorias.Click += btnConsultaCategorias_Click;
            // 
            // btnConsultaVehiculos
            // 
            btnConsultaVehiculos.AutoSize = true;
            btnConsultaVehiculos.Location = new Point(3, 34);
            btnConsultaVehiculos.Name = "btnConsultaVehiculos";
            btnConsultaVehiculos.Size = new Size(220, 25);
            btnConsultaVehiculos.TabIndex = 1;
            btnConsultaVehiculos.Text = "Consultar Vehículos";
            btnConsultaVehiculos.UseVisualStyleBackColor = true;
            btnConsultaVehiculos.Click += btnConsultaVehiculos_Click;
            // 
            // btnConsultaVendedores
            // 
            btnConsultaVendedores.AutoSize = true;
            btnConsultaVendedores.Location = new Point(3, 65);
            btnConsultaVendedores.Name = "btnConsultaVendedores";
            btnConsultaVendedores.Size = new Size(220, 25);
            btnConsultaVendedores.TabIndex = 2;
            btnConsultaVendedores.Text = "Consultar Vendedores";
            btnConsultaVendedores.UseVisualStyleBackColor = true;
            btnConsultaVendedores.Click += btnConsultaVendedores_Click;
            // 
            // btnConsultaSucursales
            // 
            btnConsultaSucursales.AutoSize = true;
            btnConsultaSucursales.Location = new Point(3, 96);
            btnConsultaSucursales.Name = "btnConsultaSucursales";
            btnConsultaSucursales.Size = new Size(220, 25);
            btnConsultaSucursales.TabIndex = 3;
            btnConsultaSucursales.Text = "Consultar Sucursales";
            btnConsultaSucursales.UseVisualStyleBackColor = true;
            btnConsultaSucursales.Click += btnConsultaSucursales_Click;
            // 
            // btnConsultaClientes
            // 
            btnConsultaClientes.AutoSize = true;
            btnConsultaClientes.Location = new Point(3, 127);
            btnConsultaClientes.Name = "btnConsultaClientes";
            btnConsultaClientes.Size = new Size(220, 25);
            btnConsultaClientes.TabIndex = 4;
            btnConsultaClientes.Text = "Consultar Clientes";
            btnConsultaClientes.UseVisualStyleBackColor = true;
            btnConsultaClientes.Click += btnConsultaClientes_Click;
            // 
            // btnConsultaVehiculosSucursal
            // 
            btnConsultaVehiculosSucursal.AutoSize = true;
            btnConsultaVehiculosSucursal.Location = new Point(3, 158);
            btnConsultaVehiculosSucursal.Name = "btnConsultaVehiculosSucursal";
            btnConsultaVehiculosSucursal.Size = new Size(220, 25);
            btnConsultaVehiculosSucursal.TabIndex = 5;
            btnConsultaVehiculosSucursal.Text = "Consultar Inventario por Sucursal";
            btnConsultaVehiculosSucursal.UseVisualStyleBackColor = true;
            btnConsultaVehiculosSucursal.Click += btnConsultaVehiculosSucursal_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoMarket - Menú Principal";
            tableLayoutPanel1.ResumeLayout(false);
            grpRegistros.ResumeLayout(false);
            grpConsultas.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpRegistros;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox grpConsultas;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnRegistroCategorias;
        private Button btnRegistroVehiculos;
        private Button btnRegistroVendedores;
        private Button btnRegistroSucursales;
        private Button btnRegistroClientes;
        private Button btnRegistroVehiculosSucursal;
        private Button btnConsultaCategorias;
        private Button btnConsultaVehiculos;
        private Button btnConsultaVendedores;
        private Button btnConsultaSucursales;
        private Button btnConsultaClientes;
        private Button btnConsultaVehiculosSucursal;
    }
}