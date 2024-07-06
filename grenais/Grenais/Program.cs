using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int vtInter = 0, vtGremio = 0, empate = 0, golInter, golGremio, grenais = 0, novoGrenal = 1;

            while (novoGrenal == 1)
            {
                string[] vet1 = Console.ReadLine().Split(' ');
                golInter = int.Parse(vet1[0]);
                golGremio = int.Parse(vet1[1]);

                if (golInter > golGremio)
                {

                    vtInter++;


                }
                else if (golGremio > golInter)
                {

                    vtGremio++;


                }
                else if (golInter == golGremio)
                {

                    empate++;

                }

                grenais++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + vtInter);
            Console.WriteLine("Gremio:" + vtGremio);
            Console.WriteLine("Empates:" + empate);

            if (vtInter > vtGremio)
            {
                Console.WriteLine("Inter venceu mais");
            } else if (vtGremio > vtInter)
            {
                Console.WriteLine("Gremio vendeu mais");
            } else
            {
                Console.WriteLine("nao tem);
            }

        }
    }
}






