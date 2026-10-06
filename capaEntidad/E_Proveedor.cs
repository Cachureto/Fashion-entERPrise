using System.Data;

namespace capaEntidad
{
    public class E_Proveedor
    {

        #region Atributos privados
        private int _codProv;
        private string _nomProv;
        private string _razonsocial;
        private string _telefono;
        private string _email;

        // Atributos de manejo de la BD
        private string _mensajeError, _valorScalar;
        private DataTable _dtResultados;

        #endregion

        #region Atributos públicos
        public int CodProv { get => _codProv; set => _codProv = value; }
        public string NomProv { get => _nomProv; set => _nomProv = value; }
        public string Razonsocial { get => _razonsocial; set => _razonsocial = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public string MensajeError { get => _mensajeError; set => _mensajeError = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion

    }
}
