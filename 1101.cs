using System;

namespace uri1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            do{
                int soma=0;
                string[] vetor=new string[2];
                vetor=Console.ReadLine().Split(' ');
                M=int.Parse(vetor[0]);
                N=int.Parse(vetor[1]);

                if(M<=0||N<=0){
                    break;
                }else{
                    if(M<N){
                    for(int i=M;i<=N;i++){
                        soma+=i;
                        Console.Write(i+" ");
                    }
                }else{
                    for(int i=N;i<=M;i++){
                        soma+=i;
                        Console.Write(i+" ");
                    }
                }
                Console.WriteLine("Sum="+soma);
                }
            }
            while(M>0&&N>0);
        }
    }
}
