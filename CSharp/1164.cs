using System;

namespace uri1164
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, soma=0;

            N=int.Parse(Console.ReadLine());

            for(int c=1;c<=N;c++){
                X=int.Parse(Console.ReadLine());
                for(int i=1;i<X;i++){
                    if(X%i==0){
                        soma+=i;
                    }
                }

                if(soma==X){
                    Console.WriteLine(X+" eh perfeito");
                    soma=0;
                }else{
                    Console.WriteLine(X+" nao eh perfeito");
                    soma=0;
                }
            }
        }
    }
}
