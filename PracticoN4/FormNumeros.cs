using System.Windows.Forms.DataVisualization.Charting;
namespace PracticoN4

{
    public partial class FormNumeros : Form
    {
        Chart chartNumeros;
        public FormNumeros()
        {
            InitializeComponent();
            TBDesde.KeyPress += TBDesde_KeyPress;
            TBHasta.KeyPress += TBHasta_KeyPress;

           
        }


        private void TBDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BGenerarFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDesde.Text) || string.IsNullOrWhiteSpace(TBHasta.Text))
            {
                MessageBox.Show("Por favor, ingrese ambos valores.");
                return;
            }

            int desde = int.Parse(TBDesde.Text);
            int hasta = int.Parse(TBHasta.Text);

            listBox1.Items.Clear();

            for (int i = desde; i <= hasta; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        // Botón Números Pares
        private void BNumerosPares_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDesde.Text) || string.IsNullOrWhiteSpace(TBHasta.Text))
            {
                MessageBox.Show("Debe ingresar ambos valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int desde = int.Parse(TBDesde.Text);
            int hasta = int.Parse(TBHasta.Text);

            listBox1.Items.Clear();

            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 == 0) // módulo 2 == 0 → par
                    listBox1.Items.Add(i);
            }
        }

        // Botón Números Impares
        private void BNumerosImpares_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDesde.Text) || string.IsNullOrWhiteSpace(TBHasta.Text))
            {
                MessageBox.Show("Debe ingresar ambos valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int desde = int.Parse(TBDesde.Text);
            int hasta = int.Parse(TBHasta.Text);

            listBox1.Items.Clear();

            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 != 0) // módulo 2 != 0 → impar
                    listBox1.Items.Add(i);
            }
        }

        // Función para verificar si un número es primo
        private bool EsPrimo(int numero)
        {
            if (numero < 2) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        // Botón Números Primos
        private void BNumerosPrimos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDesde.Text) || string.IsNullOrWhiteSpace(TBHasta.Text))
            {
                MessageBox.Show("Debe ingresar ambos valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int desde = int.Parse(TBDesde.Text);
            int hasta = int.Parse(TBHasta.Text);

            listBox1.Items.Clear();

            for (int i = desde; i <= hasta; i++)
            {
                if (EsPrimo(i))
                    listBox1.Items.Add(i);
            }
        }

        
    }

}
