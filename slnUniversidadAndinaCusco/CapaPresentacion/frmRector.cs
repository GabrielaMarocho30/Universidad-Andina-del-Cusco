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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            string estudios = txtApellidos.Text;
            string profesion = txtProfesion.Text;
            string gradoAcademico = txtGradoAcademico.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.FechaNacimiento = fechaNacimiento;
            rector1.Estudios = estudios;
            rector1.Profesion = profesion;
            rector1.GradoAcademico = gradoAcademico;
            MessageBox.Show("Los datos del rector se registraron con exito");

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombres;
            DateTime fechaNacimiento = rector1.FechaNacimiento;
            string estudios = rector1.Estudios;
            string profesion = rector1.Profesion;
            string gradoAcademico = rector1.GradoAcademico;
            MessageBox.Show(" Apellidos: " + apellidos + "\n Nombres: " + nombres + "\n Fecha de Nacimiento : " +
                fechaNacimiento + "\n Profesión: " + profesion + "\n Grado Académico: " + gradoAcademico);
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Organizar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Trabajar());
        }

        private void btnAsesorar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Asesorar());
        }

        private void btnRepresentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Representar());
        }
    }
}
