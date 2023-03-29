using System;

namespace uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N=int.Parse(Console.ReadLine());

            for(int i=1;i<=10;i++){
                Console.WriteLine(i+" x "+N+" = "+i*N);
            }
        }
    }
}
