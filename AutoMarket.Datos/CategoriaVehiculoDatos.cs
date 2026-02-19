/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Acceso a Datos. Almacenamiento en memoria de categorías de vehículo mediante arreglos.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-18
*/

using System;
using AutoMarket.Entidades;

namespace AutoMarket.Datos
{
    public sealed class CategoriaVehiculoDatos
    {
        private const int CapacidadMaxima = 20;
        private const int PrefijoIdCategoria = 1;

        private readonly CategoriaVehiculo?[] _categorias;
        private int _cantidadRegistros;
        private int _consecutivo;

        public int CantidadRegistros => _cantidadRegistros;
        public int Capacidad => CapacidadMaxima;

        public CategoriaVehiculoDatos()
        {
            _categorias = new CategoriaVehiculo[CapacidadMaxima];
            _cantidadRegistros = 0;
            _consecutivo = 1;
        }

        public CategoriaVehiculo Agregar(string nombreCategoria, string descripcion)
        {
            ValidarCapacidadDisponible();

            var idGenerado = GenerarSiguienteId();
            var nuevaCategoria = new CategoriaVehiculo(idGenerado, nombreCategoria, descripcion);

            ValidarDuplicadoId(nuevaCategoria.IdCategoria);

            _categorias[_cantidadRegistros] = nuevaCategoria;
            _cantidadRegistros++;

            return nuevaCategoria;
        }

        public void Agregar(CategoriaVehiculo categoriaVehiculo)
        {
            if (categoriaVehiculo == null)
            {
                throw new ArgumentNullException(nameof(categoriaVehiculo), "La categoría es requerida.");
            }

            if (!categoriaVehiculo.EsValida())
            {
                throw new ArgumentException("La categoría no es válida.", nameof(categoriaVehiculo));
            }

            ValidarCapacidadDisponible();
            ValidarDuplicadoId(categoriaVehiculo.IdCategoria);

            _categorias[_cantidadRegistros] = categoriaVehiculo;
            _cantidadRegistros++;

            AjustarConsecutivoConIdExistente(categoriaVehiculo.IdCategoria);
        }

        public CategoriaVehiculo[] ObtenerTodos()
        {
            var resultado = new CategoriaVehiculo[_cantidadRegistros];

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                resultado[i] = _categorias[i];
            }

            return resultado;
        }

        public CategoriaVehiculo? ObtenerPorId(int idCategoria)
        {
            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var categoria = _categorias[i];

                if (categoria is not null && categoria.IdCategoria == idCategoria)
                {
                    return categoria;
                }
            }

            return null;
        }

        public bool ExisteId(int idCategoria)
        {
            return ObtenerPorId(idCategoria) != null;
        }

        private void ValidarDuplicadoId(int idCategoria)
        {
            if (ExisteId(idCategoria))
            {
                throw new ArgumentException(
                    $"Ya existe una categoría con el IdCategoria {idCategoria}.",
                    nameof(idCategoria));
            }
        }

        private void ValidarCapacidadDisponible()
        {
            if (_cantidadRegistros >= CapacidadMaxima)
            {
                throw new InvalidOperationException(
                    $"No se pueden agregar más categorías. Capacidad máxima: {CapacidadMaxima}.");
            }
        }

        private int GenerarSiguienteId()
        {
            var id = ConstruirId(PrefijoIdCategoria, _consecutivo);
            _consecutivo++;
            return id;
        }

        private static int ConstruirId(int prefijo, int consecutivo)
        {
            var idTexto = prefijo.ToString() + consecutivo.ToString();
            return int.Parse(idTexto);
        }

        private void AjustarConsecutivoConIdExistente(int idCategoria)
        {
            var idTexto = idCategoria.ToString();

            if (idTexto.Length < 2) return;
            if (idTexto[0] != (char)('0' + PrefijoIdCategoria)) return;

            var consecutivoTexto = idTexto.Substring(1);
            if (!int.TryParse(consecutivoTexto, out int consecutivoExistente)) return;

            var siguiente = consecutivoExistente + 1;
            if (siguiente > _consecutivo)
            {
                _consecutivo = siguiente;
            }
        }
    }
}
