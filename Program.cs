using System;
using System.Threading;

namespace Omnitrix
{
    class Contratempo
    {
        static void Main(string[] args)
        {
            MenuClient();
        }


        static void MenuClient()
        {
            Console.WriteLine("Como será sua contagem?: ");
            Console.WriteLine("1 -Minutos ");
            Console.WriteLine("2 - Segundos ");
            Console.WriteLine("3 -Dar no pé ");
            Console.WriteLine("************************");

            short dados = short.Parse(Console.ReadLine());
            switch (dados)
            {
                case 1: Min(); break;
                case 2: Sec(); break;
                case 3: System.Environment.Exit(0); break;
            }
        }

        static void Min()
        {
            Console.WriteLine("Quantos minutos você deseja contar? ");
            float minu = float.Parse(Console.ReadLine());
            var contador = minu * 60;
            int timHj = 0;

            while (contador != timHj)
            {
                Console.Clear();
                timHj++;
                Console.WriteLine(timHj);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("O universo foi resetado... retornado ao inicio");
            Thread.Sleep(3000);
        }
        static void Sec()
        {
            Console.WriteLine("Quantos segundos você deseja contar? ");
            float seg = float.Parse(Console.ReadLine());
            int tempHj = 0;

            while (seg != tempHj)
            {
                Console.Clear();
                tempHj++;
                Console.WriteLine(tempHj);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("O universo foi resetado... retornado ao inicio");
            Thread.Sleep(3000);
        }

    }


}