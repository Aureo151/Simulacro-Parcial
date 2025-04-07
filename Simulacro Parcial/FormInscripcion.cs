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
    public partial class FormInscripcion : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();
        public FormInscripcion()
        {
            InitializeComponent();
        }

        private void FormInscripcion_Load(object sender, EventArgs e)
        {
            EstudianteArchivo estudianteArchivo = new EstudianteArchivo();
            estudiantes = estudianteArchivo.Leer("../../Estudiantes.json");

            cmbdpi.DataSource = estudiantes;
            cmbdpi.ValueMember = "dpi";
            cmbdpi.DisplayMember = "dpi";

            TallerArchivo tallerArchivo = new TallerArchivo();
            talleres = tallerArchivo.Leer("../../Talleres.json");

            cmbCodigo.DataSource = talleres;
            cmbCodigo.ValueMember = "codigo";
            cmbCodigo.DisplayMember = "codigo";
        }
        private void mostrar()
        {
            InscripcionArchivo inscripcionArchivo = new InscripcionArchivo();
            inscripciones = inscripcionArchivo.Leer("../../Inscripciones.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = inscripciones;
            dataGridView1.Refresh();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.dpi = cmbdpi.SelectedValue.ToString();
            inscripcion.codigo = cmbCodigo.SelectedValue.ToString();
            inscripcion.fecha = DateTime.Now;

            inscripciones.Add(inscripcion);

            InscripcionArchivo inscripcionArchivo = new InscripcionArchivo();
            inscripcionArchivo.Guardar("../../Inscripciones.json", inscripciones);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
