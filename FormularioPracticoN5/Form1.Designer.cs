namespace FormularioPracticoN5
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
            panel1 = new Panel();
            TBFoto = new TextBox();
            BFoto = new Button();
            TBSaldo = new TextBox();
            RBFem = new RadioButton();
            RBMasc = new RadioButton();
            TBApellido = new TextBox();
            TBNombre = new TextBox();
            DTFechaNacimiento = new DateTimePicker();
            LSaldo = new Label();
            LSexo = new Label();
            LFechaNac = new Label();
            LApellido = new Label();
            LNombre = new Label();
            BAgregar = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            dgvUsuarios = new DataGridView();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Fecha_Nacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.painted_concrete_background;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(TBFoto);
            panel1.Controls.Add(BFoto);
            panel1.Controls.Add(TBSaldo);
            panel1.Controls.Add(RBFem);
            panel1.Controls.Add(RBMasc);
            panel1.Controls.Add(TBApellido);
            panel1.Controls.Add(TBNombre);
            panel1.Controls.Add(DTFechaNacimiento);
            panel1.Controls.Add(LSaldo);
            panel1.Controls.Add(LSexo);
            panel1.Controls.Add(LFechaNac);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(40, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 285);
            panel1.TabIndex = 0;
            // 
            // TBFoto
            // 
            TBFoto.BackColor = Color.DimGray;
            TBFoto.Font = new Font("Papyrus", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBFoto.ForeColor = Color.White;
            TBFoto.Location = new Point(125, 233);
            TBFoto.Name = "TBFoto";
            TBFoto.Size = new Size(219, 28);
            TBFoto.TabIndex = 12;
            // 
            // BFoto
            // 
            BFoto.BackColor = Color.DimGray;
            BFoto.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BFoto.ForeColor = Color.White;
            BFoto.Location = new Point(37, 233);
            BFoto.Name = "BFoto";
            BFoto.Size = new Size(81, 35);
            BFoto.TabIndex = 11;
            BFoto.Text = "Foto";
            BFoto.UseVisualStyleBackColor = false;
            BFoto.Click += BFoto_Click;
            // 
            // TBSaldo
            // 
            TBSaldo.BackColor = Color.DimGray;
            TBSaldo.Font = new Font("Papyrus", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBSaldo.ForeColor = Color.White;
            TBSaldo.Location = new Point(125, 190);
            TBSaldo.Name = "TBSaldo";
            TBSaldo.Size = new Size(219, 28);
            TBSaldo.TabIndex = 10;
            // 
            // RBFem
            // 
            RBFem.AutoSize = true;
            RBFem.BackColor = Color.Transparent;
            RBFem.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBFem.Location = new Point(217, 144);
            RBFem.Name = "RBFem";
            RBFem.Size = new Size(97, 29);
            RBFem.TabIndex = 9;
            RBFem.Text = "Femenino";
            RBFem.UseVisualStyleBackColor = false;
            // 
            // RBMasc
            // 
            RBMasc.AutoSize = true;
            RBMasc.BackColor = Color.Transparent;
            RBMasc.Checked = true;
            RBMasc.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBMasc.Location = new Point(109, 143);
            RBMasc.Name = "RBMasc";
            RBMasc.Size = new Size(100, 29);
            RBMasc.TabIndex = 8;
            RBMasc.TabStop = true;
            RBMasc.Text = "Masculino";
            RBMasc.UseVisualStyleBackColor = false;
            // 
            // TBApellido
            // 
            TBApellido.BackColor = Color.DimGray;
            TBApellido.Font = new Font("Papyrus", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBApellido.ForeColor = Color.White;
            TBApellido.Location = new Point(125, 57);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(219, 28);
            TBApellido.TabIndex = 7;
            TBApellido.TextChanged += TBApellido_TextChanged;
            // 
            // TBNombre
            // 
            TBNombre.BackColor = Color.DimGray;
            TBNombre.Font = new Font("Papyrus", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBNombre.ForeColor = Color.White;
            TBNombre.Location = new Point(125, 19);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(219, 28);
            TBNombre.TabIndex = 6;
            TBNombre.TextChanged += TBNombre_TextChanged;
            // 
            // DTFechaNacimiento
            // 
            DTFechaNacimiento.CalendarFont = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTFechaNacimiento.CalendarMonthBackground = SystemColors.InfoText;
            DTFechaNacimiento.CalendarTitleBackColor = SystemColors.AppWorkspace;
            DTFechaNacimiento.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTFechaNacimiento.Format = DateTimePickerFormat.Short;
            DTFechaNacimiento.Location = new Point(217, 97);
            DTFechaNacimiento.Name = "DTFechaNacimiento";
            DTFechaNacimiento.Size = new Size(120, 33);
            DTFechaNacimiento.TabIndex = 5;
            // 
            // LSaldo
            // 
            LSaldo.AutoSize = true;
            LSaldo.BackColor = Color.Transparent;
            LSaldo.Location = new Point(37, 185);
            LSaldo.Name = "LSaldo";
            LSaldo.Size = new Size(74, 33);
            LSaldo.TabIndex = 4;
            LSaldo.Text = "Saldo";
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.BackColor = Color.Transparent;
            LSexo.Location = new Point(37, 140);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(66, 33);
            LSexo.TabIndex = 3;
            LSexo.Text = "Sexo";
            // 
            // LFechaNac
            // 
            LFechaNac.AutoSize = true;
            LFechaNac.BackColor = Color.Transparent;
            LFechaNac.Location = new Point(31, 98);
            LFechaNac.Name = "LFechaNac";
            LFechaNac.Size = new Size(180, 33);
            LFechaNac.TabIndex = 2;
            LFechaNac.Text = "Fecha Nacimiento";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.BackColor = Color.Transparent;
            LApellido.Location = new Point(31, 52);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(94, 33);
            LApellido.TabIndex = 1;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = Color.Transparent;
            LNombre.Location = new Point(31, 19);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(88, 33);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre";
            // 
            // BAgregar
            // 
            BAgregar.BackColor = Color.DimGray;
            BAgregar.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAgregar.ForeColor = Color.White;
            BAgregar.Image = Properties.Resources.Guardar;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(577, 174);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(129, 47);
            BAgregar.TabIndex = 0;
            BAgregar.Text = "Agregar";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Avatar;
            pictureBox1.Location = new Point(577, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 147);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, Fecha_Nacimiento, Sexo, Saldo, Foto, Ruta });
            dgvUsuarios.Location = new Point(2, 303);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(803, 135);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Fecha_Nacimiento
            // 
            Fecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.Name = "Foto";
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.abstract_uv_ultraviolet_light_composition;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 439);
            Controls.Add(dgvUsuarios);
            Controls.Add(BAgregar);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "FormularioN5";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BAgregar;
        private PictureBox pictureBox1;
        private Label LFechaNac;
        private Label LApellido;
        private Label LNombre;
        private Label LSexo;
        private TextBox TBNombre;
        private DateTimePicker DTFechaNacimiento;
        private Label LSaldo;
        private RadioButton RBFem;
        private RadioButton RBMasc;
        private TextBox TBApellido;
        private TextBox TBSaldo;
        private OpenFileDialog openFileDialog1;
        private Button BFoto;
        private TextBox TBFoto;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Fecha_Nacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
    }
}
