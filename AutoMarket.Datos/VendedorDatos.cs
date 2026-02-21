/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Acceso a Datos. Almacenamiento en memoria de vendedores mediante arreglos y generación de IDs con prefijo.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-19
*/

using System;
using AutoMarket.Entidades;

namespace AutoMarket.Datos
{
    public sealed class VendedorDatos
    {
        private const int CapacidadMaxima = 30;
        private const int PrefijoIdVendedor = 3;

        private readonly Vendedor?[] _vendedores;
        private int _cantidadRegistros;
        private int _consecutivo;

        public int CantidadRegistros => _cantidadRegistros;
        public int Capacidad => CapacidadMaxima;

        public VendedorDatos()
        {
            _vendedores = new Vendedor[CapacidadMaxima];
            _cantidadRegistros = 0;
            _consecutivo = 1;
        }

        public Vendedor Agregar(
            string nombre,
            string primerApellido,
            string segundoApellido,
            string cedula,
            string telefono,
            string correo,
            DateTime fechaIngreso,
            bool activo)
        {
            ValidarCapacidadDisponible();
            ValidarCedulaDuplicada(cedula);

            var correoNormalizado = NormalizarCorreo(correo);
            ValidarCorreoDuplicado(correoNormalizado);

            var idGenerado = GenerarSiguienteId();
            var nuevoVendedor = new Vendedor(
                idGenerado,
                nombre,
                primerApellido,
                segundoApellido,
                cedula,
                telefono,
                correoNormalizado,
                fechaIngreso,
                activo);

            ValidarDuplicadoId(nuevoVendedor.IdVendedor);

            _vendedores[_cantidadRegistros] = nuevoVendedor;
            _cantidadRegistros++;

            return nuevoVendedor;
        }

        public void Agregar(Vendedor vendedor)
        {
            if (vendedor == null)
            {
                throw new ArgumentNullException(nameof(vendedor), "El vendedor es requerido.");
            }

            if (!vendedor.EsValido())
            {
                throw new ArgumentException("El vendedor no es válido.", nameof(vendedor));
            }

            ValidarCapacidadDisponible();
            ValidarDuplicadoId(vendedor.IdVendedor);
            ValidarCedulaDuplicada(vendedor.Cedula);
            ValidarCorreoDuplicado(vendedor.Correo);

            _vendedores[_cantidadRegistros] = vendedor;
            _cantidadRegistros++;

            AjustarConsecutivoConIdExistente(vendedor.IdVendedor);
        }

        public Vendedor[] ObtenerTodos()
        {
            var resultado = new Vendedor[_cantidadRegistros];

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                resultado[i] = _vendedores[i]!;
            }

            return resultado;
        }

        public Vendedor? ObtenerPorId(int idVendedor)
        {
            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var vendedor = _vendedores[i];

                if (vendedor is not null && vendedor.IdVendedor == idVendedor)
                {
                    return vendedor;
                }
            }

            return null;
        }

        public bool ExisteId(int idVendedor)
        {
            return ObtenerPorId(idVendedor) != null;
        }

        public bool ExisteCedula(string cedula)
        {
            var cedulaNormalizada = NormalizarTexto(cedula);

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var vendedor = _vendedores[i];

                if (vendedor is not null && string.Equals(vendedor.Cedula, cedulaNormalizada, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public bool ExisteCorreo(string correo)
        {
            var correoNormalizado = NormalizarCorreo(correo);

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var vendedor = _vendedores[i];

                if (vendedor is not null && string.Equals(vendedor.Correo, correoNormalizado, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private void ValidarDuplicadoId(int idVendedor)
        {
            if (ExisteId(idVendedor))
            {
                throw new ArgumentException(
                    $"Ya existe un vendedor con el IdVendedor {idVendedor}.",
                    nameof(idVendedor));
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
                    $"Ya existe un vendedor con la Cédula {NormalizarTexto(cedula)}.",
                    nameof(cedula));
            }
        }

        private void ValidarCorreoDuplicado(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                throw new ArgumentException("El Correo es requerido.", nameof(correo));
            }

            var correoNormalizado = NormalizarCorreo(correo);

            if (ExisteCorreo(correoNormalizado))
            {
                throw new ArgumentException(
                    $"Ya existe un vendedor con el Correo {correoNormalizado}.",
                    nameof(correo));
            }
        }

        private void ValidarCapacidadDisponible()
        {
            if (_cantidadRegistros >= CapacidadMaxima)
            {
                throw new InvalidOperationException(
                    $"No se pueden agregar más vendedores. Capacidad máxima: {CapacidadMaxima}.");
            }
        }

        private int GenerarSiguienteId()
        {
            var id = ConstruirId(PrefijoIdVendedor, _consecutivo);
            _consecutivo++;
            return id;
        }

        private static int ConstruirId(int prefijo, int consecutivo)
        {
            var idTexto = prefijo.ToString() + consecutivo.ToString();
            return int.Parse(idTexto);
        }

        private void AjustarConsecutivoConIdExistente(int idVendedor)
        {
            var idTexto = idVendedor.ToString();

            if (idTexto.Length < 2) return;
            if (idTexto[0] != (char)('0' + PrefijoIdVendedor)) return;

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

        private static string NormalizarCorreo(string? correo)
        {
            return (correo?.Trim() ?? string.Empty).ToLowerInvariant();
        }
    }
}