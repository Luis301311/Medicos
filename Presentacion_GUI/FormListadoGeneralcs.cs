using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion_GUI
{
    public partial class FormListadoGeneralcs : Form
    {
        Paciente enlacePaciente = new Paciente();
        ServicioPaciente servicio = new ServicioPaciente();


        public FormListadoGeneralcs()
        {
            InitializeComponent();
            CargarDatos();
            CargarLista();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void dobleClick()
        {
            if (lstPacientes.SelectedIndex != -1)
            {
                int num = lstPacientes.SelectedIndex;
                var lst = servicio.GetByAll();

                textBoxId.Text = lst[num].Id.ToString();
                textBoxPrimerNombre.Text = lst[num].PrimerNombre;
                textBoxSegundoNombre.Text = lst[num].SegundoNombre;
                textBoxPrimerApellido.Text = lst[num].PrimerApellido;
                textBoxSegundoApellido.Text = lst[num].SegundoApellido;
                textBoxCorreo.Text = lst[num].Correo;
                textBoxEstado_Civil.Text = lst[num].EstadoCivil;
                textBoxDireccion.Text = lst[num].Direccion;
                textBoxNacionalidad.Text = lst[num].Nacionalidad;
                textBoxNivel_Educativo.Text = lst[num].NivelEducativo;
                textBoxOcupacion.Text = lst[num].Ocupacion;
                comboBox1.Text = lst[num].Regimen;
                fecha_Nacimiento.Text = lst[num].FechaNacimiento.ToString();
                textBoxEdad.Text = lst[num].Edad.ToString();
                textBoxTelefono.Text = lst[num].Telefono;

                textBoxId.Enabled = false;
            }
        }

        void CargarLista()
        {
            var lista = servicio.GetByAll();
            lstPacientes.Items.Clear();

            if(lista!=null)
            {
                foreach(var item in lista)
                {
                    lstPacientes.Items.Add(item.PrimerNombre+" "+item.PrimerApellido);
                }
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
            textBoxEdad.Clear();
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

            if (CamposEstanCompletos(textBoxId, textBoxPrimerNombre, textBoxPrimerApellido, textBoxTelefono, textBoxCorreo, textBoxEdad,
                textBoxNacionalidad, textBoxEstado_Civil, textBoxNivel_Educativo, textBoxDireccion, textBoxOcupacion) == false)
            {
                enlacePaciente.Id = int.Parse(textBoxId.Text);
                enlacePaciente.PrimerNombre = textBoxPrimerNombre.Text;
                enlacePaciente.SegundoNombre = textBoxSegundoNombre.Text;
                enlacePaciente.PrimerApellido = textBoxPrimerApellido.Text;
                enlacePaciente.SegundoApellido = textBoxSegundoApellido.Text;
                enlacePaciente.Edad = int.Parse(textBoxEdad.Text);
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
            var lista = servicio.GetByAll();
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
            }
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
                enlacePaciente.Edad = int.Parse(textBoxEdad.Text);
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


        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            //Busqueda();
        }
        /*private void Busqueda()
        {
            //if (textBoxBusqueda.Text != "")
            //{
            //    dataGridView1.CurrentCell = null;
            //    foreach (DataGridViewRow r in dataGridView1.Rows)
            //    {
            //        r.Visible = true;
            //    }

            //    foreach (DataGridViewRow r in dataGridView1.Rows)
            //    {
            //        foreach (DataGridViewCell c in dataGridView1.Rows)
            //        {
            //            if ((Convert.ToString(c.Value).ToUpper()).IndexOf(textBoxBusqueda.Text.ToUpper()) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    //CaragarDatos
            //}
            string textoBusqueda = textBoxBusqueda.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }

                // CargarDatos();
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool encontrado = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (Convert.ToString(cell.Value).ToUpper().Contains(textoBusqueda))
                        {
                            encontrado = true;
                            break;

                        }
                    }

                    row.Visible = encontrado;
                }
            }
        }*/

        private void FormListadoGeneralcs_Load(object sender, EventArgs e)
        {
            CargarDatos();
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
        private void FormListadoGeneralcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing(e);
        }

        private void buttonfiltar_Click(object sender, EventArgs e)
        {
            var busqueda = textBoxBusqueda.Text;

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
            }
        }
    }
    //===============================================================================
}

