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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMusuarios));
            ltbUsuarios = new ListBox();
            grpModificarProd = new GroupBox();
            cbxCategoria = new ComboBox();
            lblCategoria = new Label();
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
            btnVendedor = new Button();
            btnClientes = new Button();
            pnlBordeSuperior = new Panel();
            btnVolver = new Button();
            ptbMini = new PictureBox();
            ptbSalir = new PictureBox();
            label5 = new Label();
            grpModificarProd.SuspendLayout();
            pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            SuspendLayout();
            // 
            // ltbUsuarios
            // 
            ltbUsuarios.FormattingEnabled = true;
            ltbUsuarios.ItemHeight = 17;
            ltbUsuarios.Location = new Point(11, 94);
            ltbUsuarios.Name = "ltbUsuarios";
            ltbUsuarios.Size = new Size(353, 276);
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
            grpModificarProd.Location = new Point(394, 90);
            grpModificarProd.Name = "grpModificarProd";
            grpModificarProd.Size = new Size(274, 280);
            grpModificarProd.TabIndex = 18;
            grpModificarProd.TabStop = false;
            grpModificarProd.Text = "ABM";
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(7, 244);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(130, 25);
            cbxCategoria.TabIndex = 18;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(7, 222);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(67, 17);
            lblCategoria.TabIndex = 17;
            lblCategoria.Text = "Categoria";
            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderColor = Color.DarkGray;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(163, 244);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(98, 29);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 31);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.DarkGray;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(163, 53);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 32);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderColor = Color.DarkGray;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(163, 150);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 29);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderColor = Color.DarkGray;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(163, 95);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 31);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // tbxnombre
            // 
            tbxnombre.ImeMode = ImeMode.On;
            tbxnombre.Location = new Point(7, 53);
            tbxnombre.Name = "tbxnombre";
            tbxnombre.Size = new Size(130, 25);
            tbxnombre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 95);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 12;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 162);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 13;
            label3.Text = "Importe";
            // 
            // txbImporte
            // 
            txbImporte.Location = new Point(7, 185);
            txbImporte.Name = "txbImporte";
            txbImporte.Size = new Size(130, 25);
            txbImporte.TabIndex = 10;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(7, 118);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(130, 25);
            tbxPass.TabIndex = 9;
            // 
            // btnVendedor
            // 
            btnVendedor.FlatAppearance.BorderColor = Color.DarkGray;
            btnVendedor.FlatStyle = FlatStyle.Flat;
            btnVendedor.Location = new Point(11, 54);
            btnVendedor.Margin = new Padding(3, 2, 3, 2);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(102, 35);
            btnVendedor.TabIndex = 19;
            btnVendedor.Text = "Vendedores";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderColor = Color.DarkGray;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Location = new Point(119, 54);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(89, 35);
            btnClientes.TabIndex = 20;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // pnlBordeSuperior
            // 
            pnlBordeSuperior.BackColor = SystemColors.MenuBar;
            pnlBordeSuperior.Controls.Add(btnVolver);
            pnlBordeSuperior.Controls.Add(ptbMini);
            pnlBordeSuperior.Controls.Add(ptbSalir);
            pnlBordeSuperior.Controls.Add(label5);
            pnlBordeSuperior.Dock = DockStyle.Top;
            pnlBordeSuperior.Location = new Point(0, 0);
            pnlBordeSuperior.Name = "pnlBordeSuperior";
            pnlBordeSuperior.Size = new Size(680, 40);
            pnlBordeSuperior.TabIndex = 21;
            pnlBordeSuperior.MouseDown += pnlBordeSuperior_MouseDown;
            pnlBordeSuperior.MouseMove += pnlBordeSuperior_MouseMove;
            pnlBordeSuperior.MouseUp += pnlBordeSuperior_MouseUp;
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.DarkGray;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(3, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(67, 29);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "<---";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = SystemColors.ControlLightLight;
            ptbMini.Dock = DockStyle.Right;
            ptbMini.Image = (Image)resources.GetObject("ptbMini.Image");
            ptbMini.Location = new Point(542, 0);
            ptbMini.Name = "ptbMini";
            ptbMini.Size = new Size(58, 40);
            ptbMini.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMini.TabIndex = 9;
            ptbMini.TabStop = false;
            ptbMini.Click += ptbMini_Click;
            // 
            // ptbSalir
            // 
            ptbSalir.BackColor = SystemColors.Control;
            ptbSalir.Dock = DockStyle.Right;
            ptbSalir.Image = Properties.Resources.salir;
            ptbSalir.Location = new Point(600, 0);
            ptbSalir.Name = "ptbSalir";
            ptbSalir.Size = new Size(80, 40);
            ptbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbSalir.TabIndex = 8;
            ptbSalir.TabStop = false;
            ptbSalir.Click += ptbSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(78, 10);
            label5.Name = "label5";
            label5.Size = new Size(106, 19);
            label5.TabIndex = 0;
            label5.Text = "ABM  Usuarios";
            // 
            // ABMusuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(680, 390);
            Controls.Add(pnlBordeSuperior);
            Controls.Add(btnClientes);
            Controls.Add(btnVendedor);
            Controls.Add(grpModificarProd);
            Controls.Add(ltbUsuarios);
            Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ABMusuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABMusuarios";
            Load += ABMusuarios_Load;
            grpModificarProd.ResumeLayout(false);
            grpModificarProd.PerformLayout();
            pnlBordeSuperior.ResumeLayout(false);
            pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
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
        private Button btnVendedor;
        private Button btnClientes;
        private Panel pnlBordeSuperior;
        private Button btnVolver;
        private PictureBox ptbMini;
        private PictureBox ptbSalir;
        private Label label5;
    }
}