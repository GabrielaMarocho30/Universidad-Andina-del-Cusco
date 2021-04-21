using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PracticasPP
    {
        // Atributos
        private string estudiante;
        private string codigo;
        private string escuelaProfesional;
        private string creditosAprobados;
        private DateTime fechaInicio;
        private DateTime fechaFinal;

        // Propiedades
        public string Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string EscuelaProfesional
        {
            get { return escuelaProfesional; }
            set { escuelaProfesional = value; }
        }
        public string CreditosAprobados
        {
            get { return creditosAprobados; }
            set { creditosAprobados = value; }
        }
        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; }
        }
        // Métodos u operaciones
        public string Solicitar()
        {
            return "No se ha implementado el método Solicitar";
        }
        public string Aceptar()
        {
            return "No se ha implementado el método Aceptar";
        }
        public string Rechazar()
        {
            return "No se ha implementado el método Rechazar";
        }
        public string Investigar()
        {
            return "No se ha implementado el método Investigar";
        }
    }
}
