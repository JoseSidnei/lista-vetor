using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    public class Exercicio03
    {
        public Exercicio03()
        {

            // 3 -​ Crie um vetor para guardar o nome e o preço de 7 produtos;

            string[] nomesProdutos = new string[7];
            double[] precoProdutos = new double[7];

            Console.Write("Nome Pdroduto 01: ");
            nomesProdutos[0] = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            precoProdutos[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Nome Pdroduto 02: ");
            nomesProdutos[1] = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            precoProdutos[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Nome Pdroduto 03: ");
            nomesProdutos[2] = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            precoProdutos[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Nome Pdroduto 04: ");
            nomesProdutos[3] = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            precoProdutos[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Nome Pdroduto 05: ");
            nomesProdutos[4] = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            precoProdutos[4] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Nome Pdroduto 06: ");
            nomesProdutos[5] = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            precoProdutos[5] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Nome Pdroduto 07: ");
            nomesProdutos[6] = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            precoProdutos[6] = Convert.ToDouble(Console.ReadLine());



        }
    }
}
