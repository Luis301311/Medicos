using System;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion_GUI
{
    public partial class FormListadoGeneralcs : Form
    {
        //INSTANCIAS
        Paciente enlacePaciente = new Paciente();
        ServicioPaciente servicio = new ServicioPaciente();
        ServicioTipoDeSangre ServicioTipoDeSangre= new ServicioTipoDeSangre();
        public FormListadoGeneralcs()
        {
            InitializeComponent();
        }

        #region FUNCIONES
        void CargarCiudades()
        {
            ServicioCiudades servicio = new ServicioCiudades();
            cmbCiudad.DataSource = servicio.GetAll();
            cmbCiudad.DisplayMember = "nombre";
            cmbCiudad.ValueMember = "Id_cuidad";
        }
        void CargarEps()
        {
            ServicioEPS servicio = new ServicioEPS();
            cmbEps.DataSource = servicio.GetAll();
            cmbEps.ValueMember = "Id";
            cmbEps.DisplayMember = "Nombre";
        }
        void CargarTipoSangre()
        {
            cmbSangre.DataSource = ServicioTipoDeSangre.GetAll();
            cmbSangre.ValueMember = "Id";
            cmbSangre.DisplayMember = "Nombre";
        }
        void closing(FormClosingEventArgs e)
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
        void DobleClick()
        {
            if (lstPacientes.SelectedIndex != -1)
            {
                int num = lstPacientes.SelectedIndex;
                var lista = servicio.GetAll();
                if (lista != null)
                {
                    textBoxId.Text = lista[num].Id.ToString();
                    textBoxPrimerNombre.Text = lista[num].PrimerNombre;
                    textBoxSegundoNombre.Text = lista[num].SegundoNombre;
                    textBoxPrimerApellido.Text = lista[num].PrimerApellido;
                    textBoxSegundoApellido.Text = lista[num].SegundoApellido;
                    fecha_Nacimiento.Value = lista[num].FechaNacimiento;
                    textBoxTelefono.Text = lista[num].Telefono;
                    textBoxCorreo.Text = lista[num].Correo;
                    textBoxDireccion.Text = lista[num].Direccion;
                    cmbCiudad.Text = lista[num].Nacionalidad;
                    cmbSangre.Text = lista[num].Tipo_Sangre;
                    cmbEps.Text = lista[num].Eps.ToString();

                    textBoxId.Enabled = false;
                }
            }
        }
        void CargarLista()
        {
            lstPacientes.Items.Clear();
            var lista = servicio.GetAll();

            if (lista != null)
            {
                foreach (var item in lista)
                {
                    lstPacientes.Items.Add(item.PrimerNombre + " " + item.PrimerApellido);
                }
            }
        }
        void Limpiar()
        {
            textBoxId.Enabled = true;
            textBoxId.Focus();
            textBoxId.Clear();
            fecha_Nacimiento.Value = DateTime.Today;

            textBoxPrimerNombre.Clear();
            textBoxSegundoNombre.Clear();
            textBoxPrimerApellido.Clear();
            textBoxSegundoApellido.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
            cmbSangre.Text = string.Empty;
            cmbCiudad.Text = string.Empty;
            cmbEps.Text = string.Empty;
            textBoxDireccion.Clear();
        }
        void Guardar()
        {

            if (CamposEstanCompletos(textBoxId, textBoxPrimerNombre, textBoxPrimerApellido, textBoxTelefono, textBoxCorreo,
                 textBoxDireccion) == false)
            {
                enlacePaciente.Id = textBoxId.Text;
                enlacePaciente.PrimerNombre = textBoxPrimerNombre.Text;
                enlacePaciente.SegundoNombre = textBoxSegundoNombre.Text;
                enlacePaciente.PrimerApellido = textBoxPrimerApellido.Text;
                enlacePaciente.SegundoApellido = textBoxSegundoApellido.Text;
                enlacePaciente.Tipo_Sangre = cmbSangre.SelectedValue.ToString();
                enlacePaciente.FechaNacimiento = fecha_Nacimiento.Value;
                enlacePaciente.Telefono = textBoxTelefono.Text;
                enlacePaciente.Direccion = textBoxDireccion.Text;
                enlacePaciente.Correo = textBoxCorreo.Text;
                enlacePaciente.Nacionalidad = cmbCiudad.SelectedValue.ToString();
                enlacePaciente.Eps = cmbEps.SelectedValue.ToString();

                if (servicio.Add(enlacePaciente) == true)
                {
                    MessageBox.Show("Paciente Agregado Exitosamente", "GUARDAR PACIENTE",
                                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Paciente Existente", "GUARDAR PACIENTE",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CAMPOS OBLIGATORIOS");
            }

        }
        public void CargarDatos()
        {
            
            var lista = servicio.GetAll();
            GrillaPacientes.Rows.Clear();
            foreach(var item in lista)
            {
                GrillaPacientes.Rows.Add(item.Id,item.PrimerNombre,item.SegundoNombre,item.PrimerApellido,item.SegundoApellido,
                                        item.FechaNacimiento,item.Telefono,item.Correo,item.Tipo_Sangre,item.Direccion,item.Nacionalidad,item.Eps);
            }
        }
        void Actualizar()
        {
            if(textBoxId.Text!="")
            {
                enlacePaciente.Id = textBoxId.Text;
                enlacePaciente.PrimerNombre = textBoxPrimerNombre.Text;
                enlacePaciente.SegundoNombre = textBoxSegundoNombre.Text;
                enlacePaciente.PrimerApellido = textBoxPrimerApellido.Text;
                enlacePaciente.SegundoApellido = textBoxSegundoApellido.Text;
                enlacePaciente.Tipo_Sangre = cmbSangre.SelectedValue.ToString();
                enlacePaciente.FechaNacimiento = fecha_Nacimiento.Value;
                enlacePaciente.Telefono = textBoxTelefono.Text;
                enlacePaciente.Direccion = textBoxDireccion.Text;
                enlacePaciente.Correo = textBoxCorreo.Text;
                enlacePaciente.Nacionalidad = cmbCiudad.SelectedValue.ToString();
                enlacePaciente.Eps = cmbEps.SelectedValue.ToString().ToString();

                var respuesta = MessageBox.Show("¿Desea Confirmar Los Cambios?", "ACTUALIZACION",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (servicio.Update(enlacePaciente) == true)
                    {
                        CargarLista();
                        CargarDatos();
                        MessageBox.Show("Paciente " + enlacePaciente.PrimerNombre + " Actualizado Correctamente", "ACTUALIZAR PACIENTE",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error Al Actualizar", "ACTUALIZACION",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Actualizacion Cancelada", "ACTUALIZACION",
                                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        void Eliminar()
        {
            if(textBoxId.Text!="")
            {
                var respuesta = MessageBox.Show("¿Desea Eliminar Al Paciente?", "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (servicio.Delete(textBoxId.Text)==true)
                    {
                        MessageBox.Show("Paciente ELIMINADO.", "ELIMINACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error Al Eliminar", "ELIMINACION",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Eliminacion Cancelada", "ELIMINACION",
                                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                CargarDatos();
                CargarLista();
            }
        }
        void buscarNombre()
        {
            if (textBoxBusqueda.Text != string.Empty)
            {
                var listaA = servicio.GetByName(textBoxBusqueda.Text);
                GrillaPacientes.Rows.Clear();
                foreach (var item in listaA)
                {
                    GrillaPacientes.Rows.Add(item.Id, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido,
                                            item.FechaNacimiento, item.Telefono, item.Correo, item.Tipo_Sangre, item.Direccion,
                                            item.Nacionalidad);
                }
            }
            textBoxBusqueda.Enabled = false;
            buttonfiltar.Enabled = false;
        }
        private bool CamposEstanCompletos(params TextBox[] controles)
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
        #endregion

        #region ACCIONES
        void buttonagregar_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarDatos();
            CargarLista();
            Limpiar();
        }
        private void FormListadoGeneralcs_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarLista();
            CargarCiudades();
            CargarTipoSangre();
            CargarEps();
            Limpiar();
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void buttonsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lstPacientes_DoubleClick(object sender, EventArgs e)
        {
            DobleClick();
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void FormListadoGeneralcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing(e);
        }
        private void buttonfiltar_Click(object sender, EventArgs e)
        {
            buscarNombre();
        }
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            CargarDatos();
            buttonfiltar.Enabled = true;
            textBoxBusqueda.Enabled = true;
            textBoxBusqueda.Clear();
        }

        #endregion
    }
}

