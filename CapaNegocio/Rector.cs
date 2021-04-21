using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private DateTime fechaNacimiento;
        private string estudios;
        private string profesion;
        private string gradoAcademico;

        //Propiedades
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Estudios
        {
            get { return estudios; }
            set { estudios = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public string GradoAcademico
        {
            get { return gradoAcademico; }
            set { gradoAcademico = value; }
        }
        // Métodos u operaciones
        public string Organizar()
        {
            return "No se ha implementado el método Organizar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el método Trabajar";
        }
        public string Asesorar()
        {
            return "No se ha implementado el método Asesorar";
        }
        public string Representar()
        {
            return "No se ha implementado el método Representar";
        }
    }
}
