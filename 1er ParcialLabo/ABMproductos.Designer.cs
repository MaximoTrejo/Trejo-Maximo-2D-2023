namespace _1er_ParcialLabo
{
    partial class ABMproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMproductos));
            this.ltbProductos = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpModificarProd = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxnombre = new System.Windows.Forms.TextBox();
            this.tbtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPrecioKilo = new System.Windows.Forms.TextBox();
            this.tbxPesoKilo = new System.Windows.Forms.TextBox();
            this.pnlBordeSuperior = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.ptbMini = new System.Windows.Forms.PictureBox();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpModificarProd.SuspendLayout();
            this.pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // ltbProductos
            // 
            this.ltbProductos.FormattingEnabled = true;
            this.ltbProductos.ItemHeight = 17;
            this.ltbProductos.Location = new System.Drawing.Point(12, 64);
            this.ltbProductos.Name = "ltbProductos";
            this.ltbProductos.Size = new System.Drawing.Size(309, 242);
            this.ltbProductos.TabIndex = 0;
            this.ltbProductos.SelectedIndexChanged += new System.EventHandler(this.ltbProductos_SelectedIndexChanged_1);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(143, 62);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 27);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(143, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 28);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // grpModificarProd
            // 
            this.grpModificarProd.Controls.Add(this.btnAceptar);
            this.grpModificarProd.Controls.Add(this.label1);
            this.grpModificarProd.Controls.Add(this.btnEliminar);
            this.grpModificarProd.Controls.Add(this.btnAgregar);
            this.grpModificarProd.Controls.Add(this.btnModificar);
            this.grpModificarProd.Controls.Add(this.tbxnombre);
            this.grpModificarProd.Controls.Add(this.tbtStock);
            this.grpModificarProd.Controls.Add(this.label4);
            this.grpModificarProd.Controls.Add(this.label2);
            this.grpModificarProd.Controls.Add(this.label3);
            this.grpModificarProd.Controls.Add(this.txbPrecioKilo);
            this.grpModificarProd.Controls.Add(this.tbxPesoKilo);
            this.grpModificarProd.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpModificarProd.Location = new System.Drawing.Point(348, 64);
            this.grpModificarProd.Name = "grpModificarProd";
            this.grpModificarProd.Size = new System.Drawing.Size(240, 239);
            this.grpModificarProd.TabIndex = 17;
            this.grpModificarProd.TabStop = false;
            this.grpModificarProd.Text = "Modificar Producto";
            this.grpModificarProd.Enter += new System.EventHandler(this.grpModificarProd_Enter);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(143, 199);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 26);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(143, 94);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 26);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tbxnombre
            // 
            this.tbxnombre.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbxnombre.Location = new System.Drawing.Point(7, 42);
            this.tbxnombre.Name = "tbxnombre";
            this.tbxnombre.Size = new System.Drawing.Size(114, 25);
            this.tbxnombre.TabIndex = 8;
            this.tbxnombre.TextChanged += new System.EventHandler(this.tbxnombre_TextChanged);
            // 
            // tbtStock
            // 
            this.tbtStock.Location = new System.Drawing.Point(7, 201);
            this.tbtStock.Name = "tbtStock";
            this.tbtStock.Size = new System.Drawing.Size(114, 25);
            this.tbtStock.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Peso x kilo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio x Kilo";
            // 
            // txbPrecioKilo
            // 
            this.txbPrecioKilo.Location = new System.Drawing.Point(7, 146);
            this.txbPrecioKilo.Name = "txbPrecioKilo";
            this.txbPrecioKilo.Size = new System.Drawing.Size(114, 25);
            this.txbPrecioKilo.TabIndex = 10;
            // 
            // tbxPesoKilo
            // 
            this.tbxPesoKilo.Location = new System.Drawing.Point(7, 94);
            this.tbxPesoKilo.Name = "tbxPesoKilo";
            this.tbxPesoKilo.Size = new System.Drawing.Size(114, 25);
            this.tbxPesoKilo.TabIndex = 9;
            // 
            // pnlBordeSuperior
            // 
            this.pnlBordeSuperior.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlBordeSuperior.Controls.Add(this.btnVolver);
            this.pnlBordeSuperior.Controls.Add(this.ptbMini);
            this.pnlBordeSuperior.Controls.Add(this.ptbSalir);
            this.pnlBordeSuperior.Controls.Add(this.label5);
            this.pnlBordeSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBordeSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBordeSuperior.Name = "pnlBordeSuperior";
            this.pnlBordeSuperior.Size = new System.Drawing.Size(608, 42);
            this.pnlBordeSuperior.TabIndex = 18;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(3, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(59, 26);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "<---";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // ptbMini
            // 
            this.ptbMini.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ptbMini.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbMini.Image = ((System.Drawing.Image)(resources.GetObject("ptbMini.Image")));
            this.ptbMini.Location = new System.Drawing.Point(487, 0);
            this.ptbMini.Name = "ptbMini";
            this.ptbMini.Size = new System.Drawing.Size(51, 42);
            this.ptbMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMini.TabIndex = 9;
            this.ptbMini.TabStop = false;
            // 
            // ptbSalir
            // 
            this.ptbSalir.BackColor = System.Drawing.SystemColors.Control;
            this.ptbSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbSalir.Image = global::_1er_ParcialLabo.Properties.Resources.salir;
            this.ptbSalir.Location = new System.Drawing.Point(538, 0);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(70, 42);
            this.ptbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSalir.TabIndex = 8;
            this.ptbSalir.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(68, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "ABM  Productos";
            // 
            // ABMproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(608, 320);
            this.Controls.Add(this.pnlBordeSuperior);
            this.Controls.Add(this.grpModificarProd);
            this.Controls.Add(this.ltbProductos);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMproductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM";
            this.Load += new System.EventHandler(this.ABMproductos_Load_1);
            this.grpModificarProd.ResumeLayout(false);
            this.grpModificarProd.PerformLayout();
            this.pnlBordeSuperior.ResumeLayout(false);
            this.pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox ltbProductos;
        private Button btnModificar;
        private Button btnEliminar;
        private GroupBox grpModificarProd;
        private Label label1;
        private Button btnAgregar;
        private TextBox tbxnombre;
        private TextBox tbtStock;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txbPrecioKilo;
        private TextBox tbxPesoKilo;
        private Button btnAceptar;
        private Panel pnlBordeSuperior;
        private PictureBox ptbMini;
        private PictureBox ptbSalir;
        private Label label5;
        private Button btnVolver;
    }
}