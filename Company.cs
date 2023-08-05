using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAbstrato.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; } //numero de funcionarios

        public Company(string name, double anualIncome, int numberOfEmployees) :
            base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }


        public override double Tax()
        {
            //se a empresa tiver mais que 10 funcionarios, deverá que pagar 14% de impostos
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;

            //caso contrário, pagará 16% de impostos
            }else 
            {
                return AnualIncome * 0.16;
            }
           
        }
    }
}
