/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Lógica de Negocio. Reglas y validaciones para la gestión de categorías de vehículo.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-20
*/

using System;
using AutoMarket.Datos;
using AutoMarket.Entidades;

namespace AutoMarket.Logica
{
    public sealed class CategoriaVehiculoLogica
    {
        private readonly CategoriaVehiculoDatos _datos;

        public int CantidadRegistros => _datos.CantidadRegistros;
        public int Capacidad => _datos.Capacidad;

        public CategoriaVehiculoLogica()
            : this(new CategoriaVehiculoDatos())
        {
        }

        public CategoriaVehiculoLogica(CategoriaVehiculoDatos datos)
        {
            _datos = datos ?? throw new ArgumentNullException(nameof(datos), "La capa de datos es requerida.");
        }

        public CategoriaVehiculo Agregar(string nombreCategoria, string descripcion)
        {
            try
            {
                var nombreNormalizado = NormalizarTexto(nombreCategoria);
                var descripcionNormalizada = NormalizarTexto(descripcion);

                ValidarNombreCategoria(nombreNormalizado);
                ValidarDescripcion(descripcionNormalizada);

                return _datos.Agregar(nombreNormalizado, descripcionNormalizada);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar la categoría de vehículo: {ex.Message}", ex);
            }
        }

        public void Agregar(CategoriaVehiculo categoriaVehiculo)
        {
            try
            {
                if (categoriaVehiculo == null)
                {
                    throw new ArgumentNullException(nameof(categoriaVehiculo), "La categoría es requerida.");
                }

                if (!categoriaVehiculo.EsValida())
                {
                    throw new ArgumentException("La categoría no es válida.", nameof(categoriaVehiculo));
                }

                _datos.Agregar(categoriaVehiculo);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar la categoría de vehículo: {ex.Message}", ex);
            }
        }

        public CategoriaVehiculo[] ObtenerTodos()
        {
            try
            {
                return _datos.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"No se pudo consultar la lista de categorías: {ex.Message}", ex);
            }
        }

        public CategoriaVehiculo? ObtenerPorId(int idCategoria)
        {
            try
            {
                if (idCategoria <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(idCategoria), "El IdCategoria debe ser un entero positivo.");
                }

                return _datos.ObtenerPorId(idCategoria);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is ArgumentOutOfRangeException || ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo consultar la categoría por Id: {ex.Message}", ex);
            }
        }

        public bool ExisteId(int idCategoria)
        {
            if (idCategoria <= 0) return false;
            return _datos.ExisteId(idCategoria);
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