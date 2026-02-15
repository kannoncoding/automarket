/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Entidades. Clase que modela la categoría de vehículo.
Estudiante: Irus Exactus
Fecha de desarrollo: 2026-02-14
Herramientas de apoyo: ChatGPT (OpenAI)
*/

using System;

namespace AutoMarket.Entidades
{
    public sealed class CategoriaVehiculo : IEquatable<CategoriaVehiculo>
    {
        private int _idCategoria;
        private string _nombreCategoria;
        private string _descripcion;

        public int IdCategoria
        {
            get => _idCategoria;
            set
            {
                ValidarIdCategoria(value);
                _idCategoria = value;
            }
        }

        public string NombreCategoria
        {
            get => _nombreCategoria;
            set
            {
                var nombre = NormalizarTexto(value);
                ValidarNombreCategoria(nombre);
                _nombreCategoria = nombre;
            }
        }

        public string Descripcion
        {
            get => _descripcion;
            set
            {
                var descripcion = NormalizarTexto(value);
                ValidarDescripcion(descripcion);
                _descripcion = descripcion;
            }
        }

        public CategoriaVehiculo()
        {
            _idCategoria = 1;
            _nombreCategoria = "Sin categoría";
            _descripcion = "Sin descripción";
        }

        public CategoriaVehiculo(int idCategoria, string nombreCategoria, string descripcion)
        {
            ValidarIdCategoria(idCategoria);

            var nombre = NormalizarTexto(nombreCategoria);
            ValidarNombreCategoria(nombre);

            var desc = NormalizarTexto(descripcion);
            ValidarDescripcion(desc);

            _idCategoria = idCategoria;
            _nombreCategoria = nombre;
            _descripcion = desc;
        }

        public void ActualizarDatos(string nombreCategoria, string descripcion)
        {
            var nombre = NormalizarTexto(nombreCategoria);
            ValidarNombreCategoria(nombre);

            var desc = NormalizarTexto(descripcion);
            ValidarDescripcion(desc);

            _nombreCategoria = nombre;
            _descripcion = desc;
        }

        public bool EsValida()
        {
            if (_idCategoria <= 0) return false;
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

        public override bool Equals(object obj)
        {
            return Equals(obj as CategoriaVehiculo);
        }

        public bool Equals(CategoriaVehiculo other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(this, other)) return true;

            return _idCategoria == other._idCategoria;
        }

        public override int GetHashCode()
        {
            return _idCategoria.GetHashCode();
        }

        public static bool operator ==(CategoriaVehiculo left, CategoriaVehiculo right)
        {
            if (ReferenceEquals(left, null)) return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        public static bool operator !=(CategoriaVehiculo left, CategoriaVehiculo right)
        {
            return !(left == right);
        }

        private static void ValidarIdCategoria(int idCategoria)
        {
            if (idCategoria <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(idCategoria), "El IdCategoría debe ser mayor a cero.");
            }
        }

        private static void ValidarNombreCategoria(string nombreCategoria)
        {
            if (string.IsNullOrWhiteSpace(nombreCategoria))
            {
                throw new ArgumentException("El NombreCategoría es requerido.", nameof(nombreCategoria));
            }

            if (nombreCategoria.Length > 60)
            {
                throw new ArgumentException("El NombreCategoría no puede exceder 60 caracteres.", nameof(nombreCategoria));
            }
        }

        private static void ValidarDescripcion(string descripcion)
        {
            if (descripcion == null)
            {
                throw new ArgumentNullException(nameof(descripcion), "La Descripción es requerida.");
            }

            if (descripcion.Length > 200)
            {
                throw new ArgumentException("La Descripción no puede exceder 200 caracteres.", nameof(descripcion));
            }
        }

        private static string NormalizarTexto(string texto)
        {
            if (texto == null) return null;
            return texto.Trim();
        }
    }
}
