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
    public partial class frmJefePracticas : Form
    {
        public frmJefePracticas()
        {
            InitializeComponent();
        }
        CapaNegocio.JefePractica jefe1 = new CapaNegocio.JefePractica();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string dni = txtDni.Text;
            string profesion = txtProfesion.Text;
            string asignatura = txtAsignatura.Text;
            string aula = txtAula.Text;
            DateTime horario = DateTime.Parse(txtHorario.Text);
            jefe1.Apellidos = apellidos;
            jefe1.Nombres = nombres;
            jefe1.Dni = dni;
            jefe1.Profesion = profesion;
            jefe1.Asignatura = asignatura;
            jefe1.Aula = aula;
            jefe1.Horario = horario;
            MessageBox.Show("Se han registrado correctamente los datos del Jefe de practica 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = jefe1.Apellidos;
            string nombres = jefe1.Nombres;
            string dni = jefe1.Dni;
            string profesion = jefe1.Profesion;
            string asignatura = jefe1.Asignatura;
            string aula = jefe1.Aula;
            DateTime horario = jefe1.Horario;
            MessageBox.Show(" Apellidos: " + apellidos + "\n Nombres: " + nombres + "\n DNI: " + dni +
                "\n Profesión : " + profesion + "\n Asignatura: " + asignatura + "\n aula: " + aula + "\n Horario: "+horario );
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefe1.Enseñar());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefe1.Evaluar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefe1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefe1.Desaprobar());
        }
    }
}
