using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private string dni;
        private string profesion;
        private string asignatura;
        private string aula;
        private DateTime horario;
        
        // Propiedades
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
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
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
        public string Evaluar()
        {
            return "No se ha implementado el método Evaluar";
        }
        public string Aprobar()
        {
            return "No se ha implementado el método Aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el método Desaprobar";
        }
    }
}
