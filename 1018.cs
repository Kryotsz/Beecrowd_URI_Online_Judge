using System;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, nota100, resto, nota50, resto2, nota20, resto3, nota10, resto4, nota5, resto5, nota2, resto6, nota1;

            N=int.Parse(Console.ReadLine());

            nota100=N/100;
            resto=N%100;
            nota50=resto/50;
            resto2=resto%50;
            nota20=resto2/20;
            resto3=resto2%20;
            nota10=resto3/10;
            resto4=resto3%10;
            nota5=resto4/5;
            resto5=resto4%5;
            nota2=resto5/2;
            resto6=resto5%2;
            nota1=resto6/1;

            Console.WriteLine(N);
            Console.WriteLine(nota100+" nota(s) de R$ 100,00");
            Console.WriteLine(nota50+" nota(s) de R$ 50,00");
            Console.WriteLine(nota20+" nota(s) de R$ 20,00");
            Console.WriteLine(nota10+" nota(s) de R$ 10,00");
            Console.WriteLine(nota5+" nota(s) de R$ 5,00");
            Console.WriteLine(nota2+" nota(s) de R$ 2,00");
            Console.WriteLine(nota1+" nota(s) de R$ 1,00");
        }
    }
}
