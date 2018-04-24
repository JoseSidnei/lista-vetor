using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    public class Exercicio05
    {
        public Exercicio05()
        {
            // 5. Solicite para o usuário 5 pesos e apresente a soma total dos pesos e a média
            // dos pesos.

            double[] pesos = new double[5];

            Console.WriteLine("Peso 01: ");
            pesos[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Peso 02: ");
            pesos[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Peso 03: ");
            pesos[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Peso 04: ");
            pesos[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Peso 05: ");
            pesos[4] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            double soma = pesos[0] + pesos[1] + pesos[2] + pesos[3] + pesos[4];
            double media = soma / 5;

            Console.WriteLine("Soma total dos Pesoas: " + soma);
            Console.WriteLine("");
            Console.WriteLine("Média dos Pesos: " + media);

        }
    }
}
