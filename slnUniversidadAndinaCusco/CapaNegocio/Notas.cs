using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        private string estudiante;
        private string asignatura;
        private int nota1;
        private int nota2;
        private int nota3;
        private int promedio;

        //Propiedades
        public string Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }
        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }
        public int Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }
        public int Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }
        public int Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }
        public int Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }
        //Métodos u operaciones
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
