namespace pr3_Controles_Basicos
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
            lblTitulo = new Label();
            label1 = new Label();
            lblNombre = new Label();
            lblApellidos = new Label();
            lblEdad = new Label();
            lblGenero = new Label();
            lblCiudad = new Label();
            txbNombre = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.Location = new Point(232, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(282, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenidos a coffeLover";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 62);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 1;
            label1.Text = "Formulario para registrarse:";
            label1.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(73, 88);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(74, 109);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(59, 15);
            lblApellidos.TabIndex = 3;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(76, 133);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(76, 158);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Género:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(77, 187);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(45, 15);
            lblCiudad.TabIndex = 6;
            lblCiudad.Text = "Ciudad";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(133, 85);
            txbNombre.Name = "txbNombre";
            txbNombre.PlaceholderText = "Campo a rellenar";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 7;
            txbNombre.TextChanged += txbNombre_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbNombre);
            Controls.Add(lblCiudad);
            Controls.Add(lblGenero);
            Controls.Add(lblEdad);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Formulario de Bienvenida a CoffeLovers";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private Label lblNombre;
        private Label lblApellidos;
        private Label lblEdad;
        private Label lblGenero;
        private Label lblCiudad;
        private TextBox txbNombre;
    }
}
