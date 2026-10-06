namespace P_FashionERP
{
    partial class FrmCRUDProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUDProveedor));
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TxtNomProv = new System.Windows.Forms.TextBox();
            this.TxtRazonsocial = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.lblNomProv = new System.Windows.Forms.Label();
            this.lblRazon = new System.Windows.Forms.Label();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.LblCodProveedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProveedores
            // 
            this.DgvProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.DgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvProveedores.Location = new System.Drawing.Point(12, 142);
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.RowHeadersWidth = 51;
            this.DgvProveedores.RowTemplate.Height = 24;
            this.DgvProveedores.Size = new System.Drawing.Size(1045, 427);
            this.DgvProveedores.TabIndex = 0;
            this.DgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::FashionERP.Properties.Resources.lapiz_editar_20pxls;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // TxtNomProv
            // 
            this.TxtNomProv.Location = new System.Drawing.Point(17, 32);
            this.TxtNomProv.Name = "TxtNomProv";
            this.TxtNomProv.Size = new System.Drawing.Size(171, 22);
            this.TxtNomProv.TabIndex = 1;
            // 
            // TxtRazonsocial
            // 
            this.TxtRazonsocial.Location = new System.Drawing.Point(211, 32);
            this.TxtRazonsocial.Name = "TxtRazonsocial";
            this.TxtRazonsocial.Size = new System.Drawing.Size(171, 22);
            this.TxtRazonsocial.TabIndex = 2;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(405, 32);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(171, 22);
            this.TxtTelefono.TabIndex = 3;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(17, 81);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(171, 22);
            this.TxtEmail.TabIndex = 4;
            // 
            // lblNomProv
            // 
            this.lblNomProv.AutoSize = true;
            this.lblNomProv.Location = new System.Drawing.Point(17, 11);
            this.lblNomProv.Name = "lblNomProv";
            this.lblNomProv.Size = new System.Drawing.Size(145, 16);
            this.lblNomProv.TabIndex = 5;
            this.lblNomProv.Text = "Nombre del Proveedor";
            this.lblNomProv.Click += new System.EventHandler(this.lblNomProv_Click);
            // 
            // lblRazon
            // 
            this.lblRazon.AutoSize = true;
            this.lblRazon.Location = new System.Drawing.Point(208, 11);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(87, 16);
            this.lblRazon.TabIndex = 6;
            this.lblRazon.Text = "Razón Social";
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.Location = new System.Drawing.Point(402, 11);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(61, 16);
            this.lblTelef.TabIndex = 7;
            this.lblTelef.Text = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(256, 81);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(84, 30);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(346, 81);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(84, 30);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(436, 81);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(82, 30);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 114);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Código:";
            // 
            // LblCodProveedor
            // 
            this.LblCodProveedor.AutoSize = true;
            this.LblCodProveedor.Location = new System.Drawing.Point(90, 114);
            this.LblCodProveedor.Name = "LblCodProveedor";
            this.LblCodProveedor.Size = new System.Drawing.Size(0, 16);
            this.LblCodProveedor.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 17;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::FashionERP.Properties.Resources.lapiz_editar_20pxls;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // FrmCRUDProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1069, 581);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblCodProveedor);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelef);
            this.Controls.Add(this.lblRazon);
            this.Controls.Add(this.lblNomProv);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtRazonsocial);
            this.Controls.Add(this.TxtNomProv);
            this.Controls.Add(this.DgvProveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCRUDProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fashion Enterprise";
            this.Load += new System.EventHandler(this.FrmCRUDProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProveedores;
        private System.Windows.Forms.TextBox TxtNomProv;
        private System.Windows.Forms.TextBox TxtRazonsocial;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label lblNomProv;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label LblCodProveedor;
        private System.Windows.Forms.Label label7;
    }
}