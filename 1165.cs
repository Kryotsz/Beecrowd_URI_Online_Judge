using System;

namespace uri1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, cont=0;

            N=int.Parse(Console.ReadLine());

            for(int c=1;c<=N;c++){
                X=int.Parse(Console.ReadLine());
                for(int i=1;i<=X;i++){
                    if(X%i==0){
                        cont+=1;
                    }
                }
                if(cont==2){
                    Console.WriteLine(X+" eh primo");
                    cont=0;
                }else{
                    Console.WriteLine(X+" nao eh primo");
                    cont=0;
                }
            }
        }
    }
}
