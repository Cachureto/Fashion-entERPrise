namespace P_FashionERP
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.menuModulos = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconInicio = new FontAwesome.Sharp.IconMenuItem();
            this.iconRRHH = new FontAwesome.Sharp.IconMenuItem();
            this.iconCRM = new FontAwesome.Sharp.IconMenuItem();
            this.iconInventario = new FontAwesome.Sharp.IconMenuItem();
            this.iconProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuTitulo.Location = new System.Drawing.Point(96, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(837, 110);
            this.menuTitulo.TabIndex = 0;
            this.menuTitulo.Text = "menuStrip1";
            // 
            // menuModulos
            // 
            this.menuModulos.AutoSize = false;
            this.menuModulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.menuModulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuModulos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuModulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconInicio,
            this.iconRRHH,
            this.iconCRM,
            this.iconInventario,
            this.iconProveedores});
            this.menuModulos.Location = new System.Drawing.Point(0, 0);
            this.menuModulos.Name = "menuModulos";
            this.menuModulos.Size = new System.Drawing.Size(96, 579);
            this.menuModulos.TabIndex = 1;
            this.menuModulos.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("Rockwell", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(96, 110);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(837, 469);
            this.panelContenedor.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.pictureBox1.Image = global::FashionERP.Properties.Resources.Icono_FashionentERPrise_2;
            this.pictureBox1.Location = new System.Drawing.Point(821, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // iconInicio
            // 
            this.iconInicio.AutoSize = false;
            this.iconInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            this.iconInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInicio.IconSize = 52;
            this.iconInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconInicio.Name = "iconInicio";
            this.iconInicio.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.iconInicio.Size = new System.Drawing.Size(87, 86);
            // 
            // iconRRHH
            // 
            this.iconRRHH.AutoSize = false;
            this.iconRRHH.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.iconRRHH.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            this.iconRRHH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRRHH.IconSize = 52;
            this.iconRRHH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconRRHH.Name = "iconRRHH";
            this.iconRRHH.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.iconRRHH.Size = new System.Drawing.Size(87, 86);
            this.iconRRHH.Click += new System.EventHandler(this.iconRRHH_Click);
            // 
            // iconCRM
            // 
            this.iconCRM.AutoSize = false;
            this.iconCRM.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconCRM.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            this.iconCRM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCRM.IconSize = 52;
            this.iconCRM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconCRM.Name = "iconCRM";
            this.iconCRM.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.iconCRM.Size = new System.Drawing.Size(87, 86);
            this.iconCRM.Click += new System.EventHandler(this.iconCRM_Click);
            // 
            // iconInventario
            // 
            this.iconInventario.AutoSize = false;
            this.iconInventario.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.iconInventario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            this.iconInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInventario.IconSize = 52;
            this.iconInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconInventario.Name = "iconInventario";
            this.iconInventario.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.iconInventario.Size = new System.Drawing.Size(87, 86);
            this.iconInventario.Click += new System.EventHandler(this.iconInventario_Click);
            // 
            // iconProveedores
            // 
            this.iconProveedores.AutoSize = false;
            this.iconProveedores.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            this.iconProveedores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            this.iconProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProveedores.IconSize = 52;
            this.iconProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconProveedores.Name = "iconProveedores";
            this.iconProveedores.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.iconProveedores.Size = new System.Drawing.Size(87, 86);
            this.iconProveedores.Click += new System.EventHandler(this.iconProveedores_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 579);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTitulo);
            this.Controls.Add(this.menuModulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTitulo;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fashion Enterprise";
            this.menuModulos.ResumeLayout(false);
            this.menuModulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.MenuStrip menuModulos;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem iconInicio;
        private FontAwesome.Sharp.IconMenuItem iconProveedores;
        private FontAwesome.Sharp.IconMenuItem iconRRHH;
        private FontAwesome.Sharp.IconMenuItem iconInventario;
        private FontAwesome.Sharp.IconMenuItem iconCRM;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}