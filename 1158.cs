using System;

namespace uri1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y, cont=0, soma=0;
            string[] vetor=new string[2];

            N=int.Parse(Console.ReadLine());

            for(int i=1;i<=N;i++){
                vetor=Console.ReadLine().Split(' ');
                X=int.Parse(vetor[0]);
                Y=int.Parse(vetor[1]);
                for(int c=X;c<=99999999;c++){
                    if(c%2!=0){
                        soma+=c;
                        cont+=1;
                    }

                    if(cont==Y){
                        cont=0;
                        break;
                    }
                }

                Console.WriteLine(soma);
                soma=0;
            }
        }
    }
}
