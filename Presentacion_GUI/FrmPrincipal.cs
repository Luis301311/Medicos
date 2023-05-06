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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        void abrirPaciente(FormListadoGeneralcs e)
        {
            Hide();
            e.ShowDialog(this);
        }

        void abrirMedico(FrmMedico e)
        {
            Hide();
            e.ShowDialog(this);
        }
        private void btnPaciente_Click(object sender, EventArgs e)
        {
            abrirPaciente(new FormListadoGeneralcs());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            abrirMedico(new FrmMedico());
        }
    }
}
