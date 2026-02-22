namespace AutoMarket.Presentacion
{
    partial class FrmRegistroCategorias
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
            lblTitulo = new Label();
            lblNombreCategoria = new Label();
            txtNombreCategoria = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelBotones = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(15, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(275, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Categorías de Vehículo";
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new Point(15, 40);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(113, 15);
            lblNombreCategoria.TabIndex = 1;
            lblNombreCategoria.Text = "Nombre (requerido)";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Dock = DockStyle.Fill;
            txtNombreCategoria.Location = new Point(15, 69);
            txtNombreCategoria.MaxLength = 60;
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(578, 23);
            txtNombreCategoria.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(15, 102);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(126, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción (opcional)";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Dock = DockStyle.Fill;
            txtDescripcion.Location = new Point(15, 123);
            txtDescripcion.MaxLength = 200;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(578, 178);
            txtDescripcion.TabIndex = 4;
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
            lblEstado.Dock = DockStyle.Fill;
            lblEstado.Location = new Point(15, 348);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(578, 22);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Registros: 0 / 0";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNombreCategoria, 0, 1);
            tableLayoutPanel1.Controls.Add(txtNombreCategoria, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDescripcion, 0, 3);
            tableLayoutPanel1.Controls.Add(txtDescripcion, 0, 4);
            tableLayoutPanel1.Controls.Add(panelBotones, 0, 5);
            tableLayoutPanel1.Controls.Add(lblEstado, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Size = new Size(608, 382);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnRegistrar);
            panelBotones.Controls.Add(btnLimpiar);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(15, 307);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(0, 8, 0, 0);
            panelBotones.Size = new Size(578, 38);
            panelBotones.TabIndex = 5;
            panelBotones.WrapContents = false;
            // 
            // FrmRegistroCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 382);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistroCategorias";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Registro de Categorías";
            Load += FrmRegistroCategorias_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombreCategoria;
        private TextBox txtNombreCategoria;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label lblEstado;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel panelBotones;
    }
}