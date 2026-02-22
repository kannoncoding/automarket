/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de registro de vehículos con selección de categoría y estado, validación UX mínima y manejo de errores.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using System.Globalization;
using System.Windows.Forms;
using AutoMarket.Entidades;

namespace AutoMarket.Presentacion
{
    public partial class FrmRegistroVehiculos : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmRegistroVehiculos(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmRegistroVehiculos_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            CargarCategorias();
            CargarEstados();

            lblEstado.Text = ObtenerTextoEstado();
            txtMarca.Focus();
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
                var categoria = (CategoriaVehiculo)cmbCategoria.SelectedItem;

                var marca = txtMarca.Text;
                var modelo = txtModelo.Text;
                var anio = (int)nudAnio.Value;
                var precio = nudPrecio.Value;
                var estadoUi = cmbEstado.SelectedItem;

                var vehiculo = _contexto.VehiculoLogica.Agregar(
                    marca,
                    modelo,
                    anio,
                    precio,
                    categoria.IdCategoria,
                    estadoUi!);

                MessageBox.Show(
                    $"Registro exitoso.\n\n{vehiculo}",
                    "AutoMarket",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
                lblEstado.Text = ObtenerTextoEstado();
                txtMarca.Focus();
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
            txtMarca.Focus();
        }

        private void ConfigurarControles()
        {
            var maximoAnio = DateTime.Now.Year + 1;

            nudAnio.Minimum = 1886;
            nudAnio.Maximum = maximoAnio;
            nudAnio.Value = maximoAnio;

            nudPrecio.Minimum = 0.01m;
            nudPrecio.Maximum = 9999999999m;
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.ThousandsSeparator = true;
            nudPrecio.Value = 0.01m;

            txtMarca.MaxLength = 60;
            txtModelo.MaxLength = 60;

            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarCategorias()
        {
            cmbCategoria.Items.Clear();

            var categorias = _contexto.CategoriaVehiculoLogica.ObtenerTodos();

            for (int i = 0; i < categorias.Length; i++)
            {
                cmbCategoria.Items.Add(categorias[i]);
            }

            if (cmbCategoria.Items.Count > 0)
            {
                cmbCategoria.SelectedIndex = 0;
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;

                MessageBox.Show(
                    "No existen categorías registradas. Debe registrar al menos una categoría antes de registrar vehículos.",
                    "AutoMarket",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Nuevo");
            cmbEstado.Items.Add("Usado");
            cmbEstado.SelectedIndex = 0;
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtModelo.Text)) return false;
            if (cmbCategoria.SelectedItem is not CategoriaVehiculo) return false;
            if (cmbEstado.SelectedItem == null) return false;

            return true;
        }

        private void LimpiarFormulario()
        {
            txtMarca.Clear();
            txtModelo.Clear();

            nudAnio.Value = nudAnio.Maximum;
            nudPrecio.Value = nudPrecio.Minimum;

            if (cmbCategoria.Items.Count > 0)
            {
                cmbCategoria.SelectedIndex = 0;
            }

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }
        }

        private string ObtenerTextoEstado()
        {
            return $"Registros: {_contexto.VehiculoLogica.CantidadRegistros} / {_contexto.VehiculoLogica.Capacidad}";
        }
    }
}