namespace Practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TDni.KeyPress += TDni_KeyPress;
            TApellido.KeyPress += TApellido_KeyPress;
            TNombre.KeyPress += TNombre_KeyPress;
            RBVaron.CheckedChanged += RB_CheckedChanged;
            RBMujer.CheckedChanged += RB_CheckedChanged;
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacio y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacio y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            DialogResult ask;

            if (string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TNombre.Text))
            {

                ask = MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ask = MessageBox.Show(
                "Seguro que desea insertar un nuevo Cliente?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1 //Foco por defecto en el boton 1
                );

            if (ask == DialogResult.Yes)
            {
                string nombreCompleto = TApellido.Text + " " + TNombre.Text;
                LModificar.Text = nombreCompleto;
                MessageBox.Show(
                    $"El cliente: {nombreCompleto} se inserto correctamente",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Limpiar los campos después de la inserción
                TDni.Text = "";
                TApellido.Text = "";
                TNombre.Text = "";
            }

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = LModificar.Text;
            if (!string.IsNullOrWhiteSpace(nombreCompleto))
            {
                DialogResult ask;

                ask = MessageBox.Show(
                    $"Seguro que desea eliminar al cliente: {nombreCompleto}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2 //Foco por defecto en el boton 2
                    );

                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show(
                    $"El cliente: {nombreCompleto} se elimino correctamente",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                    TDni.Clear();
                    TApellido.Clear();
                    TNombre.Clear();
                    LModificar.Text = "";
                }
            }
            else
            {
                MessageBox.Show("No hay cliente para eliminar", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PanelDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PBHombre_Click(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                PBHombre.Image = Properties.Resources.IconHombre;
            }
            else if (RBMujer.Checked)
            {
                PBHombre.Image = Properties.Resources.IconMujer;
            }
        }
    }
}
