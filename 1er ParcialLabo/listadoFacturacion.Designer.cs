namespace _1er_ParcialLabo
{
    partial class listadoFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listadoFacturacion));
            dgvFacturacion = new DataGridView();
            lblTotal = new Label();
            lblMail = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            pnlBordeSuperior = new Panel();
            ptbMini = new PictureBox();
            ptbSalir = new PictureBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFacturacion).BeginInit();
            pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFacturacion
            // 
            dgvFacturacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturacion.Location = new Point(57, 106);
            dgvFacturacion.Name = "dgvFacturacion";
            dgvFacturacion.ReadOnly = true;
            dgvFacturacion.RowTemplate.Height = 25;
            dgvFacturacion.Size = new Size(492, 291);
            dgvFacturacion.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 21);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 17);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "lblTotal";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(11, 21);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(51, 17);
            lblMail.TabIndex = 2;
            lblMail.Text = "lblMail";
            // 
            // btnSiguiente
            // 
            btnSiguiente.FlatAppearance.BorderColor = Color.DarkGray;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Location = new Point(564, 216);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(48, 26);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "--->";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.FlatAppearance.BorderColor = Color.DarkGray;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Location = new Point(1, 216);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(50, 26);
            btnAnterior.TabIndex = 4;
            btnAnterior.Text = "<---";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
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
            pnlBordeSuperior.Size = new Size(611, 33);
            pnlBordeSuperior.TabIndex = 18;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = SystemColors.ControlLightLight;
            ptbMini.Dock = DockStyle.Right;
            ptbMini.Image = (Image)resources.GetObject("ptbMini.Image");
            ptbMini.Location = new Point(519, 0);
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
            ptbSalir.Location = new Point(558, 0);
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
            label5.Location = new Point(74, 5);
            label5.Name = "label5";
            label5.Size = new Size(138, 19);
            label5.TabIndex = 0;
            label5.Text = "Listado Facturacion";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMail);
            groupBox1.Location = new Point(12, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 51);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Location = new Point(424, 403);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(125, 52);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total Ticket";
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.DarkGray;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(-1, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(52, 23);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "<---";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // listadoFacturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(611, 463);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlBordeSuperior);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(dgvFacturacion);
            Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "listadoFacturacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "listadoFacturacion";
            Load += listadoFacturacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacturacion).EndInit();
            pnlBordeSuperior.ResumeLayout(false);
            pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFacturacion;
        private Label lblTotal;
        private Label lblMail;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Panel pnlBordeSuperior;
        private PictureBox ptbMini;
        private PictureBox ptbSalir;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnVolver;
    }
}