using System;
using System.Threading;

namespace ESTRUTURA_LOOP_DE_REPETIÇÃO_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Crie um programa que peça ao usuário para inserir um número e, em seguida, imprima a tabuada desse número de 1 a 10 usando um loop for.

            Console.WriteLine("Insira um numero para ver a tabuada");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("A tabuada de " +numero+ ": ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                Thread.Sleep(1000);
            }
        }
    }
}
