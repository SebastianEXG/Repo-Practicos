namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            //Concatenar los textos
            textBoxResultado.Text = textBoxNombre.Text + " " + textBoxApellido.Text;    
        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            End();
        }
        private void End()
        {
            Application.Exit();
        }
    }
}
