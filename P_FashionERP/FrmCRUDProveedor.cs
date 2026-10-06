using capaEntidad;
using capaNegocio;
using P_FashionERP.Utilidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace P_FashionERP
{
    public partial class FrmCRUDProveedor : Form
    {
        private E_Proveedor e_Proveedor = null;
        private readonly N_Proveedor  n_Proveedor = new N_Proveedor();
        private P_utilidades p_Utilidades = new P_utilidades();

        public FrmCRUDProveedor()
        {
            InitializeComponent();
            CargarListaUsuarios();
        }

        private void CargarListaUsuarios() 
        {
            e_Proveedor = new E_Proveedor();
            n_Proveedor.Index(ref e_Proveedor);
            if (e_Proveedor.MensajeError == null)
            {
                DgvProveedores.DataSource = e_Proveedor.DtResultados;
                p_Utilidades.FormatoDGV(ref DgvProveedores);

            }
            else
            {
                MessageBox.Show(e_Proveedor.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            e_Proveedor = new E_Proveedor()
            {
                NomProv = TxtNomProv.Text,
                Razonsocial = TxtRazonsocial.Text,
                Telefono = TxtTelefono.Text,
                Email = TxtEmail.Text
            };

            n_Proveedor.Create(ref e_Proveedor);

            if (e_Proveedor.MensajeError == null)
            {
                MessageBox.Show("El Registro número: "+ e_Proveedor.ValorScalar +", fue agregado correctamente");
                CargarListaUsuarios();
            }
            else
            {
                MessageBox.Show(e_Proveedor.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvProveedores.Columns[e.ColumnIndex].Name == "Editar")
                {
                    e_Proveedor = new E_Proveedor()
                    {
                        CodProv = Convert.ToInt32(DgvProveedores.Rows[e.RowIndex].Cells["CodProv"].Value.ToString())
                    };

                    LblCodProveedor.Text = e_Proveedor.CodProv.ToString();

                    n_Proveedor.Read(ref e_Proveedor);

                    TxtNomProv.Text = e_Proveedor.NomProv;
                    TxtRazonsocial.Text = e_Proveedor.Razonsocial;
                    TxtTelefono.Text = e_Proveedor.Telefono;
                    TxtEmail.Text = e_Proveedor.Email;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            e_Proveedor = new E_Proveedor()
            {
                CodProv = Convert.ToInt32(LblCodProveedor.Text),
                NomProv = TxtNomProv.Text,
                Razonsocial = TxtRazonsocial.Text,
                Telefono = TxtTelefono.Text,
                Email = TxtEmail.Text
            };

            n_Proveedor.Update(ref e_Proveedor);

            if (e_Proveedor.MensajeError == null)
            {
                MessageBox.Show("El Registro fue actualizado correctamente");
                CargarListaUsuarios();
            }
            else
            {
                MessageBox.Show(e_Proveedor.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            e_Proveedor = new E_Proveedor()
            {
                CodProv = Convert.ToInt32(LblCodProveedor.Text)
            };

            n_Proveedor.Delete(ref e_Proveedor);

            CargarListaUsuarios();
        }

        private void FrmCRUDProveedor_Load(object sender, EventArgs e)
        {

        }

        private void lblNomProv_Click(object sender, EventArgs e)
        {

        }
    }
}
