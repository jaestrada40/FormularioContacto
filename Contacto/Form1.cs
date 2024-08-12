using System.Text.RegularExpressions;

namespace Contacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtMensaje.Text))
            {
                lblEstado.Text = "Por favor, complete todos los campos.";
                lblEstado.ForeColor = Color.Red; 
                return;
            }

            // Verifica que el nombre solo contenga letras
            if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z\s]+$"))
            {
                lblEstado.Text = "El nombre solo debe contener letras.";
                lblEstado.ForeColor = Color.Red;
                return;
            }

            // Verifica que el correo tenga un formato válido
            if (!Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblEstado.Text = "Por favor, ingrese un correo electrónico válido.";
                lblEstado.ForeColor = Color.Red;
                return;
            }

            // Si todas las validaciones pasan, muestra mensaje de éxito
            lblEstado.Text = "El mensaje fue enviado correctamente.";
            lblEstado.ForeColor = Color.Green;


        }
    }
}
