namespace AutoMarket.Presentacion
{
    partial class FrmRegistroVehiculos
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
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblModelo = new Label();
            txtModelo = new TextBox();
            lblAnio = new Label();
            nudAnio = new NumericUpDown();
            lblPrecio = new Label();
            nudPrecio = new NumericUpDown();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblEstadoVehiculo = new Label();
            cmbEstado = new ComboBox();
            panelBotones = new FlowLayoutPanel();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(lblMarca, 0, 1);
            tableLayoutPanel1.Controls.Add(txtMarca, 1, 1);
            tableLayoutPanel1.Controls.Add(lblModelo, 0, 2);
            tableLayoutPanel1.Controls.Add(txtModelo, 1, 2);
            tableLayoutPanel1.Controls.Add(lblAnio, 0, 3);
            tableLayoutPanel1.Controls.Add(nudAnio, 1, 3);
            tableLayoutPanel1.Controls.Add(lblPrecio, 0, 4);
            tableLayoutPanel1.Controls.Add(nudPrecio, 1, 4);
            tableLayoutPanel1.Controls.Add(lblCategoria, 0, 5);
            tableLayoutPanel1.Controls.Add(cmbCategoria, 1, 5);
            tableLayoutPanel1.Controls.Add(lblEstadoVehiculo, 0, 6);
            tableLayoutPanel1.Controls.Add(cmbEstado, 1, 6);
            tableLayoutPanel1.Controls.Add(panelBotones, 0, 7);
            tableLayoutPanel1.Controls.Add(lblEstado, 0, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Size = new Size(640, 362);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitulo, 2);
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(15, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(174, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Vehículos";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(15, 40);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(102, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca (requerido)";
            // 
            // txtMarca
            // 
            txtMarca.Dock = DockStyle.Fill;
            txtMarca.Location = new Point(199, 43);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(426, 23);
            txtMarca.TabIndex = 2;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(15, 76);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(110, 15);
            lblModelo.TabIndex = 3;
            lblModelo.Text = "Modelo (requerido)";
            // 
            // txtModelo
            // 
            txtModelo.Dock = DockStyle.Fill;
            txtModelo.Location = new Point(199, 79);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(426, 23);
            txtModelo.TabIndex = 4;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(15, 112);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(91, 15);
            lblAnio.TabIndex = 5;
            lblAnio.Text = "Año (requerido)";
            // 
            // nudAnio
            // 
            nudAnio.Location = new Point(199, 115);
            nudAnio.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudAnio.Minimum = new decimal(new int[] { 1886, 0, 0, 0 });
            nudAnio.Name = "nudAnio";
            nudAnio.Size = new Size(140, 23);
            nudAnio.TabIndex = 6;
            nudAnio.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(15, 148);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(102, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio (requerido)";
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Location = new Point(199, 151);
            nudPrecio.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(140, 23);
            nudPrecio.TabIndex = 8;
            nudPrecio.ThousandsSeparator = true;
            nudPrecio.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(15, 184);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(120, 15);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoría (requerido)";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Dock = DockStyle.Fill;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(199, 187);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(426, 23);
            cmbCategoria.TabIndex = 10;
            // 
            // lblEstadoVehiculo
            // 
            lblEstadoVehiculo.AutoSize = true;
            lblEstadoVehiculo.Location = new Point(15, 220);
            lblEstadoVehiculo.Name = "lblEstadoVehiculo";
            lblEstadoVehiculo.Size = new Size(104, 15);
            lblEstadoVehiculo.TabIndex = 11;
            lblEstadoVehiculo.Text = "Estado (requerido)";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(199, 223);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(140, 23);
            cmbEstado.TabIndex = 12;
            // 
            // panelBotones
            // 
            tableLayoutPanel1.SetColumnSpan(panelBotones, 2);
            panelBotones.Controls.Add(btnRegistrar);
            panelBotones.Controls.Add(btnLimpiar);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(15, 259);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(0, 8, 0, 0);
            panelBotones.Size = new Size(610, 38);
            panelBotones.TabIndex = 13;
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
            lblEstado.Location = new Point(15, 300);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(610, 50);
            lblEstado.TabIndex = 14;
            lblEstado.Text = "Registros: 0 / 0";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmRegistroVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 362);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistroVehiculos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Registro de Vehículos";
            Load += FrmRegistroVehiculos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblModelo;
        private TextBox txtModelo;
        private Label lblAnio;
        private NumericUpDown nudAnio;
        private Label lblPrecio;
        private NumericUpDown nudPrecio;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblEstadoVehiculo;
        private ComboBox cmbEstado;
        private FlowLayoutPanel panelBotones;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label lblEstado;
    }
}