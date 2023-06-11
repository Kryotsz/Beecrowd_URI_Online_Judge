using System;
using System.Globalization;

namespace uri1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y;
            string[] vetor=new string[2];
            double divisao;

            N=int.Parse(Console.ReadLine());

            for(int i=1;i<=N;i++){
                vetor=Console.ReadLine().Split(' ');
                X=int.Parse(vetor[0]);
                Y=int.Parse(vetor[1]);

                if(Y==0){
                    Console.WriteLine("divisao impossivel");
                }else{
                    divisao=(double)X/Y;
                    Console.WriteLine(divisao.ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
