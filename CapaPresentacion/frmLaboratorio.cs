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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }

        private void frmLaboratorio_Load(object sender, EventArgs e)
        {

        }
        CapaNegocio.Laboratorio lab1 = new CapaNegocio.Laboratorio();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string instrumento = txtInstrumento.Text;
            string material = txtMaterial.Text;
            string cantidad = txtCantidad.Text;
            string asignatura = txtAsignatura.Text;
            DateTime horario = DateTime.Parse(txtHorario.Text);
            string aforo = txtAforo.Text;
            lab1.Instrumento = instrumento;
            lab1.Material = material;
            lab1.Cantidad = cantidad;
            lab1.Asignatura = asignatura;
            lab1.Horario = horario;
            lab1.Aforo = aforo;
            MessageBox.Show("Se han registrado correctamente los datos del Laboratorio 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string instrumento = lab1.Instrumento;
            string material = lab1.Material;
            string cantidad = lab1.Cantidad;
            string asignatura = lab1.Asignatura;
            DateTime horario = lab1.Horario;
            string aforo = lab1.Aforo;
            MessageBox.Show(" Instrumento: " + instrumento + "\n Material: " + material +"\n Cantidad: "+cantidad+
                "\n Asignatura: "+ asignatura + "\n Horario: "+ horario+ "\n Aforo: "+ aforo);
        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lab1.Experimentar());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lab1.Enseñar());
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lab1.Investigar());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lab1.Ordenar());
        }
    }
}
