namespace _1er_ParcialLabo
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            brnVendedor = new Button();
            btnCliente = new Button();
            btnInicio = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMail = new TextBox();
            txtPass = new TextBox();
            pnlBordeSuperior = new Panel();
            ptbMini = new PictureBox();
            ptbSalir = new PictureBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // brnVendedor
            // 
            brnVendedor.FlatAppearance.BorderColor = Color.DarkGray;
            brnVendedor.FlatAppearance.BorderSize = 2;
            brnVendedor.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            brnVendedor.FlatStyle = FlatStyle.Flat;
            brnVendedor.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            brnVendedor.Location = new Point(21, 52);
            brnVendedor.Name = "brnVendedor";
            brnVendedor.Size = new Size(114, 36);
            brnVendedor.TabIndex = 0;
            brnVendedor.Text = "Vendedor";
            brnVendedor.UseVisualStyleBackColor = true;
            brnVendedor.Click += brnVendedor_Click;
            // 
            // btnCliente
            // 
            btnCliente.FlatAppearance.BorderColor = Color.DarkGray;
            btnCliente.FlatAppearance.BorderSize = 2;
            btnCliente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCliente.Location = new Point(191, 52);
            btnCliente.Margin = new Padding(11);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(102, 36);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnInicio
            // 
            btnInicio.FlatAppearance.BorderColor = Color.Silver;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.Location = new Point(59, 98);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(186, 26);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio Sesion";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 31);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 3;
            label1.Text = "Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(176, 31);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 4;
            label2.Text = "Pass";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(7, 56);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(114, 25);
            txtMail.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(176, 56);
            txtPass.Margin = new Padding(0);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(110, 25);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            // 
            // pnlBordeSuperior
            // 
            pnlBordeSuperior.BackColor = SystemColors.MenuBar;
            pnlBordeSuperior.Controls.Add(ptbMini);
            pnlBordeSuperior.Controls.Add(ptbSalir);
            pnlBordeSuperior.Controls.Add(label3);
            pnlBordeSuperior.Dock = DockStyle.Top;
            pnlBordeSuperior.Location = new Point(0, 0);
            pnlBordeSuperior.Name = "pnlBordeSuperior";
            pnlBordeSuperior.Size = new Size(358, 37);
            pnlBordeSuperior.TabIndex = 7;
            pnlBordeSuperior.MouseDown += pnlBordeSuperior_MouseDown;
            pnlBordeSuperior.MouseMove += pnlBordeSuperior_MouseMove;
            pnlBordeSuperior.MouseUp += pnlBordeSuperior_MouseUp;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = SystemColors.ControlLightLight;
            ptbMini.Dock = DockStyle.Right;
            ptbMini.Image = (Image)resources.GetObject("ptbMini.Image");
            ptbMini.Location = new Point(252, 0);
            ptbMini.Name = "ptbMini";
            ptbMini.Size = new Size(45, 37);
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
            ptbSalir.Location = new Point(297, 0);
            ptbSalir.Name = "ptbSalir";
            ptbSalir.Size = new Size(61, 37);
            ptbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbSalir.TabIndex = 8;
            ptbSalir.TabStop = false;
            ptbSalir.Click += ptbSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(14, 9);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 0;
            label3.Text = "LOGIN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(btnInicio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 130);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Usuario";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(358, 275);
            Controls.Add(groupBox1);
            Controls.Add(pnlBordeSuperior);
            Controls.Add(btnCliente);
            Controls.Add(brnVendedor);
            Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlBordeSuperior.ResumeLayout(false);
            pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button brnVendedor;
        private Button btnCliente;
        private Button btnInicio;
        private Label label1;
        private Label label2;
        private TextBox txtMail;
        private TextBox txtPass;
        private Panel pnlBordeSuperior;
        private PictureBox ptbMini;
        private PictureBox ptbSalir;
        private Label label3;
        private GroupBox groupBox1;
    }
}