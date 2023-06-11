using System;

namespace uri1759
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N=int.Parse(Console.ReadLine());

            for(int i=1;i<=N;i++){
                if(i<N){
                    Console.Write("Ho ");
                }else{
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}
