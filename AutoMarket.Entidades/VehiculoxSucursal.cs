/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Entidades. Clase que modela la asociación de vehículos disponibles por sucursal.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-16
*/

using System;

namespace AutoMarket.Entidades
{
    public sealed class VehiculoxSucursal : IEquatable<VehiculoxSucursal>
    {
        private Sucursal _sucursal = null!;
        private Vehiculo _vehiculo = null!;
        private int _cantidad;

        public Sucursal Sucursal
        {
            get => _sucursal;
            private set
            {
                ValidarSucursal(value);
                _sucursal = value;
            }
        }

        public Vehiculo Vehiculo
        {
            get => _vehiculo;
            private set
            {
                ValidarVehiculo(value);
                _vehiculo = value;
            }
        }

        public int Cantidad
        {
            get => _cantidad;
            private set
            {
                ValidarCantidad(value);
                _cantidad = value;
            }
        }

        public VehiculoxSucursal(Sucursal sucursal, Vehiculo vehiculo, int cantidad)
        {
            Sucursal = sucursal;
            Vehiculo = vehiculo;
            Cantidad = cantidad;
        }

        public void ActualizarCantidad(int cantidad)
        {
            Cantidad = cantidad;
        }

        public void Incrementar(int incremento)
        {
            ValidarIncremento(incremento);
            Cantidad = checked(_cantidad + incremento);
        }

        public void Disminuir(int disminucion)
        {
            ValidarDisminucion(disminucion);

            var nuevaCantidad = _cantidad - disminucion;

            if (nuevaCantidad < 0)
                throw new ArgumentOutOfRangeException(nameof(disminucion), "La disminución no puede dejar la cantidad en un valor negativo.");

            Cantidad = nuevaCantidad;
        }

        public bool EsValida()
        {
            if (_sucursal is null) return false;
            if (_vehiculo is null) return false;
            if (_cantidad < 0) return false;

            return true;
        }

        public string ObtenerResumen()
        {
            return $"Sucursal: {_sucursal.Nombre} ({_sucursal.IdSucursal}) | Vehículo: {_vehiculo.Marca} {_vehiculo.Modelo} ({_vehiculo.IdVehiculo}) | Cantidad: {_cantidad}";
        }

        public override string ToString()
        {
            return $"Sucursal: {_sucursal.IdSucursal} - {_sucursal.Nombre} | Vehículo: {_vehiculo.IdVehiculo} - {_vehiculo.Marca} {_vehiculo.Modelo} | Cantidad: {_cantidad}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as VehiculoxSucursal);
        }

        public bool Equals(VehiculoxSucursal? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return _sucursal.IdSucursal == other._sucursal.IdSucursal
                && _vehiculo.IdVehiculo == other._vehiculo.IdVehiculo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_sucursal.IdSucursal, _vehiculo.IdVehiculo);
        }

        public static bool operator ==(VehiculoxSucursal? left, VehiculoxSucursal? right)
        {
            if (ReferenceEquals(left, null)) return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        public static bool operator !=(VehiculoxSucursal? left, VehiculoxSucursal? right)
        {
            return !(left == right);
        }

        private static void ValidarSucursal(Sucursal? sucursal)
        {
            if (sucursal is null)
                throw new ArgumentNullException(nameof(sucursal), "La Sucursal es requerida.");
        }

        private static void ValidarVehiculo(Vehiculo? vehiculo)
        {
            if (vehiculo is null)
                throw new ArgumentNullException(nameof(vehiculo), "El Vehículo es requerido.");
        }

        private static void ValidarCantidad(int cantidad)
        {
            if (cantidad < 0)
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La Cantidad no puede ser negativa.");
        }

        private static void ValidarIncremento(int incremento)
        {
            if (incremento <= 0)
                throw new ArgumentOutOfRangeException(nameof(incremento), "El incremento debe ser mayor a cero.");
        }

        private static void ValidarDisminucion(int disminucion)
        {
            if (disminucion <= 0)
                throw new ArgumentOutOfRangeException(nameof(disminucion), "La disminución debe ser mayor a cero.");
        }
    }
}
