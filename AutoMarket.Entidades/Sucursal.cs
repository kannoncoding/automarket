/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Entidades. Clase que modela la sucursal del sistema AutoMarket.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-16
*/

using System;

namespace AutoMarket.Entidades
{
    public sealed class Sucursal : IEquatable<Sucursal>
    {
        private const int PrefijoIdSucursal = 4;

        private readonly int _idSucursal;
        private string _nombre = null!;
        private string _direccion = null!;
        private string _telefono = null!;
        private string _correo = null!;
        private bool _activa;

        private Vendedor _vendedorEncargado = null!;

        public int IdSucursal => _idSucursal;

        public string Nombre
        {
            get => _nombre;
            private set
            {
                var texto = NormalizarTexto(value);
                ValidarNombre(texto);
                _nombre = texto;
            }
        }

        public string Direccion
        {
            get => _direccion;
            private set
            {
                var texto = NormalizarTexto(value);
                ValidarDireccion(texto);
                _direccion = texto;
            }
        }

        public string Telefono
        {
            get => _telefono;
            private set
            {
                var texto = NormalizarTexto(value);
                ValidarTelefono(texto);
                _telefono = texto;
            }
        }

        public string Correo
        {
            get => _correo;
            private set
            {
                var texto = NormalizarTexto(value);
                ValidarCorreo(texto);
                _correo = texto;
            }
        }

        public Vendedor VendedorEncargado
        {
            get => _vendedorEncargado;
            private set
            {
                ValidarVendedorEncargado(value);
                _vendedorEncargado = value;
            }
        }

        public bool Activa
        {
            get => _activa;
            private set => _activa = value;
        }

        public Sucursal(
            int idSucursal,
            string nombre,
            string direccion,
            string telefono,
            string correo,
            Vendedor vendedorEncargado,
            bool activa)
        {
            ValidarIdSucursal(idSucursal);

            _idSucursal = idSucursal;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            VendedorEncargado = vendedorEncargado;
            Activa = activa;
        }

        public void ActualizarDatos(
            string nombre,
            string direccion,
            string telefono,
            string correo,
            Vendedor vendedorEncargado,
            bool activa)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            VendedorEncargado = vendedorEncargado;
            Activa = activa;
        }

        public void Activar()
        {
            _activa = true;
        }

        public void Desactivar()
        {
            _activa = false;
        }

        public bool EsValida()
        {
            if (!EsIdSucursalValido(_idSucursal)) return false;
            if (string.IsNullOrWhiteSpace(_nombre)) return false;
            if (string.IsNullOrWhiteSpace(_direccion)) return false;
            if (string.IsNullOrWhiteSpace(_telefono)) return false;
            if (string.IsNullOrWhiteSpace(_correo)) return false;
            if (_vendedorEncargado is null) return false;

            return true;
        }

        public string ObtenerResumen()
        {
            var estado = _activa ? "Activa" : "Inactiva";
            return $"{_nombre} | Tel: {_telefono} | Encargado: {_vendedorEncargado.Nombre} | {estado}";
        }

        public override string ToString()
        {
            var estado = _activa ? "Activa" : "Inactiva";
            return $"Id: {_idSucursal} | Nombre: {_nombre} | Dirección: {_direccion} | Teléfono: {_telefono} | Correo: {_correo} | Encargado: {_vendedorEncargado.Nombre} | Estado: {estado}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Sucursal);
        }

        public bool Equals(Sucursal? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return _idSucursal == other._idSucursal;
        }

        public override int GetHashCode()
        {
            return _idSucursal.GetHashCode();
        }

        public static bool operator ==(Sucursal? left, Sucursal? right)
        {
            if (ReferenceEquals(left, null)) return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        public static bool operator !=(Sucursal? left, Sucursal? right)
        {
            return !(left == right);
        }

        private static void ValidarIdSucursal(int idSucursal)
        {
            if (!EsIdSucursalValido(idSucursal))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(idSucursal),
                    $"El IdSucursal debe ser un entero positivo y comenzar con el prefijo {PrefijoIdSucursal} (ej: 41, 42, 410).");
            }
        }

        private static bool EsIdSucursalValido(int idSucursal)
        {
            if (idSucursal <= 0) return false;

            var idTexto = idSucursal.ToString();
            if (idTexto.Length < 2) return false;

            return idTexto[0] == (char)('0' + PrefijoIdSucursal);
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

        private static void ValidarVendedorEncargado(Vendedor vendedorEncargado)
        {
            if (vendedorEncargado is null)
            {
                throw new ArgumentNullException(nameof(vendedorEncargado), "El Vendedor Encargado es requerido.");
            }
        }

        private static string NormalizarTexto(string? texto)
        {
            return texto?.Trim() ?? string.Empty;
        }
    }
}