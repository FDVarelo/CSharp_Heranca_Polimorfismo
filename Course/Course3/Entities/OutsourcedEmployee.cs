using System;
using Course3.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course3.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }
        public OutsourcedEmployee(string name, int hours, double valuePerHour,double additionalCharge) 
            : base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double var = base.Payment(); // var recebe (horas trabalhadas * valor por hora)
            return var += AdditionalCharge + AdditionalCharge*0.1; // var recebe (var + valor adicional + 10% do valor adicional)

            // return base.Payment() + 1.1 * AdditionalCharge; // Outra forma de fazer os calculos acima, porém menos legivel
        }
    }
}
