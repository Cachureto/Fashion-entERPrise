using capaDatos;
using capaEntidad;
using System;
using System.Data;

namespace capaNegocio
{
    public class N_Empleado
    {

        #region Variables privadas

        private D_Empleado ObjDB = null;

        #endregion

        #region Método index

        public void Index(ref E_Empleado Empleado)
        {
            ObjDB = new D_Empleado()
            {
                NombreTabla = "Empleados",
                NombreSP = "[SP_Empleados_Index]",
                Scalar = false
            };
            Ejecutar(ref Empleado);
        }

        #endregion

        #region CRUD Empleados

        public void Create(ref E_Empleado Empleado)
        {
            ObjDB = new D_Empleado()
            {
                NombreTabla = "Empleados",
                NombreSP = "[SP_Empleados_Create]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@Nombre", "16", Empleado.Nombre);
            ObjDB.Dt.Rows.Add(@"@Apellido1", "16", Empleado.Apellido1);
            ObjDB.Dt.Rows.Add(@"@Apellido2", "16", Empleado.Apellido2);
            ObjDB.Dt.Rows.Add(@"@Edad", "4", Empleado.Edad);
            ObjDB.Dt.Rows.Add(@"@Documento", "16", Empleado.Documento);
            ObjDB.Dt.Rows.Add(@"Genero", "16", Empleado.Genero);
            ObjDB.Dt.Rows.Add(@"@Email", "16", Empleado.Email);
            ObjDB.Dt.Rows.Add(@"@Telefono", "16", Empleado.Telefono);
            ObjDB.Dt.Rows.Add(@"@EstadoCivil", "16", Empleado.EstadoCivil);

            Ejecutar(ref Empleado);
        }

        public void Read(ref E_Empleado Empleado)
        {
            ObjDB = new D_Empleado()
            {
                NombreTabla = "Empleados",
                NombreSP = "[SP_Empleados_Read]",
                Scalar = false
            };

            ObjDB.Dt.Rows.Add(@"@IdEmpleado", "4", Empleado.IdEmpleado);

            Ejecutar(ref Empleado);
        }

        public void Update(ref E_Empleado Empleado)
        {
            ObjDB = new D_Empleado()
            {
                NombreTabla = "Empleados",
                NombreSP = "[SP_Empleados_Update]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@IdEmpleado", "4", Empleado.IdEmpleado);
            ObjDB.Dt.Rows.Add(@"@Nombre", "16", Empleado.Nombre);
            ObjDB.Dt.Rows.Add(@"@Apellido1", "16", Empleado.Apellido1);
            ObjDB.Dt.Rows.Add(@"@Apellido2", "16", Empleado.Apellido2);
            ObjDB.Dt.Rows.Add(@"@Edad", "4", Empleado.Edad);
            ObjDB.Dt.Rows.Add(@"@Documento", "16", Empleado.Documento);
            ObjDB.Dt.Rows.Add(@"Genero", "16", Empleado.Genero);
            ObjDB.Dt.Rows.Add(@"@Email", "16", Empleado.Email);
            ObjDB.Dt.Rows.Add(@"@Telefono", "16", Empleado.Telefono);
            ObjDB.Dt.Rows.Add(@"@EstadoCivil", "16", Empleado.EstadoCivil);

            Ejecutar(ref Empleado);
        }

        public void Delete(ref E_Empleado Empleado)
        {
            ObjDB = new D_Empleado()
            {
                NombreTabla = "Empleados",
                NombreSP = "[SP_Empleados_Delete]",
                Scalar = true
            };

            ObjDB.Dt.Rows.Add(@"@IdEmpleado", "4", Empleado.IdEmpleado);

            Ejecutar(ref Empleado);
        }


        #endregion

        #region Métodos privados

        private void Ejecutar(ref E_Empleado Empleado)
        {
            ObjDB.CRUD(ref ObjDB);

            if (ObjDB.MensajeErrorDB == null)
            {
                if (ObjDB.Scalar)
                {
                    Empleado.ValorScalar = ObjDB.ValorScalar;
                }
                else
                {
                    Empleado.DtResultados = ObjDB.Ds.Tables[0];
                    if (Empleado.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in Empleado.DtResultados.Rows)
                        {
                            Empleado.IdEmpleado = Convert.ToInt32(item["IdEmpleado"].ToString());
                            Empleado.Nombre = (item["Nombre"].ToString());
                            Empleado.Apellido1 = (item["Apellido1"].ToString());
                            Empleado.Apellido2 = (item["Apellido2"].ToString());
                            Empleado.Edad = Convert.ToInt32(item["Edad"].ToString());
                            Empleado.Documento = (item["Documento"].ToString());
                            Empleado.Genero = (item["Genero"].ToString());
                            Empleado.Email = (item["Email"].ToString());
                            Empleado.Telefono = (item["Telefono"].ToString());
                            Empleado.EstadoCivil = (item["EstadoCivil"].ToString());


                        }
                    }
                }
            }
            else
            {
                Empleado.MensajeError = ObjDB.MensajeErrorDB;
            }
        }

        #endregion
    }

}

