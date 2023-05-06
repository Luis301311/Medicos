using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Presentacion_GUI
{
    public partial class FrmMedico : Form
    {
        Medico enlaceMedico = new Medico();
        ServicioMedico servicio = new ServicioMedico();

        public FrmMedico()
        {
            InitializeComponent();
        }

        void Nuevo()
        {
            textBoxId.Enabled = true;
            textBoxId.Focus();

            textBoxId.Clear();
            textBoxPrimerNombre.Clear();
            textBoxSegundoNombre.Clear();
            textBoxPrimerApellido.Clear();
            textBoxSegundoApellido.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
            textBoxEdad.Clear();
            textBoxEspecialidad.Clear();
            textBoxExperiencia.Clear();
            labelNotificacion.Text = "";
        }
        bool CamposEstanCompletos(params TextBox[] controles)
        {
            foreach (var control in controles)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    return true;
                }
            }
            return false;
        }
        void Agregar()
        {
            if (CamposEstanCompletos(textBoxId, textBoxPrimerNombre, textBoxPrimerApellido, textBoxTelefono, textBoxCorreo, textBoxEdad, textBoxEspecialidad, textBoxExperiencia) == false)
            {
                enlaceMedico.Id = int.Parse(textBoxId.Text);
                enlaceMedico.PrimerNombre = textBoxPrimerNombre.Text;
                enlaceMedico.SegundoNombre = textBoxSegundoNombre.Text;
                enlaceMedico.PrimerApellido = textBoxPrimerApellido.Text;
                enlaceMedico.SegundoApellido = textBoxSegundoApellido.Text;
                enlaceMedico.Edad = int.Parse(textBoxEdad.Text);
                enlaceMedico.Telefono = textBoxTelefono.Text;
                enlaceMedico.Correo = textBoxCorreo.Text;
                enlaceMedico.Especialidad = textBoxEspecialidad.Text;
                enlaceMedico.AniosExperiencia = int.Parse(textBoxExperiencia.Text);

                if (servicio.Add(enlaceMedico) == true)
                {
                    labelNotificacion.Text = "AÑADIDO CORRECTAMENTE";
                    labelNotificacion.ForeColor = Color.Blue;
                }
                else
                {
                    labelNotificacion.Text = "ERROR, INTENTE NUEVAMENTE";
                    labelNotificacion.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("CAMPOS OBLIGATORIOS");
            }
        }
        
        void Salir()
        {
            Owner.Show();
            Close();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
           Nuevo();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void FrmMedico_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
