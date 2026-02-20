/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Acceso a Datos. Almacenamiento en memoria de clientes mediante arreglos y generación de IDs con prefijo.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-18
*/

using System;
using AutoMarket.Entidades;

namespace AutoMarket.Datos
{
    public sealed class ClienteDatos
    {
        private const int CapacidadMaxima = 50;
        private const int PrefijoIdCliente = 5;

        private readonly Cliente?[] _clientes;
        private int _cantidadRegistros;
        private int _consecutivo;

        public int CantidadRegistros => _cantidadRegistros;
        public int Capacidad => CapacidadMaxima;

        public ClienteDatos()
        {
            _clientes = new Cliente[CapacidadMaxima];
            _cantidadRegistros = 0;
            _consecutivo = 1;
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
            ValidarCapacidadDisponible();
            ValidarCedulaDuplicada(cedula);
            ValidarCorreoDuplicado(correo);

            var idGenerado = GenerarSiguienteId();
            var nuevoCliente = new Cliente(
                idGenerado,
                nombre,
                primerApellido,
                segundoApellido,
                cedula,
                telefono,
                correo,
                fechaRegistro,
                activo);

            ValidarDuplicadoId(nuevoCliente.IdCliente);

            _clientes[_cantidadRegistros] = nuevoCliente;
            _cantidadRegistros++;

            return nuevoCliente;
        }

        public void Agregar(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "El cliente es requerido.");
            }

            if (!cliente.EsValido())
            {
                throw new ArgumentException("El cliente no es válido.", nameof(cliente));
            }

            ValidarCapacidadDisponible();
            ValidarDuplicadoId(cliente.IdCliente);
            ValidarCedulaDuplicada(cliente.Cedula);
            ValidarCorreoDuplicado(cliente.Correo);

            _clientes[_cantidadRegistros] = cliente;
            _cantidadRegistros++;

            AjustarConsecutivoConIdExistente(cliente.IdCliente);
        }

        public Cliente[] ObtenerTodos()
        {
            var resultado = new Cliente[_cantidadRegistros];

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                resultado[i] = _clientes[i]!;
            }

            return resultado;
        }

        public Cliente? ObtenerPorId(int idCliente)
        {
            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var cliente = _clientes[i];

                if (cliente is not null && cliente.IdCliente == idCliente)
                {
                    return cliente;
                }
            }

            return null;
        }

        public bool ExisteId(int idCliente)
        {
            return ObtenerPorId(idCliente) != null;
        }

        public bool ExisteCedula(string cedula)
        {
            var cedulaNormalizada = NormalizarTexto(cedula);

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var cliente = _clientes[i];

                if (cliente is not null && string.Equals(cliente.Cedula, cedulaNormalizada, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public bool ExisteCorreo(string correo)
        {
            var correoNormalizado = NormalizarTexto(correo);

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var cliente = _clientes[i];

                if (cliente is not null && string.Equals(cliente.Correo, correoNormalizado, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private void ValidarDuplicadoId(int idCliente)
        {
            if (ExisteId(idCliente))
            {
                throw new ArgumentException(
                    $"Ya existe un cliente con el IdCliente {idCliente}.",
                    nameof(idCliente));
            }
        }

        private void ValidarCedulaDuplicada(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
            {
                throw new ArgumentException("La Cédula es requerida.", nameof(cedula));
            }

            if (ExisteCedula(cedula))
            {
                throw new ArgumentException(
                    $"Ya existe un cliente con la Cédula {NormalizarTexto(cedula)}.",
                    nameof(cedula));
            }
        }

        private void ValidarCorreoDuplicado(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                throw new ArgumentException("El Correo es requerido.", nameof(correo));
            }

            if (ExisteCorreo(correo))
            {
                throw new ArgumentException(
                    $"Ya existe un cliente con el Correo {NormalizarTexto(correo)}.",
                    nameof(correo));
            }
        }

        private void ValidarCapacidadDisponible()
        {
            if (_cantidadRegistros >= CapacidadMaxima)
            {
                throw new InvalidOperationException(
                    $"No se pueden agregar más clientes. Capacidad máxima: {CapacidadMaxima}.");
            }
        }

        private int GenerarSiguienteId()
        {
            var id = ConstruirId(PrefijoIdCliente, _consecutivo);
            _consecutivo++;
            return id;
        }

        private static int ConstruirId(int prefijo, int consecutivo)
        {
            var idTexto = prefijo.ToString() + consecutivo.ToString();
            return int.Parse(idTexto);
        }

        private void AjustarConsecutivoConIdExistente(int idCliente)
        {
            var idTexto = idCliente.ToString();

            if (idTexto.Length < 2) return;
            if (idTexto[0] != (char)('0' + PrefijoIdCliente)) return;

            var consecutivoTexto = idTexto.Substring(1);
            if (!int.TryParse(consecutivoTexto, out int consecutivoExistente)) return;

            var siguiente = consecutivoExistente + 1;
            if (siguiente > _consecutivo)
            {
                _consecutivo = siguiente;
            }
        }

        private static string NormalizarTexto(string? texto)
        {
            return texto?.Trim() ?? string.Empty;
        }
    }
}