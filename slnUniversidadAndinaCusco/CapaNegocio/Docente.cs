using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        // Atributos
        private string apellidos;
        private string nombres;
        private DateTime fechaNacimiento;
        private string dni;
        private int edad;
        private string profesion;
        // Proiedades
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
        public string Dni
        {
            get { return dni; }
            set { dni = value; }

        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        // Metodos u operaciones
        public string Aprobar()
        {
            return "No se ha implementado el metodo apobar";

        }
        public string Desaprobar()
        {
            return "No se ha implementdo el metodo desaprobar";

        }
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string Matricular()
        {
            return "No se ha implementado el metodo matricular";

        }
    }
}
