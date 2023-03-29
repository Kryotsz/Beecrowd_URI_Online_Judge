using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, anos, meses, dias, resto1;

            N=int.Parse(Console.ReadLine());

            anos=N/365;
            resto1=N%365;
            meses=resto1/30;
            dias=resto1%30;

            Console.WriteLine(anos+" ano(s)");
            Console.WriteLine(meses+" mes(es)");
            Console.WriteLine(dias+" dia(s)");

        }
    }
}
