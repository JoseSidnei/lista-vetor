using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    public class Exercicio07
    {
        public Exercicio07()
        {
            // 7. Solicite a altura de 4 animais, apresente ao final a altura do animal com a
            // menor altura.

            double[] alturas = new double[4];
            bool validaAlturas = true;
            while (validaAlturas == true)
            {

                try
                {
                    Console.Write("Altura 01: ");
                    alturas[0] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception h)
                {
                    Console.Write("Altura deve conter somente Números ");
                }

                try
                {
                    Console.Write("Altura 02: ");
                    alturas[1] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception h)
                {
                    Console.WriteLine("Altura deve conter somente Números ");
                }

                try
                {
                    Console.Write("Altura 03: ");
                    alturas[2] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception h)
                {
                    Console.WriteLine("Altura deve conter somente Números ");
                }

                try
                {
                    Console.Write("Altura 04: ");
                    alturas[3] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception h)
                {
                    Console.WriteLine("Altura deve conter somente Números ");
                }

                double menorAltura = 0; 

                if (alturas[0] < menorAltura)
                {
                    menorAltura = alturas[0];
                }
                else if (alturas[1] < menorAltura)
                {
                    menorAltura = alturas[1];
                }
                else if (alturas[2] < menorAltura)
                {
                    menorAltura = alturas[2];
                }
                else if (alturas[3] < menorAltura)
                {
                    alturas[3] = menorAltura;
                }


                Console.WriteLine("");
                Console.WriteLine("Menor altura: " + menorAltura);

            }
           

            




        }
    }
}
