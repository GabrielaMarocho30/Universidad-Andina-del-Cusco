using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        CapaNegocio.Notas nota0 = new CapaNegocio.Notas();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string estudiante = txtEstudiante.Text;
            string asignatura = txtAsignatura.Text;
            int nota1 = int.Parse(txtNota1.Text);
            int nota2 = int.Parse(txtNota2.Text);
            int nota3 = int.Parse(txtNota3.Text);
            int promedio = int.Parse(txtPromedio.Text);
            nota0.Estudiante = estudiante;
            nota0.Asignatura = asignatura;
            nota0.Nota1 = nota1;
            nota0.Nota2 = nota2;
            nota0.Nota3 = nota3;
            nota0.Promedio = promedio;
            MessageBox.Show("Se han registrado correctamente los datos de las notas");

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string estudiante = nota0.Estudiante;
            string asignatura = nota0.Asignatura;
            int nota1 = nota0.Nota1;
            int nota2 = nota0.Nota2;
            int nota3 = nota0.Nota3;
            int promedio = nota0.Promedio;
            MessageBox.Show(" Estudiante: " + estudiante + "\n Asignatura: " + asignatura + "\n Nota 1: " + nota1 +
                "\n Nota 2: " + nota2 + "\n Nota 3: " + nota3 + "\n Promedio: " + promedio);
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota0.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota0.Desaprobar());
        }
    }
}
