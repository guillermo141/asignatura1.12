using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asignatura1._1
{
    internal class asignatura
    {
        //CONTRUCTOR
        public asignatura(string nombre, int codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }
        //ATRIBUTOS
        public string nombre { get; set; }
        public int codigo { get; set; }

        //METODOS


        public void setNombre(string n)
        {
            nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string Mostrardato()
        {
            string dato2;
            dato2 = "EL nombre es: " + getNombre() + Environment.NewLine;
            dato2 += "La nota agregada es: " + codigo + Environment.NewLine;
            return dato2;

        }

    }
}
