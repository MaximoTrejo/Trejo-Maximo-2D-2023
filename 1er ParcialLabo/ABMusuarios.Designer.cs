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
            ltbUsuarios = new ListBox();
            grpModificarProd = new GroupBox();
            btnAceptar = new Button();
            label1 = new Label();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            tbxnombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txbImporte = new TextBox();
            tbxPass = new TextBox();
            lblCategoria = new Label();
            cbxCategoria = new ComboBox();
            grpModificarProd.SuspendLayout();
            SuspendLayout();
            // 
            // ltbUsuarios
            // 
            ltbUsuarios.FormattingEnabled = true;
            ltbUsuarios.ItemHeight = 15;
            ltbUsuarios.Location = new Point(12, 74);
            ltbUsuarios.Name = "ltbUsuarios";
            ltbUsuarios.Size = new Size(309, 244);
            ltbUsuarios.TabIndex = 1;
            ltbUsuarios.SelectedIndexChanged += ltbUsuarios_SelectedIndexChanged;
            // 
            // grpModificarProd
            // 
            grpModificarProd.Controls.Add(cbxCategoria);
            grpModificarProd.Controls.Add(lblCategoria);
            grpModificarProd.Controls.Add(btnAceptar);
            grpModificarProd.Controls.Add(label1);
            grpModificarProd.Controls.Add(btnEliminar);
            grpModificarProd.Controls.Add(btnAgregar);
            grpModificarProd.Controls.Add(btnModificar);
            grpModificarProd.Controls.Add(tbxnombre);
            grpModificarProd.Controls.Add(label2);
            grpModificarProd.Controls.Add(label3);
            grpModificarProd.Controls.Add(txbImporte);
            grpModificarProd.Controls.Add(tbxPass);
            grpModificarProd.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            grpModificarProd.Location = new Point(343, 74);
            grpModificarProd.Name = "grpModificarProd";
            grpModificarProd.Size = new Size(240, 247);
            grpModificarProd.TabIndex = 18;
            grpModificarProd.TabStop = false;
            grpModificarProd.Text = "Modificar Producto";
            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderColor = Color.DarkGray;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(143, 215);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 26);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 27);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.DarkGray;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(143, 27);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 28);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderColor = Color.DarkGray;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(143, 94);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 26);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderColor = Color.DarkGray;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(143, 62);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 27);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // tbxnombre
            // 
            tbxnombre.ImeMode = ImeMode.On;
            tbxnombre.Location = new Point(6, 47);
            tbxnombre.Name = "tbxnombre";
            tbxnombre.Size = new Size(114, 25);
            tbxnombre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 84);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 12;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 13;
            label3.Text = "Importe";
            // 
            // txbImporte
            // 
            txbImporte.Location = new Point(6, 163);
            txbImporte.Name = "txbImporte";
            txbImporte.Size = new Size(114, 25);
            txbImporte.TabIndex = 10;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(6, 104);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(114, 25);
            tbxPass.TabIndex = 9;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(6, 196);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(67, 17);
            lblCategoria.TabIndex = 17;
            lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(6, 215);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(114, 25);
            cbxCategoria.TabIndex = 18;
            // 
            // ABMusuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 333);
            Controls.Add(grpModificarProd);
            Controls.Add(ltbUsuarios);
            Name = "ABMusuarios";
            Text = "ABMusuarios";
            Load += ABMusuarios_Load;
            grpModificarProd.ResumeLayout(false);
            grpModificarProd.PerformLayout();
            ResumeLayout(false);
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
    }
}