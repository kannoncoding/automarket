/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de registro de sucursales con validación UX mínima y manejo de errores.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using System.Windows.Forms;

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
            ConfigurarControles();

            lblEstado.Text = ObtenerTextoEstado();
            txtNombre.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show(
                    "Debe completar los campos requeridos antes de registrar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                var sucursal = _contexto.SucursalLogica.Agregar(
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtCorreo.Text,
                    chkActiva.Checked);

                MessageBox.Show(
                    $"Registro exitoso.\n\n{sucursal}",
                    "AutoMarket",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
                lblEstado.Text = ObtenerTextoEstado();
                txtNombre.Focus();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo registrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombre.Focus();
        }

        private void ConfigurarControles()
        {
            txtNombre.MaxLength = 80;
            txtDireccion.MaxLength = 200;
            txtTelefono.MaxLength = 20;
            txtCorreo.MaxLength = 120;

            chkActiva.Checked = true;
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtDireccion.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtTelefono.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtCorreo.Text)) return false;

            return true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            chkActiva.Checked = true;
        }

        private string ObtenerTextoEstado()
        {
            return $"Registros: {_contexto.SucursalLogica.CantidadRegistros} / {_contexto.SucursalLogica.Capacidad}";
        }
    }
}