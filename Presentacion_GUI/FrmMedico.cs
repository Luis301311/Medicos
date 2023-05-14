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
            CargarLista();
            CargarGrilla();
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
     
            Close();
        }

        void CargarLista()
        {
            lstMedicos.Items.Clear();
            var lista = servicio.GetByAll();
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    lstMedicos.Items.Add(item.PrimerNombre + " " + item.PrimerApellido);
                }
            }
        }

        void Actualizar()
        {
            if(textBoxId.Text != "")
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

                servicio.Update(enlaceMedico);

                MessageBox.Show("Medico " + enlaceMedico.PrimerNombre + " Actualizado exitosamente.");
            }
        }

        void CargarGrilla()
        {
            GrillaMed.Rows.Clear();
            var lista = servicio.GetByAll();
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    GrillaMed.Rows.Add(item.Id,
                                       item.PrimerNombre,
                                       item.SegundoNombre,
                                       item.PrimerApellido,
                                       item.SegundoApellido,
                                       item.Edad,
                                       item.Telefono,
                                       item.Correo,
                                       item.Especialidad,
                                       item.AniosExperiencia);
                }
            }
        }

        void Eliminar()
        {
            if(textBoxId.Text != null)
            {
                servicio.Delete(int.Parse(textBoxId.Text));
            }
        }

        void Filtrar()
        {
            if(TxtFiltrar.Text!=null)
            {
                var lista = servicio.GetByName(TxtFiltrar.Text);
                if (lista != null)
                {
                    GrillaMed.Rows.Clear();
                    foreach (var item in lista)
                    {
                        GrillaMed.Rows.Add(item.Id,
                                           item.PrimerNombre,
                                           item.SegundoNombre,
                                           item.PrimerApellido,
                                           item.SegundoApellido,
                                           item.Edad,
                                           item.Telefono,
                                           item.Correo,
                                           item.Especialidad,
                                           item.AniosExperiencia);
                    }
                }
            }
        }









        private void buttonNuevo_Click(object sender, EventArgs e)
        {
           Nuevo();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            CargarLista();
            CargarGrilla();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void FrmMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea Salir?", "Agenda de contactos",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Owner.Show();
                Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void lstMedicos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var lista = servicio.GetByAll();
            int index = lstMedicos.SelectedIndex;

            if (index > -1)
            {
                textBoxId.Text = lista[index].Id.ToString();
                textBoxId.Enabled = false;

                textBoxPrimerNombre.Text = lista[index].PrimerNombre;
                textBoxSegundoNombre.Text = lista[index].SegundoNombre;
                textBoxPrimerApellido.Text = lista[index].PrimerApellido;
                textBoxSegundoApellido.Text = lista[index].SegundoApellido;
                textBoxEdad.Text = lista[index].Edad.ToString();
                textBoxCorreo.Text = lista[index].Correo;
                textBoxEspecialidad.Text = lista[index].Especialidad;
                textBoxExperiencia.Text = lista[index].AniosExperiencia.ToString();
                textBoxTelefono.Text = lista[index].Telefono;
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            CargarLista();
            CargarGrilla();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarGrilla();
            CargarLista();
        }

        private void buttonFiltar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
