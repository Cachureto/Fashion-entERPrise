using capaDatos;
using capaEntidad;
using System;
using System.Data;

namespace capaNegocio
{
    public class N_Cliente
    {

        #region Variables privadas

        private D_Cliente ObjDB = null;

        #endregion

        #region Método index

        public void Index(ref E_Cliente Cliente)
        {
            ObjDB = new D_Cliente()
            {
                NombreTabla = "Clientes",
                NombreSP = "[dbo].[SP_Clientes_Index]",
                Scalar = false
            };
            Ejecutar(ref Cliente);
        }

        #endregion

        #region CRUD Clientes

        public void Create(ref E_Cliente Cliente)
        {
            ObjDB = new D_Cliente()
            {
                NombreTabla = "Clientes",
                NombreSP = "[dbo].[SP_Clientes_Create]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@Nombre", "16", Cliente.Nombre);
            ObjDB.Dt.Rows.Add(@"@Apellido1", "16", Cliente.Apellido1);
            ObjDB.Dt.Rows.Add(@"@Apellido2", "16", Cliente.Apellido2);
            ObjDB.Dt.Rows.Add(@"@Edad", "4", Cliente.Edad);
            ObjDB.Dt.Rows.Add(@"@Documento", "16", Cliente.Documento);
            ObjDB.Dt.Rows.Add(@"Genero", "16", Cliente.Genero);
            ObjDB.Dt.Rows.Add(@"@Email", "16", Cliente.Email);
            ObjDB.Dt.Rows.Add(@"@Telefono", "16", Cliente.Telefono);
            ObjDB.Dt.Rows.Add(@"@FechaRegistro", "13", Cliente.FechaRegistro);

            Ejecutar(ref Cliente);
        }

        public void Read(ref E_Cliente Cliente)
        {
            ObjDB = new D_Cliente()
            {
                NombreTabla = "Clientes",
                NombreSP = "[dbo].[SP_Clientes_Read]",
                Scalar = false
            };

            ObjDB.Dt.Rows.Add(@"@IdCliente", "4", Cliente.IdCliente);

            Ejecutar(ref Cliente);
        }

        public void Update(ref E_Cliente Cliente)
        {
            ObjDB = new D_Cliente()
            {
                NombreTabla = "Clientes",
                NombreSP = "[dbo].[SP_Clientes_Update]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@IdCliente", "4", Cliente.IdCliente);
            ObjDB.Dt.Rows.Add(@"@Nombre", "16", Cliente.Nombre);
            ObjDB.Dt.Rows.Add(@"@Apellido1", "16", Cliente.Apellido1);
            ObjDB.Dt.Rows.Add(@"@Apellido2", "16", Cliente.Apellido2);
            ObjDB.Dt.Rows.Add(@"@Edad", "4", Cliente.Edad);
            ObjDB.Dt.Rows.Add(@"@Documento", "16", Cliente.Documento);
            ObjDB.Dt.Rows.Add(@"Genero", "16", Cliente.Genero);
            ObjDB.Dt.Rows.Add(@"@Email", "16", Cliente.Email);
            ObjDB.Dt.Rows.Add(@"@Telefono", "16", Cliente.Telefono);
            ObjDB.Dt.Rows.Add(@"@FechaRegistro", "13", Cliente.FechaRegistro);

            Ejecutar(ref Cliente);
        }

        public void Delete(ref E_Cliente Cliente)
        {
            ObjDB = new D_Cliente()
            {
                NombreTabla = "Clientes",
                NombreSP = "[dbo].[SP_Clientes_Delete]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@IdCliente", "4", Cliente.IdCliente);

            Ejecutar(ref Cliente);
        }


        #endregion

        #region Métodos privados

        private void Ejecutar(ref E_Cliente Cliente)
        {
            ObjDB.CRUD(ref ObjDB);

            if (ObjDB.MensajeErrorDB == null)
            {
                if (ObjDB.Scalar)
                {
                    Cliente.ValorScalar = ObjDB.ValorScalar;
                }
                else
                {
                    Cliente.DtResultados = ObjDB.Ds.Tables[0];
                    if (Cliente.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in Cliente.DtResultados.Rows)
                        {
                            Cliente.IdCliente = Convert.ToInt32(item["IdCliente"].ToString());
                            Cliente.Nombre = (item["Nombre"].ToString());
                            Cliente.Apellido1 = (item["Apellido1"].ToString());
                            Cliente.Apellido2 = (item["Apellido2"].ToString());
                            Cliente.Edad = Convert.ToInt32(item["Edad"].ToString());
                            Cliente.Apellido2 = (item["Apellido2"].ToString());
                            Cliente.Documento = (item["Documento"].ToString());
                            Cliente.Genero = (item["Genero"].ToString());
                            Cliente.Email = (item["Email"].ToString());
                            Cliente.Telefono = (item["Telefono"].ToString());
                            Cliente.FechaRegistro = Convert.ToDateTime(item["FechaRegistro"].ToString());

                        }
                    }
                }
            }
            else
            {
                Cliente.MensajeError = ObjDB.MensajeErrorDB;
            }
        }

        #endregion
    }

}

