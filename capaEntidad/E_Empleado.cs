using System.Data;

namespace capaEntidad
{
    public class E_Empleado
    {
        #region Atributos privados
        private int _idEmpleado;
        private string _nombre;
        private string _apellido1;
        private string _apellido2;
        private string _genero;
        private int _edad;
        private string _Documento;
        private string _email;
        private string _telefono;
        private string _estadoCivil;

        // Atributos de manejo de la BD
        private string _mensajeError, _valorScalar;
        private DataTable _dtResultados;
        #endregion

        #region Atributos públicos
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido1 { get => _apellido1; set => _apellido1 = value; }
        public string Apellido2 { get => _apellido2; set => _apellido2 = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string EstadoCivil { get => _estadoCivil; set => _estadoCivil = value; }
        public string MensajeError { get => _mensajeError; set => _mensajeError = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}