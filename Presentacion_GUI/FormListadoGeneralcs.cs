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
            cmbCiudad.DataSource = servicio.ObtenerC();
            cmbCiudad.DisplayMember = "nombre";
            cmbCiudad.ValueMember = "id_cuidad";
        }
        void CargarTipoSangre()
        {
            cmbSangre.DataSource = ServicioTipoDeSangre.GetByAll();
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
                var lista = servicio.GetByAll();
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
                    txtRegimen.Text = lista[num].Regimen;
                    textBoxEstado_Civil.Text = lista[num].EstadoCivil;
                    textBoxDireccion.Text = lista[num].Direccion;
                    textBoxOcupacion.Text = lista[num].Ocupacion;
                    textBoxNivel_Educativo.Text = lista[num].NivelEducativo;
                    cmbCiudad.Text = lista[num].Nacionalidad;
                    cmbSangre.Text = lista[num].Tipo_Sangre;

                    textBoxId.Enabled = false;
                }
            }
        }
        void CargarLista()
        {
            lstPacientes.Items.Clear();
            var lista = servicio.GetByAll();
            if (lista != null)
            {
                foreach (var item in lista) 
                {
                    lstPacientes.Items.Add(item.PrimerNombre+" "+item.PrimerApellido);
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
        txtRegimen.Clear();
        textBoxEstado_Civil.Clear();
        textBoxNivel_Educativo.Clear();
        textBoxDireccion.Clear();
        textBoxOcupacion.Clear();
        }
        async void Guardar()
        {

            if (CamposEstanCompletos(textBoxId, textBoxPrimerNombre, textBoxPrimerApellido, textBoxTelefono, textBoxCorreo,
                txtRegimen, textBoxEstado_Civil, textBoxNivel_Educativo, textBoxDireccion, textBoxOcupacion) == false)
            {
                enlacePaciente.Id = int.Parse(textBoxId.Text);
                enlacePaciente.PrimerNombre = textBoxPrimerNombre.Text;
                enlacePaciente.SegundoNombre = textBoxSegundoNombre.Text;
                enlacePaciente.PrimerApellido = textBoxPrimerApellido.Text;
                enlacePaciente.SegundoApellido = textBoxSegundoApellido.Text;
                enlacePaciente.Tipo_Sangre = cmbSangre.Text;
                enlacePaciente.FechaNacimiento = fecha_Nacimiento.Value;
                enlacePaciente.Telefono = textBoxTelefono.Text;
                enlacePaciente.Direccion = textBoxDireccion.Text;
                enlacePaciente.Ocupacion = textBoxOcupacion.Text;
                enlacePaciente.Correo = textBoxCorreo.Text;
                enlacePaciente.Regimen = txtRegimen.Text;
                enlacePaciente.Nacionalidad = cmbCiudad.Text;
                enlacePaciente.EstadoCivil = textBoxEstado_Civil.Text;
                enlacePaciente.NivelEducativo = textBoxNivel_Educativo.Text;

                MessageBox.Show(enlacePaciente.Nacionalidad + " " + enlacePaciente.Tipo_Sangre);
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
            ServicioPaciente servicio = new ServicioPaciente();
            GrillaPacientes.DataSource = servicio.TablaPacientes();
        }
        void Actualizar()
        {
            if(textBoxId.Text!="")
            {
                enlacePaciente.Id = int.Parse(textBoxId.Text);
                enlacePaciente.PrimerNombre = textBoxPrimerNombre.Text;
                enlacePaciente.SegundoNombre = textBoxSegundoNombre.Text;
                enlacePaciente.PrimerApellido = textBoxPrimerApellido.Text;
                enlacePaciente.SegundoApellido = textBoxSegundoApellido.Text;
                enlacePaciente.Tipo_Sangre = cmbSangre.Text;
                enlacePaciente.FechaNacimiento = fecha_Nacimiento.Value;
                enlacePaciente.Telefono = textBoxTelefono.Text;
                enlacePaciente.Direccion = textBoxDireccion.Text;
                enlacePaciente.Ocupacion = textBoxOcupacion.Text;
                enlacePaciente.Correo = textBoxCorreo.Text;
                enlacePaciente.Regimen = txtRegimen.Text;
                enlacePaciente.Nacionalidad = cmbCiudad.Text;
                enlacePaciente.EstadoCivil = textBoxEstado_Civil.Text;
                enlacePaciente.NivelEducativo = textBoxNivel_Educativo.Text;

                var respuesta = MessageBox.Show("¿Desea Confirmar Los Cambios?", "ACTUALIZACION",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (servicio.Update(enlacePaciente) == true)
                    {
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
                    if (servicio.Delete(int.Parse(textBoxId.Text)))
                    {
                        MessageBox.Show("Paciente " + textBoxPrimerNombre.Text + " " + textBoxPrimerApellido.Text + " ELIMINADO.", "ELIMINACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void buscarCedula()
        {
            GrillaPacientes.DataSource = servicio.GetByName(textBoxBusqueda.Text);
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
            CargarDatos();
            CargarLista();
        }
        private void FormListadoGeneralcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing(e);
        }
        private void buttonfiltar_Click(object sender, EventArgs e)
        {
            buscarCedula();
        }
        #endregion
    }
}

