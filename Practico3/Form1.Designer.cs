namespace Practico3
{
    partial class Form1
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
            LNyA = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LDni = new Label();
            BGuardar = new Button();
            LModificar = new Label();
            BEliminar = new Button();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            PanelDatos = new Panel();
            LTjCredito = new Label();
            CBTjCreditos = new CheckedListBox();
            Ttelefono = new TextBox();
            LTelefono = new Label();
            PBHombre = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            BSalir = new Button();
            PanelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBHombre).BeginInit();
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(12, 11);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(110, 15);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(12, 80);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(56, 15);
            LApellido.TabIndex = 1;
            LApellido.Text = "*Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(12, 119);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(56, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "*Nombre";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(12, 42);
            LDni.Name = "LDni";
            LDni.Size = new Size(32, 15);
            LDni.TabIndex = 3;
            LDni.Text = "*DNI";
            // 
            // BGuardar
            // 
            BGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(45, 364);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 4;
            BGuardar.Text = "Guardar";
            BGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = Color.Transparent;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(141, 11);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 5;
            LModificar.Text = "modificar";
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(153, 364);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 6;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // TDni
            // 
            TDni.Location = new Point(83, 39);
            TDni.Name = "TDni";
            TDni.Size = new Size(138, 23);
            TDni.TabIndex = 7;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(83, 77);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(138, 23);
            TApellido.TabIndex = 8;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(83, 116);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(138, 23);
            TNombre.TabIndex = 9;
            // 
            // PanelDatos
            // 
            PanelDatos.BackColor = SystemColors.ControlDark;
            PanelDatos.Controls.Add(LTjCredito);
            PanelDatos.Controls.Add(CBTjCreditos);
            PanelDatos.Controls.Add(Ttelefono);
            PanelDatos.Controls.Add(LTelefono);
            PanelDatos.Controls.Add(TDni);
            PanelDatos.Controls.Add(TNombre);
            PanelDatos.Controls.Add(LModificar);
            PanelDatos.Controls.Add(TApellido);
            PanelDatos.Controls.Add(LDni);
            PanelDatos.Controls.Add(LNyA);
            PanelDatos.Controls.Add(LNombre);
            PanelDatos.Controls.Add(LApellido);
            PanelDatos.Location = new Point(12, 47);
            PanelDatos.Name = "PanelDatos";
            PanelDatos.Size = new Size(240, 279);
            PanelDatos.TabIndex = 10;
            PanelDatos.Paint += PanelDatos_Paint;
            // 
            // LTjCredito
            // 
            LTjCredito.AutoSize = true;
            LTjCredito.Location = new Point(3, 206);
            LTjCredito.Name = "LTjCredito";
            LTjCredito.Size = new Size(105, 15);
            LTjCredito.TabIndex = 13;
            LTjCredito.Text = "Tarjeta de Creditos";
            // 
            // CBTjCreditos
            // 
            CBTjCreditos.BackColor = SystemColors.ButtonShadow;
            CBTjCreditos.FormattingEnabled = true;
            CBTjCreditos.Items.AddRange(new object[] { "Naranja ", "Visa", "MasterCard" });
            CBTjCreditos.Location = new Point(111, 206);
            CBTjCreditos.Name = "CBTjCreditos";
            CBTjCreditos.Size = new Size(120, 58);
            CBTjCreditos.TabIndex = 12;
            // 
            // Ttelefono
            // 
            Ttelefono.Location = new Point(83, 158);
            Ttelefono.Name = "Ttelefono";
            Ttelefono.Size = new Size(138, 23);
            Ttelefono.TabIndex = 11;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(12, 161);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(53, 15);
            LTelefono.TabIndex = 10;
            LTelefono.Text = "Telefono";
            LTelefono.Click += label1_Click;
            // 
            // PBHombre
            // 
            PBHombre.BackColor = Color.Transparent;
            PBHombre.Image = Properties.Resources.IconHombre;
            PBHombre.Location = new Point(315, 68);
            PBHombre.Name = "PBHombre";
            PBHombre.Size = new Size(117, 100);
            PBHombre.TabIndex = 11;
            PBHombre.TabStop = false;
            PBHombre.Click += PBHombre_Click;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(306, 188);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 12;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(376, 188);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 13;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(363, 370);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(75, 23);
            BSalir.TabIndex = 14;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 438);
            Controls.Add(BSalir);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(PBHombre);
            Controls.Add(PanelDatos);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Name = "Form1";
            Text = "Pequeño Formulario";
            PanelDatos.ResumeLayout(false);
            PanelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBHombre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNyA;
        private Label LApellido;
        private Label LNombre;
        private Label LDni;
        private Button BGuardar;
        private Label LModificar;
        private Button BEliminar;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Panel PanelDatos;
        private Label LTelefono;
        private CheckedListBox CBTjCreditos;
        private TextBox Ttelefono;
        private Label LTjCredito;
        private PictureBox PBHombre;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private Button BSalir;
    }
}
