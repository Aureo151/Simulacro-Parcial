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
    public partial class FormEstudiante : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        public FormEstudiante()
        {
            InitializeComponent();
        }
        private void mostar()
        {
            EstudianteArchivo estudianteArchivo = new EstudianteArchivo();
            estudiantes = estudianteArchivo.Leer("../../Estudiantes.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = estudiantes;
            dataGridView1.Refresh();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.dpi = txtdpi.Text;
            estudiante.nombre = txtNombre.Text;
            estudiante.direccion = txtDireccion.Text;

            estudiantes.Add(estudiante);

            EstudianteArchivo estudianteArchivo = new EstudianteArchivo();
            estudianteArchivo.Guardar("../../Estudiantes.json", estudiantes);

            txtNombre.Clear();
            txtdpi.Clear();
            txtDireccion.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostar();
        }
    }
}
