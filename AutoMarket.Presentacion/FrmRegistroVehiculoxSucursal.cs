/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de registro de asociaciones Vehículo por Sucursal (inventario).
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-22
*/

using System;
using System.Globalization;
using System.Windows.Forms;
using AutoMarket.Entidades;

namespace AutoMarket.Presentacion
{
    public partial class FrmRegistroVehiculoxSucursal : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmRegistroVehiculoxSucursal(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmRegistroVehiculoxSucursal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarSucursales();
                CargarVehiculos();
                ActualizarEstado();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CamposMinimosValidos())
                {
                    MessageBox.Show("Complete los campos requeridos antes de registrar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var sucursal = (Sucursal)cboSucursal.SelectedItem!;
                var vehiculo = (Vehiculo)cboVehiculo.SelectedItem!;

                if (!int.TryParse(txtCantidad.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int cantidad))
                {
                    MessageBox.Show("La cantidad debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    txtCantidad.SelectAll();
                    return;
                }

                _contexto.VehiculoxSucursalLogica.Agregar(
                    sucursal.IdSucursal,
                    vehiculo.IdVehiculo,
                    cantidad);

                MessageBox.Show("Asociación registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                ActualizarEstado();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActualizarEstado();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void CargarSucursales()
        {
            var sucursales = _contexto.SucursalLogica.ObtenerTodos();

            cboSucursal.BeginUpdate();
            cboSucursal.DataSource = null;
            cboSucursal.DisplayMember = nameof(Sucursal.Nombre);
            cboSucursal.ValueMember = nameof(Sucursal.IdSucursal);
            cboSucursal.DataSource = sucursales;
            cboSucursal.EndUpdate();

            if (cboSucursal.Items.Count > 0)
            {
                cboSucursal.SelectedIndex = 0;
            }
        }

        private void CargarVehiculos()
        {
            var vehiculos = _contexto.VehiculoLogica.ObtenerTodos();

            cboVehiculo.BeginUpdate();
            cboVehiculo.DataSource = null;
            cboVehiculo.DisplayMember = nameof(Vehiculo.Modelo);
            cboVehiculo.ValueMember = nameof(Vehiculo.IdVehiculo);
            cboVehiculo.DataSource = vehiculos;
            cboVehiculo.EndUpdate();

            if (cboVehiculo.Items.Count > 0)
            {
                cboVehiculo.SelectedIndex = 0;
            }
        }

        private bool CamposMinimosValidos()
        {
            if (cboSucursal.SelectedItem is null) return false;
            if (cboVehiculo.SelectedItem is null) return false;
            if (string.IsNullOrWhiteSpace(txtCantidad.Text)) return false;
            return true;
        }

        private void LimpiarFormulario()
        {
            if (cboSucursal.Items.Count > 0)
            {
                cboSucursal.SelectedIndex = 0;
            }

            if (cboVehiculo.Items.Count > 0)
            {
                cboVehiculo.SelectedIndex = 0;
            }

            txtCantidad.Text = "0";
            txtCantidad.Focus();
            txtCantidad.SelectAll();
        }

        private void ActualizarEstado()
        {
            lblEstado.Text =
                $"Registros: {_contexto.VehiculoxSucursalLogica.CantidadRegistros} / {_contexto.VehiculoxSucursalLogica.Capacidad}";
        }
    }
}