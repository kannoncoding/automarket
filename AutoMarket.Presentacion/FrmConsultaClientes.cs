/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Formulario de consulta de clientes.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-22
*/

using System;
using System.Windows.Forms;
using AutoMarket.Entidades;

namespace AutoMarket.Presentacion
{
    public partial class FrmConsultaClientes : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmConsultaClientes(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void FrmConsultaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarGrid();
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
                RefrescarGrid();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarGrid()
        {
            dgvClientes.Rows.Clear();

            var clientes = _contexto.ClienteLogica.ObtenerTodos();

            for (int i = 0; i < clientes.Length; i++)
            {
                var c = clientes[i];

                dgvClientes.Rows.Add(
                    c.IdCliente,
                    c.Nombre,
                    c.PrimerApellido,
                    c.SegundoApellido,
                    c.Cedula,
                    c.Telefono,
                    c.Correo,
                    c.FechaRegistro.ToShortDateString(),
                    c.Activo ? "Sí" : "No");
            }

            ActualizarEstado();
        }

        private void ActualizarEstado()
        {
            lblEstado.Text =
                $"Registros: {_contexto.ClienteLogica.CantidadRegistros} / {_contexto.ClienteLogica.Capacidad}";
        }
    }
}