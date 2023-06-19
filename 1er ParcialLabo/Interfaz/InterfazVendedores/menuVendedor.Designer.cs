namespace _1er_ParcialLabo
{
    partial class menuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuVendedor));
            btnHeladera = new Button();
            btnVenta = new Button();
            pnlBordeSuperior = new Panel();
            ptbMini = new PictureBox();
            ptbSalir = new PictureBox();
            label3 = new Label();
            pnlBordeSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            SuspendLayout();
            // 
            // btnHeladera
            // 
            btnHeladera.FlatAppearance.BorderColor = Color.DarkGray;
            btnHeladera.FlatStyle = FlatStyle.Flat;
            btnHeladera.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHeladera.ForeColor = SystemColors.ActiveCaptionText;
            btnHeladera.Location = new Point(12, 57);
            btnHeladera.Name = "btnHeladera";
            btnHeladera.Size = new Size(75, 23);
            btnHeladera.TabIndex = 0;
            btnHeladera.Text = "Heladera";
            btnHeladera.UseVisualStyleBackColor = true;
            btnHeladera.Click += btnHeladera_Click;
            // 
            // btnVenta
            // 
            btnVenta.FlatAppearance.BorderColor = Color.DarkGray;
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenta.Location = new Point(129, 57);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(75, 23);
            btnVenta.TabIndex = 1;
            btnVenta.Text = "Venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
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
            pnlBordeSuperior.Size = new Size(216, 33);
            pnlBordeSuperior.TabIndex = 8;
            pnlBordeSuperior.MouseDown += pnlBordeSuperior_MouseDown;
            pnlBordeSuperior.MouseMove += pnlBordeSuperior_MouseMove;
            pnlBordeSuperior.MouseUp += pnlBordeSuperior_MouseUp;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = SystemColors.ControlLightLight;
            ptbMini.Dock = DockStyle.Right;
            ptbMini.Image = (Image)resources.GetObject("ptbMini.Image");
            ptbMini.Location = new Point(124, 0);
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
            ptbSalir.Location = new Point(163, 0);
            ptbSalir.Name = "ptbSalir";
            ptbSalir.Size = new Size(53, 33);
            ptbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbSalir.TabIndex = 8;
            ptbSalir.TabStop = false;
            ptbSalir.Click += ptbSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(1, 7);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 0;
            label3.Text = "Menu Vendedor";

            // 
            // menuVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(216, 103);
            Controls.Add(pnlBordeSuperior);
            Controls.Add(btnVenta);
            Controls.Add(btnHeladera);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "menuVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElegirRuta";
            MouseDown += pnlBordeSuperior_MouseDown;
            MouseMove += pnlBordeSuperior_MouseMove;
            MouseUp += pnlBordeSuperior_MouseUp;
            pnlBordeSuperior.ResumeLayout(false);
            pnlBordeSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHeladera;
        private Button btnVenta;
        private Panel pnlBordeSuperior;
        private PictureBox ptbMini;
        private PictureBox ptbSalir;
        private Label label3;
    }
}