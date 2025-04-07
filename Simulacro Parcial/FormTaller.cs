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
    public partial class FormTaller : Form
    {
        List<Taller> talleres = new List<Taller>();
        public FormTaller()
        {
            InitializeComponent();
        }

        private void mostrar()
        {
            TallerArchivo tallerArchivo = new TallerArchivo();
            talleres = tallerArchivo.Leer("../../Talleres.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = talleres; 
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Taller taller = new Taller();
            taller.codigo = txtCodigo.Text;
            taller.nombre_taller = txtNombreTaller.Text;
            taller.costo = Convert.ToDecimal(maskedtxtCosto.Text);

            talleres.Add(taller);

            TallerArchivo tallerArchivo = new TallerArchivo();
            tallerArchivo.Guardar("../../Talleres.json", talleres);

            txtCodigo.Clear();
            txtNombreTaller.Clear();
            maskedtxtCosto.Clear();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
