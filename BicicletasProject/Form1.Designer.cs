namespace Principal
{
    partial class Form1
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
            BtnInventario = new Button();
            BtnEmpleado = new Button();
            BtnFacturas = new Button();
            BtnHistorial = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnInventario
            // 
            BtnInventario.Location = new Point(134, 73);
            BtnInventario.Name = "BtnInventario";
            BtnInventario.Size = new Size(135, 99);
            BtnInventario.TabIndex = 0;
            BtnInventario.Text = "INVENTARIO";
            BtnInventario.UseVisualStyleBackColor = true;
            BtnInventario.Click += BtnInventario_Click;
            // 
            // BtnEmpleado
            // 
            BtnEmpleado.Location = new Point(505, 262);
            BtnEmpleado.Name = "BtnEmpleado";
            BtnEmpleado.Size = new Size(135, 99);
            BtnEmpleado.TabIndex = 1;
            BtnEmpleado.Text = "EMPLEADOS";
            BtnEmpleado.UseVisualStyleBackColor = true;
            BtnEmpleado.Click += BtnEmpleado_Click;
            // 
            // BtnFacturas
            // 
            BtnFacturas.Location = new Point(505, 73);
            BtnFacturas.Name = "BtnFacturas";
            BtnFacturas.Size = new Size(135, 99);
            BtnFacturas.TabIndex = 2;
            BtnFacturas.Text = "FACTURAR";
            BtnFacturas.UseVisualStyleBackColor = true;
            BtnFacturas.Click += BtnFacturas_Click;
            // 
            // BtnHistorial
            // 
            BtnHistorial.Location = new Point(143, 262);
            BtnHistorial.Name = "BtnHistorial";
            BtnHistorial.Size = new Size(135, 99);
            BtnHistorial.TabIndex = 3;
            BtnHistorial.Text = "HISTORIAL";
            BtnHistorial.UseVisualStyleBackColor = true;
            BtnHistorial.Click += BtnHistorial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 29);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 4;
            label1.Text = "BIENVENIDO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BtnHistorial);
            Controls.Add(BtnFacturas);
            Controls.Add(BtnEmpleado);
            Controls.Add(BtnInventario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnInventario;
        private Button BtnEmpleado;
        private Button BtnFacturas;
        private Button BtnHistorial;
        private Label label1;
    }
}