/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Entidades. Clase que modela la categoría de vehículo.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-14
*/

using System;

namespace AutoMarket.Entidades
{
    public sealed class CategoriaVehiculo : IEquatable<CategoriaVehiculo>
    {
        private const int PrefijoIdCategoria = 1;

        private readonly int _idCategoria;
        private string _nombreCategoria = null!;
        private string _descripcion = null!;

        public int IdCategoria => _idCategoria;

        public string NombreCategoria
        {
            get => _nombreCategoria;
            private set
            {
                var nombre = NormalizarTexto(value);
                ValidarNombreCategoria(nombre);
                _nombreCategoria = nombre;
            }
        }

        public string Descripcion
        {
            get => _descripcion;
            private set
            {
                var descripcion = NormalizarTexto(value);
                ValidarDescripcion(descripcion);
                _descripcion = descripcion;
            }
        }

        public CategoriaVehiculo(int idCategoria, string nombreCategoria, string descripcion)
        {
            ValidarIdCategoria(idCategoria);

            _idCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
            Descripcion = descripcion;
        }

        public void ActualizarDatos(string nombreCategoria, string descripcion)
        {
            NombreCategoria = nombreCategoria;
            Descripcion = descripcion;
        }

        public bool EsValida()
        {
            if (!EsIdCategoriaValido(_idCategoria)) return false;
            if (string.IsNullOrWhiteSpace(_nombreCategoria)) return false;
            if (_nombreCategoria.Length > 60) return false;
            if (_descripcion == null) return false;
            if (_descripcion.Length > 200) return false;

            return true;
        }

        public string ObtenerResumen()
        {
            return $"{_nombreCategoria} - {_descripcion}";
        }

        public override string ToString()
        {
            return $"Id: {_idCategoria} | Nombre: {_nombreCategoria} | Descripción: {_descripcion}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as CategoriaVehiculo);
        }

        public bool Equals(CategoriaVehiculo? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return _idCategoria == other._idCategoria;
        }

        public override int GetHashCode()
        {
            return _idCategoria.GetHashCode();
        }

        public static bool operator ==(CategoriaVehiculo? left, CategoriaVehiculo? right)
        {
            if (ReferenceEquals(left, null)) return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        public static bool operator !=(CategoriaVehiculo? left, CategoriaVehiculo? right)
        {
            return !(left == right);
        }

        private static void ValidarIdCategoria(int idCategoria)
        {
            if (!EsIdCategoriaValido(idCategoria))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(idCategoria),
                    $"El IdCategoria debe ser un entero positivo y comenzar con el prefijo {PrefijoIdCategoria} (ej: 11, 12, 110).");
            }
        }

        private static bool EsIdCategoriaValido(int idCategoria)
        {
            if (idCategoria <= 0) return false;

            var idTexto = idCategoria.ToString();
            if (idTexto.Length < 2) return false;

            return idTexto[0] == (char)('0' + PrefijoIdCategoria);
        }

        private static void ValidarNombreCategoria(string nombreCategoria)
        {
            if (string.IsNullOrWhiteSpace(nombreCategoria))
            {
                throw new ArgumentException("El NombreCategoria es requerido.", nameof(nombreCategoria));
            }

            if (nombreCategoria.Length > 60)
            {
                throw new ArgumentException("El NombreCategoria no puede exceder 60 caracteres.", nameof(nombreCategoria));
            }
        }

        private static void ValidarDescripcion(string descripcion)
        {
            if (descripcion == null)
            {
                throw new ArgumentNullException(nameof(descripcion), "La Descripcion es requerida.");
            }

            if (descripcion.Length > 200)
            {
                throw new ArgumentException("La Descripcion no puede exceder 200 caracteres.", nameof(descripcion));
            }
        }

        private static string NormalizarTexto(string? texto)
        {
            return texto?.Trim() ?? string.Empty;
        }
    }
}