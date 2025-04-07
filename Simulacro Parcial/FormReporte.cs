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
    public partial class FormReporte : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();
        List<Reporte> reportes = new List<Reporte>();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var estudiante in estudiantes)
            {
                foreach (var inscripcion in inscripciones)
                {
                    if (estudiante.dpi.Trim() == inscripcion.dpi.Trim())
                    {                       
                        foreach (var taller in talleres)
                        {
                            if (taller.codigo == inscripcion.codigo)
                            {
                                Reporte reporte = new Reporte();
                                reporte.nombre = estudiante.nombre;
                                reporte.nombre_taller = taller.nombre_taller;

                                reportes.Add(reporte);
                            }
                        }
                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes;
            dataGridView1.Refresh();
        }
    }
}