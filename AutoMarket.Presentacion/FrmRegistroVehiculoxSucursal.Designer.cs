namespace AutoMarket.Presentacion
{
    partial class FrmRegistroVehiculoxSucursal
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
            lblSucursal = new Label();
            cboSucursal = new ComboBox();
            lblVehiculo = new Label();
            cboVehiculo = new ComboBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            panelBotones = new FlowLayoutPanel();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(lblSucursal, 0, 1);
            tableLayoutPanel1.Controls.Add(cboSucursal, 1, 1);
            tableLayoutPanel1.Controls.Add(lblVehiculo, 0, 2);
            tableLayoutPanel1.Controls.Add(cboVehiculo, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCantidad, 0, 3);
            tableLayoutPanel1.Controls.Add(txtCantidad, 1, 3);
            tableLayoutPanel1.Controls.Add(panelBotones, 0, 4);
            tableLayoutPanel1.Controls.Add(lblEstado, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Size = new Size(720, 300);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitulo, 2);
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(15, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(277, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Inventario por Sucursal";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(15, 40);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(113, 15);
            lblSucursal.TabIndex = 1;
            lblSucursal.Text = "Sucursal (requerido)";
            // 
            // cboSucursal
            // 
            cboSucursal.Dock = DockStyle.Fill;
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(237, 43);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(468, 23);
            cboSucursal.TabIndex = 2;
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(15, 74);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(114, 15);
            lblVehiculo.TabIndex = 3;
            lblVehiculo.Text = "Vehículo (requerido)";
            // 
            // cboVehiculo
            // 
            cboVehiculo.Dock = DockStyle.Fill;
            cboVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVehiculo.FormattingEnabled = true;
            cboVehiculo.Location = new Point(237, 77);
            cboVehiculo.Name = "cboVehiculo";
            cboVehiculo.Size = new Size(468, 23);
            cboVehiculo.TabIndex = 4;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(15, 108);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(117, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad (requerido)";
            // 
            // txtCantidad
            // 
            txtCantidad.Dock = DockStyle.Fill;
            txtCantidad.Location = new Point(237, 111);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(468, 23);
            txtCantidad.TabIndex = 6;
            txtCantidad.Text = "0";
            // 
            // panelBotones
            // 
            tableLayoutPanel1.SetColumnSpan(panelBotones, 2);
            panelBotones.Controls.Add(btnRegistrar);
            panelBotones.Controls.Add(btnLimpiar);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(15, 145);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(0, 8, 0, 0);
            panelBotones.Size = new Size(690, 38);
            panelBotones.TabIndex = 7;
            panelBotones.WrapContents = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.AutoSize = true;
            btnRegistrar.Location = new Point(3, 11);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(84, 25);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSize = true;
            btnLimpiar.Location = new Point(93, 11);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(74, 25);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblEstado, 2);
            lblEstado.Dock = DockStyle.Fill;
            lblEstado.Location = new Point(15, 186);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(690, 102);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Registros: 0 / 0";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmRegistroVehiculoxSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 300);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistroVehiculoxSucursal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Registro de Inventario por Sucursal";
            Load += FrmRegistroVehiculoxSucursal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Label lblSucursal;
        private ComboBox cboSucursal;
        private Label lblVehiculo;
        private ComboBox cboVehiculo;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private FlowLayoutPanel panelBotones;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label lblEstado;
    }
}