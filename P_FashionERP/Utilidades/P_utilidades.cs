using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_FashionERP.Utilidades
{
    public class P_utilidades
    {
        public void FormatoDGV(ref DataGridView Dgv) 
        {
            DataGridViewCellStyle estilo = Dgv.ColumnHeadersDefaultCellStyle;
            estilo.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estilo.Font = new Font(Dgv.Font, FontStyle.Bold);
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.ReadOnly = true; 
        }


    }
}
