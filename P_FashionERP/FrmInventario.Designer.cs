namespace P_FashionERP
{
    partial class FrmInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblNomProd = new System.Windows.Forms.Label();
            this.TxtNomProd = new System.Windows.Forms.TextBox();
            this.lblDescri = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.TxtCantProd = new System.Windows.Forms.TextBox();
            this.TxtDescProd = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProductos
            // 
            this.DgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvProductos.Location = new System.Drawing.Point(12, 182);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(948, 336);
            this.DgvProductos.TabIndex = 1;
            this.DgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::FashionERP.Properties.Resources.lapiz_editar_20pxls;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // lblNomProd
            // 
            this.lblNomProd.AutoSize = true;
            this.lblNomProd.Location = new System.Drawing.Point(13, 18);
            this.lblNomProd.Name = "lblNomProd";
            this.lblNomProd.Size = new System.Drawing.Size(135, 16);
            this.lblNomProd.TabIndex = 6;
            this.lblNomProd.Text = "Nombre del Producto";
            this.lblNomProd.Click += new System.EventHandler(this.lblNomProv_Click);
            // 
            // TxtNomProd
            // 
            this.TxtNomProd.Location = new System.Drawing.Point(12, 48);
            this.TxtNomProd.Name = "TxtNomProd";
            this.TxtNomProd.Size = new System.Drawing.Size(171, 22);
            this.TxtNomProd.TabIndex = 7;
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.Location = new System.Drawing.Point(235, 18);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(79, 16);
            this.lblDescri.TabIndex = 8;
            this.lblDescri.Text = "Descripcion";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(786, 18);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(61, 16);
            this.lblCant.TabIndex = 9;
            this.lblCant.Text = "Cantidad";
            // 
            // TxtCantProd
            // 
            this.TxtCantProd.Location = new System.Drawing.Point(789, 48);
            this.TxtCantProd.Name = "TxtCantProd";
            this.TxtCantProd.Size = new System.Drawing.Size(171, 22);
            this.TxtCantProd.TabIndex = 10;
            // 
            // TxtDescProd
            // 
            this.TxtDescProd.Location = new System.Drawing.Point(238, 48);
            this.TxtDescProd.Name = "TxtDescProd";
            this.TxtDescProd.Size = new System.Drawing.Size(508, 22);
            this.TxtDescProd.TabIndex = 11;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(230, 120);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(84, 30);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(454, 120);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(84, 30);
            this.BtnActualizar.TabIndex = 13;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(664, 120);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(82, 30);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 530);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtDescProd);
            this.Controls.Add(this.TxtCantProd);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblDescri);
            this.Controls.Add(this.TxtNomProd);
            this.Controls.Add(this.lblNomProd);
            this.Controls.Add(this.DgvProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInventario";
            this.Text = "Fashion Enterprice";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Label lblNomProd;
        private System.Windows.Forms.TextBox TxtNomProd;
        private System.Windows.Forms.Label lblDescri;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.TextBox TxtCantProd;
        private System.Windows.Forms.TextBox TxtDescProd;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}