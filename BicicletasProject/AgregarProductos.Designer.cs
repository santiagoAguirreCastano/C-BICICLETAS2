namespace Principal
{
    partial class AgregarProductos
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
            btnEnviar = new Button();
            lblResultadoProductos = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtTipo = new TextBox();
            lblResultadoProducto2 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(452, 408);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblResultadoProductos
            // 
            lblResultadoProductos.AutoSize = true;
            lblResultadoProductos.Location = new Point(411, 249);
            lblResultadoProductos.Name = "lblResultadoProductos";
            lblResultadoProductos.Size = new Size(0, 15);
            lblResultadoProductos.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(243, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(417, 128);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(243, 241);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(417, 241);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 6;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(332, 319);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 7;
            // 
            // lblResultadoProducto2
            // 
            lblResultadoProducto2.AutoSize = true;
            lblResultadoProducto2.Location = new Point(411, 416);
            lblResultadoProducto2.Name = "lblResultadoProducto2";
            lblResultadoProducto2.Size = new Size(0, 15);
            lblResultadoProducto2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 105);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 105);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 223);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 223);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 301);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 13;
            label5.Text = "label5";
            // 
            // AgregarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResultadoProducto2);
            Controls.Add(txtTipo);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblResultadoProductos);
            Controls.Add(btnEnviar);
            Name = "AgregarProductos";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private Label lblResultadoProductos;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtTipo;
        private Label lblResultadoProducto2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}