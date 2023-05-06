using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        //==========================================================

        private void buttoninicio_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        void Ingresar()
        {
            if (textBoxusuario.Text == "Programador" && textBoxcontraseña.Text == "Modofestival")
            {
                this.Hide();
                var FRM = new FormListadoGeneralcs();
                FRM.ShowDialog(this);
            }
            else
            {
                labelconfirmar.Text = "ERROR, INTENTELO NUEVAMENTE";
                textBoxusuario.Clear();
                textBoxcontraseña.Clear();
            }
        }

        //==========================================================

        private void buttonsalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        void Cerrar()
        {
            this.Close();
        }

        //==========================================================
    }
}
