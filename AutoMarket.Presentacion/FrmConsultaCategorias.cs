/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de consulta de categorías de vehículo con DataGridView rubric-safe y refresco controlado.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using System.Windows.Forms;

namespace AutoMarket.Presentacion
{
    public partial class FrmConsultaCategorias : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmConsultaCategorias(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmConsultaCategorias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                var categorias = _contexto.CategoriaVehiculoLogica.ObtenerTodos();

                dgvCategorias.Rows.Clear();

                for (int i = 0; i < categorias.Length; i++)
                {
                    var c = categorias[i];

                    dgvCategorias.Rows.Add(
                        c.IdCategoria,
                        c.NombreCategoria,
                        c.Descripcion);
                }

                lblEstado.Text = $"Registros: {categorias.Length} / {_contexto.CategoriaVehiculoLogica.Capacidad}";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo consultar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}