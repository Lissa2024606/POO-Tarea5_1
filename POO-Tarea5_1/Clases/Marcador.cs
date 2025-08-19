using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea5_1.Clases
{
    public class Marcador
    {
        private double costoHora { set; get; }
        private double horasTrabajadas { set; get; }
        private double salario { set; get; }
        public Marcador() 
        {
            this.costoHora = 50;
        }
         public double getsalario(double p_horasTrabajadas)
        {
            this.salario = horasTrabajadas * this.costoHora;
            return this.salario;
        }
    }
}
