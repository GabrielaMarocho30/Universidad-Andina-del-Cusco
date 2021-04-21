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
    public partial class frmPracticasPP : Form
    {
        public frmPracticasPP()
        {
            InitializeComponent();
        }
        CapaNegocio.PracticasPP practica1 = new CapaNegocio.PracticasPP();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string estudiante = txtEstudiante.Text;
            string codigo = txtCodigo.Text;
            string escuelaProfesional = txtEscuelaProfesional.Text;
            string creditosAprobados = txtCreditosAprobados.Text;
            DateTime fechaInicio = DateTime.Parse(txtFechaInicio.Text);
            DateTime fechaFinal = DateTime.Parse(txtFechaFinal.Text);
            practica1.Estudiante = estudiante;
            practica1.Codigo = codigo;
            practica1.EscuelaProfesional = escuelaProfesional;
            practica1.CreditosAprobados = creditosAprobados;
            practica1.FechaInicio = fechaInicio;
            practica1.FechaFinal = fechaFinal;
            MessageBox.Show("Se han registrado correctamente los datos de la práctica 1");

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string estudiante = practica1.Estudiante;
            string codigo = practica1.Codigo;
            string escuelaProfesional = practica1.EscuelaProfesional;
            string creditosAprobados = practica1.CreditosAprobados;
            DateTime fechaInicio = practica1.FechaInicio;
            DateTime fechaFinal = practica1.FechaFinal;
            MessageBox.Show(" Estudiante: "+estudiante + "\n Código: " +codigo +"\n Escuela Profesional :"+
                escuelaProfesional + "\n Creditos Aprobados: " + creditosAprobados +"\n Fecha de Inicio: " +
                fechaInicio + "\n Fecha Final: " + fechaFinal);
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practica1.Solicitar());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practica1.Aceptar());
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practica1.Rechazar());
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practica1.Investigar());
        }
    }
}
