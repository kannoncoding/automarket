/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Lógica de Negocio. Reglas y validaciones para la gestión de vehículos.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-20
*/

using System;
using AutoMarket.Datos;
using AutoMarket.Entidades;

namespace AutoMarket.Logica
{
    public sealed class VehiculoLogica
    {
        private readonly VehiculoDatos _datos;

        public int CantidadRegistros => _datos.CantidadRegistros;
        public int Capacidad => _datos.Capacidad;

        public VehiculoLogica(CategoriaVehiculoDatos categoriaVehiculoDatos)
            : this(new VehiculoDatos(categoriaVehiculoDatos))
        {
        }

        public VehiculoLogica(VehiculoDatos datos)
        {
            _datos = datos ?? throw new ArgumentNullException(nameof(datos), "La capa de datos es requerida.");
        }

        public Vehiculo Agregar(
            string marca,
            string modelo,
            int anio,
            decimal precio,
            int idCategoria,
            object estadoUi)
        {
            try
            {
                var marcaNormalizada = NormalizarTexto(marca);
                var modeloNormalizado = NormalizarTexto(modelo);

                ValidarMarca(marcaNormalizada);
                ValidarModelo(modeloNormalizado);
                ValidarAnio(anio);
                ValidarPrecio(precio);

                var estado = ConvertirEstadoUiADominio(estadoUi);

                return _datos.Agregar(marcaNormalizada, modeloNormalizado, anio, precio, idCategoria, estado);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is ArgumentOutOfRangeException || ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar el vehículo: {ex.Message}", ex);
            }
        }

        public Vehiculo Agregar(
            string marca,
            string modelo,
            int anio,
            decimal precio,
            int idCategoria,
            char estado)
        {
            try
            {
                var marcaNormalizada = NormalizarTexto(marca);
                var modeloNormalizado = NormalizarTexto(modelo);

                ValidarMarca(marcaNormalizada);
                ValidarModelo(modeloNormalizado);
                ValidarAnio(anio);
                ValidarPrecio(precio);
                ValidarEstado(estado);

                return _datos.Agregar(marcaNormalizada, modeloNormalizado, anio, precio, idCategoria, estado);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is ArgumentOutOfRangeException || ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar el vehículo: {ex.Message}", ex);
            }
        }

        public void Agregar(Vehiculo vehiculo)
        {
            try
            {
                if (vehiculo == null)
                {
                    throw new ArgumentNullException(nameof(vehiculo), "El vehículo es requerido.");
                }

                if (!vehiculo.EsValido())
                {
                    throw new ArgumentException("El vehículo no es válido.", nameof(vehiculo));
                }

                _datos.Agregar(vehiculo);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is ArgumentOutOfRangeException || ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar el vehículo: {ex.Message}", ex);
            }
        }

        public Vehiculo[] ObtenerTodos()
        {
            try
            {
                return _datos.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"No se pudo consultar la lista de vehículos: {ex.Message}", ex);
            }
        }

        public Vehiculo? ObtenerPorId(int idVehiculo)
        {
            try
            {
                if (idVehiculo <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(idVehiculo), "El IdVehiculo debe ser un entero positivo.");
                }

                return _datos.ObtenerPorId(idVehiculo);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is ArgumentOutOfRangeException || ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo consultar el vehículo por Id: {ex.Message}", ex);
            }
        }

        public bool ExisteId(int idVehiculo)
        {
            if (idVehiculo <= 0) return false;
            return _datos.ExisteId(idVehiculo);
        }

        public static string ConvertirEstadoDominioATexto(char estado)
        {
            var e = char.ToUpperInvariant(estado);
            if (e == 'N') return "Nuevo";
            if (e == 'U') return "Usado";

            throw new ArgumentException("El Estado debe ser 'N' (Nuevo) o 'U' (Usado).", nameof(estado));
        }

        private static char ConvertirEstadoUiADominio(object estadoUi)
        {
            if (estadoUi == null)
            {
                throw new ArgumentNullException(nameof(estadoUi), "El Estado es requerido.");
            }

            if (estadoUi is char c)
            {
                ValidarEstado(c);
                return char.ToUpperInvariant(c);
            }

            var texto = NormalizarTexto(estadoUi.ToString());

            if (texto.Equals("N", StringComparison.OrdinalIgnoreCase) ||
                texto.Equals("Nuevo", StringComparison.OrdinalIgnoreCase))
            {
                return 'N';
            }

            if (texto.Equals("U", StringComparison.OrdinalIgnoreCase) ||
                texto.Equals("Usado", StringComparison.OrdinalIgnoreCase))
            {
                return 'U';
            }

            throw new ArgumentException("El Estado es inválido. Valores permitidos: 'N', 'U', 'Nuevo' o 'Usado'.", nameof(estadoUi));
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
            var maximo = DateTime.Now.Year + 1;

            if (anio < 1886 || anio > maximo)
            {
                throw new ArgumentOutOfRangeException(nameof(anio), $"El Año debe estar entre 1886 y {maximo}.");
            }
        }

        private static void ValidarPrecio(decimal precio)
        {
            if (precio <= 0m)
            {
                throw new ArgumentOutOfRangeException(nameof(precio), "El Precio debe ser mayor a cero.");
            }
        }

        private static void ValidarEstado(char estado)
        {
            var e = char.ToUpperInvariant(estado);
            if (e != 'N' && e != 'U')
            {
                throw new ArgumentException("El Estado debe ser 'N' (Nuevo) o 'U' (Usado).", nameof(estado));
            }
        }

        private static string NormalizarTexto(string? texto)
        {
            return texto?.Trim() ?? string.Empty;
        }
    }
}