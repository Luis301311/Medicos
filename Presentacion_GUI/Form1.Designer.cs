namespace Presentacion_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttoninicio = new System.Windows.Forms.Button();
            this.labelacceso = new System.Windows.Forms.Label();
            this.labelusuario = new System.Windows.Forms.Label();
            this.labelpassaword = new System.Windows.Forms.Label();
            this.buttonsalir = new System.Windows.Forms.Button();
            this.textBoxusuario = new System.Windows.Forms.TextBox();
            this.textBoxcontraseña = new System.Windows.Forms.TextBox();
            this.labelconfirmar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoninicio
            // 
            this.buttoninicio.Location = new System.Drawing.Point(10, 217);
            this.buttoninicio.Name = "buttoninicio";
            this.buttoninicio.Size = new System.Drawing.Size(103, 23);
            this.buttoninicio.TabIndex = 0;
            this.buttoninicio.Text = "INICIAR SESIÓN";
            this.buttoninicio.UseVisualStyleBackColor = true;
            this.buttoninicio.Click += new System.EventHandler(this.buttoninicio_Click);
            // 
            // labelacceso
            // 
            this.labelacceso.AutoSize = true;
            this.labelacceso.Location = new System.Drawing.Point(72, 24);
            this.labelacceso.Name = "labelacceso";
            this.labelacceso.Size = new System.Drawing.Size(128, 13);
            this.labelacceso.TabIndex = 1;
            this.labelacceso.Text = "ACESSO RESTRINGIDO";
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.Location = new System.Drawing.Point(21, 75);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(59, 13);
            this.labelusuario.TabIndex = 2;
            this.labelusuario.Text = "USUARIO:";
            // 
            // labelpassaword
            // 
            this.labelpassaword.AutoSize = true;
            this.labelpassaword.Location = new System.Drawing.Point(21, 137);
            this.labelpassaword.Name = "labelpassaword";
            this.labelpassaword.Size = new System.Drawing.Size(84, 13);
            this.labelpassaword.TabIndex = 3;
            this.labelpassaword.Text = "CONTRASEÑA:";
            // 
            // buttonsalir
            // 
            this.buttonsalir.Location = new System.Drawing.Point(87, 309);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(103, 23);
            this.buttonsalir.TabIndex = 4;
            this.buttonsalir.Text = "SALIR";
            this.buttonsalir.UseVisualStyleBackColor = true;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // textBoxusuario
            // 
            this.textBoxusuario.Location = new System.Drawing.Point(116, 72);
            this.textBoxusuario.Name = "textBoxusuario";
            this.textBoxusuario.Size = new System.Drawing.Size(126, 20);
            this.textBoxusuario.TabIndex = 5;
            // 
            // textBoxcontraseña
            // 
            this.textBoxcontraseña.Location = new System.Drawing.Point(116, 130);
            this.textBoxcontraseña.Name = "textBoxcontraseña";
            this.textBoxcontraseña.Size = new System.Drawing.Size(126, 20);
            this.textBoxcontraseña.TabIndex = 6;
            // 
            // labelconfirmar
            // 
            this.labelconfirmar.AutoSize = true;
            this.labelconfirmar.Location = new System.Drawing.Point(113, 227);
            this.labelconfirmar.Name = "labelconfirmar";
            this.labelconfirmar.Size = new System.Drawing.Size(0, 13);
            this.labelconfirmar.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "REGISTRARSE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelconfirmar);
            this.Controls.Add(this.textBoxcontraseña);
            this.Controls.Add(this.textBoxusuario);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.labelpassaword);
            this.Controls.Add(this.labelusuario);
            this.Controls.Add(this.labelacceso);
            this.Controls.Add(this.buttoninicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoninicio;
        private System.Windows.Forms.Label labelacceso;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.Label labelpassaword;
        private System.Windows.Forms.Button buttonsalir;
        private System.Windows.Forms.TextBox textBoxusuario;
        private System.Windows.Forms.TextBox textBoxcontraseña;
        private System.Windows.Forms.Label labelconfirmar;
        private System.Windows.Forms.Button button1;
    }
}

