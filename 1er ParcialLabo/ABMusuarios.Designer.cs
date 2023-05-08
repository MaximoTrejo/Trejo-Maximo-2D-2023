namespace _1er_ParcialLabo
{
    partial class ABMusuarios
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
            this.ltbUsuarios = new System.Windows.Forms.ListBox();
            this.grpModificarProd = new System.Windows.Forms.GroupBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbxnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbImporte = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.grpModificarProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbUsuarios
            // 
            this.ltbUsuarios.FormattingEnabled = true;
            this.ltbUsuarios.ItemHeight = 19;
            this.ltbUsuarios.Location = new System.Drawing.Point(14, 94);
            this.ltbUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ltbUsuarios.Name = "ltbUsuarios";
            this.ltbUsuarios.Size = new System.Drawing.Size(353, 308);
            this.ltbUsuarios.TabIndex = 1;
            this.ltbUsuarios.SelectedIndexChanged += new System.EventHandler(this.ltbUsuarios_SelectedIndexChanged);
            // 
            // grpModificarProd
            // 
            this.grpModificarProd.Controls.Add(this.cbxCategoria);
            this.grpModificarProd.Controls.Add(this.lblCategoria);
            this.grpModificarProd.Controls.Add(this.btnAceptar);
            this.grpModificarProd.Controls.Add(this.label1);
            this.grpModificarProd.Controls.Add(this.btnEliminar);
            this.grpModificarProd.Controls.Add(this.btnAgregar);
            this.grpModificarProd.Controls.Add(this.btnModificar);
            this.grpModificarProd.Controls.Add(this.tbxnombre);
            this.grpModificarProd.Controls.Add(this.label2);
            this.grpModificarProd.Controls.Add(this.label3);
            this.grpModificarProd.Controls.Add(this.txbImporte);
            this.grpModificarProd.Controls.Add(this.tbxPass);
            this.grpModificarProd.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpModificarProd.Location = new System.Drawing.Point(392, 94);
            this.grpModificarProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpModificarProd.Name = "grpModificarProd";
            this.grpModificarProd.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpModificarProd.Size = new System.Drawing.Size(274, 313);
            this.grpModificarProd.TabIndex = 18;
            this.grpModificarProd.TabStop = false;
            this.grpModificarProd.Text = "Modificar Producto";
            this.grpModificarProd.Enter += new System.EventHandler(this.grpModificarProd_Enter);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(7, 272);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(130, 25);
            this.cbxCategoria.TabIndex = 18;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(7, 248);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 17);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(163, 272);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 33);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(163, 34);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(163, 119);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 33);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(163, 79);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 34);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbxnombre
            // 
            this.tbxnombre.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbxnombre.Location = new System.Drawing.Point(7, 60);
            this.tbxnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxnombre.Name = "tbxnombre";
            this.tbxnombre.Size = new System.Drawing.Size(130, 25);
            this.tbxnombre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Importe";
            // 
            // txbImporte
            // 
            this.txbImporte.Location = new System.Drawing.Point(6, 202);
            this.txbImporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbImporte.Name = "txbImporte";
            this.txbImporte.Size = new System.Drawing.Size(130, 25);
            this.txbImporte.TabIndex = 10;

            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(7, 132);
            this.tbxPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(130, 25);
            this.tbxPass.TabIndex = 9;
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(12, 64);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnVendedor.TabIndex = 19;
            this.btnVendedor.Text = "Vendedores";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(109, 64);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 23);
            this.btnClientes.TabIndex = 20;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // ABMusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 422);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.grpModificarProd);
            this.Controls.Add(this.ltbUsuarios);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ABMusuarios";
            this.Text = "ABMusuarios";
            this.grpModificarProd.ResumeLayout(false);
            this.grpModificarProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox ltbUsuarios;
        private GroupBox grpModificarProd;
        private Button btnAceptar;
        private Label label1;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnModificar;
        private TextBox tbxnombre;
        private Label label2;
        private Label label3;
        private TextBox txbImporte;
        private TextBox tbxPass;
        private Label lblCategoria;
        private ComboBox cbxCategoria;
        private Button btnVendedor;
        private Button btnClientes;
    }
}