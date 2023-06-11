using System;

namespace uri1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, soma1=1, soma2=1;

            N=int.Parse(Console.ReadLine());

            for(int i=1;i<=N;i++){
                Console.WriteLine(i+" "+Math.Pow(i,2)+" "+Math.Pow(i,3));
                soma1+=(int)Math.Pow(i,2);
                soma2+=(int)Math.Pow(i,3);
                Console.WriteLine(i+" "+soma1+" "+soma2);
                soma1=1;
                soma2=1;
            }
        }
    }
}
