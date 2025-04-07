using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacro_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEstudiante formEstudiante = new FormEstudiante();
            formEstudiante.Show();
        }

        private void btnTalleres_Click(object sender, EventArgs e)
        {
            FormTaller formTaller = new FormTaller();
            formTaller.Show();
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            FormInscripcion formInscripcion = new FormInscripcion();
            formInscripcion.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }
    }
}
