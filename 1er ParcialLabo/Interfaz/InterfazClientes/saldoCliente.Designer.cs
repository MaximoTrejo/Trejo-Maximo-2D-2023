namespace _1er_ParcialLabo
{
    partial class saldoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saldoCliente));
            tbxImporteCliente = new TextBox();
            btnConfimporte = new Button();
            label1 = new Label();
            pnlBordeSuperior = new Panel();
            ptbMini = new PictureBox();
            ptbSalir = new PictureBox();
            label5 = new Label();
            pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            SuspendLayout();
            // 
            // tbxImporteCliente
            // 
            tbxImporteCliente.Location = new Point(7, 70);
            tbxImporteCliente.Name = "tbxImporteCliente";
            tbxImporteCliente.Size = new Size(186, 25);
            tbxImporteCliente.TabIndex = 0;
            tbxImporteCliente.KeyPress += txtDni_KeyPress;
            // 
            // btnConfimporte
            // 
            btnConfimporte.FlatAppearance.BorderColor = Color.DarkGray;
            btnConfimporte.FlatStyle = FlatStyle.Flat;
            btnConfimporte.Location = new Point(107, 101);
            btnConfimporte.Name = "btnConfimporte";
            btnConfimporte.Size = new Size(86, 26);
            btnConfimporte.TabIndex = 1;
            btnConfimporte.Text = "Aceptar";
            btnConfimporte.UseVisualStyleBackColor = true;
            btnConfimporte.Click += btnConfimporte_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 50);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 2;
            label1.Text = "Ingrese Importe";
            // 
            // pnlBordeSuperior
            // 
            pnlBordeSuperior.BackColor = SystemColors.MenuBar;
            pnlBordeSuperior.Controls.Add(ptbMini);
            pnlBordeSuperior.Controls.Add(ptbSalir);
            pnlBordeSuperior.Controls.Add(label5);
            pnlBordeSuperior.Dock = DockStyle.Top;
            pnlBordeSuperior.Location = new Point(0, 0);
            pnlBordeSuperior.Name = "pnlBordeSuperior";
            pnlBordeSuperior.Size = new Size(199, 33);
            pnlBordeSuperior.TabIndex = 18;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = SystemColors.ControlLightLight;
            ptbMini.Dock = DockStyle.Right;
            ptbMini.Image = (Image)resources.GetObject("ptbMini.Image");
            ptbMini.Location = new Point(107, 0);
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
            ptbSalir.Location = new Point(146, 0);
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
            label5.Location = new Point(1, 7);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 0;
            label5.Text = "Ingrese Saldo";
            // 
            // saldoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(199, 142);
            Controls.Add(pnlBordeSuperior);
            Controls.Add(label1);
            Controls.Add(btnConfimporte);
            Controls.Add(tbxImporteCliente);
            Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "saldoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "importeCliente";
            MouseDown += pnlBordeSuperior_MouseDown;
            MouseMove += pnlBordeSuperior_MouseMove;
            MouseUp += pnlBordeSuperior_MouseUp;
            pnlBordeSuperior.ResumeLayout(false);
            pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxImporteCliente;
        private Button btnConfimporte;
        private Label label1;
        private Panel pnlBordeSuperior;
        private PictureBox ptbMini;
        private PictureBox ptbSalir;
        private Label label5;
    }
}