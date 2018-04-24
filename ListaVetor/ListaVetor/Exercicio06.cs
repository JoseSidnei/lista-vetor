using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    public class Exercicio06
    {
        public Exercicio06()
        {
            // 6. Solicite a idade de 9 pessoas, apresente ao final a pessoa com a maior
            // idade.

             int[] idades = new int[9];
            bool validaIdades = true;
            while (validaIdades == true)
            {
                try
                {
                    Console.Write("Idade 01: ");
                    idades[0] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    
                }
                catch (Exception h)
                {
                    Console.WriteLine("Idade deve conter somente Números ");
                    Console.WriteLine("");
                }
                if (idades[0] < 0)
                {
                    Console.WriteLine("Idade deve ser maior que 0 ");
                    Console.WriteLine("");
                }

                try
                {
                    Console.Write("Idade 02: ");
                    idades[1] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                }
                catch (Exception h)
                {
                    Console.WriteLine("Idade deve conter somente Números ");
                    Console.WriteLine("");
                }
                if (idades[1] < 0)
                {
                    Console.WriteLine("Idade deve ser maior que 0 ");
                    Console.WriteLine("");
                }

                try
                {
                    Console.Write("Idade 03: ");
                    idades[2] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    
                }
                catch (Exception h)
                {
                    Console.WriteLine("Idade deve conter somente Números ");
                    Console.WriteLine("");
                }
                if (idades[2] < 0)
                {
                    Console.WriteLine("Idade deve ser maior que 0 ");
                    Console.WriteLine("");
                }
                    try
                {
                    Console.Write("Idade 04: ");
                    idades[3] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    
                }
                catch (Exception h)
                {
                    Console.WriteLine("Idade deve conter somente Números ");
                    Console.WriteLine("");
                }
                if (idades[3] < 0)
                {
                    Console.WriteLine("Idade deve ser maior que 0 ");
                    Console.WriteLine("");
                }
                    try
                {
                    Console.Write("Idade 05: ");
                    idades[4] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    
                }
                catch (Exception h)
                {
                    Console.WriteLine("Idade deve conter somente Números ");
                    Console.WriteLine("");
                }
                if (idades[4] < 0)
                {
                    Console.WriteLine("Idade deve ser maior que 0 ");
                    Console.WriteLine("");
                }

                    try
                {
                    Console.Write("Idade 06: ");
                    idades[5] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    
                }
                catch (Exception h)
                {
                    Console.WriteLine("Idade deve conter somente Números ");
                    Console.WriteLine("");
                }
                if (idades[5] < 0)
                {
                    Console.WriteLine("Idade deve ser maior que 0 ");
                    Console.WriteLine("");
                }
                    try
                {
                    Console.Write("Idade 07: ");
                    idades[6] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    
                }
                catch (Exception h)
                {
                    Console.WriteLine("Idade deve conter somente Números ");
                    Console.WriteLine("");
                }
                if (idades[6] < 0)
                {
                    Console.WriteLine("Idade deve ser maior que 0 ");
                    Console.WriteLine("");
                }

                    try
                {
                    Console.Write("Idade 08: ");
                    idades[7] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    
                }
                catch (Exception h)
                {
                    Console.WriteLine("Idade deve conter somente Números ");
                    Console.WriteLine("");
                }
                if (idades[7] < 0)
                {
                        Console.WriteLine("Idade deve ser maior que 0 ");
                        Console.WriteLine("");
                }
                    try
                {
                    Console.Write("Idade 09: ");
                    idades[8] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    
                }
                catch (Exception h)
                {
                    Console.WriteLine("Idade deve conter somente Números ");
                    Console.WriteLine("");
                }
                if (idades[8] < 0)
                {
                    Console.WriteLine("Idade deve ser maior que 0 ");
                    Console.WriteLine("");
                }
            
            }   
            
               double maiorIdade = 0;
             
            if (idades[0] > maiorIdade)
            {
                Console.WriteLine("Maior dade: " + idades[0]);
            }
            else if (idades[1] > maiorIdade)
            {
                Console.WriteLine("Maior idade: " + idades[1]);
            }
            else if (idades[2] > maiorIdade)
            {
                Console.WriteLine("Maior idade: " + idades[2]);
            }
            else if (idades[3] > maiorIdade)
            {
                Console.WriteLine("Maior idade: " + idades[3]);
            }
            else if (idades[4] > maiorIdade)
            {
                Console.WriteLine("Maior idade: " + idades[4]);
            }
            else if (idades[5] > maiorIdade)
            {
                Console.WriteLine("Maior idade: " + idades[5]);
            }
            else if (idades[6] > maiorIdade)
            {
                Console.WriteLine("Maior idade: " + idades[6]);
            }
            else if (idades[7] > maiorIdade)
            {
                Console.WriteLine("Maior idade: " + idades[7]);
            }
            else if (idades[8] > maiorIdade)
            {
                Console.WriteLine("Maior idade: " + idades[8]);
            }  


        }
    }
}

