namespace FormularioBienvenida
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            btnAceptar = new Button();
            lblResultado = new Label();
            btnLimpiar = new Button();
            label2 = new Label();
            label3 = new Label();
            lblCurso = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(51, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(51, 80);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(111, 72);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            txtEdad.Tag = "";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(51, 117);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(51, 157);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(150, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Aquí aparecerá el resultado";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(136, 117);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 80);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 80);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 9;
            label3.Text = "La edad no debe ser negativa";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(53, 195);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(166, 15);
            lblCurso.TabIndex = 10;
            lblCurso.Text = "Desarrollo de Interfaces · DAM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCurso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLimpiar);
            Controls.Add(lblResultado);
            Controls.Add(btnAceptar);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Formulario de Bienvenida";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEdad;
        private TextBox txtEdad;
        private Button btnAceptar;
        private Label lblResultado;
        private Button btnLimpiar;
        private Label label2;
        private Label label3;
        private Label lblCurso;
    }
}
