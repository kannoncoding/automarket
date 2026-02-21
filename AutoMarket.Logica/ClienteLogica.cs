/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Lógica de Negocio. Reglas y validaciones para la gestión de clientes.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-20
*/

using System;
using AutoMarket.Datos;
using AutoMarket.Entidades;

namespace AutoMarket.Logica
{
    public sealed class ClienteLogica
    {
        private readonly ClienteDatos _datos;

        public int CantidadRegistros => _datos.CantidadRegistros;
        public int Capacidad => _datos.Capacidad;

        public ClienteLogica()
            : this(new ClienteDatos())
        {
        }

        public ClienteLogica(ClienteDatos datos)
        {
            _datos = datos ?? throw new ArgumentNullException(nameof(datos), "La capa de datos es requerida.");
        }

        public Cliente Agregar(
            string nombre,
            string primerApellido,
            string segundoApellido,
            string cedula,
            string telefono,
            string correo,
            DateTime fechaRegistro,
            bool activo)
        {
            try
            {
                var nombreNormalizado = NormalizarTexto(nombre);
                var primerApellidoNormalizado = NormalizarTexto(primerApellido);
                var segundoApellidoNormalizado = NormalizarTexto(segundoApellido);
                var cedulaNormalizada = NormalizarTexto(cedula);
                var telefonoNormalizado = NormalizarTexto(telefono);
                var correoNormalizado = NormalizarTexto(correo);

                ValidarNombre(nombreNormalizado);
                ValidarPrimerApellido(primerApellidoNormalizado);
                ValidarSegundoApellido(segundoApellidoNormalizado);
                ValidarCedula(cedulaNormalizada);
                ValidarTelefono(telefonoNormalizado);
                ValidarCorreo(correoNormalizado);
                ValidarFechaRegistro(fechaRegistro);

                if (_datos.ExisteCedula(cedulaNormalizada))
                {
                    throw new ArgumentException($"Ya existe un cliente con la Cédula {cedulaNormalizada}.", nameof(cedula));
                }

                if (_datos.ExisteCorreo(correoNormalizado))
                {
                    throw new ArgumentException($"Ya existe un cliente con el Correo {correoNormalizado}.", nameof(correo));
                }

                return _datos.Agregar(
                    nombreNormalizado,
                    primerApellidoNormalizado,
                    segundoApellidoNormalizado,
                    cedulaNormalizada,
                    telefonoNormalizado,
                    correoNormalizado,
                    fechaRegistro,
                    activo);
            }
            catch (Exception ex) when (
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar el cliente: {ex.Message}", ex);
            }
        }

        public void Agregar(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                {
                    throw new ArgumentNullException(nameof(cliente), "El cliente es requerido.");
                }

                if (!cliente.EsValido())
                {
                    throw new ArgumentException("El cliente no es válido.", nameof(cliente));
                }

                if (_datos.ExisteCedula(cliente.Cedula))
                {
                    throw new ArgumentException($"Ya existe un cliente con la Cédula {NormalizarTexto(cliente.Cedula)}.", nameof(cliente));
                }

                if (_datos.ExisteCorreo(cliente.Correo))
                {
                    throw new ArgumentException($"Ya existe un cliente con el Correo {NormalizarTexto(cliente.Correo)}.", nameof(cliente));
                }

                _datos.Agregar(cliente);
            }
            catch (Exception ex) when (
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo registrar el cliente: {ex.Message}", ex);
            }
        }

        public Cliente[] ObtenerTodos()
        {
            try
            {
                return _datos.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"No se pudo consultar la lista de clientes: {ex.Message}", ex);
            }
        }

        public Cliente? ObtenerPorId(int idCliente)
        {
            try
            {
                if (idCliente <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(idCliente), "El IdCliente debe ser un entero positivo.");
                }

                return _datos.ObtenerPorId(idCliente);
            }
            catch (Exception ex) when (
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is InvalidOperationException)
            {
                throw new InvalidOperationException($"No se pudo consultar el cliente por Id: {ex.Message}", ex);
            }
        }

        public bool ExisteId(int idCliente)
        {
            if (idCliente <= 0) return false;
            return _datos.ExisteId(idCliente);
        }

        public bool ExisteCedula(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula)) return false;
            return _datos.ExisteCedula(NormalizarTexto(cedula));
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

            if (nombre.Length > 60)
                throw new ArgumentException("El Nombre no puede exceder 60 caracteres.", nameof(nombre));
        }

        private static void ValidarPrimerApellido(string primerApellido)
        {
            if (string.IsNullOrWhiteSpace(primerApellido))
                throw new ArgumentException("El Primer Apellido es requerido.", nameof(primerApellido));

            if (primerApellido.Length > 60)
                throw new ArgumentException("El Primer Apellido no puede exceder 60 caracteres.", nameof(primerApellido));
        }

        private static void ValidarSegundoApellido(string segundoApellido)
        {
            if (string.IsNullOrWhiteSpace(segundoApellido))
                throw new ArgumentException("El Segundo Apellido es requerido.", nameof(segundoApellido));

            if (segundoApellido.Length > 60)
                throw new ArgumentException("El Segundo Apellido no puede exceder 60 caracteres.", nameof(segundoApellido));
        }

        private static void ValidarCedula(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
                throw new ArgumentException("La Cédula es requerida.", nameof(cedula));

            if (cedula.Length > 20)
                throw new ArgumentException("La Cédula no puede exceder 20 caracteres.", nameof(cedula));
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

        private static void ValidarFechaRegistro(DateTime fechaRegistro)
        {
            if (fechaRegistro.Date > DateTime.Today)
                throw new ArgumentOutOfRangeException(nameof(fechaRegistro), "La Fecha de Registro no puede ser posterior a la fecha actual.");
        }

        private static string NormalizarTexto(string? texto)
        {
            return texto?.Trim() ?? string.Empty;
        }
    }
}