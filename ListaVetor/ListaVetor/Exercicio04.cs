using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    public class Exercicio04
    {
        public Exercicio04()
        {
            //4. Crie um vetor para armazenar as notas de uma disciplina. A disciplina deve
           // conter 4 notas.
           // Solicite para o usuário o nome e as quatro notas, armazenando as notas em um
           // vetor, realize a média destas notas e apresente.

           
            string[] nome = new string[0];
            double[] notas = new double[4];

            Console.Write("Nome: ");
            nome[0] = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Nota 01: ");
            notas[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 02: ");
            notas[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 03: ");
            notas[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 04: ");
            notas[3] = Convert.ToDouble(Console.ReadLine());

            double media = (notas[0] + notas[1] + notas[2] + notas[3] + notas[4]) / 4;

            Console.WriteLine("Média das notas: " + media);
            


        }
    }
}
