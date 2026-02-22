/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de consulta de vendedores con DataGridView rubric-safe y refresco controlado.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using System.Windows.Forms;

namespace AutoMarket.Presentacion
{
    public partial class FrmConsultaVendedores : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmConsultaVendedores(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmConsultaVendedores_Load(object sender, EventArgs e)
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
                var vendedores = _contexto.VendedorLogica.ObtenerTodos();

                dgvVendedores.Rows.Clear();

                for (int i = 0; i < vendedores.Length; i++)
                {
                    var v = vendedores[i];

                    dgvVendedores.Rows.Add(
                        v.IdVendedor,
                        v.Nombre,
                        v.PrimerApellido,
                        v.SegundoApellido,
                        v.Cedula,
                        v.Telefono,
                        v.Correo,
                        v.FechaIngreso.Date.ToShortDateString(),
                        v.Activo ? "Sí" : "No");
                }

                lblEstado.Text = $"Registros: {vendedores.Length} / {_contexto.VendedorLogica.Capacidad}";
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