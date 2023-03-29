using System;

namespace uri1172
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor=new int[10];
            
            for(int i=0;i<10;i++){
                vetor[i]=int.Parse(Console.ReadLine());
                if(vetor[i]<0||vetor[i]==0){
                    vetor[i]=1;
                }

                Console.WriteLine("X["+i+"] = "+vetor[i]);
            }
        }
    }
}
