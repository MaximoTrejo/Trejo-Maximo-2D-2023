namespace _1er_ParcialLabo
{
    partial class Heladera
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Heladera));
            btnVolver = new Button();
            btnDetalle = new Button();
            btnListaF = new Button();
            dgvProductos = new DataGridView();
            btnABMProd = new Button();
            ltbProductos = new ListBox();
            pnlBordeSuperior = new Panel();
            ptbMini = new PictureBox();
            ptbSalir = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.DarkGray;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(0, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(52, 23);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "<---";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnDetalle
            // 
            btnDetalle.FlatAppearance.BorderColor = Color.DarkGray;
            btnDetalle.FlatStyle = FlatStyle.Flat;
            btnDetalle.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetalle.Location = new Point(160, 124);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(126, 41);
            btnDetalle.TabIndex = 2;
            btnDetalle.Text = "Detalle";
            btnDetalle.UseVisualStyleBackColor = true;
            btnDetalle.Click += btnDetalle_Click;
            // 
            // btnListaF
            // 
            btnListaF.FlatAppearance.BorderColor = Color.DarkGray;
            btnListaF.FlatStyle = FlatStyle.Flat;
            btnListaF.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListaF.Location = new Point(292, 124);
            btnListaF.Name = "btnListaF";
            btnListaF.Size = new Size(159, 45);
            btnListaF.TabIndex = 3;
            btnListaF.Text = "Lista de facturacion";
            btnListaF.UseVisualStyleBackColor = true;
            btnListaF.Click += btnListaF_Click;
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 39);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(439, 72);
            dgvProductos.TabIndex = 4;
            // 
            // btnABMProd
            // 
            btnABMProd.FlatAppearance.BorderColor = Color.DarkGray;
            btnABMProd.FlatStyle = FlatStyle.Flat;
            btnABMProd.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnABMProd.Location = new Point(12, 126);
            btnABMProd.Name = "btnABMProd";
            btnABMProd.Size = new Size(131, 41);
            btnABMProd.TabIndex = 5;
            btnABMProd.Text = "ABM Productos";
            btnABMProd.UseVisualStyleBackColor = true;
            btnABMProd.Click += btnModificar_Click;
            // 
            // ltbProductos
            // 
            ltbProductos.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ltbProductos.FormattingEnabled = true;
            ltbProductos.ItemHeight = 17;
            ltbProductos.Location = new Point(467, 39);
            ltbProductos.Name = "ltbProductos";
            ltbProductos.Size = new Size(178, 123);
            ltbProductos.TabIndex = 6;
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
            pnlBordeSuperior.Size = new Size(657, 33);
            pnlBordeSuperior.TabIndex = 17;
            pnlBordeSuperior.MouseDown += pnlBordeSuperior_MouseDown;
            pnlBordeSuperior.MouseMove += pnlBordeSuperior_MouseMove;
            pnlBordeSuperior.MouseUp += pnlBordeSuperior_MouseUp;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = SystemColors.ControlLightLight;
            ptbMini.Dock = DockStyle.Right;
            ptbMini.Image = (Image)resources.GetObject("ptbMini.Image");
            ptbMini.Location = new Point(565, 0);
            ptbMini.Name = "ptbMini";
            ptbMini.Size = new Size(39, 33);
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
            ptbSalir.Location = new Point(604, 0);
            ptbSalir.Name = "ptbSalir";
            ptbSalir.Size = new Size(53, 33);
            ptbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbSalir.TabIndex = 8;
            ptbSalir.TabStop = false;
            ptbSalir.Click += ptbSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(52, 9);
            label5.Name = "label5";
            label5.Size = new Size(112, 19);
            label5.TabIndex = 0;
            label5.Text = "Menu Heladera";
            // 
            // Heladera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(657, 175);
            Controls.Add(pnlBordeSuperior);
            Controls.Add(ltbProductos);
            Controls.Add(btnABMProd);
            Controls.Add(dgvProductos);
            Controls.Add(btnListaF);
            Controls.Add(btnDetalle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Heladera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Heladera";
            Load += Heladera_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            pnlBordeSuperior.ResumeLayout(false);
            pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private ListBox listBox1;
        private Button btnAceptar;
        private Button button2;
        private Button btnDetalle;
        private Button btnListaF;
        private DataGridView dgvProductos;
        private Button btnABMProd;
        private ListBox ltbProductos;
        private Label label1;
        private TextBox tbxnombre;
        private TextBox tbxPesoKilo;
        private TextBox txbPrecioKilo;
        private TextBox tbtStock;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox grpModificarProd;
        private Panel pnlBordeSuperior;
        private PictureBox ptbMini;
        private PictureBox ptbSalir;
        private Label label5;
    }
}