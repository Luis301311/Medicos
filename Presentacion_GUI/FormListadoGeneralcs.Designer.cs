namespace Presentacion_GUI
{
    partial class FormListadoGeneralcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelid = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labeltelefono = new System.Windows.Forms.Label();
            this.labelcorreo = new System.Windows.Forms.Label();
            this.labelnacionalidad = new System.Windows.Forms.Label();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.labelestado = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxPrimerNombre = new System.Windows.Forms.TextBox();
            this.fecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.buttonfiltar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonagregar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonsalir = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSegundoApellido = new System.Windows.Forms.TextBox();
            this.textBoxPrimerApellido = new System.Windows.Forms.TextBox();
            this.textBoxSegundoNombre = new System.Windows.Forms.TextBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbEps = new System.Windows.Forms.ComboBox();
            this.cmbSangre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.labelNotificacion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GrillaPacientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.SystemColors.Info;
            this.labelid.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(6, 12);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(105, 15);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "Identificacion:";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.BackColor = System.Drawing.SystemColors.Info;
            this.labelnombre.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(6, 75);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(112, 15);
            this.labelnombre.TabIndex = 1;
            this.labelnombre.Text = "Primer Nombre:";
            // 
            // labeltelefono
            // 
            this.labeltelefono.AutoSize = true;
            this.labeltelefono.BackColor = System.Drawing.SystemColors.Info;
            this.labeltelefono.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelefono.Location = new System.Drawing.Point(306, 186);
            this.labeltelefono.Name = "labeltelefono";
            this.labeltelefono.Size = new System.Drawing.Size(70, 15);
            this.labeltelefono.TabIndex = 2;
            this.labeltelefono.Text = "Telefono:";
            // 
            // labelcorreo
            // 
            this.labelcorreo.AutoSize = true;
            this.labelcorreo.BackColor = System.Drawing.SystemColors.Info;
            this.labelcorreo.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcorreo.Location = new System.Drawing.Point(548, 14);
            this.labelcorreo.Name = "labelcorreo";
            this.labelcorreo.Size = new System.Drawing.Size(58, 15);
            this.labelcorreo.TabIndex = 3;
            this.labelcorreo.Text = "Correo:";
            // 
            // labelnacionalidad
            // 
            this.labelnacionalidad.AutoSize = true;
            this.labelnacionalidad.BackColor = System.Drawing.SystemColors.Info;
            this.labelnacionalidad.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnacionalidad.Location = new System.Drawing.Point(548, 129);
            this.labelnacionalidad.Name = "labelnacionalidad";
            this.labelnacionalidad.Size = new System.Drawing.Size(58, 15);
            this.labelnacionalidad.TabIndex = 6;
            this.labelnacionalidad.Text = "Ciudad:";
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.BackColor = System.Drawing.SystemColors.Info;
            this.labeldireccion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion.Location = new System.Drawing.Point(304, 125);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(76, 15);
            this.labeldireccion.TabIndex = 8;
            this.labeldireccion.Text = "Dirección:";
            // 
            // labelestado
            // 
            this.labelestado.AutoSize = true;
            this.labelestado.BackColor = System.Drawing.SystemColors.Info;
            this.labelestado.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestado.Location = new System.Drawing.Point(548, 188);
            this.labelestado.Name = "labelestado";
            this.labelestado.Size = new System.Drawing.Size(35, 15);
            this.labelestado.TabIndex = 9;
            this.labelestado.Text = "Eps:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.SystemColors.Info;
            this.labelFecha.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(293, 62);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(89, 30);
            this.labelFecha.TabIndex = 11;
            this.labelFecha.Text = "  Fecha de \r\nNacimiento:";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(139, 13);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(107, 20);
            this.textBoxId.TabIndex = 12;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(399, 123);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(109, 20);
            this.textBoxDireccion.TabIndex = 14;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(645, 14);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(107, 20);
            this.textBoxCorreo.TabIndex = 20;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(403, 186);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(107, 20);
            this.textBoxTelefono.TabIndex = 21;
            // 
            // textBoxPrimerNombre
            // 
            this.textBoxPrimerNombre.Location = new System.Drawing.Point(139, 72);
            this.textBoxPrimerNombre.Name = "textBoxPrimerNombre";
            this.textBoxPrimerNombre.Size = new System.Drawing.Size(105, 20);
            this.textBoxPrimerNombre.TabIndex = 22;
            // 
            // fecha_Nacimiento
            // 
            this.fecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_Nacimiento.Location = new System.Drawing.Point(401, 72);
            this.fecha_Nacimiento.Name = "fecha_Nacimiento";
            this.fecha_Nacimiento.Size = new System.Drawing.Size(107, 20);
            this.fecha_Nacimiento.TabIndex = 24;
            // 
            // buttonfiltar
            // 
            this.buttonfiltar.Location = new System.Drawing.Point(741, 6);
            this.buttonfiltar.Name = "buttonfiltar";
            this.buttonfiltar.Size = new System.Drawing.Size(75, 23);
            this.buttonfiltar.TabIndex = 26;
            this.buttonfiltar.Text = "Filtrar";
            this.buttonfiltar.UseVisualStyleBackColor = true;
            this.buttonfiltar.Click += new System.EventHandler(this.buttonfiltar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(464, 250);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(83, 29);
            this.buttonEliminar.TabIndex = 27;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonagregar
            // 
            this.buttonagregar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonagregar.Location = new System.Drawing.Point(200, 250);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(78, 29);
            this.buttonagregar.TabIndex = 28;
            this.buttonagregar.Text = "Agregar";
            this.buttonagregar.UseVisualStyleBackColor = true;
            this.buttonagregar.Click += new System.EventHandler(this.buttonagregar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Location = new System.Drawing.Point(79, 251);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(73, 29);
            this.buttonNuevo.TabIndex = 29;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonsalir
            // 
            this.buttonsalir.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalir.Location = new System.Drawing.Point(842, 399);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(107, 28);
            this.buttonsalir.TabIndex = 30;
            this.buttonsalir.Text = "Salir";
            this.buttonsalir.UseVisualStyleBackColor = true;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(558, 9);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(161, 20);
            this.textBoxBusqueda.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Segundo Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Segundo Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Primer Apellido:";
            // 
            // textBoxSegundoApellido
            // 
            this.textBoxSegundoApellido.Location = new System.Drawing.Point(405, 13);
            this.textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            this.textBoxSegundoApellido.Size = new System.Drawing.Size(105, 20);
            this.textBoxSegundoApellido.TabIndex = 38;
            // 
            // textBoxPrimerApellido
            // 
            this.textBoxPrimerApellido.Location = new System.Drawing.Point(139, 186);
            this.textBoxPrimerApellido.Name = "textBoxPrimerApellido";
            this.textBoxPrimerApellido.Size = new System.Drawing.Size(105, 20);
            this.textBoxPrimerApellido.TabIndex = 39;
            // 
            // textBoxSegundoNombre
            // 
            this.textBoxSegundoNombre.Location = new System.Drawing.Point(139, 123);
            this.textBoxSegundoNombre.Name = "textBoxSegundoNombre";
            this.textBoxSegundoNombre.Size = new System.Drawing.Size(105, 20);
            this.textBoxSegundoNombre.TabIndex = 40;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(645, 125);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(107, 21);
            this.cmbCiudad.TabIndex = 42;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 333);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbEps);
            this.tabPage1.Controls.Add(this.cmbSangre);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttonActualizar);
            this.tabPage1.Controls.Add(this.lstPacientes);
            this.tabPage1.Controls.Add(this.labelNotificacion);
            this.tabPage1.Controls.Add(this.labelid);
            this.tabPage1.Controls.Add(this.cmbCiudad);
            this.tabPage1.Controls.Add(this.labelnombre);
            this.tabPage1.Controls.Add(this.textBoxSegundoNombre);
            this.tabPage1.Controls.Add(this.labeltelefono);
            this.tabPage1.Controls.Add(this.textBoxPrimerApellido);
            this.tabPage1.Controls.Add(this.labelcorreo);
            this.tabPage1.Controls.Add(this.textBoxSegundoApellido);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelnacionalidad);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labeldireccion);
            this.tabPage1.Controls.Add(this.labelestado);
            this.tabPage1.Controls.Add(this.labelFecha);
            this.tabPage1.Controls.Add(this.buttonNuevo);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.buttonagregar);
            this.tabPage1.Controls.Add(this.buttonEliminar);
            this.tabPage1.Controls.Add(this.textBoxDireccion);
            this.tabPage1.Controls.Add(this.fecha_Nacimiento);
            this.tabPage1.Controls.Add(this.textBoxPrimerNombre);
            this.tabPage1.Controls.Add(this.textBoxTelefono);
            this.tabPage1.Controls.Add(this.textBoxCorreo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbEps
            // 
            this.cmbEps.FormattingEnabled = true;
            this.cmbEps.Location = new System.Drawing.Point(645, 185);
            this.cmbEps.Name = "cmbEps";
            this.cmbEps.Size = new System.Drawing.Size(107, 21);
            this.cmbEps.TabIndex = 50;
            // 
            // cmbSangre
            // 
            this.cmbSangre.FormattingEnabled = true;
            this.cmbSangre.Location = new System.Drawing.Point(645, 69);
            this.cmbSangre.Name = "cmbSangre";
            this.cmbSangre.Size = new System.Drawing.Size(107, 21);
            this.cmbSangre.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 30);
            this.label6.TabIndex = 48;
            this.label6.Text = "Tipo De \r\nSangre:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(815, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Pacientes";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(327, 250);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(96, 29);
            this.buttonActualizar.TabIndex = 46;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.Location = new System.Drawing.Point(790, 53);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(128, 225);
            this.lstPacientes.TabIndex = 45;
            this.lstPacientes.DoubleClick += new System.EventHandler(this.lstPacientes_DoubleClick);
            // 
            // labelNotificacion
            // 
            this.labelNotificacion.AutoSize = true;
            this.labelNotificacion.Location = new System.Drawing.Point(604, 267);
            this.labelNotificacion.Name = "labelNotificacion";
            this.labelNotificacion.Size = new System.Drawing.Size(0, 13);
            this.labelNotificacion.TabIndex = 43;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRestablecer);
            this.tabPage2.Controls.Add(this.GrillaPacientes);
            this.tabPage2.Controls.Add(this.buttonfiltar);
            this.tabPage2.Controls.Add(this.textBoxBusqueda);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista De Pacientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GrillaPacientes
            // 
            this.GrillaPacientes.BackgroundColor = System.Drawing.Color.White;
            this.GrillaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.p_nom,
            this.s_nom,
            this.p_ape,
            this.s_ape,
            this.Fecha,
            this.Tel,
            this.Correo,
            this.Tipo,
            this.Dire,
            this.Ciudad,
            this.Eps});
            this.GrillaPacientes.Location = new System.Drawing.Point(26, 35);
            this.GrillaPacientes.Name = "GrillaPacientes";
            this.GrillaPacientes.Size = new System.Drawing.Size(886, 254);
            this.GrillaPacientes.TabIndex = 23;
            // 
            // Id
            // 
            this.Id.HeaderText = "Identificación";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // p_nom
            // 
            this.p_nom.HeaderText = "Primer Nombre";
            this.p_nom.Name = "p_nom";
            this.p_nom.ReadOnly = true;
            // 
            // s_nom
            // 
            this.s_nom.HeaderText = "Segundo Nombre";
            this.s_nom.Name = "s_nom";
            this.s_nom.ReadOnly = true;
            // 
            // p_ape
            // 
            this.p_ape.HeaderText = "Primer Apellido";
            this.p_ape.Name = "p_ape";
            this.p_ape.ReadOnly = true;
            // 
            // s_ape
            // 
            this.s_ape.HeaderText = "Segundo Apellido";
            this.s_ape.Name = "s_ape";
            this.s_ape.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha De Nacimiento";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Telefono";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo De Sangre";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Dire
            // 
            this.Dire.HeaderText = "Direccion";
            this.Dire.Name = "Dire";
            this.Dire.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad De Origen";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Eps
            // 
            this.Eps.HeaderText = "Eps";
            this.Eps.Name = "Eps";
            this.Eps.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(293, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 48);
            this.label4.TabIndex = 44;
            this.label4.Text = "Hospital San Fernando";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Image = global::Presentacion_GUI.Properties.Resources.clinica_hospital_san_fernando_logo_BBB34D347D_seeklogo_com;
            this.pictureBox2.Location = new System.Drawing.Point(867, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(837, 6);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(75, 23);
            this.btnRestablecer.TabIndex = 32;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // FormListadoGeneralcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 432);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonsalir);
            this.Name = "FormListadoGeneralcs";
            this.Text = "Gestión Pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListadoGeneralcs_FormClosing);
            this.Load += new System.EventHandler(this.FormListadoGeneralcs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labeltelefono;
        private System.Windows.Forms.Label labelcorreo;
        private System.Windows.Forms.Label labelnacionalidad;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.Label labelestado;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxPrimerNombre;
        private System.Windows.Forms.DateTimePicker fecha_Nacimiento;
        private System.Windows.Forms.Button buttonfiltar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonagregar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonsalir;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSegundoApellido;
        private System.Windows.Forms.TextBox textBoxPrimerApellido;
        private System.Windows.Forms.TextBox textBoxSegundoNombre;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelNotificacion;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView GrillaPacientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSangre;
        private System.Windows.Forms.ComboBox cmbEps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eps;
        private System.Windows.Forms.Button btnRestablecer;
    }
}