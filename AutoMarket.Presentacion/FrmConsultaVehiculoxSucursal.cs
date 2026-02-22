/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de consulta de asociaciones Vehículo por Sucursal (inventario).
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-22
*/

using System;
using System.Globalization;
using System.Windows.Forms;
using AutoMarket.Entidades;
using AutoMarket.Logica;

namespace AutoMarket.Presentacion
{
    public partial class FrmConsultaVehiculoxSucursal : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmConsultaVehiculoxSucursal(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmConsultaVehiculoxSucursal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarSucursales();
                RefrescarGrid();
                ActualizarEstado();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
            ActualizarEstado();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
            ActualizarEstado();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            if (cboSucursalFiltro.Items.Count > 0)
            {
                cboSucursalFiltro.SelectedIndex = 0;
            }

            RefrescarGrid();
            ActualizarEstado();
        }

        private void CargarSucursales()
        {
            var sucursales = _contexto.SucursalLogica.ObtenerTodos();

            cboSucursalFiltro.BeginUpdate();
            cboSucursalFiltro.DataSource = null;
            cboSucursalFiltro.DisplayMember = nameof(Sucursal.Nombre);
            cboSucursalFiltro.ValueMember = nameof(Sucursal.IdSucursal);
            cboSucursalFiltro.DataSource = sucursales;
            cboSucursalFiltro.EndUpdate();

            if (cboSucursalFiltro.Items.Count > 0)
            {
                cboSucursalFiltro.SelectedIndex = 0;
            }
        }

        private void RefrescarGrid()
        {
            try
            {
                dgvInventario.Rows.Clear();

                VehiculoxSucursal[] asociaciones;

                // Si hay sucursales, filtramos por la seleccionada.
                if (cboSucursalFiltro.SelectedItem is Sucursal sucursalSeleccionada)
                {
                    asociaciones = _contexto.VehiculoxSucursalLogica.ObtenerPorSucursal(sucursalSeleccionada.IdSucursal);
                }
                else
                {
                    asociaciones = _contexto.VehiculoxSucursalLogica.ObtenerTodos();
                }

                foreach (var a in asociaciones)
                {
                    var s = a.Sucursal;
                    var v = a.Vehiculo;

                    var categoriaId = v.Categoria?.IdCategoria.ToString(CultureInfo.InvariantCulture) ?? string.Empty;
                    var categoriaNombre = v.Categoria?.NombreCategoria ?? string.Empty;

                    var estadoTexto = VehiculoLogica.ConvertirEstadoDominioATexto(v.Estado);

                    dgvInventario.Rows.Add(
                        s.IdSucursal,
                        s.Nombre,
                        v.IdVehiculo,
                        v.Marca,
                        v.Modelo,
                        v.Anio,
                        v.Precio,
                        categoriaId,
                        categoriaNombre,
                        estadoTexto,
                        a.Cantidad);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo refrescar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEstado()
        {
            lblEstado.Text =
                $"Registros: {_contexto.VehiculoxSucursalLogica.CantidadRegistros} / {_contexto.VehiculoxSucursalLogica.Capacidad}";
        }
    }
}