using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, resto;
            int nota100, nota50, nota20, nota10, nota5, nota2, moeda1, moeda050, moeda025, moeda010, moeda005, moeda001;

            N=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            nota100=(int)N/100;
            resto=N%100;
            nota50=(int)resto/50;
            resto=resto%50;
            nota20=(int)resto/20;
            resto=resto%20;
            nota10=(int)resto/10;
            resto=resto%10;
            nota5=(int)resto/5;
            resto=resto%5;
            nota2=(int)resto/2;
            resto=resto%2;

            resto=resto*100.0;

            moeda1=(int)resto/100;
            resto=resto%100;
            moeda050=(int)resto/50;
            resto=resto%50;
            moeda025=(int)resto/25;
            resto=resto%25;
            moeda010=(int)resto/10;
            resto=resto%10;
            moeda005=(int)resto/5;
            resto=resto%5;
            moeda001=(int)resto/1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100+" nota(s) de R$ 100.00");
            Console.WriteLine(nota50+" nota(s) de R$ 50.00");
            Console.WriteLine(nota20+" nota(s) de R$ 20.00");
            Console.WriteLine(nota10+" nota(s) de R$ 10.00");
            Console.WriteLine(nota5+" nota(s) de R$ 5.00");
            Console.WriteLine(nota2+" nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1+" moeda(s) de R$ 1.00");
            Console.WriteLine(moeda050+" moeda(s) de R$ 0.50");
            Console.WriteLine(moeda025+" moeda(s) de R$ 0.25");
            Console.WriteLine(moeda010+" moeda(s) de R$ 0.10");
            Console.WriteLine(moeda005+" moeda(s) de R$ 0.05");
            Console.WriteLine(moeda001+" moeda(s) de R$ 0.01");
        }
    }
}
