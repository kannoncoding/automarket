/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Presentación. Menú principal con navegación a formularios de registro y consulta utilizando contexto compartido.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using System.Windows.Forms;

namespace AutoMarket.Presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private readonly AutoMarketContexto _contexto;

        public FrmMenuPrincipal(AutoMarketContexto contexto)
        {
            _contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            InitializeComponent();
        }

        private void btnRegistroCategorias_Click(object sender, EventArgs e)
        {
            using var frm = new FrmRegistroCategorias(_contexto);
            frm.ShowDialog(this);
        }

        private void btnConsultaCategorias_Click(object sender, EventArgs e)
        {
            using var frm = new FrmConsultaCategorias(_contexto);
            frm.ShowDialog(this);
        }

        private void btnRegistroVehiculos_Click(object sender, EventArgs e)
        {
            using var frm = new FrmRegistroVehiculos(_contexto);
            frm.ShowDialog(this);
        }

        private void btnConsultaVehiculos_Click(object sender, EventArgs e)
        {
            using var frm = new FrmConsultaVehiculos(_contexto);
            frm.ShowDialog(this);
        }

        private void btnRegistroVendedores_Click(object sender, EventArgs e)
        {
            using var frm = new FrmRegistroVendedores(_contexto);
            frm.ShowDialog(this);
        }

        private void btnConsultaVendedores_Click(object sender, EventArgs e)
        {
            using var frm = new FrmConsultaVendedores(_contexto);
            frm.ShowDialog(this);
        }

        private void btnRegistroSucursales_Click(object sender, EventArgs e)
        {
            using var frm = new FrmRegistroSucursales(_contexto);
            frm.ShowDialog(this);
        }

        private void btnConsultaSucursales_Click(object sender, EventArgs e)
        {
            using var frm = new FrmConsultaSucursales(_contexto);
            frm.ShowDialog(this);
        }

        private void btnRegistroClientes_Click(object sender, EventArgs e)
        {
            using var frm = new FrmRegistroClientes(_contexto);
            frm.ShowDialog(this);
        }

        private void btnConsultaClientes_Click(object sender, EventArgs e)
        {
            using var frm = new FrmConsultaClientes(_contexto);
            frm.ShowDialog(this);
        }

        private void btnRegistroVehiculosSucursal_Click(object sender, EventArgs e)
        {
            using var frm = new FrmRegistroVehiculoxSucursal(_contexto);
            frm.ShowDialog(this);
        }

        private void btnConsultaVehiculosSucursal_Click(object sender, EventArgs e)
        {
            using var frm = new FrmConsultaVehiculoxSucursal(_contexto);
            frm.ShowDialog(this);
        }
    }
}