namespace Practico1
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
        /// 

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxResultado;
        private Button BSalir;
        private void InitializeComponent()
        {
            BGuardar = new Button();
            BEliminar = new Button();
            LApellido = new Label();
            LNombre = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxResultado = new TextBox();
            BSalir = new Button();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.BackColor = SystemColors.ScrollBar;
            BGuardar.Location = new Point(40, 164);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 0;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.BackColor = SystemColors.ActiveBorder;
            BEliminar.Location = new Point(141, 164);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 1;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = false;
            BEliminar.Click += BEliminar_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(24, 67);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            LApellido.Click += LNombre_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(24, 107);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(81, 64);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(135, 23);
            textBoxNombre.TabIndex = 7;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(81, 104);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(135, 23);
            textBoxApellido.TabIndex = 8;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(267, 59);
            textBoxResultado.Multiline = true;
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(174, 160);
            textBoxResultado.TabIndex = 9;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(93, 214);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(75, 23);
            BSalir.TabIndex = 7;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxResultado);
            Controls.Add(BSalir);
            Name = "Form1";
            Text = "Mi Primer Forms";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Button BEliminar;
        private Label LApellido;
        private Label LNombre;
    }
}
