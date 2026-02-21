/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Lógica de Negocio. Reglas y validaciones para la gestión de sucursales.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-20
*/

using System;
using AutoMarket.Datos;
using AutoMarket.Entidades;

namespace AutoMarket.Logica
{
    public sealed class SucursalLogica
    {
        private readonly SucursalDatos _datos;

        public int CantidadRegistros => _datos.CantidadRegistros;
        public int Capacidad => _datos.Capacidad;

        public SucursalLogica()
            : this(new SucursalDatos())
        {
        }

        public SucursalLogica(SucursalDatos datos)
        {
            _datos = datos ?? throw new ArgumentNullException(nameof(datos), "La capa de datos es requerida.");
        }

        public Sucursal Agregar(
            string nombre,
            string direccion,
            string telefono,
            string correo,
            bool activa)
        {
            try
            {
                var nombreNormalizado = NormalizarTexto(nombre);
                var direccionNormalizada = NormalizarTexto(direccion);
                var telefonoNormalizado = NormalizarTexto(telefono);
                var correoNormalizado = NormalizarTexto(correo);

                ValidarNombre(nombreNormalizado);
                ValidarDireccion(direccionNormalizada);
                ValidarTelefono(telefonoNormalizado);
                ValidarCorreo(correoNormalizado);

                if (_datos.ExisteCorreo(correoNormalizado))
                {
                    throw new ArgumentException($"Ya existe una sucursal con el Correo {correoNormalizado}.", nameof(correo));
                }

                return _datos.Agregar(
                    nombreNormalizado,
                    direccionNormalizada,
                    telefonoNormalizado,
                    correoNormalizado,
                    activa);
            }
            catch (Exception ex) when (
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar la sucursal: {ex.Message}", ex);
            }
        }

        public void Agregar(Sucursal sucursal)
        {
            try
            {
                if (sucursal == null)
                {
                    throw new ArgumentNullException(nameof(sucursal), "La sucursal es requerida.");
                }

                if (!sucursal.EsValida())
                {
                    throw new ArgumentException("La sucursal no es válida.", nameof(sucursal));
                }

                if (_datos.ExisteCorreo(sucursal.Correo))
                {
                    throw new ArgumentException($"Ya existe una sucursal con el Correo {NormalizarTexto(sucursal.Correo)}.", nameof(sucursal));
                }

                _datos.Agregar(sucursal);
            }
            catch (Exception ex) when (
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar la sucursal: {ex.Message}", ex);
            }
        }

        public Sucursal[] ObtenerTodos()
        {
            try
            {
                return _datos.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"No se pudo consultar la lista de sucursales: {ex.Message}", ex);
            }
        }

        public Sucursal? ObtenerPorId(int idSucursal)
        {
            try
            {
                if (idSucursal <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(idSucursal), "El IdSucursal debe ser un entero positivo.");
                }

                return _datos.ObtenerPorId(idSucursal);
            }
            catch (Exception ex) when (
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo consultar la sucursal por Id: {ex.Message}", ex);
            }
        }

        public bool ExisteId(int idSucursal)
        {
            if (idSucursal <= 0) return false;
            return _datos.ExisteId(idSucursal);
        }

        public bool ExisteCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo)) return false;
            return _datos.ExisteCorreo(NormalizarTexto(correo));
        }

        private static void ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El Nombre es requerido.", nameof(nombre));

            if (nombre.Length > 80)
                throw new ArgumentException("El Nombre no puede exceder 80 caracteres.", nameof(nombre));
        }

        private static void ValidarDireccion(string direccion)
        {
            if (string.IsNullOrWhiteSpace(direccion))
                throw new ArgumentException("La Dirección es requerida.", nameof(direccion));

            if (direccion.Length > 200)
                throw new ArgumentException("La Dirección no puede exceder 200 caracteres.", nameof(direccion));
        }

        private static void ValidarTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentException("El Teléfono es requerido.", nameof(telefono));

            if (telefono.Length > 20)
                throw new ArgumentException("El Teléfono no puede exceder 20 caracteres.", nameof(telefono));
        }

        private static void ValidarCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                throw new ArgumentException("El Correo es requerido.", nameof(correo));

            if (correo.Length > 120)
                throw new ArgumentException("El Correo no puede exceder 120 caracteres.", nameof(correo));
        }

        private static string NormalizarTexto(string? texto)
        {
            return texto?.Trim() ?? string.Empty;
        }
    }
}