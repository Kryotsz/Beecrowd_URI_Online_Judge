using System;

namespace uri1177
{
    class Program
    {
        static void Main(string[] args)
        {
            int T, cont=0;
            int[] vetor=new int[1000];

            T=int.Parse(Console.ReadLine());

            for(int i=0;i<1000;i++){
                if(cont<T){
                    vetor[i]=cont;
                    cont+=1;
                }else{
                    cont=1;
                }
                Console.WriteLine("N["+i+"] = "+vetor[i]);
            }
        }
    }
}
