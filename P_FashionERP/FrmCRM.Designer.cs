namespace P_FashionERP
{
    partial class FrmCRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRM));
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.TxtNomCliente = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.labeCodigo = new System.Windows.Forms.Label();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TxtApellido1 = new System.Windows.Forms.TextBox();
            this.TxtApellido2 = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.DtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblIdCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Location = new System.Drawing.Point(9, 9);
            this.lblNomCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNomCliente.TabIndex = 6;
            this.lblNomCliente.Text = "Nombre";
            // 
            // TxtNomCliente
            // 
            this.TxtNomCliente.Location = new System.Drawing.Point(11, 26);
            this.TxtNomCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNomCliente.Name = "TxtNomCliente";
            this.TxtNomCliente.Size = new System.Drawing.Size(129, 20);
            this.TxtNomCliente.TabIndex = 7;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(160, 9);
            this.lblApellido1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(53, 13);
            this.lblApellido1.TabIndex = 8;
            this.lblApellido1.Text = "Apellido 1";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(312, 9);
            this.lblApellido2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(53, 13);
            this.lblApellido2.TabIndex = 9;
            this.lblApellido2.Text = "Apellido 2";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(462, 9);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(618, 9);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(77, 13);
            this.lblDocumento.TabIndex = 11;
            this.lblDocumento.Text = "N° Documento";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(9, 53);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "Genero";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(160, 53);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(312, 53);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Telefono";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(626, 68);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(63, 24);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(704, 68);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(63, 24);
            this.BtnActualizar.TabIndex = 17;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(780, 68);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(62, 24);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // labeCodigo
            // 
            this.labeCodigo.AutoSize = true;
            this.labeCodigo.Location = new System.Drawing.Point(9, 98);
            this.labeCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeCodigo.Name = "labeCodigo";
            this.labeCodigo.Size = new System.Drawing.Size(43, 13);
            this.labeCodigo.TabIndex = 19;
            this.labeCodigo.Text = "Código:";
            // 
            // DgvClientes
            // 
            this.DgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvClientes.Location = new System.Drawing.Point(1, 124);
            this.DgvClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.RowHeadersWidth = 51;
            this.DgvClientes.RowTemplate.Height = 24;
            this.DgvClientes.Size = new System.Drawing.Size(850, 375);
            this.DgvClientes.TabIndex = 20;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::FashionERP.Properties.Resources.lapiz_editar_20pxls;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // TxtApellido1
            // 
            this.TxtApellido1.Location = new System.Drawing.Point(162, 26);
            this.TxtApellido1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtApellido1.Name = "TxtApellido1";
            this.TxtApellido1.Size = new System.Drawing.Size(129, 20);
            this.TxtApellido1.TabIndex = 21;
            // 
            // TxtApellido2
            // 
            this.TxtApellido2.Location = new System.Drawing.Point(314, 26);
            this.TxtApellido2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtApellido2.Name = "TxtApellido2";
            this.TxtApellido2.Size = new System.Drawing.Size(129, 20);
            this.TxtApellido2.TabIndex = 22;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(464, 26);
            this.TxtEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(129, 20);
            this.TxtEdad.TabIndex = 23;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(620, 26);
            this.TxtDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(129, 20);
            this.TxtDocumento.TabIndex = 24;
            // 
            // TxtGenero
            // 
            this.TxtGenero.Location = new System.Drawing.Point(11, 70);
            this.TxtGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(129, 20);
            this.TxtGenero.TabIndex = 25;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(162, 70);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(129, 20);
            this.TxtEmail.TabIndex = 26;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(314, 70);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(129, 20);
            this.TxtTelefono.TabIndex = 27;
            // 
            // DtpFechaRegistro
            // 
            this.DtpFechaRegistro.Location = new System.Drawing.Point(464, 70);
            this.DtpFechaRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpFechaRegistro.Name = "DtpFechaRegistro";
            this.DtpFechaRegistro.Size = new System.Drawing.Size(151, 20);
            this.DtpFechaRegistro.TabIndex = 28;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(57, 98);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(13, 13);
            this.lblIdCliente.TabIndex = 29;
            this.lblIdCliente.Text = "_";
            // 
            // FrmCRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(850, 498);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.DtpFechaRegistro);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtApellido2);
            this.Controls.Add(this.TxtApellido1);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.labeCodigo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.TxtNomCliente);
            this.Controls.Add(this.lblNomCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCRM";
            this.Text = "FrmCRM";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.TextBox TxtNomCliente;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label labeCodigo;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.TextBox TxtApellido1;
        private System.Windows.Forms.TextBox TxtApellido2;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.DateTimePicker DtpFechaRegistro;
        private System.Windows.Forms.Label lblIdCliente;
    }
}