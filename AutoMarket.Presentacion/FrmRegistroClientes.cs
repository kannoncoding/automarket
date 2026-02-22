/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de registro de clientes.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-22
*/

using System;
using System.Windows.Forms;

namespace AutoMarket.Presentacion
{
    public partial class FrmRegistroClientes : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmRegistroClientes(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmRegistroClientes_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaRegistro.Value = DateTime.Today;
                chkActivo.Checked = true;
                ActualizarEstado();
                txtNombre.Focus();
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

                _contexto.ClienteLogica.Agregar(
                    txtNombre.Text,
                    txtPrimerApellido.Text,
                    txtSegundoApellido.Text,
                    txtCedula.Text,
                    txtTelefono.Text,
                    txtCorreo.Text,
                    dtpFechaRegistro.Value.Date,
                    chkActivo.Checked);

                MessageBox.Show(
                    "Cliente registrado correctamente.",
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

        private bool CamposMinimosValidos()
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
            dtpFechaRegistro.Value = DateTime.Today;
            chkActivo.Checked = true;

            txtNombre.Focus();
        }

        private void ActualizarEstado()
        {
            lblEstado.Text =
                $"Registros: {_contexto.ClienteLogica.CantidadRegistros} / {_contexto.ClienteLogica.Capacidad}";
        }
    }
}