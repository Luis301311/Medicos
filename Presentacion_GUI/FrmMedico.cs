using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Logica;
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

        #region Funciones
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
            dtpGraduacion.Value = DateTime.Today;
            dtpNacimiento.Value = DateTime.Today;
            cmbCiudad.Text = "";
            cmbEspecialidad.Text = "";

            labelNotificacion.Text = string.Empty;
        }
        void CargarCiudades()
        {
            ServicioCiudades servicio = new ServicioCiudades();
            cmbCiudad.DataSource = servicio.GetAll();
            cmbCiudad.DisplayMember = "nombre";
            cmbCiudad.ValueMember = "Id_cuidad";
        }
        void CargarEspecialidades()
        {
            ServicioEspecialidad servicio = new ServicioEspecialidad();
            cmbEspecialidad.DataSource = servicio.GetAll();
            cmbEspecialidad.DisplayMember = "nombre";
            cmbEspecialidad.ValueMember = "Id";
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
            if (CamposEstanCompletos(textBoxId, textBoxPrimerNombre, textBoxPrimerApellido, textBoxTelefono, textBoxCorreo) == false)
            {
                enlaceMedico.Id = textBoxId.Text;
                enlaceMedico.PrimerNombre = textBoxPrimerNombre.Text;
                enlaceMedico.SegundoNombre = textBoxSegundoNombre.Text;
                enlaceMedico.PrimerApellido = textBoxPrimerApellido.Text;
                enlaceMedico.SegundoApellido = textBoxSegundoApellido.Text;
                enlaceMedico.Telefono = textBoxTelefono.Text;
                enlaceMedico.Correo = textBoxCorreo.Text;
                enlaceMedico.Especialidad = cmbEspecialidad.SelectedValue.ToString();
                enlaceMedico.FechaGraduado = dtpGraduacion.Value;
                enlaceMedico.Nacionalidad = cmbCiudad.SelectedValue.ToString();
                enlaceMedico.FechaNacimiento = dtpNacimiento.Value;

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
            var lista = servicio.GetAll();
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
                enlaceMedico.Id = textBoxId.Text;
                enlaceMedico.PrimerNombre = textBoxPrimerNombre.Text;
                enlaceMedico.SegundoNombre = textBoxSegundoNombre.Text;
                enlaceMedico.PrimerApellido = textBoxPrimerApellido.Text;
                enlaceMedico.SegundoApellido = textBoxSegundoApellido.Text;
                enlaceMedico.FechaNacimiento = dtpNacimiento.Value;
                enlaceMedico.Telefono = textBoxTelefono.Text;
                enlaceMedico.Correo = textBoxCorreo.Text;
                enlaceMedico.FechaGraduado = dtpGraduacion.Value;
                enlaceMedico.Nacionalidad = cmbCiudad.SelectedValue.ToString();
                enlaceMedico.Especialidad = cmbEspecialidad.SelectedValue.ToString();

                var respuesta = MessageBox.Show("¿Desea Actualizar Al Medico " + textBoxPrimerNombre.Text + "?", "ACTUALIZACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (servicio.Update(enlaceMedico) == true)
                    {
                        CargarGrilla();
                        CargarLista();
                        MessageBox.Show("Medico " + enlaceMedico.PrimerNombre + " Actualizado exitosamente.","ACTUALIZACION");
                    }
                    else
                    {
                        MessageBox.Show("Error Al Actualizar", "ACTUALIZACION");
                    }
                }
                else
                {
                    MessageBox.Show("ACTUALIZACION CANCELADA", "ACTUALIZACION");
                }                
            }
        }
        int ObtenerAño(DateTime fecha)
        {
            int años = (DateTime.Now.Year - fecha.Year);
            return años;
        }
        void CargarGrilla()
        {
            GrillaMed.Rows.Clear();
            var lista = servicio.GetAll();
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    GrillaMed.Rows.Add(item.Id,
                                       item.PrimerNombre,
                                       item.SegundoNombre,
                                       item.PrimerApellido,
                                       item.SegundoApellido,
                                       ObtenerAño(item.FechaNacimiento),
                                       item.Telefono,
                                       item.Correo,
                                       item.Especialidad,
                                       ObtenerAño(item.FechaGraduado),
                                       item.Nacionalidad);                      
                }
            }
        }
        void Eliminar()
        {
            if(textBoxId.Text != null)
            {
                var respuesta = MessageBox.Show("¿Desea Eliminar Al Medico " + textBoxPrimerNombre.Text + "?", "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    if(servicio.Delete(textBoxId.Text)==true)
                    {
                        CargarGrilla();
                        CargarLista();
                        MessageBox.Show("Medico Eliminado Satisfcatoriamente","ELIMINACION");
                    }
                    else
                    {
                        MessageBox.Show("Error Al Eliminar","ELIMINACION");
                    }
                }
                else
                {
                    MessageBox.Show("ELIMINACION CANCELADA","ELIMINACION");
                }
                
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
                                           ObtenerAño(item.FechaNacimiento),
                                           item.Telefono,
                                           item.Correo,
                                           item.Especialidad,
                                           ObtenerAño(item.FechaGraduado),
                                           item.Nacionalidad);
                    }
                    buttonFiltar.Enabled = false;
                    TxtFiltrar.Enabled = false;
                }
            }
        }
        #endregion

        #region Botones
        private void FrmMedico_Load(object sender, EventArgs e)
        {
            CargarLista();
            CargarGrilla();
            CargarCiudades();
            CargarEspecialidades();
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
            var lista = servicio.GetAll();
            int index = lstMedicos.SelectedIndex;

            if (index > -1)
            {
                textBoxId.Text = lista[index].Id.ToString();
                textBoxId.Enabled = false;

                textBoxPrimerNombre.Text = lista[index].PrimerNombre;
                textBoxSegundoNombre.Text = lista[index].SegundoNombre;
                textBoxPrimerApellido.Text = lista[index].PrimerApellido;
                textBoxSegundoApellido.Text = lista[index].SegundoApellido;
                textBoxCorreo.Text = lista[index].Correo;
                cmbEspecialidad.Text = lista[index].Especialidad;
                cmbCiudad.Text = lista[index].Nacionalidad;
                textBoxTelefono.Text = lista[index].Telefono;
                dtpGraduacion.Value = lista[index].FechaGraduado;
                dtpNacimiento.Value = lista[index].FechaNacimiento;
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

        #endregion

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            buttonFiltar.Enabled = true;
            TxtFiltrar.Enabled = true;
            TxtFiltrar.Clear();
            TxtFiltrar.Focus();
        }
    }
}
