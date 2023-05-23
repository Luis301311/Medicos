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

        //FUNCIONES
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
        void dobleClick()
        {
            if (lstPacientes.SelectedIndex != -1)
            {
                int num = lstPacientes.SelectedIndex;

                textBoxId.Text = GrillaPacientes.Rows[num].Cells[0].Value.ToString();
                textBoxPrimerNombre.Text = GrillaPacientes.Rows[num].Cells[1].Value.ToString();
                textBoxSegundoNombre.Text = GrillaPacientes.Rows[num].Cells[2].Value.ToString();
                textBoxPrimerApellido.Text = GrillaPacientes.Rows[num].Cells[3].Value.ToString();
                textBoxSegundoApellido.Text = GrillaPacientes.Rows[num].Cells[4].Value.ToString();
                textBoxCorreo.Text = GrillaPacientes.Rows[num].Cells[8].Value.ToString();
                textBoxEstado_Civil.Text = GrillaPacientes.Rows[num].Cells[13].Value.ToString();
                textBoxDireccion.Text = GrillaPacientes.Rows[num].Cells[10].Value.ToString();
                textBoxNacionalidad.Text = GrillaPacientes.Rows[num].Cells[13].Value.ToString();
                textBoxNivel_Educativo.Text = GrillaPacientes.Rows[num].Cells[12].Value.ToString();
                textBoxOcupacion.Text = GrillaPacientes.Rows[num].Cells[11].Value.ToString();
                comboBox1.Text = GrillaPacientes.Rows[num].Cells[9].Value.ToString();
                //fecha_Nacimiento.Value = DateTime.Parse(GrillaPacientes.Rows[num].Cells[6].Value.ToString());
                textBoxSangre.Text = GrillaPacientes.Rows[num].Cells[14].Value.ToString();
                textBoxTelefono.Text = GrillaPacientes.Rows[num].Cells[7].Value.ToString();

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
        private void Limpiar()
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
            textBoxSangre.Clear();
            comboBox1.Text = string.Empty;
            textBoxNacionalidad.Clear();
            textBoxEstado_Civil.Clear();
            textBoxNivel_Educativo.Clear();
            textBoxDireccion.Clear();
            textBoxOcupacion.Clear();

        }
        private void buttonagregar_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarDatos();
            CargarLista();
            Limpiar();
        }
        private async void Guardar()
        {

            if (CamposEstanCompletos(textBoxId, textBoxPrimerNombre, textBoxPrimerApellido, textBoxTelefono, textBoxCorreo, textBoxSangre,
                textBoxNacionalidad, textBoxEstado_Civil, textBoxNivel_Educativo, textBoxDireccion, textBoxOcupacion) == false)
            {
                enlacePaciente.Id = int.Parse(textBoxId.Text);
                enlacePaciente.PrimerNombre = textBoxPrimerNombre.Text;
                enlacePaciente.SegundoNombre = textBoxSegundoNombre.Text;
                enlacePaciente.PrimerApellido = textBoxPrimerApellido.Text;
                enlacePaciente.SegundoApellido = textBoxSegundoApellido.Text;
                enlacePaciente.Tipo_Sangre = textBoxSangre.Text;
                enlacePaciente.FechaNacimiento = fecha_Nacimiento.Value;
                enlacePaciente.Telefono = textBoxTelefono.Text;
                enlacePaciente.Direccion = textBoxDireccion.Text;
                enlacePaciente.Ocupacion = textBoxOcupacion.Text;
                enlacePaciente.Correo = textBoxCorreo.Text;
                enlacePaciente.Regimen = comboBox1.Text;
                enlacePaciente.Nacionalidad = textBoxNacionalidad.Text;
                enlacePaciente.EstadoCivil = textBoxEstado_Civil.Text;
                enlacePaciente.NivelEducativo = textBoxNivel_Educativo.Text;


                if (servicio.Add(enlacePaciente) == true)
                {
                    labelNotificacion.Text = "AÑADIDO CORRECTAMENTE";
                    labelNotificacion.ForeColor = Color.Blue;
                    await Task.Delay(5000);
                    labelNotificacion.Text = "";

                
                }

                else
                {
                    labelNotificacion.Text = "ERROR, INTENTE NUEVAMENTE";
                    labelNotificacion.ForeColor = Color.Red;
                    await Task.Delay(5000);
                    labelNotificacion.Text = "";
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
            GrillaPacientes.DataSource = servicio.MostrarPacientes();
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
                enlacePaciente.Tipo_Sangre = textBoxSangre.Text;
                enlacePaciente.FechaNacimiento = fecha_Nacimiento.Value;
                enlacePaciente.Telefono = textBoxTelefono.Text;
                enlacePaciente.Direccion = textBoxDireccion.Text;
                enlacePaciente.Ocupacion = textBoxOcupacion.Text;
                enlacePaciente.Correo = textBoxCorreo.Text;
                enlacePaciente.Regimen = comboBox1.Text;
                enlacePaciente.Nacionalidad = textBoxNacionalidad.Text;
                enlacePaciente.EstadoCivil = textBoxEstado_Civil.Text;
                enlacePaciente.NivelEducativo = textBoxNivel_Educativo.Text;

                servicio.Update(enlacePaciente);
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

        //ACCIONES
        private void FormListadoGeneralcs_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarLista();
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
            dobleClick();
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
            /*var busqueda = textBoxBusqueda.Text;

            var lista = servicio.GetByName(busqueda);

            if (lista != null)
            {
                dataGridView1.Rows.Clear();
                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(item.Id, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido,
                                           item.SegundoApellido, item.Telefono, item.Direccion, item.Ocupacion,
                                           item.EstadoCivil, item.Correo, item.FechaNacimiento, item.Edad, item.Regimen,
                                           item.Nacionalidad, item.EstadoCivil, item.NivelEducativo);
                }
            }*/
        }
    }
}

