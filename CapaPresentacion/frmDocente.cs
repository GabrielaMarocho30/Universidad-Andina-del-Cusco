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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }
        CapaNegocio.Docente docente1 = new CapaNegocio.Docente();
        private void button1_Click(object sender, EventArgs e)
        {
            // Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;           
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            string dni = txtDni.Text;
            int edad = int.Parse(txtEdad.Text);
            string profesion = txtProfesion.Text;
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.FechaNacimiento = fechaNacimiento;
            docente1.Dni = dni;
            docente1.Edad = edad;
            docente1.Profesion = profesion;
            MessageBox.Show("Se han registrado correctamente los datos de Docente 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos alamacenados en el objeto 1
            string apellidos = docente1.Apellidos;
            string nombres = docente1.Nombres;
            DateTime fechaNacimiento = docente1.FechaNacimiento;
            string dni = docente1.Dni;
            int edad = docente1.Edad;
            string profesion = docente1.Profesion;
            MessageBox.Show("Apellidos: " + apellidos + "\n Nombres: " + nombres + "\n Fecha de Nacimiento: " + fechaNacimiento
                + "\n DNI: " + dni + "\n Profesión: " + profesion);
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Desaprobar());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Enseñar());
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Matricular());
        }
    }
}
