using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;
using System.Data;
using System.Linq;

namespace Presentacion_GUI
{
    public partial class FormListadoGeneralcs : Form
    {
        //INSTANCIAS
        Paciente enlacePaciente = new Paciente();
        ServicioPaciente servicio = new ServicioPaciente();
        DataTable tabla = new DataTable();

        public FormListadoGeneralcs()
        {
            InitializeComponent();
        }

        #region FUNCIONES

        void CargarCiudades()
        {
            cmbCiudad.DataSource = servicio.ObtenerC();
            cmbCiudad.ValueMember = "id_cuidad";
            cmbCiudad.DisplayMember = "nombre";
        }
        void CargarTipoSangre()
        {
            cmbSangre.DataSource = servicio.ObtenerT();
            cmbSangre.ValueMember = "id_sangre";
            cmbSangre.DisplayMember = "nombre";
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

                textBoxId.Text = GrillaPacientes.Rows[num].Cells[0].Value.ToString();
                textBoxPrimerNombre.Text = GrillaPacientes.Rows[num].Cells[1].Value.ToString();
                textBoxSegundoNombre.Text = GrillaPacientes.Rows[num].Cells[2].Value.ToString();
                textBoxPrimerApellido.Text = GrillaPacientes.Rows[num].Cells[3].Value.ToString();
                textBoxSegundoApellido.Text = GrillaPacientes.Rows[num].Cells[4].Value.ToString();
                fecha_Nacimiento.Value = DateTime.Parse(GrillaPacientes.Rows[num].Cells[5].Value.ToString());
                textBoxTelefono.Text = GrillaPacientes.Rows[num].Cells[6].Value.ToString();
                textBoxCorreo.Text = GrillaPacientes.Rows[num].Cells[7].Value.ToString();
                txtRegimen.Text = GrillaPacientes.Rows[num].Cells[8].Value.ToString();
                textBoxEstado_Civil.Text = GrillaPacientes.Rows[num].Cells[9].Value.ToString();
                textBoxDireccion.Text = GrillaPacientes.Rows[num].Cells[10].Value.ToString();
                textBoxOcupacion.Text = GrillaPacientes.Rows[num].Cells[11].Value.ToString();
                textBoxNivel_Educativo.Text = GrillaPacientes.Rows[num].Cells[12].Value.ToString();
                cmbCiudad.Text = GrillaPacientes.Rows[num].Cells[13].Value.ToString();
                cmbSangre.Text = GrillaPacientes.Rows[num].Cells[14].Value.ToString();
                

                textBoxId.Enabled = false;
            }
        }
        void CargarLista()
        {
            lstPacientes.Items.Clear();
            for (int fila = 0; fila < GrillaPacientes.Rows.Count - 1; fila++)
            {
                lstPacientes.Items.Add(GrillaPacientes.Rows[fila].Cells[1].Value.ToString()+" "+ GrillaPacientes.Rows[fila].Cells[3].Value.ToString());
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
                servicio.Delete(int.Parse(textBoxId.Text));
                MessageBox.Show("Paciente " + textBoxPrimerNombre.Text + " " + textBoxPrimerApellido.Text + " ELIMINADO.");
                CargarDatos();
                CargarLista();
                Limpiar();
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
            Limpiar();
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

