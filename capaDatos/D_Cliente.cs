using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class D_Cliente
    {
        #region Variables privadas

        private SqlConnection _cn;
        private SqlDataAdapter _da;
        private SqlCommand _cmd;
        private DataSet _ds;
        private DataTable _dt;
        private string _nombreTabla, _nombreSP, _mensajeErrorDB, _valorScalar, _nombreDB;
        private bool _scalar;

        #endregion

        #region Variables públicas

        public SqlConnection Cn { get => _cn; set => _cn = value; }
        public SqlDataAdapter Da { get => _da; set => _da = value; }
        public SqlCommand Cmd { get => _cmd; set => _cmd = value; }
        public DataSet Ds { get => _ds; set => _ds = value; }
        public DataTable Dt { get => _dt; set => _dt = value; }
        public string NombreTabla { get => _nombreTabla; set => _nombreTabla = value; }
        public string NombreSP { get => _nombreSP; set => _nombreSP = value; }
        public string MensajeErrorDB { get => _mensajeErrorDB; set => _mensajeErrorDB = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public string NombreDB { get => _nombreDB; set => _nombreDB = value; }
        public bool Scalar { get => _scalar; set => _scalar = value; }

        #endregion

        #region Constructores

        public D_Cliente()
        {
            _dt = new DataTable("SpParametros");
            _dt.Columns.Add("Nombre");
            _dt.Columns.Add("TipoDato");
            _dt.Columns.Add("Valor");

            NombreDB = "Fashionenterprise"; // misma BD usada por los demás módulos
        }

        #endregion

        #region Métodos privados

        private void CrearConexionBD(ref D_Cliente Db)
        {
            switch (Db.NombreDB)
            {
                case "Fashionenterprise":
                    Db._cn = new SqlConnection(Properties.Settings.Default.cadenaConeccion_DB_Fashionenterprise);
                    break;
                default:
                    break;
            }
        }

        private void ValidarConexionBD(ref D_Cliente Db)
        {
            if (Db._cn.State == ConnectionState.Closed)
            {
                Db._cn.Open();
            }
            else
            {
                Db._cn.Close();
                Db._cn.Dispose();
            }
        }

        private void AgregarParametros(ref D_Cliente Db)
        {
            if (Db.Dt != null)
            {
                SqlDbType TipoDatoSQL = new SqlDbType();

                foreach (DataRow item in Db.Dt.Rows)
                {
                    switch (item[1])
                    {
                        case "1": TipoDatoSQL = SqlDbType.Bit; break;
                        case "2": TipoDatoSQL = SqlDbType.TinyInt; break;
                        case "3": TipoDatoSQL = SqlDbType.SmallInt; break;
                        case "4": TipoDatoSQL = SqlDbType.Int; break;
                        case "5": TipoDatoSQL = SqlDbType.BigInt; break;
                        case "6": TipoDatoSQL = SqlDbType.Decimal; break;
                        case "7": TipoDatoSQL = SqlDbType.SmallMoney; break;
                        case "8": TipoDatoSQL = SqlDbType.Money; break;
                        case "9": TipoDatoSQL = SqlDbType.Float; break;
                        case "10": TipoDatoSQL = SqlDbType.Real; break;
                        case "11": TipoDatoSQL = SqlDbType.Date; break;
                        case "12": TipoDatoSQL = SqlDbType.Time; break;
                        case "13": TipoDatoSQL = SqlDbType.SmallDateTime; break;
                        case "14": TipoDatoSQL = SqlDbType.Char; break;
                        case "15": TipoDatoSQL = SqlDbType.NChar; break;
                        case "16": TipoDatoSQL = SqlDbType.VarChar; break;
                        case "17": TipoDatoSQL = SqlDbType.NVarChar; break;
                        default: break;
                    }

                    if (Db.Scalar)
                    {
                        if (item[2].ToString().Equals(string.Empty))
                            Db._cmd.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = DBNull.Value;
                        else
                            Db._cmd.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = item[2].ToString();
                    }
                    else
                    {
                        if (item[2].ToString().Equals(string.Empty))
                            Db._da.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = DBNull.Value;
                        else
                            Db._da.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = item[2].ToString();
                    }
                }
            }
        }

        private void PrepararConexionBD(ref D_Cliente Db)
        {
            CrearConexionBD(ref Db);
            ValidarConexionBD(ref Db);
        }

        private void EjecutarDA(ref D_Cliente Db)
        {
            try
            {
                PrepararConexionBD(ref Db);

                Db.Da = new SqlDataAdapter(Db.NombreSP, Db.Cn);
                Db.Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                AgregarParametros(ref Db);
                Db.Ds = new DataSet();
                Db.Da.Fill(Db.Ds, Db.NombreTabla);
            }
            catch (Exception ex)
            {
                Db.MensajeErrorDB = ex.Message.ToString();
            }
            finally
            {
                if (Db.Cn.State == ConnectionState.Open)
                {
                    ValidarConexionBD(ref Db);
                }
            }
        }

        private void EjecutarCMD(ref D_Cliente Db)
        {
            try
            {
                PrepararConexionBD(ref Db);
                Db.Cmd = new SqlCommand(Db.NombreSP, Db.Cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                AgregarParametros(ref Db);

                if (Db.Scalar)
                {
                    Db.ValorScalar = Db.Cmd.ExecuteScalar().ToString().Trim();
                }
                else
                {
                    Db.Cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Db.MensajeErrorDB = ex.ToString();
            }
            finally
            {
                if (Db.Cn.State == ConnectionState.Open)
                {
                    ValidarConexionBD(ref Db);
                }
            }
        }

        #endregion

        #region Métodos públicos

        public void CRUD(ref D_Cliente Db)
        {
            if (Db.Scalar)
            {
                EjecutarCMD(ref Db);
            }
            else
            {
                EjecutarDA(ref Db);
            }
        }

        #endregion
    }
}