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
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(12, 24);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(110, 15);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(12, 121);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 1;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(12, 163);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(12, 83);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 3;
            LDni.Text = "DNI";
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(47, 228);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 4;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = Color.Transparent;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(160, 24);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 5;
            LModificar.Text = "modificar";
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(143, 228);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 6;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // TDni
            // 
            TDni.Location = new Point(80, 80);
            TDni.Name = "TDni";
            TDni.Size = new Size(138, 23);
            TDni.TabIndex = 7;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(80, 121);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(138, 23);
            TApellido.TabIndex = 8;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(80, 163);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(138, 23);
            TNombre.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 336);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(BEliminar);
            Controls.Add(LModificar);
            Controls.Add(BGuardar);
            Controls.Add(LDni);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(LNyA);
            Name = "Form1";
            Text = "Pequeño Formulario";
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
    }
}
