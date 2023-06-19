namespace _1er_ParcialLabo
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            btnVolver = new Button();
            groupBox1 = new GroupBox();
            txbBuscarCliente = new TextBox();
            btnBuscar = new Button();
            btnComprar = new Button();
            lblUsuario = new Label();
            gbxDetalleCliente = new GroupBox();
            lblImporte = new Label();
            lblCategoria = new Label();
            dgvProductosVenta = new DataGridView();
            groupBox2 = new GroupBox();
            cbxMediosPago = new ComboBox();
            nudStock = new NumericUpDown();
            txbProducto = new TextBox();
            btnBuscarProducto = new Button();
            label5 = new Label();
            ptbSalir = new PictureBox();
            ptbMini = new PictureBox();
            pnlBordeSuperior = new Panel();
            groupBox1.SuspendLayout();
            gbxDetalleCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosVenta).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            pnlBordeSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.DarkGray;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(2, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(54, 26);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "<---";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbBuscarCliente);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(233, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 87);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Cliente";

            // 
            // txbBuscarCliente
            // 
            txbBuscarCliente.Location = new Point(8, 24);
            txbBuscarCliente.Name = "txbBuscarCliente";
            txbBuscarCliente.Size = new Size(193, 25);
            txbBuscarCliente.TabIndex = 1;

            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderColor = Color.DarkGray;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(115, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 26);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnComprar
            // 
            btnComprar.FlatAppearance.BorderColor = Color.DarkGray;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Location = new Point(356, 634);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(86, 26);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(7, 52);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 17);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "lblusuario";

            // 
            // gbxDetalleCliente
            // 
            gbxDetalleCliente.Controls.Add(lblImporte);
            gbxDetalleCliente.Controls.Add(lblCategoria);
            gbxDetalleCliente.Controls.Add(lblUsuario);
            gbxDetalleCliente.Location = new Point(8, 39);
            gbxDetalleCliente.Name = "gbxDetalleCliente";
            gbxDetalleCliente.Size = new Size(207, 117);
            gbxDetalleCliente.TabIndex = 6;
            gbxDetalleCliente.TabStop = false;
            gbxDetalleCliente.Text = "Detalle Usuario";

            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(7, 84);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(73, 17);
            lblImporte.TabIndex = 7;
            lblImporte.Text = "lblImporte";

            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(7, 24);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(83, 17);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "lblCategoria";

            // 
            // dgvProductosVenta
            // 
            dgvProductosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosVenta.Location = new Point(8, 346);
            dgvProductosVenta.Name = "dgvProductosVenta";
            dgvProductosVenta.ReadOnly = true;
            dgvProductosVenta.RowTemplate.Height = 25;
            dgvProductosVenta.Size = new Size(432, 282);
            dgvProductosVenta.TabIndex = 10;

            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxMediosPago);
            groupBox2.Controls.Add(nudStock);
            groupBox2.Controls.Add(txbProducto);
            groupBox2.Controls.Add(btnBuscarProducto);
            groupBox2.Location = new Point(8, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(207, 168);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Producto";

            // 
            // cbxMediosPago
            // 
            cbxMediosPago.FormattingEnabled = true;
            cbxMediosPago.Location = new Point(7, 84);
            cbxMediosPago.Name = "cbxMediosPago";
            cbxMediosPago.Size = new Size(193, 25);
            cbxMediosPago.TabIndex = 12;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(7, 53);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(193, 25);
            nudStock.TabIndex = 11;

            // 
            // txbProducto
            // 
            txbProducto.Location = new Point(7, 20);
            txbProducto.Name = "txbProducto";
            txbProducto.Size = new Size(193, 25);
            txbProducto.TabIndex = 1;

            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.FlatAppearance.BorderColor = Color.DarkGray;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.Location = new Point(115, 136);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(86, 26);
            btnBuscarProducto.TabIndex = 0;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(62, 9);
            label5.Name = "label5";
            label5.Size = new Size(109, 19);
            label5.TabIndex = 0;
            label5.Text = "Panel de Venta";
            // 
            // ptbSalir
            // 
            ptbSalir.BackColor = SystemColors.Control;
            ptbSalir.Dock = DockStyle.Right;
            ptbSalir.Image = Properties.Resources.salir;
            ptbSalir.Location = new Point(395, 0);
            ptbSalir.Name = "ptbSalir";
            ptbSalir.Size = new Size(53, 33);
            ptbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbSalir.TabIndex = 8;
            ptbSalir.TabStop = false;
            ptbSalir.Click += ptbSalir_Click;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = SystemColors.ControlLightLight;
            ptbMini.Dock = DockStyle.Right;
            ptbMini.Image = (Image)resources.GetObject("ptbMini.Image");
            ptbMini.Location = new Point(356, 0);
            ptbMini.Name = "ptbMini";
            ptbMini.Size = new Size(39, 33);
            ptbMini.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMini.TabIndex = 9;
            ptbMini.TabStop = false;
            ptbMini.Click += ptbMini_Click;
            // 
            // pnlBordeSuperior
            // 
            pnlBordeSuperior.BackColor = SystemColors.MenuBar;
            pnlBordeSuperior.Controls.Add(ptbMini);
            pnlBordeSuperior.Controls.Add(ptbSalir);
            pnlBordeSuperior.Controls.Add(label5);
            pnlBordeSuperior.Controls.Add(btnVolver);
            pnlBordeSuperior.Dock = DockStyle.Top;
            pnlBordeSuperior.Location = new Point(0, 0);
            pnlBordeSuperior.Name = "pnlBordeSuperior";
            pnlBordeSuperior.Size = new Size(448, 33);
            pnlBordeSuperior.TabIndex = 19;

            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(448, 672);
            Controls.Add(pnlBordeSuperior);
            Controls.Add(groupBox2);
            Controls.Add(dgvProductosVenta);
            Controls.Add(gbxDetalleCliente);
            Controls.Add(btnComprar);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Venta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta";
            Load += Venta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxDetalleCliente.ResumeLayout(false);
            gbxDetalleCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosVenta).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            pnlBordeSuperior.ResumeLayout(false);
            pnlBordeSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox groupBox1;
        private Button btnComprar;
        private Label lblUsuario;
        private GroupBox gbxDetalleCliente;
        private DataGridView dgvProductosVenta;
        private TextBox txbBuscarCliente;
        private Button btnBuscar;
        private GroupBox groupBox2;
        private TextBox txbProducto;
        private Button btnBuscarProducto;
        private Label lblImporte;
        private Label lblCategoria;
        private NumericUpDown nudStock;
        private ComboBox cbxMediosPago;
        private Label label5;
        private PictureBox ptbSalir;
        private PictureBox ptbMini;
        private Panel pnlBordeSuperior;
    }
}