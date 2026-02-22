namespace AutoMarket.Presentacion
{
    partial class FrmRegistroVendedores
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
            lblPrimerApellido = new Label();
            txtPrimerApellido = new TextBox();
            lblSegundoApellido = new Label();
            txtSegundoApellido = new TextBox();
            lblCedula = new Label();
            txtCedula = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblFechaIngreso = new Label();
            dtpFechaIngreso = new DateTimePicker();
            chkActivo = new CheckBox();
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
            tableLayoutPanel1.Controls.Add(lblPrimerApellido, 0, 2);
            tableLayoutPanel1.Controls.Add(txtPrimerApellido, 1, 2);
            tableLayoutPanel1.Controls.Add(lblSegundoApellido, 0, 3);
            tableLayoutPanel1.Controls.Add(txtSegundoApellido, 1, 3);
            tableLayoutPanel1.Controls.Add(lblCedula, 0, 4);
            tableLayoutPanel1.Controls.Add(txtCedula, 1, 4);
            tableLayoutPanel1.Controls.Add(lblTelefono, 0, 5);
            tableLayoutPanel1.Controls.Add(txtTelefono, 1, 5);
            tableLayoutPanel1.Controls.Add(lblCorreo, 0, 6);
            tableLayoutPanel1.Controls.Add(txtCorreo, 1, 6);
            tableLayoutPanel1.Controls.Add(lblFechaIngreso, 0, 7);
            tableLayoutPanel1.Controls.Add(dtpFechaIngreso, 1, 7);
            tableLayoutPanel1.Controls.Add(chkActivo, 1, 8);
            tableLayoutPanel1.Controls.Add(panelBotones, 0, 9);
            tableLayoutPanel1.Controls.Add(lblEstado, 0, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Size = new Size(690, 416);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitulo, 2);
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(15, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Vendedores";
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
            txtNombre.Location = new Point(228, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(447, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(15, 74);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(151, 15);
            lblPrimerApellido.TabIndex = 3;
            lblPrimerApellido.Text = "Primer Apellido (requerido)";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Dock = DockStyle.Fill;
            txtPrimerApellido.Location = new Point(228, 77);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(447, 23);
            txtPrimerApellido.TabIndex = 4;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(15, 108);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(163, 15);
            lblSegundoApellido.TabIndex = 5;
            lblSegundoApellido.Text = "Segundo Apellido (requerido)";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Dock = DockStyle.Fill;
            txtSegundoApellido.Location = new Point(228, 111);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(447, 23);
            txtSegundoApellido.TabIndex = 6;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(15, 142);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(106, 15);
            lblCedula.TabIndex = 7;
            lblCedula.Text = "Cédula (requerido)";
            // 
            // txtCedula
            // 
            txtCedula.Dock = DockStyle.Fill;
            txtCedula.Location = new Point(228, 145);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(447, 23);
            txtCedula.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(15, 176);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(115, 15);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono (requerido)";
            // 
            // txtTelefono
            // 
            txtTelefono.Dock = DockStyle.Fill;
            txtTelefono.Location = new Point(228, 179);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(447, 23);
            txtTelefono.TabIndex = 10;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(15, 210);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 11;
            lblCorreo.Text = "Correo (requerido)";
            // 
            // txtCorreo
            // 
            txtCorreo.Dock = DockStyle.Fill;
            txtCorreo.Location = new Point(228, 213);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(447, 23);
            txtCorreo.TabIndex = 12;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(15, 244);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(158, 15);
            lblFechaIngreso.TabIndex = 13;
            lblFechaIngreso.Text = "Fecha de Ingreso (requerido)";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(228, 247);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(220, 23);
            dtpFechaIngreso.TabIndex = 14;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(228, 281);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 15;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // panelBotones
            // 
            tableLayoutPanel1.SetColumnSpan(panelBotones, 2);
            panelBotones.Controls.Add(btnRegistrar);
            panelBotones.Controls.Add(btnLimpiar);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(15, 309);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(0, 8, 0, 0);
            panelBotones.Size = new Size(660, 38);
            panelBotones.TabIndex = 16;
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
            lblEstado.Location = new Point(15, 350);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(660, 54);
            lblEstado.TabIndex = 17;
            lblEstado.Text = "Registros: 0 / 0";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmRegistroVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 416);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistroVendedores";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Registro de Vendedores";
            Load += FrmRegistroVendedores_Load;
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
        private Label lblPrimerApellido;
        private TextBox txtPrimerApellido;
        private Label lblSegundoApellido;
        private TextBox txtSegundoApellido;
        private Label lblCedula;
        private TextBox txtCedula;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblFechaIngreso;
        private DateTimePicker dtpFechaIngreso;
        private CheckBox chkActivo;
        private FlowLayoutPanel panelBotones;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label lblEstado;
    }
}