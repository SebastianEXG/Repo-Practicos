namespace FormularioPracticoN5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 

            //Validaciones para los textbox
            TBApellido.KeyPress += TBApellido_KeyPress;
            TBNombre.KeyPress += TBNombre_KeyPress; 
            TBSaldo.KeyPress += TBSaldo_KeyPress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        } 

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        } 

        private void TBSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }


        private void BFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de Imagen|*.jpg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                TBFoto.Text = openFileDialog1.FileName;
            }
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            if (TBNombre.Text.Length > 0)
            {
                TBNombre.Text = char.ToUpper(TBNombre.Text[0]) +
                                 TBNombre.Text.Substring(1).ToLower();
                TBNombre.SelectionStart = TBNombre.Text.Length; // mantiene cursor al final
            }
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {


            if (TBApellido.Text.Length > 0)
            {
                TBApellido.Text = char.ToUpper(TBApellido.Text[0]) +
                                 TBApellido.Text.Substring(1).ToLower();
                TBApellido.SelectionStart = TBApellido.Text.Length; // mantiene cursor al final
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            string rutaBase = Application.StartupPath;
            string rutaImagen = Path.Combine(rutaBase, "Fotos", "Avatar.png");


            int rowIndex = dgvUsuarios.Rows.Add();
            DataGridViewRow row = dgvUsuarios.Rows[rowIndex];

            row.Cells["Nombre"].Value = TBNombre.Text;
            row.Cells["Apellido"].Value = TBApellido.Text;
            row.Cells["Fecha_Nacimiento"].Value = DTFechaNacimiento.Value.ToShortDateString();
            row.Cells["Sexo"].Value = RBMasc.Checked ? "Masculino" : "Femenino";
            row.Cells["Saldo"].Value = TBSaldo.Text;
            row.Cells["Ruta"].Value = TBFoto.Text;

            if (File.Exists(rutaImagen))
            {
                row.Cells["Foto"].Value = Image.FromFile(rutaImagen);
            }
            else
            {
                MessageBox.Show("No se encontró la imagen en: " + rutaImagen);
            }

            if (File.Exists(TBFoto.Text))
            {
                row.Cells["Foto"].Value = Image.FromFile(TBFoto.Text);
            }
            else
            {
                MessageBox.Show("La imagen no existe en la ruta: " + TBFoto.Text);
            }


            //Boton Eliminar 
            if (!dgvUsuarios.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn BEliminar = new DataGridViewButtonColumn();
                BEliminar.Name = "Eliminar";
                BEliminar.Text = "Eliminar";
                BEliminar.UseColumnTextForButtonValue = true;
                dgvUsuarios.Columns.Add(BEliminar);
            }

            //Caso del saldo 
            if (decimal.TryParse(TBSaldo.Text, out decimal saldo))
            {
                if (saldo < 50)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }

            //Img por defecto 
            pictureBox1.Image = Image.FromFile(@"Fotos\Avatar.png");
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsuarios.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("¿Desea eliminar este registro?",
                                                  "Confirmación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dgvUsuarios.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                string sexo = dgvUsuarios.CurrentRow.Cells["Sexo"].Value?.ToString();
                if (sexo == "Masculino")
                    RBMasc.Checked = true;
                else if (sexo == "Femenino")
                    RBFem.Checked = true;
            }
        }

        
    }
}
