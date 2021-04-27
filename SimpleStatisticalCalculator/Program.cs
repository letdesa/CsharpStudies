using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStatisticalCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 0, i2 = 0, i3 = 0, bigger = 0, smaller = 0, sum = 0;
            decimal average;
            var valuesList = new List<string>();

            Console.WriteLine("DETERMINAÇÃO DO MAIOR, MENOR E NÚMERO MÉDIO DOS VALORES DIGITADOS");
            Console.Write("Digite os números que deseja informar separados por vírgula:");

            var txtNumbers = Console.ReadLine();
            var txtNumber = txtNumbers.Split(',');

            foreach (var number in txtNumber)
            {
                i1++;

                valuesList.Add(number);

            }

            int[] listInt = valuesList.Select(x => Int32.Parse(x)).ToArray();

            for (i2 = 0; i2 < i1; i2++)
            {
                sum += listInt[i2];

                if (i2 == 0)
                {
                    smaller = listInt[0];
                    bigger = listInt[0];
                }
                if (listInt[i2] < smaller)
                {
                    smaller = listInt[i2];
                }

                else if (listInt[i2] > bigger)
                {
                    bigger = listInt[i2];
                }


            }

            average =(decimal) sum / i1;

            var listString = string.Join(',', listInt);

            Console.Write("A lista de termos é: ");
            Console.WriteLine($"{listString}");

            Console.Write("Total de termos: ");
            Console.WriteLine(i1);

            Console.Write("O valor menor: ");
            Console.WriteLine(smaller);

            Console.Write("O valor maior: ");
            Console.WriteLine(bigger);

            Console.Write("O valor médio: ");
            Console.WriteLine(average);

            Console.ReadLine();

        }

        private static void Foo(int[] vs)
        {
            throw new NotImplementedException();
        }
    }
}
