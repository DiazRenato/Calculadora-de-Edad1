using System.Runtime.CompilerServices;

namespace CalcularEdad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNacimiento = DateTime.Parse(txtFCNCA.Text);

            while (!DateTime.TryParse(txtFCNCA.Text, out fechaNacimiento))
            {
                MessageBox.Show("Por favor ingrese una fecha válida en formato dd/MM/yyyy.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
            {
                edad--; // ajustar si todavía no cumplió años este año
            }

            // Condicional para determinar mayor o menor de edad
            if (edad >= 18)
            {
                MessageBox.Show($"{nombre} {apellido} es MAYOR de edad ({edad} años).",
                                "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{nombre} {apellido} es MENOR de edad ({edad} años).",
                                "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }






        }
    }
}
