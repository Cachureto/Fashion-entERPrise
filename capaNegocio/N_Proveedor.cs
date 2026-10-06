using capaDatos;
using capaEntidad;
using System;
using System.Data;

namespace capaNegocio
{
    public class N_Proveedor
    {

        #region Variables privadas

        private D_Proveedor ObjDB = null;

        #endregion

        #region Método index

        public void Index(ref E_Proveedor Proveedor)
        {
            ObjDB = new D_Proveedor()
            {
                NombreTabla = "Proveedores",
                NombreSP = "[SP_Proveedores_Index]",
                Scalar = false
            };
            Ejecutar(ref Proveedor);
        }

        #endregion

        #region CRUD Proveedores

        public void Create(ref E_Proveedor Proveedor)
        {
            ObjDB = new D_Proveedor()
            {
                NombreTabla = "Proveedores",
                NombreSP = "[SP_Proveedores_Create]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@NomProv", "16", Proveedor.NomProv);
            ObjDB.Dt.Rows.Add(@"@Razonsocial", "16", Proveedor.Razonsocial);
            ObjDB.Dt.Rows.Add(@"@Telefono", "16", Proveedor.Telefono);
            ObjDB.Dt.Rows.Add(@"@Email", "16", Proveedor.Email);

            Ejecutar(ref Proveedor);
        }

        public void Read(ref E_Proveedor Proveedor)
        {
            ObjDB = new D_Proveedor()
            {
                NombreTabla = "Proveedores",
                NombreSP = "[SP_Proveedores_Read]",
                Scalar = false
            };

            ObjDB.Dt.Rows.Add(@"@CodProv", "4", Proveedor.CodProv);

            Ejecutar(ref Proveedor);
        }

        public void Update(ref E_Proveedor Proveedor)
        {
            ObjDB = new D_Proveedor()
            {
                NombreTabla = "Proveedores",
                NombreSP = "[SP_Proveedores_Update]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@CodPRov", "4", Proveedor.CodProv);
            ObjDB.Dt.Rows.Add(@"@NomProv", "16", Proveedor.NomProv);
            ObjDB.Dt.Rows.Add(@"@Razonsocial", "16", Proveedor.Razonsocial);
            ObjDB.Dt.Rows.Add(@"@Telefono", "16", Proveedor.Telefono);
            ObjDB.Dt.Rows.Add(@"@Email", "16", Proveedor.Email);

            Ejecutar(ref Proveedor);
        }

        public void Delete(ref E_Proveedor Proveedor)
        {
            ObjDB = new D_Proveedor()
            {
                NombreTabla = "Proveedores",
                NombreSP = "[SP_Proveedores_Delete]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@CodProv", "4", Proveedor.CodProv);

            Ejecutar(ref Proveedor);
        }


        #endregion

        #region Métodos privados

        private void Ejecutar(ref E_Proveedor Proveedor)
        {
            ObjDB.CRUD(ref ObjDB);

            if (ObjDB.MensajeErrorDB == null)
            {
                if (ObjDB.Scalar)
                {
                    Proveedor.ValorScalar = ObjDB.ValorScalar;
                }
                else
                {
                    Proveedor.DtResultados = ObjDB.Ds.Tables[0];
                    if (Proveedor.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in Proveedor.DtResultados.Rows)
                        {
                            Proveedor.CodProv = Convert.ToInt32(item["CodProv"].ToString());
                            Proveedor.NomProv = (item["NomProv"].ToString());
                            Proveedor.Razonsocial = (item["Razonsocial"].ToString());
                            Proveedor.Telefono = (item["Telefono"].ToString());
                            Proveedor.Email = (item["Email"].ToString());

                        }
                    }
                }
            }
            else
            {
                Proveedor.MensajeError = ObjDB.MensajeErrorDB;
            }
        }

        #endregion
    }

}

