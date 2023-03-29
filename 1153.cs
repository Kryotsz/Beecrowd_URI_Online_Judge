using System;

namespace uri1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, fatorial;

            N=int.Parse(Console.ReadLine());

            fatorial=N;

            do{
                fatorial*=(N-1);
                N=N-1;
            }
            while(N>2);

            Console.WriteLine(fatorial);
        }
    }
}
