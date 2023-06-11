using System;

namespace uri1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, maior=0, posicao=0;

            for(int i=1;i<=100;i++){
                N=int.Parse(Console.ReadLine());
                if(i==1){
                    maior=N;
                    posicao=i;
                    
                }else{
                    if(N>maior){
                        maior=N;
                        posicao=i;
                    }
                }

            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
