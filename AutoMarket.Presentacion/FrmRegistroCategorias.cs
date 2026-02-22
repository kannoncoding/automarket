/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de registro de categorías de vehículo con validación UX mínima y manejo de errores.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using System.Windows.Forms;
using AutoMarket.Entidades;

namespace AutoMarket.Presentacion
{
    public partial class FrmRegistroCategorias : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmRegistroCategorias(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmRegistroCategorias_Load(object sender, EventArgs e)
        {
            lblEstado.Text = ObtenerTextoEstado();
            txtNombreCategoria.Focus();
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
                var nombre = txtNombreCategoria.Text;
                var descripcion = txtDescripcion.Text;

                CategoriaVehiculo categoria = _contexto.CategoriaVehiculoLogica.Agregar(nombre, descripcion);

                MessageBox.Show(
                    $"Registro exitoso.\n\n{categoria}",
                    "AutoMarket",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
                lblEstado.Text = ObtenerTextoEstado();
                txtNombreCategoria.Focus();
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
            txtNombreCategoria.Focus();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text)) return false;
            if (txtDescripcion.Text == null) return false;

            return true;
        }

        private void LimpiarFormulario()
        {
            txtNombreCategoria.Clear();
            txtDescripcion.Clear();
        }

        private string ObtenerTextoEstado()
        {
            return $"Registros: {_contexto.CategoriaVehiculoLogica.CantidadRegistros} / {_contexto.CategoriaVehiculoLogica.Capacidad}";
        }
    }
}