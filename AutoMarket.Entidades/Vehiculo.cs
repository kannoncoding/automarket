/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Entidades. Clase que modela el vehículo registrado en AutoMarket.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-15
*/

using System;

namespace AutoMarket.Entidades
{
    public sealed class Vehiculo : IEquatable<Vehiculo>
    {
        private const int PrefijoIdVehiculo = 2;

        private readonly int _idVehiculo;
        private string _marca = null!;
        private string _modelo = null!;
        private int _anio;
        private decimal _precio;
        private CategoriaVehiculo _categoria = null!;
        private char _estado;

        public int IdVehiculo => _idVehiculo;

        public string Marca
        {
            get => _marca;
            private set
            {
                var marca = NormalizarTexto(value);
                ValidarMarca(marca);
                _marca = marca;
            }
        }

        public string Modelo
        {
            get => _modelo;
            private set
            {
                var modelo = NormalizarTexto(value);
                ValidarModelo(modelo);
                _modelo = modelo;
            }
        }

        public int Anio
        {
            get => _anio;
            private set
            {
                ValidarAnio(value);
                _anio = value;
            }
        }

        public decimal Precio
        {
            get => _precio;
            private set
            {
                ValidarPrecio(value);
                _precio = value;
            }
        }

        public CategoriaVehiculo Categoria
        {
            get => _categoria;
            private set
            {
                ValidarCategoria(value);
                _categoria = value;
            }
        }

        public char Estado
        {
            get => _estado;
            private set
            {
                ValidarEstado(value);
                _estado = char.ToUpperInvariant(value);
            }
        }

        public string EstadoTexto => _estado == 'N' ? "Nuevo" : "Usado";

        public Vehiculo(
            int idVehiculo,
            string marca,
            string modelo,
            int anio,
            decimal precio,
            CategoriaVehiculo categoria,
            char estado)
        {
            ValidarIdVehiculo(idVehiculo);

            _idVehiculo = idVehiculo;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
            Categoria = categoria;
            Estado = estado;
        }

        public void ActualizarDatos(
            string marca,
            string modelo,
            int anio,
            decimal precio,
            CategoriaVehiculo categoria,
            char estado)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
            Categoria = categoria;
            Estado = estado;
        }

        public bool EsValida()
        {
            if (!EsIdVehiculoValido(_idVehiculo)) return false;
            if (string.IsNullOrWhiteSpace(_marca)) return false;
            if (string.IsNullOrWhiteSpace(_modelo)) return false;
            if (!EsAnioValido(_anio)) return false;
            if (_precio <= 0m) return false;
            if (_categoria is null) return false;
            if (!EsEstadoValido(_estado)) return false;

            return true;
        }

        public string ObtenerResumen()
        {
            return $"{_marca} {_modelo} ({_anio}) - {EstadoTexto} - ₡{_precio:N2}";
        }

        public override string ToString()
        {
            return $"Id: {_idVehiculo} | Marca: {_marca} | Modelo: {_modelo} | Año: {_anio} | Precio: {_precio:N2} | Categoría: {_categoria?.NombreCategoria} | Estado: {EstadoTexto}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Vehiculo);
        }

        public bool Equals(Vehiculo? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return _idVehiculo == other._idVehiculo;
        }

        public override int GetHashCode()
        {
            return _idVehiculo.GetHashCode();
        }

        public static bool operator ==(Vehiculo? left, Vehiculo? right)
        {
            if (ReferenceEquals(left, null)) return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        public static bool operator !=(Vehiculo? left, Vehiculo? right)
        {
            return !(left == right);
        }

        private static void ValidarIdVehiculo(int idVehiculo)
        {
            if (!EsIdVehiculoValido(idVehiculo))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(idVehiculo),
                    $"El IdVehiculo debe ser un entero positivo y comenzar con el prefijo {PrefijoIdVehiculo} (ej: 21, 22, 210).");
            }
        }

        private static bool EsIdVehiculoValido(int idVehiculo)
        {
            if (idVehiculo <= 0) return false;

            var idTexto = idVehiculo.ToString();
            if (idTexto.Length < 2) return false;

            return idTexto[0] == (char)('0' + PrefijoIdVehiculo);
        }

        private static void ValidarMarca(string marca)
        {
            if (string.IsNullOrWhiteSpace(marca))
            {
                throw new ArgumentException("La Marca es requerida.", nameof(marca));
            }
        }

        private static void ValidarModelo(string modelo)
        {
            if (string.IsNullOrWhiteSpace(modelo))
            {
                throw new ArgumentException("El Modelo es requerido.", nameof(modelo));
            }
        }

        private static void ValidarAnio(int anio)
        {
            if (!EsAnioValido(anio))
            {
                throw new ArgumentOutOfRangeException(nameof(anio), $"El Año debe estar entre 1886 y {ObtenerAnioMaximoPermitido()}.");
            }
        }

        private static bool EsAnioValido(int anio)
        {
            return anio >= 1886 && anio <= ObtenerAnioMaximoPermitido();
        }

        private static int ObtenerAnioMaximoPermitido()
        {
            return DateTime.Now.Year + 1;
        }

        private static void ValidarPrecio(decimal precio)
        {
            if (precio <= 0m)
            {
                throw new ArgumentOutOfRangeException(nameof(precio), "El Precio debe ser mayor a cero.");
            }
        }

        private static void ValidarCategoria(CategoriaVehiculo? categoria)
        {
            if (categoria is null)
            {
                throw new ArgumentNullException(nameof(categoria), "La Categoría es requerida.");
            }
        }

        private static void ValidarEstado(char estado)
        {
            if (!EsEstadoValido(estado))
            {
                throw new ArgumentException("El Estado debe ser 'N' (Nuevo) o 'U' (Usado).", nameof(estado));
            }
        }

        private static bool EsEstadoValido(char estado)
        {
            var e = char.ToUpperInvariant(estado);
            return e == 'N' || e == 'U';
        }

        private static string NormalizarTexto(string? texto)
        {
            return texto?.Trim() ?? string.Empty;
        }
    }
}
