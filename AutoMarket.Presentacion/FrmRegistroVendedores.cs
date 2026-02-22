/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de registro de vendedores con validación UX mínima y manejo de errores.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using System.Windows.Forms;
using AutoMarket.Entidades;

namespace AutoMarket.Presentacion
{
    public partial class FrmRegistroVendedores : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmRegistroVendedores(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmRegistroVendedores_Load(object sender, EventArgs e)
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
                var vendedor = _contexto.VendedorLogica.Agregar(
                    txtNombre.Text,
                    txtPrimerApellido.Text,
                    txtSegundoApellido.Text,
                    txtCedula.Text,
                    txtTelefono.Text,
                    txtCorreo.Text,
                    dtpFechaIngreso.Value.Date,
                    chkActivo.Checked);

                MessageBox.Show(
                    $"Registro exitoso.\n\n{vendedor}",
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
            txtNombre.MaxLength = 60;
            txtPrimerApellido.MaxLength = 60;
            txtSegundoApellido.MaxLength = 60;

            txtCedula.MaxLength = 20;
            txtTelefono.MaxLength = 20;
            txtCorreo.MaxLength = 120;

            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.MaxDate = DateTime.Today;
            dtpFechaIngreso.Value = DateTime.Today;

            chkActivo.Checked = true;
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtPrimerApellido.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtSegundoApellido.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtCedula.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtTelefono.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtCorreo.Text)) return false;

            return true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            dtpFechaIngreso.Value = DateTime.Today;
            chkActivo.Checked = true;
        }

        private string ObtenerTextoEstado()
        {
            return $"Registros: {_contexto.VendedorLogica.CantidadRegistros} / {_contexto.VendedorLogica.Capacidad}";
        }
    }
}