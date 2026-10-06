using System;
using System.Windows.Forms;
using capaEntidad;
using capaNegocio;
using P_FashionERP.Utilidades;

namespace P_FashionERP
{
    public partial class FrmCRM : Form
    {

        private E_Cliente e_Cliente = null;
        private readonly N_Cliente n_Cliente = new N_Cliente();
        private P_utilidades p_Utilidades = new P_utilidades();

        public FrmCRM()
        {
            InitializeComponent();
            CargarListaClientes();
        }


        private void CargarListaClientes()
        {
            e_Cliente = new E_Cliente();
            n_Cliente.Index(ref e_Cliente);
            if (e_Cliente.MensajeError == null)
            {
                DgvClientes.DataSource = e_Cliente.DtResultados;
                p_Utilidades.FormatoDGV(ref DgvClientes);

            }
            else
            {
                MessageBox.Show(e_Cliente.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            e_Cliente = new E_Cliente()
            {
                Nombre = TxtNomCliente.Text,
                Apellido1 = TxtApellido1.Text,
                Apellido2 = TxtApellido2.Text,
                Edad = Convert.ToInt32(TxtEdad.Text),
                Documento = TxtDocumento.Text,
                Genero = TxtGenero.Text,
                Email = TxtEmail.Text,
                Telefono = TxtTelefono.Text,
                FechaRegistro = DtpFechaRegistro.Value
            };
            n_Cliente.Create(ref e_Cliente);
            if (e_Cliente.MensajeError == null)
            {
                MessageBox.Show("El Registro número: " + e_Cliente.ValorScalar + ", fue agregado correctamente");
                CargarListaClientes();
            }
            else
            {
                MessageBox.Show(e_Cliente.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvClientes.Columns[e.ColumnIndex].Name == "Editar")
                {
                    e_Cliente = new E_Cliente()
                    {
                        IdCliente = Convert.ToInt32(DgvClientes.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString())
                    };

                    lblIdCliente.Text = e_Cliente.IdCliente.ToString();

                    n_Cliente.Read(ref e_Cliente);

                    TxtNomCliente.Text = e_Cliente.Nombre;
                    TxtApellido1.Text = e_Cliente.Apellido1;
                    TxtApellido2.Text = e_Cliente.Apellido2;
                    TxtEdad.Text = e_Cliente.Edad.ToString();
                    TxtDocumento.Text = e_Cliente.Documento;
                    TxtGenero.Text = e_Cliente.Genero;
                    TxtEmail.Text = e_Cliente.Email;
                    TxtTelefono.Text = e_Cliente.Telefono;
                    DtpFechaRegistro.Value = e_Cliente.FechaRegistro;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            e_Cliente = new E_Cliente()
            {
                IdCliente = Convert.ToInt32(lblIdCliente.Text),
                Nombre = TxtNomCliente.Text,
                Apellido1 = TxtApellido1.Text,
                Apellido2 = TxtApellido2.Text,
                Edad = Convert.ToInt32(TxtEdad.Text),
                Documento = TxtDocumento.Text,
                Genero = TxtGenero.Text,
                Email = TxtEmail.Text,
                Telefono = TxtTelefono.Text,
                FechaRegistro = DtpFechaRegistro.Value
            };

            n_Cliente.Update(ref e_Cliente);
            
            if (e_Cliente.MensajeError == null)
            {
                MessageBox.Show("El Registro fue actualizado correctamente");
                CargarListaClientes();
            }
            else
            {
                MessageBox.Show(e_Cliente.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            e_Cliente = new E_Cliente()
            {
                IdCliente = Convert.ToInt32(lblIdCliente.Text)
            };

            n_Cliente.Delete(ref e_Cliente);
            
            if (e_Cliente.MensajeError == null)
            {
                MessageBox.Show("El Registro fue eliminado correctamente");
                CargarListaClientes();
            }
            else
            {
                MessageBox.Show(e_Cliente.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}