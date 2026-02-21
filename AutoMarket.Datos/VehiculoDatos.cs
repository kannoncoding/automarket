/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Acceso a Datos. Almacenamiento en memoria de vehículos mediante arreglos y validación de referencias.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-18
*/

using System;
using AutoMarket.Entidades;

namespace AutoMarket.Datos
{
    public sealed class VehiculoDatos
    {
        private const int CapacidadMaxima = 50;
        private const int PrefijoIdVehiculo = 2;

        private readonly Vehiculo?[] _vehiculos;
        private int _cantidadRegistros;
        private int _consecutivo;

        private readonly CategoriaVehiculoDatos _categoriaVehiculoDatos;

        public int CantidadRegistros => _cantidadRegistros;
        public int Capacidad => CapacidadMaxima;

        public VehiculoDatos(CategoriaVehiculoDatos categoriaVehiculoDatos)
        {
            _categoriaVehiculoDatos = categoriaVehiculoDatos ?? throw new ArgumentNullException(
                nameof(categoriaVehiculoDatos),
                "El acceso a datos de categorías es requerido para validar referencias.");

            _vehiculos = new Vehiculo[CapacidadMaxima];
            _cantidadRegistros = 0;
            _consecutivo = 1;
        }

        public Vehiculo Agregar(string marca, string modelo, int anio, decimal precio, int idCategoria, char estado)
        {
            ValidarCapacidadDisponible();
            var estadoNormalizado = NormalizarEstado(estado);

            var categoria = _categoriaVehiculoDatos.ObtenerPorId(idCategoria);
            if (categoria is null)
            {
                throw new ArgumentException(
                    $"La categoría indicada no existe. IdCategoria: {idCategoria}.",
                    nameof(idCategoria));
            }

            var idGenerado = GenerarSiguienteId();
            var nuevoVehiculo = new Vehiculo(idGenerado, marca, modelo, anio, precio, categoria, estadoNormalizado);

            ValidarDuplicadoId(nuevoVehiculo.IdVehiculo);

            _vehiculos[_cantidadRegistros] = nuevoVehiculo;
            _cantidadRegistros++;

            return nuevoVehiculo;
        }

        public void Agregar(Vehiculo vehiculo)
        {
            if (vehiculo == null)
            {
                throw new ArgumentNullException(nameof(vehiculo), "El vehículo es requerido.");
            }

            if (!vehiculo.EsValido())
            {
                throw new ArgumentException("El vehículo no es válido.", nameof(vehiculo));
            }

            ValidarCapacidadDisponible();
            ValidarEstado(vehiculo.Estado);

            if (vehiculo.Categoria is null)
            {
                throw new ArgumentException("La categoría del vehículo es requerida.", nameof(vehiculo));
            }

            if (!_categoriaVehiculoDatos.ExisteId(vehiculo.Categoria.IdCategoria))
            {
                throw new ArgumentException(
                    $"La categoría asociada al vehículo no existe en el registro. IdCategoria: {vehiculo.Categoria.IdCategoria}.",
                    nameof(vehiculo));
            }

            ValidarDuplicadoId(vehiculo.IdVehiculo);

            _vehiculos[_cantidadRegistros] = vehiculo;
            _cantidadRegistros++;

            AjustarConsecutivoConIdExistente(vehiculo.IdVehiculo);
        }

        public Vehiculo[] ObtenerTodos()
        {
            var resultado = new Vehiculo[_cantidadRegistros];

            for (int i = 0; i < _cantidadRegistros; i++)
            {
                resultado[i] = _vehiculos[i]!;
            }

            return resultado;
        }

        public Vehiculo? ObtenerPorId(int idVehiculo)
        {
            for (int i = 0; i < _cantidadRegistros; i++)
            {
                var vehiculo = _vehiculos[i];

                if (vehiculo is not null && vehiculo.IdVehiculo == idVehiculo)
                {
                    return vehiculo;
                }
            }

            return null;
        }

        public bool ExisteId(int idVehiculo)
        {
            return ObtenerPorId(idVehiculo) != null;
        }

        private void ValidarDuplicadoId(int idVehiculo)
        {
            if (ExisteId(idVehiculo))
            {
                throw new ArgumentException(
                    $"Ya existe un vehículo con el IdVehiculo {idVehiculo}.",
                    nameof(idVehiculo));
            }
        }

        private void ValidarCapacidadDisponible()
        {
            if (_cantidadRegistros >= CapacidadMaxima)
            {
                throw new InvalidOperationException(
                    $"No se pueden agregar más vehículos. Capacidad máxima: {CapacidadMaxima}.");
            }
        }

        private static void ValidarEstado(char estado)
        {
            var estadoNormalizado = NormalizarEstado(estado);

            if (estadoNormalizado != 'N' && estadoNormalizado != 'U')
            {
                throw new ArgumentException(
                    "El Estado del vehículo es inválido. Valores permitidos: 'N' (Nuevo) o 'U' (Usado).",
                    nameof(estado));
            }
        }

        private static char NormalizarEstado(char estado)
        {
            return char.ToUpperInvariant(estado);
        }


        private int GenerarSiguienteId()
        {
            var id = ConstruirId(PrefijoIdVehiculo, _consecutivo);
            _consecutivo++;
            return id;
        }

        private static int ConstruirId(int prefijo, int consecutivo)
        {
            var idTexto = prefijo.ToString() + consecutivo.ToString();
            return int.Parse(idTexto);
        }

        private void AjustarConsecutivoConIdExistente(int idVehiculo)
        {
            var idTexto = idVehiculo.ToString();

            if (idTexto.Length < 2) return;
            if (idTexto[0] != (char)('0' + PrefijoIdVehiculo)) return;

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
