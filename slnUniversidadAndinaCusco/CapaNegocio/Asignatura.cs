using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //Atributos
        private string nombreAsignatura;
        private string codigo;
        private string plan;
        private string aula;
        private DateTime horario; 

        //Propiedades
        public string NombreAsignatura
        {
            get { return nombreAsignatura; }
            set { nombreAsignatura = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Plan
        {
            get { return plan; }
            set { plan = value; }

        }
        public string Aula
        {
            get { return aula; }
            set { aula = value; }
        }
        public DateTime Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        // Métodos u operaciones
        public string Enseñar()
        {
            return "No se ha implementado el método Enseñar";
        }
        public string Estudiar()
        {
            return "No se ha implementado el método Estudiar";
        }
        public string Investigar()
        {
            return "No se ha implementado el método Investigar";
        }
        public string Aprender()
        {
            return "No se ha implementado el método Aprender";
        }
    }
}
