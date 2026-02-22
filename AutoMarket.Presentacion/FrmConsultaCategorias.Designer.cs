namespace AutoMarket.Presentacion
{
    partial class FrmConsultaCategorias
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
            dgvCategorias = new DataGridView();
            colIdCategoria = new DataGridViewTextBoxColumn();
            colNombreCategoria = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            panelAcciones = new FlowLayoutPanel();
            btnRefrescar = new Button();
            lblEstado = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            panelAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvCategorias, 0, 1);
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
            tableLayoutPanel1.Size = new Size(820, 430);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(15, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(277, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consulta de Categorías de Vehículo";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AutoGenerateColumns = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { colIdCategoria, colNombreCategoria, colDescripcion });
            dgvCategorias.Dock = DockStyle.Fill;
            dgvCategorias.Location = new Point(15, 43);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(790, 318);
            dgvCategorias.TabIndex = 1;
            // 
            // colIdCategoria
            // 
            colIdCategoria.HeaderText = "IdCategoria";
            colIdCategoria.Name = "colIdCategoria";
            colIdCategoria.ReadOnly = true;
            colIdCategoria.Width = 110;
            // 
            // colNombreCategoria
            // 
            colNombreCategoria.HeaderText = "NombreCategoria";
            colNombreCategoria.Name = "colNombreCategoria";
            colNombreCategoria.ReadOnly = true;
            colNombreCategoria.Width = 220;
            // 
            // colDescripcion
            // 
            colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // panelAcciones
            // 
            panelAcciones.Controls.Add(btnRefrescar);
            panelAcciones.Dock = DockStyle.Fill;
            panelAcciones.FlowDirection = FlowDirection.LeftToRight;
            panelAcciones.Location = new Point(15, 367);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Padding = new Padding(0, 8, 0, 0);
            panelAcciones.Size = new Size(790, 38);
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
            lblEstado.Location = new Point(15, 406);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(790, 22);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Registros: 0 / 0";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmConsultaCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 430);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultaCategorias";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoMarket - Consulta de Categorías";
            Load += FrmConsultaCategorias_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            panelAcciones.ResumeLayout(false);
            panelAcciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private DataGridView dgvCategorias;
        private DataGridViewTextBoxColumn colIdCategoria;
        private DataGridViewTextBoxColumn colNombreCategoria;
        private DataGridViewTextBoxColumn colDescripcion;
        private FlowLayoutPanel panelAcciones;
        private Button btnRefrescar;
        private Label lblEstado;
    }
}