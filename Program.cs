using ExercicioAbstrato.Entities;
using System.Globalization;

namespace ExercicioAbstrato
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais
            podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um,
            bem como o total de imposto arrecadado. 
            */

            List<TaxPayer> list = new List<TaxPayer>();//declarando uma list com o tipo TaxPayer

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                //dados padrão 
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or comoany (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    //caso for individual
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                    //adicionando na instancia do Individual

                }
                else if (ch == 'c')
                {
                    //caso for empresa
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, employees));
                    //adicionando na instancia da Company
                }              
            }//final for 

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            //apresentando o nome e a taxa de cada pessoa
            foreach(TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name + " $ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            //somando todos os valores e atribuindo à uma variavel
            double sum = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                sum += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES:  $" + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
