namespace AutoMarket.Presentacion
{
    partial class FrmRegistroSucursales
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblVendedorEncargado = new Label();
            cboVendedorEncargado = new ComboBox();
            chkActiva = new CheckBox();
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
            tableLayoutPanel1.Controls.Add(lblNombre, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNombre, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDireccion, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDireccion, 1, 2);
            tableLayoutPanel1.Controls.Add(lblTelefono, 0, 3);
            tableLayoutPanel1.Controls.Add(txtTelefono, 1, 3);
            tableLayoutPanel1.Controls.Add(lblCorreo, 0, 4);
            tableLayoutPanel1.Controls.Add(txtCorreo, 1, 4);
            tableLayoutPanel1.Controls.Add(lblVendedorEncargado, 0, 5);
            tableLayoutPanel1.Controls.Add(cboVendedorEncargado, 1, 5);
            tableLayoutPanel1.Controls.Add(chkActiva, 1, 6);
            tableLayoutPanel1.Controls.Add(panelBotones, 0, 7);
            tableLayoutPanel1.Controls.Add(lblEstado, 0, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Size = new Size(720, 376);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitulo, 2);
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(15, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Sucursales";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre (requerido)";
            // 
            // txtNombre
            // 
            txtNombre.Dock = DockStyle.Fill;
            txtNombre.Location = new Point(237, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(468, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(15, 74);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(119, 15);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Dirección (requerido)";
            // 
            // txtDireccion
            // 
            txtDireccion.Dock = DockStyle.Fill;
            txtDireccion.Location = new Point(237, 77);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ScrollBars = ScrollBars.Vertical;
            txtDireccion.Size = new Size(468, 52);
            txtDireccion.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(15, 132);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(115, 15);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono (requerido)";
            // 
            // txtTelefono
            // 
            txtTelefono.Dock = DockStyle.Fill;
            txtTelefono.Location = new Point(237, 135);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(468, 23);
            txtTelefono.TabIndex = 6;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(15, 166);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "Correo (requerido)";
            // 
            // txtCorreo
            // 
            txtCorreo.Dock = DockStyle.Fill;
            txtCorreo.Location = new Point(237, 169);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(468, 23);
            txtCorreo.TabIndex = 8;
            // 
            // lblVendedorEncargado
            // 
            lblVendedorEncargado.AutoSize = true;
            lblVendedorEncargado.Location = new Point(15, 200);
            lblVendedorEncargado.Name = "lblVendedorEncargado";
            lblVendedorEncargado.Size = new Size(178, 15);
            lblVendedorEncargado.TabIndex = 9;
            lblVendedorEncargado.Text = "Vendedor Encargado (requerido)";
            // 
            // cboVendedorEncargado
            // 
            cboVendedorEncargado.Dock = DockStyle.Fill;
            cboVendedorEncargado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVendedorEncargado.FormattingEnabled = true;
            cboVendedorEncargado.Location = new Point(237, 203);
            cboVendedorEncargado.Name = "cboVendedorEncargado";
            cboVendedorEncargado.Size = new Size(468, 23);
            cboVendedorEncargado.TabIndex = 10;
            // 
            // chkActiva
            // 
            chkActiva.AutoSize = true;
            chkActiva.Location = new Point(237, 237);
            chkActiva.Name = "chkActiva";
            chkActiva.Size = new Size(59, 19);
            chkActiva.TabIndex = 11;
            chkActiva.Text = "Activa";
            chkActiva.UseVisualStyleBackColor = true;
            // 
            // panelBotones
            // 
            tableLayoutPanel1.SetColumnSpan(panelBotones, 2);
            panelBotones.Controls.Add(btnRegistrar);
            panelBotones.Controls.Add(btnLimpiar);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(15, 265);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(0, 8, 0, 0);
            panelBotones.Size = new Size(690, 38);
            panelBotones.TabIndex = 12;
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
            lblEstado.Location = new Point(15, 306);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(690, 58);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Registros: 0 / 0";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmRegistroSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 376);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistroSucursales";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Registro de Sucursales";
            Load += FrmRegistroSucursales_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblVendedorEncargado;
        private ComboBox cboVendedorEncargado;
        private CheckBox chkActiva;
        private FlowLayoutPanel panelBotones;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label lblEstado;
    }
}