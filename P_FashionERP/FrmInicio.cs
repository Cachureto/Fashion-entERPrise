using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_FashionERP
{
    public partial class FrmInicio : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
                MenuActivo.IconColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            }

            menu.BackColor = Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            menu.IconColor = Color.White;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);
            formulario.Show();

        }

        private void iconRRHH_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmRRHH());
        }

        private void iconCRM_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmCRM());
        }

        private void iconInventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmInventario());
        }

        private void iconProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmCRUDProveedor());
        }
    }
}
