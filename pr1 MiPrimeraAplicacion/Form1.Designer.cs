namespace MiPrimeraAplicacion
{
    partial class frmPrincipal
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
            lblInstruccion = new Label();
            btnSaludar = new Button();
            btnDespedir = new Button();
            SuspendLayout();
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 14F);
            lblInstruccion.Location = new Point(222, 88);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(347, 25);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "Pulsa el botón para mostrar un mensaje";
            lblInstruccion.Click += lblTitulo_Click;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(222, 125);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(75, 23);
            btnSaludar.TabIndex = 1;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // btnDespedir
            // 
            btnDespedir.Location = new Point(222, 154);
            btnDespedir.Name = "btnDespedir";
            btnDespedir.Size = new Size(75, 23);
            btnDespedir.TabIndex = 2;
            btnDespedir.Text = "Despedir";
            btnDespedir.UseVisualStyleBackColor = true;
            btnDespedir.Click += btnDespedir_Click_1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDespedir);
            Controls.Add(btnSaludar);
            Controls.Add(lblInstruccion);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi primera aplicacion Ejemplo nombre";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruccion;
        private Button btnSaludar;
        private Button btnDespedir;
    }
}
