using capaDatos;
using capaEntidad;
using System;
using System.Data;

namespace capaNegocio
{
    public class N_Inventario
    {

        #region Variables privadas

        private D_Inventario ObjDB = null;

        #endregion

        #region Método index

        public void Index(ref E_Inventario Inventario)
        {
            ObjDB = new D_Inventario()
            {
                NombreTabla = "Productos",
                NombreSP = "[SP_Productos_Index]",
                Scalar = false
            };
            Ejecutar(ref Inventario);
        }

        #endregion

        #region CRUD Productos

        public void Create(ref E_Inventario Inventario)
        {
            ObjDB = new D_Inventario()
            {
                NombreTabla = "Productos",
                NombreSP = "[SP_Productos_Create]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@Nombre", "16", Inventario.Nombre);
            ObjDB.Dt.Rows.Add(@"@Descripcion", "16", Inventario.Descripcion);
            ObjDB.Dt.Rows.Add(@"@Cantidad", "4", Inventario.Cantidad);

            Ejecutar(ref Inventario);
        }

        public void Read(ref E_Inventario Inventario)
        {
            ObjDB = new D_Inventario()
            {
                NombreTabla = "Productos",
                NombreSP = "[SP_Productos_Read]",
                Scalar = false
            };

            ObjDB.Dt.Rows.Add(@"@IdProducto", "4", Inventario.IdProducto);

            Ejecutar(ref Inventario);
        }

        public void Update(ref E_Inventario Inventario)
        {
            ObjDB = new D_Inventario()
            {
                NombreTabla = "Productos",
                NombreSP = "[SP_Productos_Update]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@IdProducto", "4", Inventario.IdProducto);
            ObjDB.Dt.Rows.Add(@"@Nombre", "16", Inventario.Nombre);
            ObjDB.Dt.Rows.Add(@"@Descripcion", "16", Inventario.Descripcion);
            ObjDB.Dt.Rows.Add(@"@Cantidad", "4", Inventario.Cantidad);

            Ejecutar(ref Inventario);
        }

        public void Delete(ref E_Inventario Inventario)
        {
            ObjDB = new D_Inventario()
            {
                NombreTabla = "Productos",
                NombreSP = "[SP_Productos_Delete]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@IdProducto", "4", Inventario.IdProducto);

            Ejecutar(ref Inventario);
        }


        #endregion

        #region Métodos privados

        private void Ejecutar(ref E_Inventario Inventario)
        {
            ObjDB.CRUD(ref ObjDB);

            if (ObjDB.MensajeErrorDB == null)
            {
                if (ObjDB.Scalar)
                {
                    Inventario.ValorScalar = ObjDB.ValorScalar;
                }
                else
                {
                    Inventario.DtResultados = ObjDB.Ds.Tables[0];
                    if (Inventario.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in Inventario.DtResultados.Rows)
                        {
                            Inventario.IdProducto = Convert.ToInt32(item["IdProducto"].ToString());
                            Inventario.Nombre = (item["NomProv"].ToString());
                            Inventario.Descripcion = (item["Descripcion"].ToString());
                            Inventario.Cantidad = Convert.ToInt32(item["Cantidad"].ToString());

                        }
                    }
                }
            }
            else
            {
                Inventario.MensajeError = ObjDB.MensajeErrorDB;
            }
        }

        #endregion
    }

}

