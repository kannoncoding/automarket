/*
Universidad: UNED
Cuatrimestre: I Cuatrimestre 2026
Proyecto: AutoMarket - Proyecto #1
Descripción: Capa de Entidades. Clase que modela el vendedor del sistema AutoMarket.
Estudiante: Jorge Arias
Fecha de desarrollo: 2026-02-16
*/

using System;

namespace AutoMarket.Entidades
{
    public sealed class Vendedor : IEquatable<Vendedor>
    {
        private const int PrefijoIdVendedor = 3;

        private readonly int _idVendedor;
        private string _nombre = null!;
        private string _primerApellido = null!;
        private string _segundoApellido = null!;
        private string _cedula = null!;
        private string _telefono = null!;
        private string _correo = null!;
        private DateTime _fechaIngreso;
        private bool _activo;

        public int IdVendedor => _idVendedor;

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

        public DateTime FechaIngreso
        {
            get => _fechaIngreso;
            private set
            {
                ValidarFechaIngreso(value);
                _fechaIngreso = value.Date;
            }
        }

        public bool Activo
        {
            get => _activo;
            private set => _activo = value;
        }

        public string NombreCompleto => $"{_nombre} {_primerApellido} {_segundoApellido}".Trim();

        public Vendedor(
            int idVendedor,
            string nombre,
            string primerApellido,
            string segundoApellido,
            string cedula,
            string telefono,
            string correo,
            DateTime fechaIngreso,
            bool activo)
        {
            ValidarIdVendedor(idVendedor);

            _idVendedor = idVendedor;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Cedula = cedula;
            Telefono = telefono;
            Correo = correo;
            FechaIngreso = fechaIngreso;
            Activo = activo;
        }

        public void ActualizarDatos(
            string nombre,
            string primerApellido,
            string segundoApellido,
            string cedula,
            string telefono,
            string correo,
            DateTime fechaIngreso,
            bool activo)
        {
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Cedula = cedula;
            Telefono = telefono;
            Correo = correo;
            FechaIngreso = fechaIngreso;
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
            if (!EsIdVendedorValido(_idVendedor)) return false;
            if (string.IsNullOrWhiteSpace(_nombre)) return false;
            if (string.IsNullOrWhiteSpace(_primerApellido)) return false;
            if (string.IsNullOrWhiteSpace(_segundoApellido)) return false;
            if (string.IsNullOrWhiteSpace(_cedula)) return false;
            if (string.IsNullOrWhiteSpace(_telefono)) return false;
            if (string.IsNullOrWhiteSpace(_correo)) return false;
            if (!EsFechaIngresoValida(_fechaIngreso)) return false;

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
            return $"Id: {_idVendedor} | Nombre: {NombreCompleto} | Cédula: {_cedula} | Teléfono: {_telefono} | Correo: {_correo} | Ingreso: {_fechaIngreso:yyyy-MM-dd} | Estado: {estado}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Vendedor);
        }

        public bool Equals(Vendedor? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return _idVendedor == other._idVendedor;
        }

        public override int GetHashCode()
        {
            return _idVendedor.GetHashCode();
        }

        public static bool operator ==(Vendedor? left, Vendedor? right)
        {
            if (ReferenceEquals(left, null)) return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        public static bool operator !=(Vendedor? left, Vendedor? right)
        {
            return !(left == right);
        }

        private static void ValidarIdVendedor(int idVendedor)
        {
            if (!EsIdVendedorValido(idVendedor))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(idVendedor),
                    $"El IdVendedor debe ser un entero positivo y comenzar con el prefijo {PrefijoIdVendedor} (ej: 31, 32, 310).");
            }
        }

        private static bool EsIdVendedorValido(int idVendedor)
        {
            if (idVendedor <= 0) return false;

            var idTexto = idVendedor.ToString();
            if (idTexto.Length < 2) return false;

            return idTexto[0] == (char)('0' + PrefijoIdVendedor);
        }

        private static void ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El Nombre es requerido.", nameof(nombre));
            }

            if (nombre.Length > 60)
            {
                throw new ArgumentException("El Nombre no puede exceder 60 caracteres.", nameof(nombre));
            }
        }

        private static void ValidarPrimerApellido(string primerApellido)
        {
            if (string.IsNullOrWhiteSpace(primerApellido))
            {
                throw new ArgumentException("El Primer Apellido es requerido.", nameof(primerApellido));
            }

            if (primerApellido.Length > 60)
            {
                throw new ArgumentException("El Primer Apellido no puede exceder 60 caracteres.", nameof(primerApellido));
            }
        }

        private static void ValidarSegundoApellido(string segundoApellido)
        {
            if (string.IsNullOrWhiteSpace(segundoApellido))
            {
                throw new ArgumentException("El Segundo Apellido es requerido.", nameof(segundoApellido));
            }

            if (segundoApellido.Length > 60)
            {
                throw new ArgumentException("El Segundo Apellido no puede exceder 60 caracteres.", nameof(segundoApellido));
            }
        }

        private static void ValidarCedula(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
            {
                throw new ArgumentException("La Cédula es requerida.", nameof(cedula));
            }

            if (cedula.Length > 20)
            {
                throw new ArgumentException("La Cédula no puede exceder 20 caracteres.", nameof(cedula));
            }
        }

        private static void ValidarTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("El Teléfono es requerido.", nameof(telefono));
            }

            if (telefono.Length > 20)
            {
                throw new ArgumentException("El Teléfono no puede exceder 20 caracteres.", nameof(telefono));
            }
        }

        private static void ValidarCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                throw new ArgumentException("El Correo es requerido.", nameof(correo));
            }

            if (correo.Length > 120)
            {
                throw new ArgumentException("El Correo no puede exceder 120 caracteres.", nameof(correo));
            }
        }

        private static void ValidarFechaIngreso(DateTime fechaIngreso)
        {
            if (!EsFechaIngresoValida(fechaIngreso))
            {
                throw new ArgumentOutOfRangeException(nameof(fechaIngreso), "La Fecha de Ingreso no puede ser posterior a la fecha actual.");
            }
        }

        private static bool EsFechaIngresoValida(DateTime fechaIngreso)
        {
            return fechaIngreso.Date <= DateTime.Today;
        }

        private static string NormalizarTexto(string? texto)
        {
            return texto?.Trim() ?? string.Empty;
        }
    }
}
