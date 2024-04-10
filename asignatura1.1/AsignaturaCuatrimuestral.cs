using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asignatura1._1
{
    internal class AsignaturaCuatrimuestral : asignatura
    {
        //contructor
        public AsignaturaCuatrimuestral(string cuatrimestre, string nontateorica) :base("a",2)
        {
            this.cuatrimestre = cuatrimestre;
            this.nontateorica = nontateorica;
        }
       
        //atributos
        public string cuatrimestre {  get; set; }
        public string nontateorica { get; set; }
        
        
        //metodos
        public string informacion(double b)
        {
            string 
             lord= "cuatrimestre (primer-segundo): " + cuatrimestre;
             lord+="nota teorica es: " + nontateorica;
            return lord;
        }
    }
}
