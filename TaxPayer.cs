using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAbstrato.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; } //nome da pessoa ou empresa
        public double AnualIncome { get; set; } //ganho anual

        public TaxPayer()
        {
        }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        //pagar imposto
        public abstract double Tax();
    }
}
