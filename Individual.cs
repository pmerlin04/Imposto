using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAbstrato.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; } //gasto com saúde

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            //se a renda anual for menor que 20.000, deverá pagar 15% de imposto
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            //se nao, deverá pagar 25% de imposto
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }
    }
}
