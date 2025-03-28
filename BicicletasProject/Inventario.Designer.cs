namespace Principal
{
    partial class Inventario
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
            button1 = new Button();
            lblResultadoProductos = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(328, 322);
            button1.Name = "button1";
            button1.Size = new Size(143, 64);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultadoProductos
            // 
            lblResultadoProductos.AutoSize = true;
            lblResultadoProductos.Location = new Point(198, 82);
            lblResultadoProductos.Name = "lblResultadoProductos";
            lblResultadoProductos.Size = new Size(25, 15);
            lblResultadoProductos.TabIndex = 1;
            lblResultadoProductos.Text = "asd";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoProductos);
            Controls.Add(button1);
            Name = "Inventario";
            Text = "Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblResultadoProductos;
    }
}