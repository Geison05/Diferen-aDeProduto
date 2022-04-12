using System;


namespace Project
{
    class Program
    {
        static void Main(String[] args)
        {
            //Variavel

            int A, B, C, D, dif;

            //Entrada

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            //Processamento

            dif = A * B - C * D;

            //Saida

            Console.WriteLine("DIFERENCA = " + dif);

        }
    }
}