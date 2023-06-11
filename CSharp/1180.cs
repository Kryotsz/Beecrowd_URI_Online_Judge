using System;

namespace uri1180
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, menor, posicao=0, numero;

            N=int.Parse(Console.ReadLine());

            string[] vetor=new string[N];
            vetor=Console.ReadLine().Split(' ');

            menor=int.Parse(vetor[0]);

            for(int i=0;i<N;i++){
                numero=int.Parse(vetor[i]);
                if(numero<menor){
                    menor=numero;
                    posicao=i;
                }
            }

            Console.WriteLine("Menor valor: "+menor);
            Console.WriteLine("Posicao: "+posicao);
        }
    }
}
