namespace Principal
{
    partial class Formulario
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
            button2 = new Button();
            lblResultadoProductos = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtTipo = new TextBox();
            lblResultadoProducto2 = new Label();
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
            // button2
            // 
            button2.Location = new Point(131, 119);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "traer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            txtNombre.Location = new Point(315, 230);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(530, 230);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(339, 298);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(570, 302);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 6;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(387, 371);
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
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoProducto2);
            Controls.Add(txtTipo);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblResultadoProductos);
            Controls.Add(button2);
            Controls.Add(btnEnviar);
            Name = "Formulario";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private Button button2;
        private Label lblResultadoProductos;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtTipo;
        private Label lblResultadoProducto2;
    }
}