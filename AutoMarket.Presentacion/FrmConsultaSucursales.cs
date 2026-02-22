/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de consulta de sucursales con visualización del vendedor encargado.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using System.Windows.Forms;

namespace AutoMarket.Presentacion
{
    public partial class FrmConsultaSucursales : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmConsultaSucursales(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmConsultaSucursales_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            var sucursales = _contexto.SucursalLogica.ObtenerTodos();

            dgvSucursales.Rows.Clear();

            foreach (var s in sucursales)
            {
                var idVendedor = s.VendedorEncargado.IdVendedor;
                var nombreVendedor = s.VendedorEncargado.Nombre;
                var cedulaVendedor = s.VendedorEncargado.Cedula;

                dgvSucursales.Rows.Add(
                    s.IdSucursal,
                    s.Nombre,
                    s.Direccion,
                    s.Telefono,
                    s.Correo,
                    idVendedor,
                    nombreVendedor,
                    cedulaVendedor,
                    s.Activa ? "Sí" : "No");
            }

            lblEstado.Text = $"Registros: {_contexto.SucursalLogica.CantidadRegistros} / {_contexto.SucursalLogica.Capacidad}";
        }
    }
}