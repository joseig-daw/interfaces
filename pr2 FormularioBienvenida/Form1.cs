namespace FormularioBienvenida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string textoEdad = txtEdad.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce tu nombre.");
                return;
            }
            if (!int.TryParse(textoEdad, out int edad) || edad < 0)
            {
                MessageBox.Show("Introduce una edad válida.");
                return;
            }
            if (edad >= 18)
            {
                lblResultado.Text = $"Hola, {nombre}.\nTienes {edad} años, eres mayor de edad viejo.";
                return;
            }
            lblResultado.Text = $"Hola, {nombre}.\nTienes {edad}.";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Aquí aparecerá el resultado";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
