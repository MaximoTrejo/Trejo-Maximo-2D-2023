namespace _1__Parcial_Laboratorio_II
{
    partial class Form1
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
            btnVendedor = new Button();
            btnCliente = new Button();
            SuspendLayout();
            // 
            // btnVendedor
            // 
            btnVendedor.Location = new Point(13, 12);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(75, 23);
            btnVendedor.TabIndex = 0;
            btnVendedor.Text = "Vendedor";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += button1_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(136, 12);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(92, 23);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 54);
            Controls.Add(btnCliente);
            Controls.Add(btnVendedor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVendedor;
        private Button btnCliente;
    }
}