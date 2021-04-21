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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }

        private void frmAsignatura_Load(object sender, EventArgs e)
        {

        }
        CapaNegocio.Asignatura asig1 = new CapaNegocio.Asignatura();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombreAsignatura = txtNombreAsignatura.Text;
            string codigo = txtCodigo.Text;
            string plan = txtPlan.Text;
            string aula = txtAula.Text;
            DateTime horario = DateTime.Parse(txtHorario.Text);
            asig1.NombreAsignatura = nombreAsignatura;
            asig1.Codigo = codigo;
            asig1.Plan = plan;
            asig1.Aula = aula;
            asig1.Horario = horario;
            MessageBox.Show("Se han registrado correctamente los datos de la Asignatura 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombreAsignatura = asig1.NombreAsignatura;
            string codigo = asig1.Codigo;
            string plan = asig1.Plan;
            string aula = asig1.Aula;
            DateTime horario = asig1.Horario;
            MessageBox.Show(" Asignatura: " + nombreAsignatura + "\n Código: " + codigo + "\n Plan: " + plan +
                "\n Aula: " + aula + "\n Horario: " + horario);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asig1.Enseñar());
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asig1.Estudiar());
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asig1.Investigar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asig1.Aprender());
        }
    }
}
