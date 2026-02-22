/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Contexto compartido de Presentación. Centraliza instancias únicas de Datos y Lógica para reutilización entre formularios y persistencia en memoria.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-21
*/

using System;
using AutoMarket.Datos;
using AutoMarket.Logica;

namespace AutoMarket.Presentacion
{
    public sealed class AutoMarketContexto
    {
        private readonly CategoriaVehiculoDatos _categoriaVehiculoDatos;
        private readonly VendedorDatos _vendedorDatos;
        private readonly SucursalDatos _sucursalDatos;
        private readonly ClienteDatos _clienteDatos;
        private readonly VehiculoDatos _vehiculoDatos;
        private readonly VehiculoxSucursalDatos _vehiculoxSucursalDatos;

        public CategoriaVehiculoLogica CategoriaVehiculoLogica { get; }
        public VehiculoLogica VehiculoLogica { get; }
        public VendedorLogica VendedorLogica { get; }
        public SucursalLogica SucursalLogica { get; }
        public ClienteLogica ClienteLogica { get; }
        public VehiculoxSucursalLogica VehiculoxSucursalLogica { get; }

        public AutoMarketContexto()
        {
            _categoriaVehiculoDatos = new CategoriaVehiculoDatos();
            _vendedorDatos = new VendedorDatos();
            _sucursalDatos = new SucursalDatos();
            _clienteDatos = new ClienteDatos();

            _vehiculoDatos = new VehiculoDatos(_categoriaVehiculoDatos);
            _vehiculoxSucursalDatos = new VehiculoxSucursalDatos(_sucursalDatos, _vehiculoDatos);

            CategoriaVehiculoLogica = new CategoriaVehiculoLogica(_categoriaVehiculoDatos);
            VendedorLogica = new VendedorLogica(_vendedorDatos);
            SucursalLogica = new SucursalLogica(_sucursalDatos);
            ClienteLogica = new ClienteLogica(_clienteDatos);

            VehiculoLogica = new VehiculoLogica(_vehiculoDatos);
            VehiculoxSucursalLogica = new VehiculoxSucursalLogica(_vehiculoxSucursalDatos);
        }

        public AutoMarketContexto(
            CategoriaVehiculoDatos categoriaVehiculoDatos,
            VehiculoDatos vehiculoDatos,
            VendedorDatos vendedorDatos,
            SucursalDatos sucursalDatos,
            ClienteDatos clienteDatos,
            VehiculoxSucursalDatos vehiculoxSucursalDatos)
        {
            _categoriaVehiculoDatos = categoriaVehiculoDatos ?? throw new ArgumentNullException(nameof(categoriaVehiculoDatos));
            _vehiculoDatos = vehiculoDatos ?? throw new ArgumentNullException(nameof(vehiculoDatos));
            _vendedorDatos = vendedorDatos ?? throw new ArgumentNullException(nameof(vendedorDatos));
            _sucursalDatos = sucursalDatos ?? throw new ArgumentNullException(nameof(sucursalDatos));
            _clienteDatos = clienteDatos ?? throw new ArgumentNullException(nameof(clienteDatos));
            _vehiculoxSucursalDatos = vehiculoxSucursalDatos ?? throw new ArgumentNullException(nameof(vehiculoxSucursalDatos));

            CategoriaVehiculoLogica = new CategoriaVehiculoLogica(_categoriaVehiculoDatos);
            VehiculoLogica = new VehiculoLogica(_vehiculoDatos);
            VendedorLogica = new VendedorLogica(_vendedorDatos);
            SucursalLogica = new SucursalLogica(_sucursalDatos);
            ClienteLogica = new ClienteLogica(_clienteDatos);
            VehiculoxSucursalLogica = new VehiculoxSucursalLogica(_vehiculoxSucursalDatos);
        }
    }
}