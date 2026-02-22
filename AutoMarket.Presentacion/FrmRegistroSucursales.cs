/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de registro de sucursales con selección de vendedor encargado.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using System.Windows.Forms;
using AutoMarket.Entidades;

namespace AutoMarket.Presentacion
{
    public partial class FrmRegistroSucursales : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmRegistroSucursales(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmRegistroSucursales_Load(object sender, EventArgs e)
        {
            try
            {
                CargarVendedores();
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
                    MessageBox.Show(
                        "Complete los campos requeridos antes de registrar.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (cboVendedorEncargado.SelectedItem is not Vendedor vendedor)
                {
                    MessageBox.Show(
                        "Debe seleccionar un vendedor encargado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                _contexto.SucursalLogica.Agregar(
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtCorreo.Text,
                    vendedor.IdVendedor,
                    chkActiva.Checked);

                MessageBox.Show(
                    "Sucursal registrada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

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

        private void CargarVendedores()
        {
            var vendedores = _contexto.VendedorLogica.ObtenerTodos();

            cboVendedorEncargado.BeginUpdate();
            cboVendedorEncargado.DataSource = null;

            // Para compilar sin depender de nombres de propiedades:
            // el ComboBox mostrará lo que devuelva Vendedor.ToString().
            cboVendedorEncargado.DataSource = vendedores;

            cboVendedorEncargado.EndUpdate();

            var hayVendedores = cboVendedorEncargado.Items.Count > 0;
            btnRegistrar.Enabled = hayVendedores;

            if (!hayVendedores)
            {
                MessageBox.Show(
                    "Debe registrar al menos un vendedor antes de registrar sucursales.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                cboVendedorEncargado.SelectedIndex = 0;
            }
        }

        private bool CamposMinimosValidos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtDireccion.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtTelefono.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtCorreo.Text)) return false;
            if (cboVendedorEncargado.SelectedItem is null) return false;

            return true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            chkActiva.Checked = false;

            if (cboVendedorEncargado.Items.Count > 0)
            {
                cboVendedorEncargado.SelectedIndex = 0;
            }

            txtNombre.Focus();
        }

        private void ActualizarEstado()
        {
            lblEstado.Text =
                $"Registros: {_contexto.SucursalLogica.CantidadRegistros} / {_contexto.SucursalLogica.Capacidad}";
        }
    }
}