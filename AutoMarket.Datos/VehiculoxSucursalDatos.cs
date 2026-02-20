/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Acceso a Datos. Almacenamiento en memoria de asociaciones Vehículo por Sucursal mediante arreglos y validación de referencias.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-18
*/

using System;
using AutoMarket.Entidades;

namespace AutoMarket.Datos
{
    public sealed class VehiculoxSucursalDatos
    {
        private const int CapacidadMaxima = 100;

        private readonly VehiculoxSucursal?[] _asociaciones;
        private int _cantidadRegistros;

        private readonly SucursalDatos _sucursalDatos;
        private readonly VehiculoDatos _vehiculoDatos;

        public int CantidadRegistros => _cantidadRegistros;
        public int Capacidad => CapacidadMaxima;

        public VehiculoxSucursalDatos(SucursalDatos sucursalDatos, VehiculoDatos vehiculoDatos)
        {
            _sucursalDatos = sucursalDatos ?? throw new ArgumentNullException(
                nameof(sucursalDatos),
                "El acceso a datos de sucursales es requerido para validar referencias.");

            _vehiculoDatos = vehiculoDatos ?? throw new ArgumentNullException(
                nameof(vehiculoDatos),
                "El acceso a datos de vehículos es requerido para validar referencias.");

            _asociaciones = new VehiculoxSucursal[CapacidadMaxima];
            _cantidadRegistros = 0;
        }

        public VehiculoxSucursal Agregar(int idSucursal, int idVehiculo, int cantidad)
        {
            ValidarCapacidadDisponible();

            var sucursal = _sucursalDatos.ObtenerPorId(idSucursal);
            if (sucursal is null)
            {
                throw new ArgumentException(
                    $"La sucursal indicada no existe. IdSucursal: {idSucursal}.",
                    nameof(idSucursal));
            }

            var vehiculo = _vehiculoDatos.ObtenerPorId(idVehiculo);
            if (vehiculo is null)
            {
                throw new ArgumentException(
                    $"El vehículo indicado no existe. IdVehiculo: {idVehiculo}.",
                    nameof(idVehiculo));
            }

            ValidarDuplicadoAsociacion(idSucursal, idVehiculo);

            var nuevaAsociacion = new VehiculoxSucursal(sucursal, vehiculo, cantidad);

            _asociaciones[_cantidadRegistros] = nuevaAsociacion;
            _cantidadRegistros++;

            return nuevaAsociacion;
        }

        public void Agregar(VehiculoxSucursal asociacion)
        {
            if (asociacion == null)
            {
                throw new ArgumentNullException(nameof(asociacion), "La asociación es requerida.");
            }

            if (!asociacion.EsValida())
            {
                throw new ArgumentException("La asociación no es válida.", nameof(asociacion));
            }

            ValidarCapacidadDisponible();

            var idSucursal = asociacion.Sucursal.IdSucursal;
            var idVehiculo = asociacion.Vehiculo.IdVehiculo;

            if (!_sucursalDatos.ExisteId(idSucursal))
            {
                throw new ArgumentException(
                    $"La sucursal asociada no existe en el registro. IdSucursal: {idSucursal}.",
                    nameof(asociacion));
            }

            if (!_vehiculoDatos.ExisteId(idVehiculo))
            {
                throw new ArgumentException(
                    $"El vehículo asociado no existe en el registro. IdVehiculo: {idVehiculo}.",
                    nameof(asociacion));
            }

            ValidarDuplicadoAsociacion(idSucursal, idVehiculo);

            _asociaciones[_cantidadRegistros] = asociacion;
            _cantidadRegistros++;
        }

        public VehiculoxSucursal[] ObtenerTodos()
        {
            var resultado = new VehiculoxSucursal[_cantidadRegistros];

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                resultado[i] = _asociaciones[i]!;
            }

            return resultado;
        }

        public VehiculoxSucursal? ObtenerPorSucursalVehiculo(int idSucursal, int idVehiculo)
        {
            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var asociacion = _asociaciones[i];

                if (asociacion is not null
                    && asociacion.Sucursal.IdSucursal == idSucursal
                    && asociacion.Vehiculo.IdVehiculo == idVehiculo)
                {
                    return asociacion;
                }
            }

            return null;
        }

        public VehiculoxSucursal[] ObtenerPorSucursal(int idSucursal)
        {
            var conteo = 0;

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var asociacion = _asociaciones[i];

                if (asociacion is not null && asociacion.Sucursal.IdSucursal == idSucursal)
                {
                    conteo++;
                }
            }

            var resultado = new VehiculoxSucursal[conteo];
            var indice = 0;

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var asociacion = _asociaciones[i];

                if (asociacion is not null && asociacion.Sucursal.IdSucursal == idSucursal)
                {
                    resultado[indice] = asociacion;
                    indice++;
                }
            }

            return resultado;
        }

        public bool ExisteAsociacion(int idSucursal, int idVehiculo)
        {
            return ObtenerPorSucursalVehiculo(idSucursal, idVehiculo) != null;
        }

        private void ValidarDuplicadoAsociacion(int idSucursal, int idVehiculo)
        {
            if (ExisteAsociacion(idSucursal, idVehiculo))
            {
                throw new ArgumentException(
                    $"Ya existe una asociación para la Sucursal {idSucursal} y el Vehículo {idVehiculo}.",
                    nameof(idSucursal));
            }
        }

        private void ValidarCapacidadDisponible()
        {
            if (_cantidadRegistros >= CapacidadMaxima)
            {
                throw new InvalidOperationException(
                    $"No se pueden agregar más asociaciones. Capacidad máxima: {CapacidadMaxima}.");
            }
        }
    }
}