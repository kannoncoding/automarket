/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Entidades. Clase que modela el cliente del sistema AutoMarket.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-16
*/

using System;

namespace AutoMarket.Entidades
{
    public sealed class Cliente : IEquatable<Cliente>
    {
        private const int PrefijoIdCliente = 5;

        private readonly int _idCliente;
        private string _nombre = null!;
        private string _primerApellido = null!;
        private string _segundoApellido = null!;
        private string _cedula = null!;
        private string _telefono = null!;
        private string _correo = null!;
        private DateTime _fechaRegistro;
        private bool _activo;

        public int IdCliente => _idCliente;

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

        public string PrimerApellido
        {
            get => _primerApellido;
            private set
            {
                var texto = NormalizarTexto(value);
                ValidarPrimerApellido(texto);
                _primerApellido = texto;
            }
        }

        public string SegundoApellido
        {
            get => _segundoApellido;
            private set
            {
                var texto = NormalizarTexto(value);
                ValidarSegundoApellido(texto);
                _segundoApellido = texto;
            }
        }

        public string Cedula
        {
            get => _cedula;
            private set
            {
                var texto = NormalizarTexto(value);
                ValidarCedula(texto);
                _cedula = texto;
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

        public DateTime FechaRegistro
        {
            get => _fechaRegistro;
            private set
            {
                ValidarFechaRegistro(value);
                _fechaRegistro = value.Date;
            }
        }

        public bool Activo
        {
            get => _activo;
            private set => _activo = value;
        }

        public string NombreCompleto => $"{_nombre} {_primerApellido} {_segundoApellido}".Trim();

        public Cliente(
            int idCliente,
            string nombre,
            string primerApellido,
            string segundoApellido,
            string cedula,
            string telefono,
            string correo,
            DateTime fechaRegistro,
            bool activo)
        {
            ValidarIdCliente(idCliente);

            _idCliente = idCliente;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Cedula = cedula;
            Telefono = telefono;
            Correo = correo;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }

        public void ActualizarDatos(
            string nombre,
            string primerApellido,
            string segundoApellido,
            string cedula,
            string telefono,
            string correo,
            DateTime fechaRegistro,
            bool activo)
        {
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Cedula = cedula;
            Telefono = telefono;
            Correo = correo;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }

        public void Activar()
        {
            _activo = true;
        }

        public void Desactivar()
        {
            _activo = false;
        }

        public bool EsValido()
        {
            if (!EsIdClienteValido(_idCliente)) return false;
            if (string.IsNullOrWhiteSpace(_nombre)) return false;
            if (string.IsNullOrWhiteSpace(_primerApellido)) return false;
            if (string.IsNullOrWhiteSpace(_segundoApellido)) return false;
            if (string.IsNullOrWhiteSpace(_cedula)) return false;
            if (string.IsNullOrWhiteSpace(_telefono)) return false;
            if (string.IsNullOrWhiteSpace(_correo)) return false;
            if (!EsFechaRegistroValida(_fechaRegistro)) return false;

            return true;
        }

        public string ObtenerResumen()
        {
            var estado = _activo ? "Activo" : "Inactivo";
            return $"{NombreCompleto} | Cédula: {_cedula} | Tel: {_telefono} | {estado}";
        }

        public override string ToString()
        {
            var estado = _activo ? "Activo" : "Inactivo";
            return $"Id: {_idCliente} | Nombre: {NombreCompleto} | Cédula: {_cedula} | Teléfono: {_telefono} | Correo: {_correo} | Registro: {_fechaRegistro:yyyy-MM-dd} | Estado: {estado}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Cliente);
        }

        public bool Equals(Cliente? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return _idCliente == other._idCliente;
        }

        public override int GetHashCode()
        {
            return _idCliente.GetHashCode();
        }

        public static bool operator ==(Cliente? left, Cliente? right)
        {
            if (ReferenceEquals(left, null)) return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        public static bool operator !=(Cliente? left, Cliente? right)
        {
            return !(left == right);
        }

        private static void ValidarIdCliente(int idCliente)
        {
            if (!EsIdClienteValido(idCliente))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(idCliente),
                    $"El IdCliente debe ser un entero positivo y comenzar con el prefijo {PrefijoIdCliente} (ej: 51, 52, 510).");
            }
        }

        private static bool EsIdClienteValido(int idCliente)
        {
            if (idCliente <= 0) return false;

            var idTexto = idCliente.ToString();
            if (idTexto.Length < 2) return false;

            return idTexto[0] == (char)('0' + PrefijoIdCliente);
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
            if (!EsFechaRegistroValida(fechaRegistro))
                throw new ArgumentOutOfRangeException(nameof(fechaRegistro), "La Fecha de Registro no puede ser posterior a la fecha actual.");
        }

        private static bool EsFechaRegistroValida(DateTime fechaRegistro)
        {
            return fechaRegistro.Date <= DateTime.Today;
        }

        private static string NormalizarTexto(string? texto)
        {
            return texto?.Trim() ?? string.Empty;
        }
    }
}
