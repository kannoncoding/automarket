/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Acceso a Datos. Almacenamiento en memoria de sucursales mediante arreglos y generación de IDs con prefijo.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-18
*/

using System;
using AutoMarket.Entidades;

namespace AutoMarket.Datos
{
    public sealed class SucursalDatos
    {
        private const int CapacidadMaxima = 20;
        private const int PrefijoIdSucursal = 4;

        private readonly Sucursal?[] _sucursales;
        private int _cantidadRegistros;
        private int _consecutivo;

        public int CantidadRegistros => _cantidadRegistros;
        public int Capacidad => CapacidadMaxima;

        public SucursalDatos()
        {
            _sucursales = new Sucursal[CapacidadMaxima];
            _cantidadRegistros = 0;
            _consecutivo = 1;
        }

        public Sucursal Agregar(
            string nombre,
            string direccion,
            string telefono,
            string correo,
            bool activa)
        {
            ValidarCapacidadDisponible();
            ValidarCorreoDuplicado(correo);

            var idGenerado = GenerarSiguienteId();
            var nuevaSucursal = new Sucursal(
                idGenerado,
                nombre,
                direccion,
                telefono,
                correo,
                activa);

            ValidarDuplicadoId(nuevaSucursal.IdSucursal);

            _sucursales[_cantidadRegistros] = nuevaSucursal;
            _cantidadRegistros++;

            return nuevaSucursal;
        }

        public void Agregar(Sucursal sucursal)
        {
            if (sucursal == null)
            {
                throw new ArgumentNullException(nameof(sucursal), "La sucursal es requerida.");
            }

            if (!sucursal.EsValida())
            {
                throw new ArgumentException("La sucursal no es válida.", nameof(sucursal));
            }

            ValidarCapacidadDisponible();
            ValidarDuplicadoId(sucursal.IdSucursal);
            ValidarCorreoDuplicado(sucursal.Correo);

            _sucursales[_cantidadRegistros] = sucursal;
            _cantidadRegistros++;

            AjustarConsecutivoConIdExistente(sucursal.IdSucursal);
        }

        public Sucursal[] ObtenerTodos()
        {
            var resultado = new Sucursal[_cantidadRegistros];

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                resultado[i] = _sucursales[i]!;
            }

            return resultado;
        }

        public Sucursal? ObtenerPorId(int idSucursal)
        {
            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var sucursal = _sucursales[i];

                if (sucursal is not null && sucursal.IdSucursal == idSucursal)
                {
                    return sucursal;
                }
            }

            return null;
        }

        public bool ExisteId(int idSucursal)
        {
            return ObtenerPorId(idSucursal) != null;
        }

        public bool ExisteCorreo(string correo)
        {
            var correoNormalizado = NormalizarTexto(correo);

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var sucursal = _sucursales[i];

                if (sucursal is not null && string.Equals(sucursal.Correo, correoNormalizado, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private void ValidarDuplicadoId(int idSucursal)
        {
            if (ExisteId(idSucursal))
            {
                throw new ArgumentException(
                    $"Ya existe una sucursal con el IdSucursal {idSucursal}.",
                    nameof(idSucursal));
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
                    $"Ya existe una sucursal con el Correo {NormalizarTexto(correo)}.",
                    nameof(correo));
            }
        }

        private void ValidarCapacidadDisponible()
        {
            if (_cantidadRegistros >= CapacidadMaxima)
            {
                throw new InvalidOperationException(
                    $"No se pueden agregar más sucursales. Capacidad máxima: {CapacidadMaxima}.");
            }
        }

        private int GenerarSiguienteId()
        {
            var id = ConstruirId(PrefijoIdSucursal, _consecutivo);
            _consecutivo++;
            return id;
        }

        private static int ConstruirId(int prefijo, int consecutivo)
        {
            var idTexto = prefijo.ToString() + consecutivo.ToString();
            return int.Parse(idTexto);
        }

        private void AjustarConsecutivoConIdExistente(int idSucursal)
        {
            var idTexto = idSucursal.ToString();

            if (idTexto.Length < 2) return;
            if (idTexto[0] != (char)('0' + PrefijoIdSucursal)) return;

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