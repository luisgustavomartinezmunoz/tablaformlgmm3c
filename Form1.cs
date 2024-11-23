namespace tablaformlgmm3c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonver_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }

        private void muestraTabla()
        {
            try
            {
                // obtener el número ingresado por el usuario
                int n = Convert.ToInt32(this.textBoxnum.Text);
                string tabla = "";

                // generar la tabla de multiplicar
                for (int i = 1; i <= 10; i++)
                {
                    tabla += n + " x " + i + " = " + (n * i) + "\n";
                }

                // mostrar el resultado en el RichTextBox
                this.richTextresul.Text = tabla;
            }
            catch (FormatException)
            {
                // manejar errores de formato en caso de entrada inválida
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
