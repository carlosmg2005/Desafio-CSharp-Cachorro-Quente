using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_CSharp_Cachorro_Quente
{
        class Program
        {
            static void Main(string[] args)
            {
            string[] entrada = Console.ReadLine().Split();
            int participantes = int.Parse(entrada[0]);
            int cachorrosQuentes = int.Parse(entrada[1]);

            //TODO: Calcular a média de cachorros-quentes consumidos pelos participantes.
            double media = (double)participantes / cachorrosQuentes;

            Console.WriteLine("{0}", media.ToString("N2"));

            Console.ReadKey();
            }
        }
}
