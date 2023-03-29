using System;

namespace uri1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, atual=1, anterior=0, soma, cont=3;

            N=int.Parse(Console.ReadLine());
            Console.Write(anterior+" "+atual+" ");

            if(N==1){
                Console.WriteLine(anterior);
            }else if(N==2){
                Console.WriteLine(anterior+" "+atual);
            }else{
                for(int i=3;i<=N;i++){
                if(cont<N){
                    soma=anterior+atual;
                    Console.Write(soma+" ");
                    anterior=atual;
                    atual=soma;
                    cont+=1;
                }else if(cont==N){
                    soma=anterior+atual;
                    Console.WriteLine(soma);
                }
                }
            }
        }
    }
}
