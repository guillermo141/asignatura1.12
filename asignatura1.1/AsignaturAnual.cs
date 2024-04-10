using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asignatura1._1
{
    internal class AsignaturAnual : asignatura
    {
        //CONTRUCTOR
        public AsignaturAnual(int notateoricaPC, int notateoriaSC) : base ("lala", 2) 
        {
            this.notateoricaPC = notateoricaPC;
            this.notateoriaSC = notateoriaSC;
        }
        //atributos
        public int notateoricaPC { get; set; }
        public int notateoriaSC { get; set;}

        //METODO


        public string informacion(double a)
        {
            string  texto = "La nota teorica del primer cuatri.. es: " + codigo;
            codigo = ((notateoriaSC + notateoricaPC) * 1/2);
            texto += "la nota teorica del segundo cuatri es: " + codigo;
            return texto;
        }
    }

}
