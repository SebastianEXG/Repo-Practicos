namespace PracticoN4
{
    partial class FormNumeros
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
            LDesde = new Label();
            LHasta = new Label();
            TBDesde = new TextBox();
            TBHasta = new TextBox();
            LListaDeNumeros = new Label();
            BGenerarFunc = new Button();
            listBox1 = new ListBox();
            BNumerosPares = new Button();
            BNumerosImpares = new Button();
            BNumerosPrimos = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.Location = new Point(9, 47);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(39, 15);
            LDesde.TabIndex = 0;
            LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Location = new Point(11, 76);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(37, 15);
            LHasta.TabIndex = 1;
            LHasta.Text = "Hasta";
            // 
            // TBDesde
            // 
            TBDesde.Location = new Point(54, 43);
            TBDesde.Name = "TBDesde";
            TBDesde.Size = new Size(88, 23);
            TBDesde.TabIndex = 2;
            // 
            // TBHasta
            // 
            TBHasta.Location = new Point(54, 73);
            TBHasta.Name = "TBHasta";
            TBHasta.Size = new Size(88, 23);
            TBHasta.TabIndex = 3;
            // 
            // LListaDeNumeros
            // 
            LListaDeNumeros.Location = new Point(159, 7);
            LListaDeNumeros.Name = "LListaDeNumeros";
            LListaDeNumeros.Size = new Size(200, 33);
            LListaDeNumeros.TabIndex = 4;
            LListaDeNumeros.Text = "Lista de Numeros";
            LListaDeNumeros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BGenerarFunc
            // 
            BGenerarFunc.BackColor = SystemColors.AppWorkspace;
            BGenerarFunc.Location = new Point(41, 111);
            BGenerarFunc.Name = "BGenerarFunc";
            BGenerarFunc.Size = new Size(112, 22);
            BGenerarFunc.TabIndex = 6;
            BGenerarFunc.Text = "Generar Funcion";
            BGenerarFunc.UseVisualStyleBackColor = false;
            BGenerarFunc.Click += BGenerarFunc_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(159, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 184);
            listBox1.TabIndex = 7;
            // 
            // BNumerosPares
            // 
            BNumerosPares.Location = new Point(41, 139);
            BNumerosPares.Name = "BNumerosPares";
            BNumerosPares.Size = new Size(112, 21);
            BNumerosPares.TabIndex = 8;
            BNumerosPares.Text = "Numeros Pares";
            BNumerosPares.UseVisualStyleBackColor = true;
            BNumerosPares.Click += BNumerosPares_Click;
            // 
            // BNumerosImpares
            // 
            BNumerosImpares.Location = new Point(41, 166);
            BNumerosImpares.Name = "BNumerosImpares";
            BNumerosImpares.Size = new Size(112, 23);
            BNumerosImpares.TabIndex = 9;
            BNumerosImpares.Text = "Numeros Impares";
            BNumerosImpares.UseVisualStyleBackColor = true;
            BNumerosImpares.Click += BNumerosImpares_Click;
            // 
            // BNumerosPrimos
            // 
            BNumerosPrimos.Location = new Point(41, 195);
            BNumerosPrimos.Name = "BNumerosPrimos";
            BNumerosPrimos.Size = new Size(112, 21);
            BNumerosPrimos.TabIndex = 10;
            BNumerosPrimos.Text = "Numeros Primos";
            BNumerosPrimos.UseVisualStyleBackColor = true;
            BNumerosPrimos.Click += BNumerosPrimos_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BNumerosPrimos);
            panel1.Controls.Add(LListaDeNumeros);
            panel1.Controls.Add(BNumerosImpares);
            panel1.Controls.Add(BNumerosPares);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(BGenerarFunc);
            panel1.Controls.Add(TBHasta);
            panel1.Controls.Add(TBDesde);
            panel1.Controls.Add(LHasta);
            panel1.Controls.Add(LDesde);
            panel1.Location = new Point(105, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 247);
            panel1.TabIndex = 11;
            // 
            // FormNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 351);
            Controls.Add(panel1);
            Name = "FormNumeros";
            Text = "Formulario4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LDesde;
        private Label LHasta;
        private TextBox TBDesde;
        private TextBox TBHasta;
        private Label LListaDeNumeros;
        private Button BGenerarFunc;
        private ListBox listBox1;
        private Button BNumerosPares;
        private Button BNumerosImpares;
        private Button BNumerosPrimos;
        private Panel panel1;
    }
}
