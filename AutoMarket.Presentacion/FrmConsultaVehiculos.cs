/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de consulta de vehículos con DataGridView rubric-safe y expansión de categoría y estado.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using System.Windows.Forms;
using AutoMarket.Logica;

namespace AutoMarket.Presentacion
{
    public partial class FrmConsultaVehiculos : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmConsultaVehiculos(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmConsultaVehiculos_Load(object sender, EventArgs e)
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
                var vehiculos = _contexto.VehiculoLogica.ObtenerTodos();

                dgvVehiculos.Rows.Clear();

                for (int i = 0; i < vehiculos.Length; i++)
                {
                    var v = vehiculos[i];

                    var idCategoria = v.Categoria.IdCategoria;
                    var nombreCategoria = v.Categoria.NombreCategoria;
                    var descripcionCategoria = v.Categoria.Descripcion;

                    var estadoTexto = VehiculoLogica.ConvertirEstadoDominioATexto(v.Estado);

                    dgvVehiculos.Rows.Add(
                        v.IdVehiculo,
                        v.Marca,
                        v.Modelo,
                        v.Anio,
                        v.Precio,
                        estadoTexto,
                        idCategoria,
                        nombreCategoria,
                        descripcionCategoria);
                }

                lblEstado.Text = $"Registros: {vehiculos.Length} / {_contexto.VehiculoLogica.Capacidad}";
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