using System.Data;

namespace capaEntidad
{
    public class E_Inventario
    {
        #region Atributos privados
        private int _idProducto;
        private string _nombre;
        private string _descripcion;
        private int _cantidad;

        // Atributos de manejo de la BD
        private string _mensajeError, _valorScalar;
        private DataTable _dtResultados;
        #endregion

        #region Atributos públicos
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public string MensajeError { get => _mensajeError; set => _mensajeError = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}