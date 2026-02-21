/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Lógica de Negocio. Reglas y validaciones para la gestión de asociaciones Vehículo por Sucursal.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-20
*/

using System;
using AutoMarket.Datos;
using AutoMarket.Entidades;

namespace AutoMarket.Logica
{
    public sealed class VehiculoxSucursalLogica
    {
        private readonly VehiculoxSucursalDatos _datos;

        public int CantidadRegistros => _datos.CantidadRegistros;
        public int Capacidad => _datos.Capacidad;

        public VehiculoxSucursalLogica(SucursalDatos sucursalDatos, VehiculoDatos vehiculoDatos)
            : this(new VehiculoxSucursalDatos(sucursalDatos, vehiculoDatos))
        {
        }

        public VehiculoxSucursalLogica(VehiculoxSucursalDatos datos)
        {
            _datos = datos ?? throw new ArgumentNullException(nameof(datos), "La capa de datos es requerida.");
        }

        public VehiculoxSucursal Agregar(int idSucursal, int idVehiculo, int cantidad)
        {
            try
            {
                ValidarIdSucursal(idSucursal);
                ValidarIdVehiculo(idVehiculo);
                ValidarCantidad(cantidad);

                return _datos.Agregar(idSucursal, idVehiculo, cantidad);
            }
            catch (Exception ex) when (
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar la asociación Vehículo por Sucursal: {ex.Message}", ex);
            }
        }

        public void Agregar(VehiculoxSucursal asociacion)
        {
            try
            {
                if (asociacion == null)
                {
                    throw new ArgumentNullException(nameof(asociacion), "La asociación es requerida.");
                }

                if (!asociacion.EsValida())
                {
                    throw new ArgumentException("La asociación no es válida.", nameof(asociacion));
                }

                _datos.Agregar(asociacion);
            }
            catch (Exception ex) when (
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar la asociación Vehículo por Sucursal: {ex.Message}", ex);
            }
        }

        public VehiculoxSucursal[] ObtenerTodos()
        {
            try
            {
                return _datos.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"No se pudo consultar la lista de asociaciones: {ex.Message}", ex);
            }
        }

        public VehiculoxSucursal? ObtenerPorSucursalVehiculo(int idSucursal, int idVehiculo)
        {
            try
            {
                ValidarIdSucursal(idSucursal);
                ValidarIdVehiculo(idVehiculo);

                return _datos.ObtenerPorSucursalVehiculo(idSucursal, idVehiculo);
            }
            catch (Exception ex) when (
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo consultar la asociación por Sucursal/Vehículo: {ex.Message}", ex);
            }
        }

        public VehiculoxSucursal[] ObtenerPorSucursal(int idSucursal)
        {
            try
            {
                ValidarIdSucursal(idSucursal);

                return _datos.ObtenerPorSucursal(idSucursal);
            }
            catch (Exception ex) when (
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo consultar asociaciones por sucursal: {ex.Message}", ex);
            }
        }

        public bool ExisteAsociacion(int idSucursal, int idVehiculo)
        {
            if (idSucursal <= 0 || idVehiculo <= 0) return false;
            return _datos.ExisteAsociacion(idSucursal, idVehiculo);
        }

        private static void ValidarIdSucursal(int idSucursal)
        {
            if (idSucursal <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(idSucursal), "El IdSucursal debe ser un entero positivo.");
            }
        }

        private static void ValidarIdVehiculo(int idVehiculo)
        {
            if (idVehiculo <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(idVehiculo), "El IdVehiculo debe ser un entero positivo.");
            }
        }

        private static void ValidarCantidad(int cantidad)
        {
            if (cantidad < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La Cantidad no puede ser negativa.");
            }
        }
    }
}