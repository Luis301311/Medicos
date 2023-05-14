namespace Presentacion_GUI
{
    partial class FrmMedico
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelNotificacion = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxExperiencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxEspecialidad = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.textBoxSegundoNombre = new System.Windows.Forms.TextBox();
            this.textBoxPrimerApellido = new System.Windows.Forms.TextBox();
            this.textBoxSegundoApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPrimerNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GrillaMed = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNomber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Años = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonFiltar = new System.Windows.Forms.Button();
            this.TxtFiltrar = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 337);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelNotificacion);
            this.tabPage1.Controls.Add(this.buttonActualizar);
            this.tabPage1.Controls.Add(this.buttonNuevo);
            this.tabPage1.Controls.Add(this.buttonAgregar);
            this.tabPage1.Controls.Add(this.buttonEliminar);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.lstMedicos);
            this.tabPage1.Controls.Add(this.textBoxTelefono);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxCorreo);
            this.tabPage1.Controls.Add(this.textBoxExperiencia);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBoxEdad);
            this.tabPage1.Controls.Add(this.textBoxEspecialidad);
            this.tabPage1.Controls.Add(this.labelid);
            this.tabPage1.Controls.Add(this.labelnombre);
            this.tabPage1.Controls.Add(this.textBoxSegundoNombre);
            this.tabPage1.Controls.Add(this.textBoxPrimerApellido);
            this.tabPage1.Controls.Add(this.textBoxSegundoApellido);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.textBoxPrimerNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelNotificacion
            // 
            this.labelNotificacion.AutoSize = true;
            this.labelNotificacion.Location = new System.Drawing.Point(517, 274);
            this.labelNotificacion.Name = "labelNotificacion";
            this.labelNotificacion.Size = new System.Drawing.Size(0, 13);
            this.labelNotificacion.TabIndex = 110;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(258, 264);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(96, 29);
            this.buttonActualizar.TabIndex = 109;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Location = new System.Drawing.Point(10, 265);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(73, 29);
            this.buttonNuevo.TabIndex = 108;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(131, 264);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(78, 29);
            this.buttonAgregar.TabIndex = 107;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(395, 264);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(83, 29);
            this.buttonEliminar.TabIndex = 106;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Info;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(670, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 105;
            this.label11.Text = "Medicos:";
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.Location = new System.Drawing.Point(638, 38);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(137, 225);
            this.lstMedicos.TabIndex = 104;
            this.lstMedicos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMedicos_MouseDoubleClick);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(454, 59);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(105, 20);
            this.textBoxTelefono.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(337, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 102;
            this.label8.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Info;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(336, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 101;
            this.label10.Text = "Experiencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 93;
            this.label5.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 94;
            this.label6.Text = "Especialidad:";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(454, 104);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(105, 20);
            this.textBoxCorreo.TabIndex = 100;
            // 
            // textBoxExperiencia
            // 
            this.textBoxExperiencia.Location = new System.Drawing.Point(454, 197);
            this.textBoxExperiencia.Name = "textBoxExperiencia";
            this.textBoxExperiencia.Size = new System.Drawing.Size(105, 20);
            this.textBoxExperiencia.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 98;
            this.label7.Text = "Años De";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(336, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 97;
            this.label9.Text = "Correo:";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(454, 15);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(107, 20);
            this.textBoxEdad.TabIndex = 95;
            // 
            // textBoxEspecialidad
            // 
            this.textBoxEspecialidad.Location = new System.Drawing.Point(454, 152);
            this.textBoxEspecialidad.Name = "textBoxEspecialidad";
            this.textBoxEspecialidad.Size = new System.Drawing.Size(105, 20);
            this.textBoxEspecialidad.TabIndex = 96;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.SystemColors.Info;
            this.labelid.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(17, 20);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(105, 15);
            this.labelid.TabIndex = 83;
            this.labelid.Text = "Identificacion:";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.BackColor = System.Drawing.SystemColors.Info;
            this.labelnombre.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(17, 64);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(112, 15);
            this.labelnombre.TabIndex = 84;
            this.labelnombre.Text = "Primer Nombre:";
            // 
            // textBoxSegundoNombre
            // 
            this.textBoxSegundoNombre.Location = new System.Drawing.Point(158, 104);
            this.textBoxSegundoNombre.Name = "textBoxSegundoNombre";
            this.textBoxSegundoNombre.Size = new System.Drawing.Size(105, 20);
            this.textBoxSegundoNombre.TabIndex = 92;
            // 
            // textBoxPrimerApellido
            // 
            this.textBoxPrimerApellido.Location = new System.Drawing.Point(158, 152);
            this.textBoxPrimerApellido.Name = "textBoxPrimerApellido";
            this.textBoxPrimerApellido.Size = new System.Drawing.Size(105, 20);
            this.textBoxPrimerApellido.TabIndex = 91;
            // 
            // textBoxSegundoApellido
            // 
            this.textBoxSegundoApellido.Location = new System.Drawing.Point(158, 199);
            this.textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            this.textBoxSegundoApellido.Size = new System.Drawing.Size(105, 20);
            this.textBoxSegundoApellido.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Primer Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 88;
            this.label2.Text = "Segundo Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 87;
            this.label1.Text = "Segundo Nombre:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(158, 15);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(107, 20);
            this.textBoxId.TabIndex = 85;
            // 
            // textBoxPrimerNombre
            // 
            this.textBoxPrimerNombre.Location = new System.Drawing.Point(158, 59);
            this.textBoxPrimerNombre.Name = "textBoxPrimerNombre";
            this.textBoxPrimerNombre.Size = new System.Drawing.Size(105, 20);
            this.textBoxPrimerNombre.TabIndex = 86;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtFiltrar);
            this.tabPage2.Controls.Add(this.buttonFiltar);
            this.tabPage2.Controls.Add(this.GrillaMed);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado De Medicos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GrillaMed
            // 
            this.GrillaMed.AllowUserToOrderColumns = true;
            this.GrillaMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PNomber,
            this.SNombre,
            this.PApellido,
            this.SApellido,
            this.Edad,
            this.Tel,
            this.Corr,
            this.Especialidad,
            this.Años});
            this.GrillaMed.Location = new System.Drawing.Point(19, 56);
            this.GrillaMed.Name = "GrillaMed";
            this.GrillaMed.Size = new System.Drawing.Size(785, 255);
            this.GrillaMed.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Identificación";
            this.Id.Name = "Id";
            // 
            // PNomber
            // 
            this.PNomber.HeaderText = "Primer Nombre";
            this.PNomber.Name = "PNomber";
            // 
            // SNombre
            // 
            this.SNombre.HeaderText = "Segundo Nombre";
            this.SNombre.Name = "SNombre";
            // 
            // PApellido
            // 
            this.PApellido.HeaderText = "Primer Apellido";
            this.PApellido.Name = "PApellido";
            // 
            // SApellido
            // 
            this.SApellido.HeaderText = "Segundo Apellido";
            this.SApellido.Name = "SApellido";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Telefono";
            this.Tel.Name = "Tel";
            // 
            // Corr
            // 
            this.Corr.HeaderText = "Correo";
            this.Corr.Name = "Corr";
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // Años
            // 
            this.Años.HeaderText = "Años De Experiencia";
            this.Años.Name = "Años";
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
            this.label4.Location = new System.Drawing.Point(282, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 48);
            this.label4.TabIndex = 45;
            this.label4.Text = "Hospital San Fernando";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(776, 416);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(83, 29);
            this.buttonSalir.TabIndex = 107;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonFiltar
            // 
            this.buttonFiltar.Location = new System.Drawing.Point(729, 15);
            this.buttonFiltar.Name = "buttonFiltar";
            this.buttonFiltar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltar.TabIndex = 27;
            this.buttonFiltar.Text = "Filtrar";
            this.buttonFiltar.UseVisualStyleBackColor = true;
            this.buttonFiltar.Click += new System.EventHandler(this.buttonFiltar_Click);
            // 
            // TxtFiltrar
            // 
            this.TxtFiltrar.Location = new System.Drawing.Point(574, 17);
            this.TxtFiltrar.Name = "TxtFiltrar";
            this.TxtFiltrar.Size = new System.Drawing.Size(131, 20);
            this.TxtFiltrar.TabIndex = 28;
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 451);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMedico";
            this.Text = "Gestión Medicos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMedico_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxExperiencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxEspecialidad;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.TextBox textBoxSegundoNombre;
        private System.Windows.Forms.TextBox textBoxPrimerApellido;
        private System.Windows.Forms.TextBox textBoxSegundoApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPrimerNombre;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridView GrillaMed;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelNotificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNomber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Años;
        private System.Windows.Forms.TextBox TxtFiltrar;
        private System.Windows.Forms.Button buttonFiltar;
    }
}