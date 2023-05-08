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
            ltbProductos = new ListBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            grpModificarProd = new GroupBox();
            btnAceptar = new Button();
            label1 = new Label();
            btnAgregar = new Button();
            tbxnombre = new TextBox();
            tbtStock = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbPrecioKilo = new TextBox();
            tbxPesoKilo = new TextBox();
            pnlBordeSuperior = new Panel();
            ptbMini = new PictureBox();
            ptbSalir = new PictureBox();
            label5 = new Label();
            btnVolver = new Button();
            grpModificarProd.SuspendLayout();
            pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            SuspendLayout();
            // 
            // ltbProductos
            // 
            ltbProductos.FormattingEnabled = true;
            ltbProductos.ItemHeight = 17;
            ltbProductos.Location = new Point(12, 64);
            ltbProductos.Name = "ltbProductos";
            ltbProductos.Size = new Size(309, 242);
            ltbProductos.TabIndex = 0;
            ltbProductos.SelectedIndexChanged += ltbProductos_SelectedIndexChanged;
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
            btnModificar.Click += button1_Click;
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
            btnEliminar.Click += button2_Click;
            // 
            // grpModificarProd
            // 
            grpModificarProd.Controls.Add(btnAceptar);
            grpModificarProd.Controls.Add(label1);
            grpModificarProd.Controls.Add(btnEliminar);
            grpModificarProd.Controls.Add(btnAgregar);
            grpModificarProd.Controls.Add(btnModificar);
            grpModificarProd.Controls.Add(tbxnombre);
            grpModificarProd.Controls.Add(tbtStock);
            grpModificarProd.Controls.Add(label4);
            grpModificarProd.Controls.Add(label2);
            grpModificarProd.Controls.Add(label3);
            grpModificarProd.Controls.Add(txbPrecioKilo);
            grpModificarProd.Controls.Add(tbxPesoKilo);
            grpModificarProd.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            grpModificarProd.Location = new Point(348, 64);
            grpModificarProd.Name = "grpModificarProd";
            grpModificarProd.Size = new Size(240, 239);
            grpModificarProd.TabIndex = 17;
            grpModificarProd.TabStop = false;
            grpModificarProd.Text = "Modificar Producto";

            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderColor = Color.DarkGray;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(143, 199);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 26);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 22);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
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
            btnAgregar.Click += btnAceptar_Click;
            // 
            // tbxnombre
            // 
            tbxnombre.ImeMode = ImeMode.On;
            tbxnombre.Location = new Point(7, 42);
            tbxnombre.Name = "tbxnombre";
            tbxnombre.Size = new Size(114, 25);
            tbxnombre.TabIndex = 8;
            // 
            // tbtStock
            // 
            tbtStock.Location = new Point(7, 201);
            tbtStock.Name = "tbtStock";
            tbtStock.Size = new Size(114, 25);
            tbtStock.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 178);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 14;
            label4.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 74);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 12;
            label2.Text = "Peso x kilo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 124);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 13;
            label3.Text = "Precio x Kilo";
            // 
            // txbPrecioKilo
            // 
            txbPrecioKilo.Location = new Point(7, 146);
            txbPrecioKilo.Name = "txbPrecioKilo";
            txbPrecioKilo.Size = new Size(114, 25);
            txbPrecioKilo.TabIndex = 10;
            // 
            // tbxPesoKilo
            // 
            tbxPesoKilo.Location = new Point(7, 94);
            tbxPesoKilo.Name = "tbxPesoKilo";
            tbxPesoKilo.Size = new Size(114, 25);
            tbxPesoKilo.TabIndex = 9;
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
            pnlBordeSuperior.Size = new Size(608, 42);
            pnlBordeSuperior.TabIndex = 18;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = SystemColors.ControlLightLight;
            ptbMini.Dock = DockStyle.Right;
            ptbMini.Image = (Image)resources.GetObject("ptbMini.Image");
            ptbMini.Location = new Point(487, 0);
            ptbMini.Name = "ptbMini";
            ptbMini.Size = new Size(51, 42);
            ptbMini.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMini.TabIndex = 9;
            ptbMini.TabStop = false;
            // 
            // ptbSalir
            // 
            ptbSalir.BackColor = SystemColors.Control;
            ptbSalir.Dock = DockStyle.Right;
            ptbSalir.Image = Properties.Resources.salir;
            ptbSalir.Location = new Point(538, 0);
            ptbSalir.Name = "ptbSalir";
            ptbSalir.Size = new Size(70, 42);
            ptbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbSalir.TabIndex = 8;
            ptbSalir.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(68, 9);
            label5.Name = "label5";
            label5.Size = new Size(117, 19);
            label5.TabIndex = 0;
            label5.Text = "ABM  Productos";

            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.DarkGray;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(3, 7);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(59, 26);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "<---";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ABMproductos
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(608, 320);
            Controls.Add(pnlBordeSuperior);
            Controls.Add(grpModificarProd);
            Controls.Add(ltbProductos);
            Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ABMproductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABM";
            Load += ABMproductos_Load;
            grpModificarProd.ResumeLayout(false);
            grpModificarProd.PerformLayout();
            pnlBordeSuperior.ResumeLayout(false);
            pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            ResumeLayout(false);
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