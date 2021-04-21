using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //Atributos
        private string instrumento;
        private string material;
        private string cantidad;
        private string asignatura;
        private DateTime horario;
        private string aforo;

        //propiedades
        public string Instrumento
        {
            get { return instrumento; }
            set { instrumento = value;  }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value;  }
        }
        public DateTime Horario
        {
            get { return horario;  }
            set { horario = value;  }
        }
        public string Aforo
        {
            get { return aforo;  }
            set { aforo = value;  }
        }
        //Metodos u operaciones
        public string Experimentar()
        {
            return "No se ha implementado el método experimentar";
        }
        public string Enseñar()
        {
            return "No se ha implementado el método desaprobar";
        }
        public string Investigar()
        {
            return "No se ha implementado el método investigar";
        }
        public string Ordenar()
        {
            return "No se ha implementado el método ordenar";
        }
            
    }
}
