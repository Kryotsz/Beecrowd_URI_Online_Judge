using System;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAB, maiorFinal;
            
            string[] vetor=new string[3];

            vetor=Console.ReadLine().Split(' ');
            a=int.Parse(vetor[0]);
            b=int.Parse(vetor[1]);
            c=int.Parse(vetor[2]);

            maiorAB=(a+b+Math.Abs(a-b))/2;
            maiorFinal=(maiorAB+c+Math.Abs(maiorAB-c))/2;

            Console.WriteLine(maiorFinal+" eh o maior");

        }
    }
}
