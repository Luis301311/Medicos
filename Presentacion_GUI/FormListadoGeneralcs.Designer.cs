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
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelRegimen = new System.Windows.Forms.Label();
            this.labelnacionalidad = new System.Windows.Forms.Label();
            this.labelocupacion = new System.Windows.Forms.Label();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.labelestado = new System.Windows.Forms.Label();
            this.labelniveleducativo = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxOcupacion = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNivel_Educativo = new System.Windows.Forms.TextBox();
            this.textBoxEstado_Civil = new System.Windows.Forms.TextBox();
            this.textBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxPrimerNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segundo_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segundo_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regimen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel_Educativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.labelNotificacion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.labelnombre.Location = new System.Drawing.Point(6, 60);
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
            this.labeltelefono.Location = new System.Drawing.Point(548, 12);
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
            this.labelcorreo.Location = new System.Drawing.Point(548, 53);
            this.labelcorreo.Name = "labelcorreo";
            this.labelcorreo.Size = new System.Drawing.Size(58, 15);
            this.labelcorreo.TabIndex = 3;
            this.labelcorreo.Text = "Correo:";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.BackColor = System.Drawing.SystemColors.Info;
            this.labelEdad.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(548, 102);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(45, 15);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad:";
            // 
            // labelRegimen
            // 
            this.labelRegimen.AutoSize = true;
            this.labelRegimen.BackColor = System.Drawing.SystemColors.Info;
            this.labelRegimen.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegimen.Location = new System.Drawing.Point(548, 147);
            this.labelRegimen.Name = "labelRegimen";
            this.labelRegimen.Size = new System.Drawing.Size(69, 15);
            this.labelRegimen.TabIndex = 5;
            this.labelRegimen.Text = "Regimen:";
            // 
            // labelnacionalidad
            // 
            this.labelnacionalidad.AutoSize = true;
            this.labelnacionalidad.BackColor = System.Drawing.SystemColors.Info;
            this.labelnacionalidad.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnacionalidad.Location = new System.Drawing.Point(281, 12);
            this.labelnacionalidad.Name = "labelnacionalidad";
            this.labelnacionalidad.Size = new System.Drawing.Size(96, 15);
            this.labelnacionalidad.TabIndex = 6;
            this.labelnacionalidad.Text = "Nacionalidad";
            // 
            // labelocupacion
            // 
            this.labelocupacion.AutoSize = true;
            this.labelocupacion.BackColor = System.Drawing.SystemColors.Info;
            this.labelocupacion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelocupacion.Location = new System.Drawing.Point(280, 200);
            this.labelocupacion.Name = "labelocupacion";
            this.labelocupacion.Size = new System.Drawing.Size(84, 15);
            this.labelocupacion.TabIndex = 7;
            this.labelocupacion.Text = "Ocupación:";
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.BackColor = System.Drawing.SystemColors.Info;
            this.labeldireccion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion.Location = new System.Drawing.Point(281, 153);
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
            this.labelestado.Location = new System.Drawing.Point(281, 60);
            this.labelestado.Name = "labelestado";
            this.labelestado.Size = new System.Drawing.Size(96, 15);
            this.labelestado.TabIndex = 9;
            this.labelestado.Text = "Estado Civil: ";
            // 
            // labelniveleducativo
            // 
            this.labelniveleducativo.AutoSize = true;
            this.labelniveleducativo.BackColor = System.Drawing.SystemColors.Info;
            this.labelniveleducativo.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelniveleducativo.Location = new System.Drawing.Point(280, 104);
            this.labelniveleducativo.Name = "labelniveleducativo";
            this.labelniveleducativo.Size = new System.Drawing.Size(118, 15);
            this.labelniveleducativo.TabIndex = 10;
            this.labelniveleducativo.Text = "Nivel Educativo:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.SystemColors.Info;
            this.labelFecha.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(548, 183);
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
            // textBoxOcupacion
            // 
            this.textBoxOcupacion.Location = new System.Drawing.Point(403, 197);
            this.textBoxOcupacion.Name = "textBoxOcupacion";
            this.textBoxOcupacion.Size = new System.Drawing.Size(109, 20);
            this.textBoxOcupacion.TabIndex = 13;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(403, 150);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(109, 20);
            this.textBoxDireccion.TabIndex = 14;
            // 
            // textBoxNivel_Educativo
            // 
            this.textBoxNivel_Educativo.Location = new System.Drawing.Point(403, 102);
            this.textBoxNivel_Educativo.Name = "textBoxNivel_Educativo";
            this.textBoxNivel_Educativo.Size = new System.Drawing.Size(109, 20);
            this.textBoxNivel_Educativo.TabIndex = 15;
            // 
            // textBoxEstado_Civil
            // 
            this.textBoxEstado_Civil.Location = new System.Drawing.Point(403, 60);
            this.textBoxEstado_Civil.Name = "textBoxEstado_Civil";
            this.textBoxEstado_Civil.Size = new System.Drawing.Size(109, 20);
            this.textBoxEstado_Civil.TabIndex = 16;
            // 
            // textBoxNacionalidad
            // 
            this.textBoxNacionalidad.Location = new System.Drawing.Point(403, 13);
            this.textBoxNacionalidad.Name = "textBoxNacionalidad";
            this.textBoxNacionalidad.Size = new System.Drawing.Size(109, 20);
            this.textBoxNacionalidad.TabIndex = 17;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(645, 102);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(107, 20);
            this.textBoxEdad.TabIndex = 19;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(645, 53);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(107, 20);
            this.textBoxCorreo.TabIndex = 20;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(645, 12);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(107, 20);
            this.textBoxTelefono.TabIndex = 21;
            // 
            // textBoxPrimerNombre
            // 
            this.textBoxPrimerNombre.Location = new System.Drawing.Point(139, 57);
            this.textBoxPrimerNombre.Name = "textBoxPrimerNombre";
            this.textBoxPrimerNombre.Size = new System.Drawing.Size(105, 20);
            this.textBoxPrimerNombre.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Primer_Nombre,
            this.Segundo_Nombre,
            this.Primer_Apellido,
            this.Segundo_Apellido,
            this.Telefono,
            this.Direccion,
            this.Ocupación,
            this.EstadoCivil,
            this.Correo,
            this.Fecha,
            this.Edad,
            this.Regimen,
            this.Nacionalidad,
            this.Estado_Civil,
            this.Nivel_Educativo});
            this.dataGridView1.Location = new System.Drawing.Point(26, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(886, 254);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Identificacion";
            this.ID.Name = "ID";
            this.ID.ToolTipText = "System.Int32";
            // 
            // Primer_Nombre
            // 
            this.Primer_Nombre.HeaderText = "Primer Nombre";
            this.Primer_Nombre.Name = "Primer_Nombre";
            // 
            // Segundo_Nombre
            // 
            this.Segundo_Nombre.HeaderText = "Segundo Nombre";
            this.Segundo_Nombre.Name = "Segundo_Nombre";
            // 
            // Primer_Apellido
            // 
            this.Primer_Apellido.HeaderText = "Primer Apellido";
            this.Primer_Apellido.Name = "Primer_Apellido";
            // 
            // Segundo_Apellido
            // 
            this.Segundo_Apellido.HeaderText = "Segundo Apellido";
            this.Segundo_Apellido.Name = "Segundo_Apellido";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Ocupación
            // 
            this.Ocupación.HeaderText = "Ocupacion";
            this.Ocupación.Name = "Ocupación";
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.HeaderText = "Estado Civil";
            this.EstadoCivil.Name = "EstadoCivil";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Regimen
            // 
            this.Regimen.HeaderText = "Regimen";
            this.Regimen.Name = "Regimen";
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            // 
            // Estado_Civil
            // 
            this.Estado_Civil.HeaderText = "Estado_Civil";
            this.Estado_Civil.Name = "Estado_Civil";
            // 
            // Nivel_Educativo
            // 
            this.Nivel_Educativo.HeaderText = "Nivel_Educativo";
            this.Nivel_Educativo.Name = "Nivel_Educativo";
            // 
            // fecha_Nacimiento
            // 
            this.fecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_Nacimiento.Location = new System.Drawing.Point(645, 194);
            this.fecha_Nacimiento.Name = "fecha_Nacimiento";
            this.fecha_Nacimiento.Size = new System.Drawing.Size(107, 20);
            this.fecha_Nacimiento.TabIndex = 24;
            // 
            // buttonfiltar
            // 
            this.buttonfiltar.Location = new System.Drawing.Point(818, 6);
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
            this.buttonsalir.Location = new System.Drawing.Point(975, 466);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(107, 28);
            this.buttonsalir.TabIndex = 30;
            this.buttonsalir.Text = "Salir";
            this.buttonsalir.UseVisualStyleBackColor = true;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(635, 9);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(161, 20);
            this.textBoxBusqueda.TabIndex = 31;
            this.textBoxBusqueda.TextChanged += new System.EventHandler(this.textBoxBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 104);
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
            this.label2.Location = new System.Drawing.Point(6, 200);
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
            this.label3.Location = new System.Drawing.Point(6, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Primer Apellido:";
            // 
            // textBoxSegundoApellido
            // 
            this.textBoxSegundoApellido.Location = new System.Drawing.Point(139, 197);
            this.textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            this.textBoxSegundoApellido.Size = new System.Drawing.Size(105, 20);
            this.textBoxSegundoApellido.TabIndex = 38;
            // 
            // textBoxPrimerApellido
            // 
            this.textBoxPrimerApellido.Location = new System.Drawing.Point(139, 150);
            this.textBoxPrimerApellido.Name = "textBoxPrimerApellido";
            this.textBoxPrimerApellido.Size = new System.Drawing.Size(105, 20);
            this.textBoxPrimerApellido.TabIndex = 39;
            // 
            // textBoxSegundoNombre
            // 
            this.textBoxSegundoNombre.Location = new System.Drawing.Point(139, 102);
            this.textBoxSegundoNombre.Name = "textBoxSegundoNombre";
            this.textBoxSegundoNombre.Size = new System.Drawing.Size(105, 20);
            this.textBoxSegundoNombre.TabIndex = 40;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sudsiado",
            "Contributivo"});
            this.comboBox1.Location = new System.Drawing.Point(645, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 42;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(78, 127);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 333);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttonActualizar);
            this.tabPage1.Controls.Add(this.lstPacientes);
            this.tabPage1.Controls.Add(this.labelNotificacion);
            this.tabPage1.Controls.Add(this.labelid);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.labelnombre);
            this.tabPage1.Controls.Add(this.textBoxSegundoNombre);
            this.tabPage1.Controls.Add(this.labeltelefono);
            this.tabPage1.Controls.Add(this.textBoxPrimerApellido);
            this.tabPage1.Controls.Add(this.labelcorreo);
            this.tabPage1.Controls.Add(this.textBoxSegundoApellido);
            this.tabPage1.Controls.Add(this.labelEdad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelRegimen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelnacionalidad);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelocupacion);
            this.tabPage1.Controls.Add(this.labeldireccion);
            this.tabPage1.Controls.Add(this.labelestado);
            this.tabPage1.Controls.Add(this.labelniveleducativo);
            this.tabPage1.Controls.Add(this.labelFecha);
            this.tabPage1.Controls.Add(this.buttonNuevo);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.buttonagregar);
            this.tabPage1.Controls.Add(this.textBoxOcupacion);
            this.tabPage1.Controls.Add(this.buttonEliminar);
            this.tabPage1.Controls.Add(this.textBoxDireccion);
            this.tabPage1.Controls.Add(this.textBoxNivel_Educativo);
            this.tabPage1.Controls.Add(this.fecha_Nacimiento);
            this.tabPage1.Controls.Add(this.textBoxEstado_Civil);
            this.tabPage1.Controls.Add(this.textBoxPrimerNombre);
            this.tabPage1.Controls.Add(this.textBoxNacionalidad);
            this.tabPage1.Controls.Add(this.textBoxTelefono);
            this.tabPage1.Controls.Add(this.textBoxCorreo);
            this.tabPage1.Controls.Add(this.textBoxEdad);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.buttonfiltar);
            this.tabPage2.Controls.Add(this.textBoxBusqueda);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista De Pacientes";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.label4.Location = new System.Drawing.Point(366, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 48);
            this.label4.TabIndex = 44;
            this.label4.Text = "Hospital San Fernando";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Image = global::Presentacion_GUI.Properties.Resources.clinica_hospital_san_fernando_logo_BBB34D347D_seeklogo_com;
            this.pictureBox2.Location = new System.Drawing.Point(900, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentacion_GUI.Properties.Resources.vector_JUL_2021_73;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(933, 307);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion_GUI.Properties.Resources.gabinete_hospital_ortodoncista_estomatologia_vacia_nadie;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1092, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion_GUI.Properties.Resources.vector_JUL_2021_73;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(933, 307);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // FormListadoGeneralcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 506);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormListadoGeneralcs";
            this.Text = "Gestión Pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListadoGeneralcs_FormClosing);
            this.Load += new System.EventHandler(this.FormListadoGeneralcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labeltelefono;
        private System.Windows.Forms.Label labelcorreo;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelRegimen;
        private System.Windows.Forms.Label labelnacionalidad;
        private System.Windows.Forms.Label labelocupacion;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.Label labelestado;
        private System.Windows.Forms.Label labelniveleducativo;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxOcupacion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNivel_Educativo;
        private System.Windows.Forms.TextBox textBoxEstado_Civil;
        private System.Windows.Forms.TextBox textBoxNacionalidad;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxPrimerNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segundo_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segundo_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocupación;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regimen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel_Educativo;
        private System.Windows.Forms.Label labelNotificacion;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}