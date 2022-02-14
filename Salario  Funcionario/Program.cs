using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Salario__Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu numero");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de horas trabalhada");
            int numHoras = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que recebe por horas");
            double valorHoras = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double sal = valorHoras * numHoras;

            Console.WriteLine("O seu numero é " + num + "E o seu salario é " + sal.ToString("F2", CultureInfo.InvariantCulture)); ;

            Console.ReadLine();
        }
    }
}
